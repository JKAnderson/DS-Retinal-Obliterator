namespace DS_Retinal_Obliterator
{
    static class DSOffsets
    {
        public const int CheckVersion = 0x400080;

        public const int AllNoMagicQtyConsume = 0x1376EE7;
        public const int PlayerNoDead = 0x13784D2;
        public const int PlayerExterminate = 0x13784D3;
        public const int AllNoStaminaConsume = 0x13784E4;
        public const int AllNoMPConsume = 0x13784E5;
        public const int AllNoArrowConsume = 0x13784E6;
        public const int PlayerHide = 0x13784E7;
        public const int PlayerSilence = 0x13784E8;
        public const int AllNoDead = 0x13784E9;
        public const int AllNoDamage = 0x13784EA;
        public const int AllNoHit = 0x13784EB;
        public const int AllNoAttack = 0x13784EC;
        public const int AllNoMove = 0x13784ED;
        public const int AllNoUpdateAI = 0x13784EE;
        public const int CompassLarge = 0x1378525;
        public const int CompassSmall = 0x137851B;
        public const int Altimeter = 0x1378524;
        public const int DrawMap = 0x12DEFEB;
        public const int DrawCreatures = 0x12DF242;
        public const int NodeGraph = 0xFA256C;

        public const int CharData1Ptr = 0x137DC70;
        public const int CharData1Ptr2 = 0x4;
        public enum CharData1
        {

        }

        public const int GraphicsDataPtr = 0x1378520;
        public const int GraphicsDataPtr2 = 0x10;
        public enum GraphicsData
        {
            DrawTrees = 0x23F,
            DrawTextures = 0x240,
            DrawBoundingBoxes = 0x241,
            DrawSprites = 0x242,
            DrawVFX = 0x245,
            DrawShadows = 0x246,
            EnableFilter = 0x26D,
            BrightnessR = 0x270,
            BrightnessG = 0x274,
            BrightnessB = 0x278,
            Saturation = 0x27C,
            ContrastR = 0x280,
            ContrastG = 0x284,
            ContrastB = 0x288,
            Hue = 0x28C,
        }

        public const int CharData2Ptr = 0x1378700;
        public const int CharData2Ptr2 = 0x8;
        public enum CharData2
        {
            Vitality = 0x38,
            Attunement = 0x40,
            Endurance = 0x48,
            Strength = 0x50,
            Dexterity = 0x58,
            Intelligence = 0x60,
            Faith = 0x68,
            Humanity = 0x7C,
            Resistance = 0x80,
            SoulLevel = 0x88,
            Souls = 0x8C,
            Class = 0xC6,
            Stance = 0x230,
        }

        public enum DropItem : int
        {
            Category = 0x01,
            ItemID = 0x06,
            Count = 0x10,
            Ptr1 = 0x15,
            Ptr2 = 0x32,
            Jump = 0x38
        }
    }
}
