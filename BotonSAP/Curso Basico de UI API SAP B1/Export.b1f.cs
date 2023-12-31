﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_EXPORT")]
    class Export : UDOFormBase
    {
        public Export()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_0").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("btCrear").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_2").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_6").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_12").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_13").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_14").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_15").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_16").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_17").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_18").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_19").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_20").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Grid Grid0;

        private void OnCustomInitialize()
        {

        }
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
    }
}
