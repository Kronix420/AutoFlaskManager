﻿using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace FlaskManager
{
    public class FlaskManagerSettings : SettingsBase
    {
        public FlaskManagerSettings()
        {
            #region Flask Manager Settings Var
            //plugin
            Enable = false;
            //Auto Quit
            isPercentQuit = false;
            percentHPQuit = new RangeNode<float>(35f, 0f, 100f);
            percentESQuit = new RangeNode<float>(35f, 0, 100);
            //HP/MANA
            autoFlask = false;
            perHPFlask = new RangeNode<int>(60, 0, 100);
            HPDelay = new RangeNode<float>(1f, 0f, 4f);
            ManaDelay = new RangeNode<float>(1f, 0f, 4f);
            PerManaFlask = new RangeNode<float>(25f, 0, 100);
            //Ailment Flask
            remAilment = false;
            remFrozen = false;
            remShocked = false;
            remBurning = false;
            remCurse = false;
            remPoison = false;
            remCorrupt = false;
            corrptCount = new RangeNode<int>(10, 1, 20);
            ailmentDur = new RangeNode<int>(0, 0, 5);
            //QuickSilver
            qSEnable = false;
            qSDur = new RangeNode<float>(1.5f, 0f, 10f);
            //Defensive Flask
            defFlaskEnable = false;
            hPDefensive = new RangeNode<int>(50, 0, 100);
            eSDefensive = new RangeNode<int>(50, 0, 100);
            DefensiveDelay = new RangeNode<float>(3f, 2f, 10f);
            //Offensive Flask
            offFlaskEnable = false;
            hpOffensive = new RangeNode<int>(50, 0, 100);
            esOffensive = new RangeNode<int>(50, 0, 100);
            OffensiveDelay = new RangeNode<float>(3f, 2f, 10f);
            //Unique Flask
            uniqFlaskEnable = false;
            // Settings
            uiEnable = false;
            positionX = new RangeNode<float>(28.0f, 0.0f, 100.0f);
            positionY = new RangeNode<float>(83.0f, 0.0f, 100.0f);
            textSize = new RangeNode<int>(15, 15, 60);
            flaskSlot1Enable = true;
            flaskSlot2Enable = true;
            flaskSlot3Enable = true;
            flaskSlot4Enable = true;
            flaskSlot5Enable = true;
            debugMode = false;
            #endregion
        }

        #region Auto Quit Menu
        [Menu("Auto % HP/ES to Quit", 1)]
        public ToggleNode isPercentQuit { get; set; }
        [Menu("Min % Life to Auto Quit", 2, 1)]
        public RangeNode<float> percentHPQuit { get; set; }
        [Menu("Min % ES Auto Quit", 3, 1)]
        public RangeNode<float> percentESQuit { get; set; }
        #endregion

        #region HP Mana Flask Menu
        [Menu("HP/MANA % Auto Flask", 10)]
        public ToggleNode autoFlask { get; set; }
        [Menu("Min Life % Auto HP Flask", 11, 10)]
        public RangeNode<int> perHPFlask { get; set; }
        [Menu("HP Flask Delay", 12, 10)]
        public RangeNode<float> HPDelay { get; set; }
        [Menu("Min Mana % Auto Mana Flask", 13, 10)]
        public RangeNode<float> PerManaFlask { get; set; }
        [Menu("Mana Flask Delay", 14, 10)]
        public RangeNode<float> ManaDelay { get; set; }
        #endregion

        #region Ailment Flask Menu
        [Menu("Remove Ailment Flask", 20)]
        public ToggleNode remAilment { get; set; }
        [Menu("Remove Frozen Ailment", 21, 20)]
        public ToggleNode remFrozen { get; set; }
        [Menu("Remove Burning Ailment", 22, 20)]
        public ToggleNode remBurning { get; set; }
        [Menu("Remove Shocked Ailment", 23, 20)]
        public ToggleNode remShocked { get; set; }
        [Menu("Remove Curse Ailment", 24, 20)]
        public ToggleNode remCurse { get; set; }
        [Menu("Remove Poison Ailment", 25, 20)]
        public ToggleNode remPoison { get; set; }
        [Menu("Remove Corrupting/Bleed Ailment", 26, 20)]
        public ToggleNode remCorrupt { get; set; }
        [Menu("Corrupting Blood Stacks", 27, 20)]
        public RangeNode<int> corrptCount { get; set; }
        [Menu("Remove Ailment Post Duration (s)", 28, 20)]
        public RangeNode<int> ailmentDur { get; set; } 
        #endregion

        #region Quick Sivler Flask Menu
        [Menu("QuickSilver Flask", 30)]
        public ToggleNode qSEnable { get; set; }
        [Menu("Use After Moving Post (s)", 31, 30)]
        public RangeNode<float> qSDur { get; set; } 
        #endregion

        #region Defensive Flask Menu
        [Menu("Defensive Flask", 40)]
        public ToggleNode defFlaskEnable { get; set; }
        [Menu("Min Life % Auto Defensive Flask", 41, 40)]
        public RangeNode<int> hPDefensive { get; set; }
        [Menu("Min ES % Auto Defensive Flask", 42, 40)]
        public RangeNode<int> eSDefensive { get; set; }
        [Menu("Defensive Flask Delay", 43, 40)]
        public RangeNode<float> DefensiveDelay { get; set; }
        #endregion

        #region Offensive Flask Menu
        [Menu("Offensive Flask", 50)]
        public ToggleNode offFlaskEnable { get; set; }
        [Menu("Min Life % Auto Offensive Flask", 51, 50)]
        public RangeNode<int> hpOffensive { get; set; }
        [Menu("Min ES % Auto Offensive Flask", 52, 50)]
        public RangeNode<int> esOffensive { get; set; }
        [Menu("Offensive Flask Delay", 53, 50)]
        public RangeNode<float> OffensiveDelay { get; set; }
        #endregion

        #region Unnique Flask Menu
        [Menu("Unique Flask", 60)]
        public ToggleNode uniqFlaskEnable { get; set; } 
        #endregion

        #region Settings Menu
        [Menu("UI Settings/Debug Mode", 100)]
        public EmptyNode uisettingsHolder { get; set; }
        [Menu("UI Enable", 101, 100)]
        public ToggleNode uiEnable { get; set; }
        [Menu("Position: X", 102, 100)]
        public RangeNode<float> positionX { get; set; }
        [Menu("Position: Y", 103, 100)]
        public RangeNode<float> positionY { get; set; }
        [Menu("Text Size", 104, 100)]
        public RangeNode<int> textSize { get; set; }
        [Menu("Debug Mode", 105, 100)]
        public ToggleNode debugMode { get; set; }


        [Menu("Enable/Disable Flasks", 110)]
        public EmptyNode flasksettingsHolder { get; set; }
        [Menu("Use Flask Slot 1", 111, 110)]
        public ToggleNode flaskSlot1Enable { get; set; }
        [Menu("Use Flask Slot 2", 112, 110)]
        public ToggleNode flaskSlot2Enable { get; set; }
        [Menu("Use Flask Slot 3", 113, 110)]
        public ToggleNode flaskSlot3Enable { get; set; }
        [Menu("Use Flask Slot 4", 114, 110)]
        public ToggleNode flaskSlot4Enable { get; set; }
        [Menu("Use Flask Slot 5", 115, 110)]
        public ToggleNode flaskSlot5Enable { get; set; }
        #endregion
    }
}