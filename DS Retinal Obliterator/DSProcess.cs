using System;
using System.Diagnostics;

namespace DS_Retinal_Obliterator
{
    class DSProcess
    {
        private const uint VERSION_RELEASE = 0xFC293654;
        private const uint VERSION_DEBUG = 0xCE9634B4;
        private const uint VERSION_BETA = 0xE91B11E2;

        public static DSProcess Attach(Process candidate, out string versionName, out bool valid)
        {
            DSProcess result = null;
            versionName = "Unknown";
            valid = false;
            DSInterface dsInterface = DSInterface.Attach(candidate);
            if (dsInterface != null)
            {
                uint version = dsInterface.ReadUInt32(DSOffsets.CheckVersion);
                if (version == VERSION_RELEASE)
                {
                    result = new DSProcess(candidate, dsInterface, true);
                    versionName = "Steam";
                    valid = true;
                }
                else if (version == VERSION_DEBUG)
                {
                    result = new DSProcess(candidate, dsInterface, false);
                    versionName = "Debug";
                }
                else if (version == VERSION_BETA)
                {
                    result = new DSProcess(candidate, dsInterface, false);
                    versionName = "Beta";
                }
            }
            return result;
        }


        private Process process;
        private DSInterface dsInterface;
        private bool enabled;

        private int charData1, charData2, graphicsData;

        public DSProcess(Process setProcess, DSInterface setDSInterface, bool setEnabled)
        {
            process = setProcess;
            dsInterface = setDSInterface;
            enabled = setEnabled;
        }

        public void Close()
        {
            dsInterface.Close();
        }

        public bool Alive()
        {
            return !process.HasExited;
        }

        public bool Loaded()
        {
            if (enabled)
            {
                return GetCharData1() != 0;
            }
            else
                return false;
        }

        public void LoadPointers()
        {
            charData1 = GetCharData1();
            charData2 = GetCharData2();
            graphicsData = GetGraphicsData();
        }

        private void ReplaceBytes(byte[] victim, int value, int index)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Copy(bytes, 0, victim, index, bytes.Length);
        }

        private int GetCharData1()
        {
            int temp = dsInterface.ReadInt32(DSOffsets.CharData1Ptr);
            int pointer = dsInterface.ReadInt32(temp + DSOffsets.CharData1Ptr2);
            return pointer;
        }

        private int GetCharData2()
        {
            int temp = dsInterface.ReadInt32(DSOffsets.CharData2Ptr);
            int pointer = dsInterface.ReadInt32(temp + DSOffsets.CharData2Ptr2);
            return pointer;
        }

        private int GetGraphicsData()
        {
            int temp = dsInterface.ReadInt32(DSOffsets.GraphicsDataPtr);
            int pointer = dsInterface.ReadInt32(temp + DSOffsets.GraphicsDataPtr2);
            return pointer;
        }

        public void OverrideFilter(bool enable)
        {
            dsInterface.WriteBool(graphicsData + (int)DSOffsets.GraphicsData.EnableFilter, enable);
        }

        public void SetBrightness(float brightnessR, float brightnessG, float brightnessB)
        {
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.BrightnessR, brightnessR);
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.BrightnessG, brightnessG);
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.BrightnessB, brightnessB);
        }

        public void SetContrast(float contrastR, float contrastG, float contrastB)
        {
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.ContrastR, contrastR);
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.ContrastG, contrastG);
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.ContrastB, contrastB);
        }

        public void SetSaturation(float saturation)
        {
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.Saturation, saturation);
        }

        public void SetHue(float hue)
        {
            dsInterface.WriteFloat(graphicsData + (int)DSOffsets.GraphicsData.Hue, hue);
        }
    }
}
