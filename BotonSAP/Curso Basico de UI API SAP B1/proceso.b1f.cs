using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_PROCESOFE")]
    class proceso : UDOFormBase
    {
        public proceso()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_4").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_5").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_6").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_7").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_8").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_10").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_12").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_13").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_14").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_15").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_16").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_17").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_18").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_19").Specific));
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_20").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_25").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_26").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_27").Specific));
            this.ComboBox5 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_28").Specific));
            this.Button6 = ((SAPbouiCOM.Button)(this.GetItem("Item_29").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.ComboBox ComboBox5;
        private SAPbouiCOM.Button Button6;
    }
}
