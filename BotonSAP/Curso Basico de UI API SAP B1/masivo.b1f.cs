using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_FACTURAMASIVA")]
    class masivo : UDOFormBase
    {
        public masivo()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_4").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_6").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_7").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_8").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_9").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_10").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_11").Specific));
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
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Button Button3;
    }
}
