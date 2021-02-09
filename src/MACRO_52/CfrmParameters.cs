namespace MACRO_52
{
    using AxComCtl2;
    using AxMSFlexGridArray;
    using AxMSFlexGridLib;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmParameters : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("cmdHelp")]
        private Button _cmdHelp;
        public OpenFileDialog CommonDialog1Open;
        public SaveFileDialog CommonDialog1Save;
        public FontDialog CommonDialog1Font;
        public ColorDialog CommonDialog1Color;
        public PrintDialog CommonDialog1Print;
        [AccessedThroughProperty("cmdApply")]
        private Button _cmdApply;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("_txtBox_1")]
        private TextBox __txtBox_1;
        [AccessedThroughProperty("_txtBox_0")]
        private TextBox __txtBox_0;
        [AccessedThroughProperty("_flx_Parameters_1")]
        private AxMSFlexGrid __flx_Parameters_1;
        [AccessedThroughProperty("cmbDeleteYear")]
        private ComboBox _cmbDeleteYear;
        [AccessedThroughProperty("Command7")]
        private Button _Command7;
        [AccessedThroughProperty("Frame7")]
        private GroupBox _Frame7;
        [AccessedThroughProperty("cmbYearSW2")]
        private ComboBox _cmbYearSW2;
        [AccessedThroughProperty("_txtCropDev2_8")]
        private TextBox __txtCropDev2_8;
        [AccessedThroughProperty("_txtCropDev2_7")]
        private TextBox __txtCropDev2_7;
        [AccessedThroughProperty("_txtCropDev2_6")]
        private TextBox __txtCropDev2_6;
        [AccessedThroughProperty("_txtCropDev2_5")]
        private TextBox __txtCropDev2_5;
        [AccessedThroughProperty("_txtCropDev2_4")]
        private TextBox __txtCropDev2_4;
        [AccessedThroughProperty("_txtCropDev2_3")]
        private TextBox __txtCropDev2_3;
        [AccessedThroughProperty("_txtCropDev2_2")]
        private TextBox __txtCropDev2_2;
        [AccessedThroughProperty("_txtCropDev2_1")]
        private TextBox __txtCropDev2_1;
        [AccessedThroughProperty("_txtCropDev2_0")]
        private TextBox __txtCropDev2_0;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        [AccessedThroughProperty("_lblCrop_8")]
        private Label __lblCrop_8;
        [AccessedThroughProperty("_lblCrop_7")]
        private Label __lblCrop_7;
        [AccessedThroughProperty("_lblCrop_6")]
        private Label __lblCrop_6;
        [AccessedThroughProperty("_lblCrop_5")]
        private Label __lblCrop_5;
        [AccessedThroughProperty("_lblCrop_4")]
        private Label __lblCrop_4;
        [AccessedThroughProperty("_lblCrop_3")]
        private Label __lblCrop_3;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("fraCropSW2")]
        private GroupBox _fraCropSW2;
        [AccessedThroughProperty("cmbYearSW3")]
        private ComboBox _cmbYearSW3;
        [AccessedThroughProperty("_txtCropDev3_2")]
        private TextBox __txtCropDev3_2;
        [AccessedThroughProperty("_txtCropDev3_1")]
        private TextBox __txtCropDev3_1;
        [AccessedThroughProperty("_txtCropDev3_0")]
        private TextBox __txtCropDev3_0;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("_lblCrop_2")]
        private Label __lblCrop_2;
        [AccessedThroughProperty("_lblCrop_1")]
        private Label __lblCrop_1;
        [AccessedThroughProperty("_lblCrop_0")]
        private Label __lblCrop_0;
        [AccessedThroughProperty("fraCropSw3")]
        private GroupBox _fraCropSw3;
        [AccessedThroughProperty("_flx_Parameters_0")]
        private AxMSFlexGrid __flx_Parameters_0;
        [AccessedThroughProperty("Command11")]
        private Button _Command11;
        [AccessedThroughProperty("Command18")]
        private Button _Command18;
        [AccessedThroughProperty("_lblHelp_0")]
        private Label __lblHelp_0;
        [AccessedThroughProperty("_SSTab1_TabPage0")]
        private TabPage __SSTab1_TabPage0;
        [AccessedThroughProperty("_lblHelp_2")]
        private Label __lblHelp_2;
        [AccessedThroughProperty("_flx_Parameters_2")]
        private AxMSFlexGrid __flx_Parameters_2;
        [AccessedThroughProperty("_txtBox_2")]
        private TextBox __txtBox_2;
        [AccessedThroughProperty("cmdBrowseForTensionFile")]
        private Button _cmdBrowseForTensionFile;
        [AccessedThroughProperty("txtTensionFile")]
        private TextBox _txtTensionFile;
        [AccessedThroughProperty("_text1_5")]
        private TextBox __text1_5;
        [AccessedThroughProperty("_text1_4")]
        private TextBox __text1_4;
        [AccessedThroughProperty("_text1_0")]
        private TextBox __text1_0;
        [AccessedThroughProperty("_text1_1")]
        private TextBox __text1_1;
        [AccessedThroughProperty("_text1_2")]
        private TextBox __text1_2;
        [AccessedThroughProperty("_text1_3")]
        private TextBox __text1_3;
        [AccessedThroughProperty("_Label1_5")]
        private Label __Label1_5;
        [AccessedThroughProperty("_Label1_4")]
        private Label __Label1_4;
        [AccessedThroughProperty("_Label1_0")]
        private Label __Label1_0;
        [AccessedThroughProperty("_Label1_1")]
        private Label __Label1_1;
        [AccessedThroughProperty("_Label1_2")]
        private Label __Label1_2;
        [AccessedThroughProperty("_Label1_3")]
        private Label __Label1_3;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("_Check1_9")]
        private CheckBox __Check1_9;
        [AccessedThroughProperty("_optVariableToCopy_2")]
        private RadioButton __optVariableToCopy_2;
        [AccessedThroughProperty("_optVariableToCopy_1")]
        private RadioButton __optVariableToCopy_1;
        [AccessedThroughProperty("_optVariableToCopy_0")]
        private RadioButton __optVariableToCopy_0;
        [AccessedThroughProperty("_Check1_1")]
        private CheckBox __Check1_1;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("_Check1_0")]
        private CheckBox __Check1_0;
        [AccessedThroughProperty("_Check1_2")]
        private CheckBox __Check1_2;
        [AccessedThroughProperty("_Check1_3")]
        private CheckBox __Check1_3;
        [AccessedThroughProperty("_Check1_4")]
        private CheckBox __Check1_4;
        [AccessedThroughProperty("_Check1_5")]
        private CheckBox __Check1_5;
        [AccessedThroughProperty("_Check1_6")]
        private CheckBox __Check1_6;
        [AccessedThroughProperty("_Check1_7")]
        private CheckBox __Check1_7;
        [AccessedThroughProperty("_Check1_8")]
        private CheckBox __Check1_8;
        [AccessedThroughProperty("Text3")]
        private TextBox _Text3;
        [AccessedThroughProperty("Command3")]
        private Button _Command3;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("Command4")]
        private Button _Command4;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Frame10")]
        private GroupBox _Frame10;
        [AccessedThroughProperty("_SSTab1_TabPage1")]
        private TabPage __SSTab1_TabPage1;
        [AccessedThroughProperty("cmdStore")]
        private Button _cmdStore;
        [AccessedThroughProperty("cmdClear")]
        private Button _cmdClear;
        [AccessedThroughProperty("cmdAggregate")]
        private Button _cmdAggregate;
        [AccessedThroughProperty("lstYearSubSets")]
        private ListBox _lstYearSubSets;
        [AccessedThroughProperty("lstYears")]
        private ListBox _lstYears;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("fraDefineSubSets")]
        private GroupBox _fraDefineSubSets;
        [AccessedThroughProperty("_optDefinitionType_1")]
        private RadioButton __optDefinitionType_1;
        [AccessedThroughProperty("_optDefinitionType_0")]
        private RadioButton __optDefinitionType_0;
        [AccessedThroughProperty("Frame9")]
        private GroupBox _Frame9;
        [AccessedThroughProperty("_txtBox_3")]
        private TextBox __txtBox_3;
        [AccessedThroughProperty("Text8")]
        private TextBox _Text8;
        [AccessedThroughProperty("_flx_Parameters_3")]
        private AxMSFlexGrid __flx_Parameters_3;
        [AccessedThroughProperty("lblIrrigationYears")]
        private Label _lblIrrigationYears;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("_lblHelp_3")]
        private Label __lblHelp_3;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Frame11")]
        private GroupBox _Frame11;
        [AccessedThroughProperty("_SSTab1_TabPage2")]
        private TabPage __SSTab1_TabPage2;
        [AccessedThroughProperty("_Check2_9")]
        private CheckBox __Check2_9;
        [AccessedThroughProperty("cmbVariables")]
        private ComboBox _cmbVariables;
        [AccessedThroughProperty("Command5")]
        private Button _Command5;
        [AccessedThroughProperty("Text13")]
        private TextBox _Text13;
        [AccessedThroughProperty("_Check2_8")]
        private CheckBox __Check2_8;
        [AccessedThroughProperty("_Check2_7")]
        private CheckBox __Check2_7;
        [AccessedThroughProperty("_Check2_6")]
        private CheckBox __Check2_6;
        [AccessedThroughProperty("_Check2_5")]
        private CheckBox __Check2_5;
        [AccessedThroughProperty("_Check2_4")]
        private CheckBox __Check2_4;
        [AccessedThroughProperty("_Check2_3")]
        private CheckBox __Check2_3;
        [AccessedThroughProperty("_Check2_2")]
        private CheckBox __Check2_2;
        [AccessedThroughProperty("_Check2_1")]
        private CheckBox __Check2_1;
        [AccessedThroughProperty("_Check2_0")]
        private CheckBox __Check2_0;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label36")]
        private Label _Label36;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Frame6")]
        private GroupBox _Frame6;
        [AccessedThroughProperty("_txtBox_4")]
        private TextBox __txtBox_4;
        [AccessedThroughProperty("_flx_Parameters_4")]
        private AxMSFlexGrid __flx_Parameters_4;
        [AccessedThroughProperty("_lblHelp_4")]
        private Label __lblHelp_4;
        [AccessedThroughProperty("Frame12")]
        private GroupBox _Frame12;
        [AccessedThroughProperty("_SSTab1_TabPage3")]
        private TabPage __SSTab1_TabPage3;
        [AccessedThroughProperty("_Text4_13")]
        private TextBox __Text4_13;
        [AccessedThroughProperty("_Text4_5")]
        private TextBox __Text4_5;
        [AccessedThroughProperty("_Text4_4")]
        private TextBox __Text4_4;
        [AccessedThroughProperty("_Text4_3")]
        private TextBox __Text4_3;
        [AccessedThroughProperty("_Text4_2")]
        private TextBox __Text4_2;
        [AccessedThroughProperty("_Text4_1")]
        private TextBox __Text4_1;
        [AccessedThroughProperty("_Text4_0")]
        private TextBox __Text4_0;
        [AccessedThroughProperty("_Text4_6")]
        private TextBox __Text4_6;
        [AccessedThroughProperty("_Text4_7")]
        private TextBox __Text4_7;
        [AccessedThroughProperty("_Text4_8")]
        private TextBox __Text4_8;
        [AccessedThroughProperty("_Text4_9")]
        private TextBox __Text4_9;
        [AccessedThroughProperty("_Text4_10")]
        private TextBox __Text4_10;
        [AccessedThroughProperty("_Text4_11")]
        private TextBox __Text4_11;
        [AccessedThroughProperty("_Text4_12")]
        private TextBox __Text4_12;
        [AccessedThroughProperty("_Label11_13")]
        private Label __Label11_13;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("_Label11_4")]
        private Label __Label11_4;
        [AccessedThroughProperty("_Label11_3")]
        private Label __Label11_3;
        [AccessedThroughProperty("_Label11_2")]
        private Label __Label11_2;
        [AccessedThroughProperty("_Label11_1")]
        private Label __Label11_1;
        [AccessedThroughProperty("_Label11_0")]
        private Label __Label11_0;
        [AccessedThroughProperty("_Label11_5")]
        private Label __Label11_5;
        [AccessedThroughProperty("_Label11_6")]
        private Label __Label11_6;
        [AccessedThroughProperty("_Label11_7")]
        private Label __Label11_7;
        [AccessedThroughProperty("_Label11_8")]
        private Label __Label11_8;
        [AccessedThroughProperty("_Label11_9")]
        private Label __Label11_9;
        [AccessedThroughProperty("_Label11_10")]
        private Label __Label11_10;
        [AccessedThroughProperty("_Label11_11")]
        private Label __Label11_11;
        [AccessedThroughProperty("_Label11_12")]
        private Label __Label11_12;
        [AccessedThroughProperty("lblHelpSite")]
        private Label _lblHelpSite;
        [AccessedThroughProperty("Frame4")]
        private GroupBox _Frame4;
        [AccessedThroughProperty("_SSTab1_TabPage4")]
        private TabPage __SSTab1_TabPage4;
        [AccessedThroughProperty("_lblHelp_5")]
        private Label __lblHelp_5;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("_flx_Parameters_5")]
        private AxMSFlexGrid __flx_Parameters_5;
        [AccessedThroughProperty("_Check4_9")]
        private CheckBox __Check4_9;
        [AccessedThroughProperty("cmbSoluteVariables")]
        private ComboBox _cmbSoluteVariables;
        [AccessedThroughProperty("_Check4_0")]
        private CheckBox __Check4_0;
        [AccessedThroughProperty("_Check4_1")]
        private CheckBox __Check4_1;
        [AccessedThroughProperty("_Check4_2")]
        private CheckBox __Check4_2;
        [AccessedThroughProperty("_Check4_3")]
        private CheckBox __Check4_3;
        [AccessedThroughProperty("_Check4_4")]
        private CheckBox __Check4_4;
        [AccessedThroughProperty("_Check4_5")]
        private CheckBox __Check4_5;
        [AccessedThroughProperty("_Check4_6")]
        private CheckBox __Check4_6;
        [AccessedThroughProperty("_Check4_7")]
        private CheckBox __Check4_7;
        [AccessedThroughProperty("_Check4_8")]
        private CheckBox __Check4_8;
        [AccessedThroughProperty("Text27")]
        private TextBox _Text27;
        [AccessedThroughProperty("Command15")]
        private Button _Command15;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Frame13")]
        private GroupBox _Frame13;
        [AccessedThroughProperty("_txtBox_5")]
        private TextBox __txtBox_5;
        [AccessedThroughProperty("_text12_21")]
        private TextBox __text12_21;
        [AccessedThroughProperty("_text12_20")]
        private TextBox __text12_20;
        [AccessedThroughProperty("_text12_19")]
        private TextBox __text12_19;
        [AccessedThroughProperty("_text12_18")]
        private TextBox __text12_18;
        [AccessedThroughProperty("_text12_17")]
        private TextBox __text12_17;
        [AccessedThroughProperty("_text12_16")]
        private TextBox __text12_16;
        [AccessedThroughProperty("_text12_15")]
        private TextBox __text12_15;
        [AccessedThroughProperty("_text12_14")]
        private TextBox __text12_14;
        [AccessedThroughProperty("_text12_13")]
        private TextBox __text12_13;
        [AccessedThroughProperty("_text12_12")]
        private TextBox __text12_12;
        [AccessedThroughProperty("_text12_11")]
        private TextBox __text12_11;
        [AccessedThroughProperty("_text12_10")]
        private TextBox __text12_10;
        [AccessedThroughProperty("_text12_9")]
        private TextBox __text12_9;
        [AccessedThroughProperty("_text12_8")]
        private TextBox __text12_8;
        [AccessedThroughProperty("_text12_7")]
        private TextBox __text12_7;
        [AccessedThroughProperty("_text12_6")]
        private TextBox __text12_6;
        [AccessedThroughProperty("_text12_5")]
        private TextBox __text12_5;
        [AccessedThroughProperty("_text12_4")]
        private TextBox __text12_4;
        [AccessedThroughProperty("_text12_3")]
        private TextBox __text12_3;
        [AccessedThroughProperty("_text12_2")]
        private TextBox __text12_2;
        [AccessedThroughProperty("_text12_1")]
        private TextBox __text12_1;
        [AccessedThroughProperty("_text12_0")]
        private TextBox __text12_0;
        [AccessedThroughProperty("cmbIndex")]
        private ComboBox _cmbIndex;
        [AccessedThroughProperty("cmbParameters")]
        private ComboBox _cmbParameters;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("txtkoc")]
        private TextBox _txtkoc;
        [AccessedThroughProperty("cmdKoc")]
        private Button _cmdKoc;
        [AccessedThroughProperty("cmdFOCUS")]
        private Button _cmdFOCUS;
        [AccessedThroughProperty("_SSTab1_TabPage5")]
        private TabPage __SSTab1_TabPage5;
        [AccessedThroughProperty("_txtMan_13")]
        private TextBox __txtMan_13;
        [AccessedThroughProperty("_txtMan_12")]
        private TextBox __txtMan_12;
        [AccessedThroughProperty("_txtMan_8")]
        private TextBox __txtMan_8;
        [AccessedThroughProperty("_txtMan_11")]
        private TextBox __txtMan_11;
        [AccessedThroughProperty("_txtMan_10")]
        private TextBox __txtMan_10;
        [AccessedThroughProperty("_txtMan_9")]
        private TextBox __txtMan_9;
        [AccessedThroughProperty("_txtMan_7")]
        private TextBox __txtMan_7;
        [AccessedThroughProperty("_txtMan_6")]
        private TextBox __txtMan_6;
        [AccessedThroughProperty("_txtMan_5")]
        private TextBox __txtMan_5;
        [AccessedThroughProperty("_txtMan_4")]
        private TextBox __txtMan_4;
        [AccessedThroughProperty("_txtMan_3")]
        private TextBox __txtMan_3;
        [AccessedThroughProperty("_txtMan_2")]
        private TextBox __txtMan_2;
        [AccessedThroughProperty("_txtMan_1")]
        private TextBox __txtMan_1;
        [AccessedThroughProperty("_txtMan_0")]
        private TextBox __txtMan_0;
        [AccessedThroughProperty("_txtBox_6")]
        private TextBox __txtBox_6;
        [AccessedThroughProperty("_flx_Parameters_6")]
        private AxMSFlexGrid __flx_Parameters_6;
        [AccessedThroughProperty("_lblMan_13")]
        private Label __lblMan_13;
        [AccessedThroughProperty("_lblMan_12")]
        private Label __lblMan_12;
        [AccessedThroughProperty("_lblMan_11")]
        private Label __lblMan_11;
        [AccessedThroughProperty("_lblMan_10")]
        private Label __lblMan_10;
        [AccessedThroughProperty("_lblMan_9")]
        private Label __lblMan_9;
        [AccessedThroughProperty("_lblMan_8")]
        private Label __lblMan_8;
        [AccessedThroughProperty("_lblMan_5")]
        private Label __lblMan_5;
        [AccessedThroughProperty("_lblMan_0")]
        private Label __lblMan_0;
        [AccessedThroughProperty("_lblMan_1")]
        private Label __lblMan_1;
        [AccessedThroughProperty("_lblMan_3")]
        private Label __lblMan_3;
        [AccessedThroughProperty("_lblMan_6")]
        private Label __lblMan_6;
        [AccessedThroughProperty("_lblMan_7")]
        private Label __lblMan_7;
        [AccessedThroughProperty("_lblMan_4")]
        private Label __lblMan_4;
        [AccessedThroughProperty("_lblMan_2")]
        private Label __lblMan_2;
        [AccessedThroughProperty("_lblHelp_6")]
        private Label __lblHelp_6;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("_fraManagement_0")]
        private GroupBox __fraManagement_0;
        [AccessedThroughProperty("_SSTab1_TabPage6")]
        private TabPage __SSTab1_TabPage6;
        [AccessedThroughProperty("_txtBox_8")]
        private TextBox __txtBox_8;
        [AccessedThroughProperty("_lblHelp_7")]
        private Label __lblHelp_7;
        [AccessedThroughProperty("Frame8")]
        private GroupBox _Frame8;
        [AccessedThroughProperty("_flx_Parameters_8")]
        private AxMSFlexGrid __flx_Parameters_8;
        [AccessedThroughProperty("_txtBox_7")]
        private TextBox __txtBox_7;
        [AccessedThroughProperty("_flx_Parameters_7")]
        private AxMSFlexGrid __flx_Parameters_7;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Frame5")]
        private GroupBox _Frame5;
        [AccessedThroughProperty("_SSTab1_TabPage7")]
        private TabPage __SSTab1_TabPage7;
        [AccessedThroughProperty("SSTab1")]
        private TabControl _SSTab1;
        [AccessedThroughProperty("Check1")]
        private CheckBoxArray _Check1;
        [AccessedThroughProperty("Check2")]
        private CheckBoxArray _Check2;
        [AccessedThroughProperty("Check4")]
        private CheckBoxArray _Check4;
        [AccessedThroughProperty("Label1")]
        private LabelArray _Label1;
        [AccessedThroughProperty("Label11")]
        private LabelArray _Label11;
        [AccessedThroughProperty("Text4")]
        private TextBoxArray _Text4;
        [AccessedThroughProperty("flx_Parameters")]
        private AxMSFlexGridArray.AxMSFlexGridArray _flx_Parameters;
        [AccessedThroughProperty("fraManagement")]
        private GroupBoxArray _fraManagement;
        [AccessedThroughProperty("lblCrop")]
        private LabelArray _lblCrop;
        [AccessedThroughProperty("lblHelp")]
        private LabelArray _lblHelp;
        [AccessedThroughProperty("lblMan")]
        private LabelArray _lblMan;
        [AccessedThroughProperty("optDefinitionType")]
        private RadioButtonArray _optDefinitionType;
        [AccessedThroughProperty("optVariableToCopy")]
        private RadioButtonArray _optVariableToCopy;
        [AccessedThroughProperty("text1")]
        private TextBoxArray _text1;
        [AccessedThroughProperty("text12")]
        private TextBoxArray _text12;
        [AccessedThroughProperty("txtBox")]
        private TextBoxArray _txtBox;
        [AccessedThroughProperty("txtCropDev2")]
        private TextBoxArray _txtCropDev2;
        [AccessedThroughProperty("txtCropDev3")]
        private TextBoxArray _txtCropDev3;
        [AccessedThroughProperty("txtMan")]
        private TextBoxArray _txtMan;
        [AccessedThroughProperty("udNIRR")]
        private NumericUpDown _udNIRR;
        [AccessedThroughProperty("txtCropParameters")]
        private TextBox _txtCropParameters;
        [AccessedThroughProperty("txtIBCond")]
        private TextBox _txtIBCond;
        [AccessedThroughProperty("txtSolute")]
        private TextBox _txtSolute;
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [AccessedThroughProperty("btnCalculatePedotransfer")]
        private Button _btnCalculatePedotransfer;
        [AccessedThroughProperty("optFOOTPRINTPedotransfer")]
        private RadioButton _optFOOTPRINTPedotransfer;
        [AccessedThroughProperty("optMACROPedotransfer")]
        private RadioButton _optMACROPedotransfer;
        [AccessedThroughProperty("udNMAN")]
        private AxUpDown _udNMAN;
        [AccessedThroughProperty("txtNMan")]
        private NumericUpDown _txtNMan;
        private bool IsInitializing;
        private bool m_IsEditing;
        private const double pi = 3.1416;
        private const double e = 2.7183;
        private string msg;
        private short flx_top;
        private short flx_left;
        private bool bKeepColor;
        private bool b_ok;
        private short flag;
        private int mr;
        private int mc;
        private short m_CurrIrrGroup;
        private string v_name;
        private int ph_x;
        private int ph_rp;
        private int crop_x;
        private int crop2_x;
        private int crop_rp;
        private int crop2_rp;
        private int irr_x;
        private int solute_x;
        private int solute_rp;
        private int ib_x;
        private int ib_rp1;
        private string koll;
        private short qb_c;
        private short ii;
        private short chk;
        private string v_imp;
        private string impers;
        private short svar;
        private float[] theta50;
        private short tabort;
        private short kol;
        private short rad;
        private short updwn;
        private bool bSkip;
        private bool bLoading;
        private bool UserEdit;
        private bool Pedotransfer;
        private bool bCheckingValues;
        private const short OPT_SUBSET = 1;
        private bool bSkipStore;
        private bool m_InGrid;
        private string m_ClipBoard;
        private CfrmMain frmMain;
        private int[] tmp_idstart;
        private int[] tmp_iharv;
        private short $STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab;
        private StaticLocalInitFlag $STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init;

        public CfrmParameters(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmParameters_Activated);
            base.KeyPress += new KeyPressEventHandler(this.frmParameters_KeyPress);
            base.Load += new EventHandler(this.frmParameters_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.theta50 = new float[0x3d];
            this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init = new StaticLocalInitFlag();
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
        }

        private void _txtBox_0_TextChanged(object sender, EventArgs e)
        {
        }

        public void AddYear()
        {
            short index = (short) (this.flx_Parameters[0].Rows - 1);
            GlobalVariables.Y_ear[index + 1] = (short) (GlobalVariables.Y_ear[index] + 1);
            this.flx_Parameters[0].Rows++;
            this.cmbDeleteYear.Items.Add(Conversions.ToString((int) (this.flx_Parameters[0].Rows - 1)));
            this.cmbYearSW2.Items.Add(Conversions.ToString((int) (this.flx_Parameters[0].Rows - 1)));
            this.cmbYearSW3.Items.Add(Conversions.ToString((int) (this.flx_Parameters[0].Rows - 1)));
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                GlobalVariables.CropDevelopment2 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment2, new float[((this.flx_Parameters[0].Rows - 1) * this.txtCropDev2.Count()) + 1]);
            }
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                GlobalVariables.CropDevelopment3 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment3, new float[((this.flx_Parameters[0].Rows - 1) * this.txtCropDev2.Count()) + 1]);
            }
            this.CopyRowAbove();
            this.CopyCropDevFromFirstYear();
            this.SetYearsForIHARVandIDSTART();
            this.ShowYears();
        }

        public bool AssignValues(ref bool all = false)
        {
            short num;
            short num2;
            short num11;
            Cursor.Current = Cursors.WaitCursor;
            GlobalVariables.sw_chapar = !((GlobalVariables.NumOfYears > 1) | this.optDefinitionType[1].Checked) ? MACROConstants.Switch.NoMetabolite : MACROConstants.Switch.BareSoil;
            bool flag = false;
            if (all)
            {
                if (this.SSTab1.Enabled & (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil))
                {
                    if (ChecksAndAssignments.CheckCrop(ref this.frmMain))
                    {
                        this.bCheckingValues = false;
                        ChecksAndAssignments.AssignCropValues(ref this.frmMain);
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (this.SSTab1.Enabled)
                {
                    if (ChecksAndAssignments.CheckIBCond(ref this.frmMain))
                    {
                        ChecksAndAssignments.AssignIBCondValues(ref this.frmMain);
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if ((((MACROConstants.Switch) -this.SSTab1.Enabled) & GlobalVariables.sw_irrigate) != ((MACROConstants.Switch) false))
                {
                    if (ChecksAndAssignments.CheckIrrigation(ref this.frmMain, ref true))
                    {
                        if (!GlobalVariables.b_irrsame)
                        {
                            GlobalVariables.IrrYears = (short) this.lstYears.Items.Count;
                        }
                        else
                        {
                            GlobalVariables.IrrYears = 1;
                            short num8 = (short) Information.UBound(GlobalVariables.Groups, 1);
                            num2 = 1;
                            while (num2 <= num8)
                            {
                                short num9 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                num = 1;
                                while (true)
                                {
                                    num11 = num9;
                                    if (num > num11)
                                    {
                                        num2 = (short) (num2 + 1);
                                        break;
                                    }
                                    if (GlobalVariables.Groups[num2, num] > 0)
                                    {
                                        ChecksAndAssignments.AssignIrrigation(ref GlobalVariables.Groups[num2, num], ref this.frmMain, ref 0);
                                    }
                                    num = (short) (num + 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (this.SSTab1.Enabled)
                {
                    if (ChecksAndAssignments.CheckPhysicalParameters(ref this.frmMain))
                    {
                        ChecksAndAssignments.AssignPhysicalParameters(ref this.frmMain, ref true);
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (this.SSTab1.Enabled)
                {
                    if (ChecksAndAssignments.CheckSite(ref this.frmMain))
                    {
                        if (GlobalVariables.sw_tempini == MACROConstants.Switch.BareSoil)
                        {
                            this.CalcTempIni();
                        }
                        ChecksAndAssignments.AssignSiteValues(ref this.frmMain);
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (this.SSTab1.Enabled)
                {
                    if (ChecksAndAssignments.CheckSolute(ref this.frmMain))
                    {
                        ChecksAndAssignments.AssignSoluteValues(ref this.frmMain);
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (GlobalVariables.sw_management == MACROConstants.Switch.BareSoil)
                {
                    if (ChecksAndAssignments.CheckPhysicalParameters(ref this.frmMain))
                    {
                        ChecksAndAssignments.AssignPhysicalParameters(ref this.frmMain, ref true);
                        if (ChecksAndAssignments.CheckManagement(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignManagementValues(ref this.frmMain);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                    }
                    else
                    {
                        this.bCheckingValues = true;
                        return flag;
                    }
                }
                if (ChecksAndAssignments.CheckNumerical(this.frmMain.frmParameters))
                {
                    ChecksAndAssignments.AssignNumerical(this.frmMain.frmParameters);
                }
                else
                {
                    this.bCheckingValues = true;
                    return flag;
                }
            }
            else
            {
                switch (this.SSTab1.SelectedIndex)
                {
                    case 0:
                        if (GlobalVariables.sw_crop <= MACROConstants.Switch.BareSoil)
                        {
                            return flag;
                        }
                        else if (ChecksAndAssignments.CheckCrop(ref this.frmMain))
                        {
                            this.bCheckingValues = false;
                            ChecksAndAssignments.AssignCropValues(ref this.frmMain);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 1:
                        if (ChecksAndAssignments.CheckIBCond(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignIBCondValues(ref this.frmMain);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 2:
                        if (ChecksAndAssignments.CheckIrrigation(ref this.frmMain, ref true))
                        {
                            if (!GlobalVariables.b_irrsame)
                            {
                                GlobalVariables.IrrYears = (short) this.lstYears.Items.Count;
                            }
                            else
                            {
                                GlobalVariables.IrrYears = 1;
                                short num4 = (short) Information.UBound(GlobalVariables.Groups, 1);
                                num2 = 1;
                                while (num2 <= num4)
                                {
                                    short num5 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                    num = 1;
                                    while (true)
                                    {
                                        num11 = num5;
                                        if (num > num11)
                                        {
                                            num2 = (short) (num2 + 1);
                                            break;
                                        }
                                        if (GlobalVariables.Groups[num2, num] > 0)
                                        {
                                            ChecksAndAssignments.AssignIrrigation(ref GlobalVariables.Groups[num2, num], ref this.frmMain, ref 0);
                                        }
                                        num = (short) (num + 1);
                                    }
                                }
                            }
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 3:
                        if (ChecksAndAssignments.CheckPhysicalParameters(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignPhysicalParameters(ref this.frmMain, ref true);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 4:
                        if (ChecksAndAssignments.CheckSite(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignSiteValues(ref this.frmMain);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 5:
                        if (ChecksAndAssignments.CheckSolute(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignSoluteValues(ref this.frmMain);
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 6:
                        if (GlobalVariables.sw_management != MACROConstants.Switch.BareSoil)
                        {
                            return flag;
                        }
                        else if (ChecksAndAssignments.CheckPhysicalParameters(ref this.frmMain))
                        {
                            ChecksAndAssignments.AssignPhysicalParameters(ref this.frmMain, ref true);
                            if (ChecksAndAssignments.CheckManagement(ref this.frmMain))
                            {
                                ChecksAndAssignments.AssignManagementValues(ref this.frmMain);
                            }
                            else
                            {
                                this.bCheckingValues = true;
                                return flag;
                            }
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    case 7:
                        if (ChecksAndAssignments.CheckNumerical(this.frmMain.frmParameters))
                        {
                            ChecksAndAssignments.AssignNumerical(this.frmMain.frmParameters);
                            this.ShowIBConditions();
                        }
                        else
                        {
                            this.bCheckingValues = true;
                            return flag;
                        }
                        break;

                    default:
                        break;
                }
            }
            flag = true;
            Cursor.Current = Cursors.Default;
            return flag;
        }

        private void btnCalculatePedotransfer_Click(object sender, EventArgs e)
        {
            this.cmdApply_Click(this, null);
            if (this.optFOOTPRINTPedotransfer.Checked)
            {
                this.FOOTPRINTPedotransferFunctions();
            }
            else
            {
                this.MACROPedotransfer();
            }
            this.ShowPhysical();
        }

        public void CalcTempIni()
        {
            float[] numArray = new float[GlobalVariables.TotalLayers + 1];
            float num = this.numofdays(ref Conversions.ToString(this.frmMain.frmSetup.dtStartDate.Value));
            numArray[1] = (float) (((double) GlobalVariables.Zthick[1]) / 2.0);
            short totalLayers = GlobalVariables.TotalLayers;
            short index = 2;
            while (true)
            {
                short num5 = totalLayers;
                if (index > num5)
                {
                    short num4 = GlobalVariables.TotalLayers;
                    index = 1;
                    while (true)
                    {
                        num5 = num4;
                        if (index > num5)
                        {
                            return;
                        }
                        GlobalVariables.tempini[index] = GlobalVariables.anntav + ((float) ((GlobalVariables.annamp * Math.Pow(2.7183, (-1.0 * numArray[index]) / 200.0)) * Math.Cos(6.2832 * (((num - 212f) / 365f) - (numArray[index] / 200f)))));
                        GlobalVariables.tempini_c[index] = 3;
                        index = (short) (index + 1);
                    }
                }
                numArray[index] = (numArray[index - 1] + (GlobalVariables.Zthick[index - 1] / 2f)) + (GlobalVariables.Zthick[index] / 2f);
                index = (short) (index + 1);
            }
        }

        private void Check1_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            short index = this.Check1.GetIndex((CheckBox) eventSender);
            this.Command2.Enabled = true;
        }

        private void Check2_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            short index = this.Check2.GetIndex((CheckBox) eventSender);
            this.Command5.Enabled = true;
        }

        public void ClearGroups()
        {
            short num3 = (short) Information.UBound(GlobalVariables.Groups, 1);
            short num = 1;
            while (num <= num3)
            {
                short num4 = (short) Information.UBound(GlobalVariables.Groups, 2);
                short num2 = 1;
                while (true)
                {
                    short num5 = num4;
                    if (num2 > num5)
                    {
                        num = (short) (num + 1);
                        break;
                    }
                    GlobalVariables.Groups[num, num2] = 0;
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private void cmbParameters_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            short num2 = (short) (this.text12.Count() - 1);
            short num = 0;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    this.cmbIndex.SelectedIndex = this.cmbParameters.SelectedIndex;
                    this.text12[Conversions.ToShort(this.cmbIndex.Text)].Visible = true;
                    HelpFunctions.Help_Solute(ref this.cmbParameters.Text, ref this.lblHelp[5]);
                    return;
                }
                this.text12[num].Visible = false;
                num = (short) (num + 1);
            }
        }

        private void cmbSoluteVariables_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            HelpFunctions.Help_Solute(ref this.cmbSoluteVariables.Text, ref this.lblHelp[5]);
        }

        private void cmbVariables_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            HelpFunctions.Help_Physical(ref this.cmbVariables.Text, ref this.lblHelp[4]);
        }

        private void cmbYearSW2_Enter(object eventSender, EventArgs eventArgs)
        {
            this.SaveCropDevelopment();
        }

        private void cmbYearSW2_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            this.ShowCropDevelopment();
        }

        private void cmbYearSW3_Enter(object eventSender, EventArgs eventArgs)
        {
            this.SaveCropDevelopment();
        }

        private void cmbYearSW3_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            this.ShowCropDevelopment();
        }

        private void cmdAggregate_Click(object eventSender, EventArgs eventArgs)
        {
            ListBox lstYears = this.lstYears;
            string item = "";
            short num2 = (short) (lstYears.Items.Count - 1);
            short index = 0;
            while (true)
            {
                short num5 = num2;
                if (index > num5)
                {
                    lstYears = null;
                    this.lstYearSubSets.Items.Add(item);
                    this.SetGroupArray();
                    MiscFUncs.RedimIrrigationArrays(ref this.lstYears.Items.Count);
                    break;
                }
                if (lstYears.GetSelected(index))
                {
                    if (this.IsInGroup(ref Conversions.ToShort(Support.GetItemString(this.lstYears, index))))
                    {
                        MiscFUncs.MsgBox_Renamed("Year " + Support.GetItemString(this.lstYears, index) + " is already in a group.\rPlease select another variable.", 0x30, "Variable already in group");
                        break;
                    }
                    item = item + " " + Support.GetItemString(this.lstYears, index);
                }
                index = (short) (index + 1);
            }
        }

        private void cmdApply_Click(object eventSender, EventArgs eventArgs)
        {
            this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref 0);
            this.SaveCropDevelopment();
            this.AssignValues(ref false);
            this.bCheckingValues = false;
            this.Cursor = Cursors.Default;
            Cursor.Current = Cursors.Default;
        }

        private void cmdBrowseForTensionFile_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            this.lstYearSubSets.Items.Clear();
            this.SetDefinitionYears();
            GlobalVariables.Groups = new short[((this.frmMain.frmSetup.dtEndDate.Value.Year - this.frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1, ((this.frmMain.frmSetup.dtEndDate.Value.Year - this.frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1];
            this.udNIRR.Enabled = false;
        }

        private void cmdFOCUS_Click(object eventSender, EventArgs eventArgs)
        {
            float[,] numArray = new float[(this.flx_Parameters[5].Rows - 1) + 1, 3];
            float[] degrate = new float[5];
            short num4 = (short) (this.flx_Parameters[5].Rows - 1);
            short row = 1;
            while (true)
            {
                short num7 = num4;
                if (row > num7)
                {
                    degrate[1] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(1, 5));
                    degrate[2] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(1, 6));
                    degrate[3] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(1, 7));
                    degrate[4] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(1, 8));
                    short num5 = (short) (this.flx_Parameters[5].Rows - 1);
                    row = 1;
                    while (true)
                    {
                        num7 = num5;
                        if (row > num7)
                        {
                            return;
                        }
                        if (numArray[row, 2] <= 30f)
                        {
                            this.SetDEG(ref row, ref degrate, ref 1f);
                        }
                        else if (numArray[row, 1] > 100f)
                        {
                            this.SetDEG(ref row, ref degrate, ref 0f);
                        }
                        else
                        {
                            float num3 = numArray[row, 2] - numArray[row, 1];
                            float frac = 0f;
                            if (numArray[row, 1] < 30f)
                            {
                                frac = (30f - numArray[row, 1]) / num3;
                            }
                            if (numArray[row, 1] <= 60f)
                            {
                                frac = (numArray[row, 2] <= 60f) ? ((numArray[row, 1] >= 30f) ? (frac + ((float) (((numArray[row, 2] - numArray[row, 1]) * 0.5) / ((double) num3)))) : (frac + ((float) (((numArray[row, 2] - 30f) * 0.5) / ((double) num3))))) : (frac + ((float) (((60f - numArray[row, 1]) * 0.5) / ((double) num3))));
                            }
                            if ((numArray[row, 1] <= 100f) & (numArray[row, 2] >= 60f))
                            {
                                frac = (numArray[row, 2] <= 100f) ? ((numArray[row, 1] >= 60f) ? (frac + ((float) (((numArray[row, 2] - numArray[row, 1]) * 0.3) / ((double) num3)))) : (frac + ((float) (((numArray[row, 2] - 60f) * 0.3) / ((double) num3))))) : (frac + ((float) (((100f - numArray[row, 1]) * 0.3) / ((double) num3))));
                            }
                            this.SetDEG(ref row, ref degrate, ref frac);
                        }
                        row = (short) (row + 1);
                    }
                }
                numArray[row, 1] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(row, 1));
                numArray[row, 2] = Conversions.ToSingle(this.flx_Parameters[5].get_TextMatrix(row, 2));
                row = (short) (row + 1);
            }
        }

        private void cmdFOOTPRINTPedotransfer_Click(object sender, EventArgs e)
        {
            this.FOOTPRINTPedotransferFunctions();
        }

        private void cmdKoc_Click(object eventSender, EventArgs eventArgs)
        {
            if (!Versioned.IsNumeric(this.txtkoc.Text))
            {
                MiscFUncs.MsgBox_Renamed("Please check the Koc value", 0x30, "Check Koc");
            }
            else if (Conversions.ToSingle(this.txtkoc.Text) < 0f)
            {
                MiscFUncs.MsgBox_Renamed("Please check the Koc value", 0x30, "Check Koc");
            }
            else
            {
                short num3 = (short) (this.flx_Parameters[5].Cols - 1);
                short row = 0;
                while (true)
                {
                    short num;
                    short num5 = num3;
                    if (row > num5)
                    {
                        short num4 = (short) (this.flx_Parameters[5].Rows - 1);
                        row = 1;
                        while (true)
                        {
                            num5 = num4;
                            if (row > num5)
                            {
                                break;
                            }
                            this.flx_Parameters[5].set_TextMatrix(row, num, Conversions.ToString((float) ((Conversions.ToSingle(this.txtkoc.Text) * GlobalVariables.orgc[row]) / 100f)));
                            row = (short) (row + 1);
                        }
                        break;
                    }
                    if (this.flx_Parameters[5].get_TextMatrix(0, row) == "ZKD")
                    {
                        num = row;
                    }
                    row = (short) (row + 1);
                }
            }
        }

        private byte ColorID(ref int n)
        {
            byte num;
            int num2 = n;
            if (num2 == 0x8000)
            {
                num = 2;
            }
            else if (num2 == 0)
            {
                num = 0;
            }
            else if (num2 == 0xff)
            {
                num = 3;
            }
            return num;
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref 0);
            this.SaveCropDevelopment();
            GlobalVariables.Koc = Conversions.ToSingle(this.txtkoc.Text);
            if (!this.AssignValues(ref true))
            {
                this.Cursor = Cursors.Default;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                short num3 = GlobalVariables.ncrop[1];
                short index = 1;
                while (true)
                {
                    short num5 = num3;
                    if (index > num5)
                    {
                        short nhorizon = GlobalVariables.Nhorizon;
                        index = 1;
                        while (true)
                        {
                            num5 = nhorizon;
                            if (index > num5)
                            {
                                this.frmMain.Refresh();
                                this.Hide();
                                break;
                            }
                            if ((((GlobalVariables.gwflux * GlobalVariables.profiledepth) * 10f) / GlobalVariables.ksatmin[index]) > 1f)
                            {
                                MiscFUncs.MsgBox_Renamed("The criterion for convergence of the numerical\rsolution to Richards' equation is not fulfilled for \rhorizon " + Conversions.ToString((int) index) + ". See equation 62.", 0x30, "Warning");
                            }
                            index = (short) (index + 1);
                        }
                        break;
                    }
                    GlobalVariables.waten[index] = this.ComputeWATEN(ref index);
                    index = (short) (index + 1);
                }
            }
        }

        private void Command11_Click(object eventSender, EventArgs eventArgs)
        {
            this.flx_Parameters[0].Visible = !this.flx_Parameters[0].Visible;
            this.flx_Parameters[1].Visible = !this.flx_Parameters[1].Visible;
            short num2 = (short) (this.flx_Parameters[0].Rows - 1);
            short row = 1;
            while (true)
            {
                short num3 = num2;
                if (row > num3)
                {
                    return;
                }
                this.flx_Parameters[1].set_TextMatrix(row, 1, this.flx_Parameters[0].get_TextMatrix(row, 1));
                row = (short) (row + 1);
            }
        }

        private void Command15_Click(object eventSender, EventArgs eventArgs)
        {
            TextBox box = this.Text27;
            object chk = this.Check4;
            this.CopyToGrid(ref 5, ref box, ref chk, ref this.cmbSoluteVariables.Text);
            this.Check4 = (CheckBoxArray) chk;
            this.Text27 = box;
        }

        private void Command18_Click(object eventSender, EventArgs eventArgs)
        {
            this.SaveCropDevelopment();
            this.AddYear();
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
            AxMSFlexGrid grid = this.flx_Parameters[2];
            this.chk = 0;
            if (!(((GlobalVariables.sw_tempini == MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_initial == MACROConstants.Switch.BareSoil)) & (GlobalVariables.sw_solute == MACROConstants.Switch.BareSoil)))
            {
                short num;
                if (this.optVariableToCopy[0].Checked)
                {
                    num = 3;
                }
                else if (this.optVariableToCopy[1].Checked)
                {
                    num = !this.optVariableToCopy[0].Visible ? (this.optVariableToCopy[2].Visible ? 4 : 3) : (this.optVariableToCopy[2].Visible ? 5 : 4);
                }
                else if (this.optVariableToCopy[2].Checked)
                {
                    num = 4;
                    if (GlobalVariables.sw_tempini == MACROConstants.Switch.BareSoil)
                    {
                        num = (short) (num - 1);
                    }
                }
                short nhorizon = GlobalVariables.Nhorizon;
                short index = 1;
                while (true)
                {
                    short num3;
                    short num7;
                    if (index > nhorizon)
                    {
                        grid = null;
                        break;
                    }
                    if (index != 1)
                    {
                        if (this.Check1[(short) (index - 1)].CheckState == CheckState.Checked)
                        {
                            this.chk = -1;
                            short num6 = GlobalVariables.laysum[index];
                            num3 = (short) (GlobalVariables.laysum[index - 1] + 1);
                            while (true)
                            {
                                num7 = num6;
                                if (num3 > num7)
                                {
                                    break;
                                }
                                grid.Row = num3;
                                grid.set_TextMatrix(num3, num, this.Text3.Text);
                                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                                num3 = (short) (num3 + 1);
                            }
                        }
                    }
                    else if (this.Check1[(short) (index - 1)].CheckState == CheckState.Checked)
                    {
                        this.chk = -1;
                        AxMSFlexGrid grid2 = this.flx_Parameters[2];
                        grid2.Col = num;
                        short num5 = GlobalVariables.laysum[1];
                        num3 = 1;
                        while (true)
                        {
                            num7 = num5;
                            if (num3 > num7)
                            {
                                grid2 = null;
                                break;
                            }
                            grid2.Row = num3;
                            grid2.set_TextMatrix(num3, num, this.Text3.Text);
                            grid2.CellForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            num3 = (short) (num3 + 1);
                        }
                    }
                    index = (short) (index + 1);
                }
            }
        }

        private void Command3_Click(object eventSender, EventArgs eventArgs)
        {
        }

        private void Command5_Click(object eventSender, EventArgs eventArgs)
        {
            TextBox box = this.Text13;
            object chk = this.Check2;
            this.CopyToGrid(ref 4, ref box, ref chk, ref this.cmbVariables.Text);
            this.Check2 = (CheckBoxArray) chk;
            this.Text13 = box;
        }

        private void Command7_Click(object eventSender, EventArgs eventArgs)
        {
            this.SaveCropDevelopment();
            if (this.flx_Parameters[0].Rows == 2)
            {
                MiscFUncs.MsgBox_Renamed("At least one year is necessary", 0x40, "Cannot delete");
            }
            else
            {
                this.DeleteOneYear();
            }
        }

        public bool ComputeDifference()
        {
            bool flag;
            short num3 = 1;
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (index <= nhorizon)
            {
                float num4 = 0f;
                short num6 = (short) (((short) (num3 + GlobalVariables.N_Layer[index])) - 1);
                short row = num3;
                while (true)
                {
                    short num7 = num6;
                    if (row > num7)
                    {
                        num3 = (short) (num3 + GlobalVariables.N_Layer[index]);
                        this.flx_Parameters[8].set_TextMatrix(index, 2, Conversions.ToString((double) (num4 - Conversions.ToDouble(this.flx_Parameters[8].get_TextMatrix(index, 1)))));
                        if (Math.Abs(Conversions.ToDouble(this.flx_Parameters[8].get_TextMatrix(index, 2))) < 0.0001)
                        {
                            this.flx_Parameters[8].set_TextMatrix(index, 2, Conversions.ToString(0));
                        }
                        this.flx_Parameters[8].set_TextMatrix(index, 2, Support.Format(this.flx_Parameters[8].get_TextMatrix(index, 2), "#0.###", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                        if (Conversions.ToDouble(this.flx_Parameters[8].get_TextMatrix(index, 2)) != 0.0)
                        {
                            flag = true;
                        }
                        index = (short) (index + 1);
                        break;
                    }
                    if (!Versioned.IsNumeric(this.flx_Parameters[7].get_TextMatrix(row, 2)))
                    {
                        this.flx_Parameters[7].set_TextMatrix(row, 2, "0");
                    }
                    num4 += (float) Conversions.ToDouble(this.flx_Parameters[7].get_TextMatrix(row, 2));
                    row = (short) (row + 1);
                }
            }
            return flag;
        }

        private float ComputeWATEN(ref short i)
        {
            float num;
            float num6 = (float) ((GlobalVariables.xmpor[1] * Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[1] * GlobalVariables.cten[1], (double) GlobalVariables.vg_N[1]), (double) (1f - (1f / GlobalVariables.vg_N[1])))) / 100.0);
            if (GlobalVariables.sw_crop != MACROConstants.Switch.BareSoil)
            {
                float num2 = 1f - (1f / GlobalVariables.vg_N[1]);
                float num4 = GlobalVariables.xmpor[1] / 100f;
                float num5 = ((((float) ((1f - GlobalVariables.fawc[1]) * (num4 - (((double) GlobalVariables.wilt[1]) / 100.0)))) + (GlobalVariables.wilt[1] / 100f)) - (GlobalVariables.resid[1] / 100f)) / (num6 - (GlobalVariables.resid[1] / 100f));
                num = (float) (((1.0 / GlobalVariables.vg_alpha[1]) * Math.Pow((1.0 / Math.Pow((double) num5, (double) (1f / num2))) - 1.0, (double) (1f / GlobalVariables.vg_N[1]))) / 100.0);
            }
            return num;
        }

        private void CopyCropDevFromFirstYear()
        {
            short num2;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                num2 = this.txtCropDev2.Count();
            }
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                num2 = this.txtCropDev3.Count();
            }
            short num3 = num2;
            short num = 0;
            while (true)
            {
                short num4 = num3;
                if (num > num4)
                {
                    return;
                }
                if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                {
                    GlobalVariables.CropDevelopment2[Information.UBound(GlobalVariables.CropDevelopment2, 1) - num] = GlobalVariables.CropDevelopment2[(short) (this.txtCropDev2.Count() - num)];
                }
                if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
                {
                    GlobalVariables.CropDevelopment3[Information.UBound(GlobalVariables.CropDevelopment3, 1) - num] = GlobalVariables.CropDevelopment3[(short) (this.txtCropDev3.Count() - num)];
                }
                num = (short) (num + 1);
            }
        }

        private void CopyRowAbove()
        {
            AxMSFlexGrid grid = this.flx_Parameters[0];
            grid.set_TextMatrix(grid.Rows - 1, 0, Conversions.ToString((int) (grid.Rows - 1)));
            short num2 = (short) (grid.Cols - 1);
            short col = 1;
            while (true)
            {
                short num3 = num2;
                if (col > num3)
                {
                    grid = null;
                    return;
                }
                grid.set_TextMatrix(grid.Rows - 1, col, grid.get_TextMatrix(grid.Rows - 2, col));
                col = (short) (col + 1);
            }
        }

        private void CopyToGrid(ref short index, ref TextBox box, ref object chk, ref string varText)
        {
            box.Text = Strings.Trim(box.Text);
            if (!Versioned.IsNumeric(box.Text) | (Strings.Len(box.Text) == 0))
            {
                MiscFUncs.MsgBox_Renamed("Please enter a numeric value", 0x30, "Error");
            }
            else
            {
                AxMSFlexGrid grid = this.flx_Parameters[index];
                grid.Row = 0;
                short num2 = (short) (grid.Cols - 1);
                short num = (short) (grid.FixedCols - 1);
                while (true)
                {
                    short num4 = num2;
                    if (num <= num4)
                    {
                        grid.Col = num;
                        if (grid.Text != varText)
                        {
                            num = (short) (num + 1);
                            continue;
                        }
                    }
                    grid.Col = num;
                    short nhorizon = GlobalVariables.Nhorizon;
                    num = 1;
                    while (true)
                    {
                        num4 = nhorizon;
                        if (num > num4)
                        {
                            grid = null;
                            break;
                        }
                        object[] arguments = new object[] { num - 1 };
                        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(chk, arguments, null), null, "checked", new object[0], null, null, null), true, false))
                        {
                            grid.Row = num;
                            grid.Text = box.Text;
                            grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        num = (short) (num + 1);
                    }
                    break;
                }
            }
        }

        public void DeleteOneYear()
        {
            short num2;
            short num3;
            short num4;
            short num10;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                num2 = this.txtCropDev2.Count();
                num3 = (short) Information.UBound(GlobalVariables.CropDevelopment2, 1);
            }
            else if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                num2 = this.txtCropDev3.Count();
                num3 = (short) Information.UBound(GlobalVariables.CropDevelopment3, 1);
            }
            short num5 = Conversions.ToShort(this.cmbDeleteYear.Text);
            if (Conversions.ToDouble(this.cmbDeleteYear.Text) == this.flx_Parameters[0].Rows)
            {
                this.flx_Parameters[0].Rows--;
            }
            else
            {
                short num6 = (short) (this.flx_Parameters[0].Rows - 1);
                num4 = (short) Math.Round((double) (Conversions.ToDouble(this.cmbDeleteYear.Text) + 1.0));
                while (true)
                {
                    if (num4 > num6)
                    {
                        short num8 = (short) (num3 - 1);
                        num4 = (short) ((((short) (num5 * num2)) - 1) + 1);
                        while (true)
                        {
                            num10 = num8;
                            if (num4 > num10)
                            {
                                break;
                            }
                            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                            {
                                GlobalVariables.CropDevelopment2[(short) (num4 - num2)] = GlobalVariables.CropDevelopment2[num4];
                            }
                            else
                            {
                                GlobalVariables.CropDevelopment3[(short) (num4 - num2)] = GlobalVariables.CropDevelopment3[num4];
                            }
                            num4 = (short) (num4 + 1);
                        }
                        break;
                    }
                    short num7 = (short) (this.flx_Parameters[0].Cols - 1);
                    short col = 1;
                    while (true)
                    {
                        num10 = num7;
                        if (col > num10)
                        {
                            num4 = (short) (num4 + 1);
                            break;
                        }
                        this.flx_Parameters[0].set_TextMatrix(num4 - 1, col, this.flx_Parameters[0].get_TextMatrix(num4, col));
                        col = (short) (col + 1);
                    }
                }
            }
            this.flx_Parameters[0].Rows--;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                GlobalVariables.CropDevelopment2 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment2, new float[((this.flx_Parameters[0].Rows - 1) * num2) + 1]);
            }
            else if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                GlobalVariables.CropDevelopment3 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment3, new float[((this.flx_Parameters[0].Rows - 1) * num2) + 1]);
            }
            this.cmbDeleteYear.Items.Clear();
            this.cmbYearSW2.Items.Clear();
            this.cmbYearSW3.Items.Clear();
            short num9 = (short) (this.flx_Parameters[0].Rows - 1);
            num4 = 1;
            while (true)
            {
                num10 = num9;
                if (num4 > num10)
                {
                    this.cmbDeleteYear.SelectedIndex = 0;
                    this.cmbYearSW2.SelectedIndex = 0;
                    this.cmbYearSW3.SelectedIndex = 0;
                    this.SetYearsForIHARVandIDSTART();
                    this.ShowYears();
                    return;
                }
                this.cmbDeleteYear.Items.Add(Conversions.ToString((int) num4));
                this.cmbYearSW2.Items.Add(Conversions.ToString((int) num4));
                this.cmbYearSW3.Items.Add(Conversions.ToString((int) num4));
                num4 = (short) (num4 + 1);
            }
        }

        public void Diffusion(ref short ix1, ref short ix2, ref short hori)
        {
            Array.Clear(this.theta50, 0, this.theta50.Length);
            string str4 = Strings.Trim(GlobalVariables.structur[hori]);
            if (str4 == "none")
            {
                GlobalVariables.ascale[hori] = 1f;
            }
            else
            {
                short num3 = (short) Strings.InStr(1, str4, " ", CompareMethod.Binary);
                string str = Strings.Trim(Strings.Mid(str4, 1, num3 - 1));
                short start = (short) Strings.Len(str4);
                while (true)
                {
                    short num5;
                    short num6 = 1;
                    if (start >= num6)
                    {
                        if (Strings.Mid(str4, start, 1) != " ")
                        {
                            start = (short) (start + -1);
                            continue;
                        }
                        num5 = start;
                    }
                    string str3 = Strings.Trim(Strings.Mid(str4, num5 + 1));
                    string str2 = Strings.Trim(Strings.Mid(str4, num3 + 1, num5 - (num3 + 1)));
                    float num = (str != "weak") ? ((str != "moderate") ? 3f : 2f) : 1f;
                    if (str2 == "fine")
                    {
                        string str5 = str3;
                        if (str5 == "granular")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 2.0);
                        }
                        else if (str5 == "platy")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 10.0);
                        }
                        else if (str5 == "blocky")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 5.0);
                        }
                        else if (str5 == "prismatic")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 10.0);
                        }
                    }
                    else if (str2 == "medium")
                    {
                        string str6 = str3;
                        if (str6 == "granular")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 3.0);
                        }
                        else if (str6 == "platy")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 25.0);
                        }
                        else if (str6 == "blocky")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 10.0);
                        }
                        else if (str6 == "prismatic")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 25.0);
                        }
                    }
                    else if (str2 == "coarse")
                    {
                        string str7 = str3;
                        if (str7 == "granular")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 5.0);
                        }
                        else if (str7 == "platy")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 50.0);
                        }
                        else if (str7 == "blocky")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 25.0);
                        }
                        else if (str7 == "prismatic")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 50.0);
                        }
                    }
                    else
                    {
                        string str8 = str3;
                        if (str8 == "granular")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 10.0);
                        }
                        else if (str8 == "platy")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 50.0);
                        }
                        else if (str8 == "blocky")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 50.0);
                        }
                        else if (str8 == "prismatic")
                        {
                            GlobalVariables.ascale[hori] = (float) (num * 100.0);
                        }
                    }
                    break;
                }
            }
            GlobalVariables.ascale_c[hori] = 3;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing && !ReferenceEquals(this.components, null))
            {
                this.components.Dispose();
            }
            base.Dispose(Disposing);
        }

        private void FillYearsList()
        {
            this.lstYears.Items.Clear();
            short year = (short) this.frmMain.frmSetup.dtStartDate.Value.Year;
            short num3 = (short) ((this.frmMain.frmSetup.dtEndDate.Value.Year - this.frmMain.frmSetup.dtStartDate.Value.Year) + 1);
            short num = 1;
            while (true)
            {
                short num5 = num3;
                if (num > num5)
                {
                    if (Information.UBound(GlobalVariables.irrig_no, 1) == 0)
                    {
                        MiscFUncs.RedimIrrigationArrays(ref this.lstYears.Items.Count);
                    }
                    return;
                }
                this.lstYears.Items.Add(Conversions.ToString((int) num));
                num = (short) (num + 1);
            }
        }

        private int FindColumn(string str)
        {
            AxMSFlexGrid grid = this._flx_Parameters_4;
            int num3 = grid.Cols - 1;
            int col = 0;
            while (true)
            {
                int num;
                int num4 = num3;
                if (col > num4)
                {
                    grid = null;
                    num = -99;
                }
                else
                {
                    if (Strings.UCase(grid.get_TextMatrix(0, col)) != Strings.UCase(str))
                    {
                        col++;
                        continue;
                    }
                    num = col;
                }
                return num;
            }
        }

        private void flx_Parameters_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            short index = this.flx_Parameters.GetIndex((AxMSFlexGrid) eventSender);
            if (index != 8)
            {
                AxMSFlexGrid grid = this.flx_Parameters[index];
                if ((grid.MouseRow > (grid.FixedRows - 1)) & (grid.MouseCol > (grid.FixedCols - 1)))
                {
                    if ((index == 0) | (index == 1))
                    {
                        this.txtCropParameters.Height = (int) Math.Round(Support.TwipsToPixelsY((double) grid.CellHeight));
                        this.txtCropParameters.Left = (int) Math.Round(Support.TwipsToPixelsX(grid.CellLeft + Support.PixelsToTwipsX((double) grid.Left)));
                        this.txtCropParameters.Top = (int) Math.Round(Support.TwipsToPixelsY(grid.CellTop + Support.PixelsToTwipsY((double) grid.Top)));
                        this.txtCropParameters.Width = (int) Math.Round(Support.TwipsToPixelsX((double) grid.CellWidth));
                        this.bKeepColor = true;
                    }
                    else if (index == 2)
                    {
                        this.txtIBCond.Height = (int) Math.Round(Support.TwipsToPixelsY((double) grid.CellHeight));
                        this.txtIBCond.Left = (int) Math.Round(Support.TwipsToPixelsX(grid.CellLeft + Support.PixelsToTwipsX((double) grid.Left)));
                        this.txtIBCond.Top = (int) Math.Round(Support.TwipsToPixelsY(grid.CellTop + Support.PixelsToTwipsY((double) grid.Top)));
                        this.txtIBCond.Width = (int) Math.Round(Support.TwipsToPixelsX((double) grid.CellWidth));
                        this.bKeepColor = true;
                    }
                    else if (index == 5)
                    {
                        this.txtSolute.Height = (int) Math.Round(Support.TwipsToPixelsY((double) grid.CellHeight));
                        this.txtSolute.Left = (int) Math.Round(Support.TwipsToPixelsX(grid.CellLeft + Support.PixelsToTwipsX((double) grid.Left)));
                        this.txtSolute.Top = (int) Math.Round(Support.TwipsToPixelsY(grid.CellTop + Support.PixelsToTwipsY((double) grid.Top)));
                        this.txtSolute.Width = (int) Math.Round(Support.TwipsToPixelsX((double) grid.CellWidth));
                        this.bKeepColor = true;
                    }
                    else
                    {
                        this.txtBox[index].Height = (int) Math.Round(Support.TwipsToPixelsY((double) grid.CellHeight));
                        this.txtBox[index].Left = (int) Math.Round(Support.TwipsToPixelsX(grid.CellLeft + Support.PixelsToTwipsX((double) grid.Left)));
                        this.txtBox[index].Top = (int) Math.Round(Support.TwipsToPixelsY(grid.CellTop + Support.PixelsToTwipsY((double) grid.Top)));
                        this.txtBox[index].Width = (int) Math.Round(Support.TwipsToPixelsX((double) grid.CellWidth));
                        this.bKeepColor = true;
                    }
                    this.ShowTextBox(ref index, ref "");
                    this.bKeepColor = false;
                }
                grid = null;
            }
        }

        private void flx_Parameters_KeyDownEvent(object eventSender, DMSFlexGridEvents_KeyDownEvent eventArgs)
        {
            short index = this.flx_Parameters.GetIndex((AxMSFlexGrid) eventSender);
            AxMSFlexGrid grid = this.flx_Parameters[index];
            if ((grid.Row > (grid.FixedRows - 1)) & (grid.Col > (grid.FixedCols - 1)))
            {
                this.txtBox[index].Height = (int) Math.Round(Support.TwipsToPixelsY((double) grid.CellHeight));
                this.txtBox[index].Left = (int) Math.Round(Support.TwipsToPixelsX(grid.CellLeft + Support.PixelsToTwipsX((double) grid.Left)));
                this.txtBox[index].Top = (int) Math.Round(Support.TwipsToPixelsY(grid.CellTop + Support.PixelsToTwipsY((double) grid.Top)));
                this.txtBox[index].Width = (int) Math.Round(Support.TwipsToPixelsX((double) grid.CellWidth));
                this.bKeepColor = true;
                this.ShowTextBox(ref index, ref Conversions.ToString(Strings.Chr(eventArgs.keyCode)));
                this.bKeepColor = false;
            }
            grid = null;
        }

        private void flx_Parameters_LeaveCell(object eventSender, EventArgs eventArgs)
        {
            short index = this.flx_Parameters.GetIndex((AxMSFlexGrid) eventSender);
            this.m_InGrid = false;
        }

        private void flx_Parameters_MouseMoveEvent(object eventSender, DMSFlexGridEvents_MouseMoveEvent eventArgs)
        {
            short index = this.flx_Parameters.GetIndex((AxMSFlexGrid) eventSender);
            string str = "";
            AxMSFlexGrid grid = this.flx_Parameters[index];
            short num3 = (short) (grid.Cols - 1);
            short num = 1;
            while (true)
            {
                short num5 = num3;
                if (num <= num5)
                {
                    if ((((double) grid.get_ColPos(num)) / 15.0) <= eventArgs.x)
                    {
                        str = grid.get_TextMatrix(0, num);
                        num = (short) (num + 1);
                        continue;
                    }
                    str = grid.get_TextMatrix(0, num - 1);
                }
                if (eventArgs.x > grid.get_ColPos(grid.Cols - 1))
                {
                    str = grid.get_TextMatrix(0, grid.Cols - 1);
                }
                switch (index)
                {
                    case 0:
                        HelpFunctions.HELP_Crop1(ref str, ref this.lblHelp[0]);
                        break;

                    case 1:
                        HelpFunctions.HELP_Crop1(ref str, ref this.lblHelp[0]);
                        break;

                    case 2:
                        HelpFunctions.Help_IBcond(ref str, ref this.lblHelp[2]);
                        break;

                    case 3:
                        HelpFunctions.HELP_Irr(ref str, ref this.lblHelp[3]);
                        break;

                    case 4:
                        HelpFunctions.Help_Physical(ref str, ref this.lblHelp[4]);
                        break;

                    case 5:
                        HelpFunctions.Help_Solute(ref str, ref this.lblHelp[5]);
                        break;

                    case 6:
                        HelpFunctions.Help_Management(ref str, ref this.lblHelp[6]);
                        break;

                    case 7:
                        HelpFunctions.HELP_Numerical(ref str, ref this.lblHelp[7]);
                        break;

                    case 8:
                        HelpFunctions.HELP_Numerical(ref str, ref this.lblHelp[7]);
                        break;

                    default:
                        break;
                }
                grid = null;
                return;
            }
        }

        private void flx_Parameters_Scroll(object eventSender, EventArgs eventArgs)
        {
            short index = this.flx_Parameters.GetIndex((AxMSFlexGrid) eventSender);
            if (this.txtBox[index].Visible)
            {
                this.MoveTextBox(ref this.flx_Parameters[index], ref this.txtBox[index]);
            }
        }

        public void FOOTPRINTPedotransferFunctions()
        {
            frmFOOTPRINTPedotransferInput frm = new frmFOOTPRINTPedotransferInput();
            float midpoint = 0f;
            float left = 0f;
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                AxMSFlexGrid grid = this._flx_Parameters_4;
                int num7 = 1;
                int nhorizon = GlobalVariables.Nhorizon;
                int index = 1;
                while (true)
                {
                    float num2;
                    short num5;
                    float num8;
                    short num10;
                    short num11;
                    float num13;
                    int num14;
                    int num15 = nhorizon;
                    if (index > num15)
                    {
                        grid = null;
                        this.Show();
                        this.ShowPhysical();
                        break;
                    }
                    num7 = (Strings.Left(GlobalVariables.designat[index], 1) != "A") ? 0 : 1;
                    midpoint = Conversions.ToSingle(Operators.AddObject(left, Operators.DivideObject(GlobalVariables.thickness[index], 2)));
                    grid.set_TextMatrix(index, this.FindColumn("CTEN"), "10");
                    GlobalVariables.cten[index] = 10f;
                    if (!(((GlobalVariables.designat[index] != "O") & (GlobalVariables.designat[index] != "H")) & (GlobalVariables.designat[index] != "R")))
                    {
                        if (!((GlobalVariables.designat[index] == "H") | (GlobalVariables.designat[index] == "O")))
                        {
                            if (GlobalVariables.designat[index] == "R")
                            {
                                Interaction.MsgBox("No estimations were done for the R horizon, properties have to be set manually.", MsgBoxStyle.Information, "Rock horizon");
                            }
                        }
                        else
                        {
                            GlobalVariables.vg_alpha[index] = 0.013;
                            GlobalVariables.scalevg_c[index] = 3;
                            GlobalVariables.vg_N[index] = 1.2f;
                            GlobalVariables.zlamb_c[index] = 3;
                            num8 = ((1f - (GlobalVariables.bulk[index] / ((GlobalVariables.orgc[index] / 100f) + ((float) ((1f - (GlobalVariables.orgc[index] / 100f)) * 2.7))))) - ((float) 0.05)) * 100f;
                            int num22 = index;
                            num11 = (short) index;
                            num14 = index;
                            num13 = (float) GlobalVariables.vg_alpha[num14];
                            num10 = (short) num7;
                            float single4 = FootprintPedotransfer.fp_XMPOR(ref num11, ref GlobalVariables.vg_N[index], ref num13, ref num8, ref num10);
                            num7 = num10;
                            GlobalVariables.vg_alpha[num14] = num13;
                            index = num11;
                            GlobalVariables.xmpor[num22] = single4;
                            GlobalVariables.xmpor_c[index] = 3;
                            num11 = (short) index;
                            float single5 = FootprintPedotransfer.macroporosity(ref num11, ref FootprintPedotransfer.TextureClassification(ref GlobalVariables.Texture[index]), ref GlobalVariables.designat[index], ref midpoint, frm);
                            index = num11;
                            num2 = single5;
                            if (num2 == 0f)
                            {
                                Interaction.MsgBox("Error in macroporosity function. Please check horizon designations.", MsgBoxStyle.Exclamation, "FOOTPRINT pedotransfer functions");
                                break;
                            }
                            int num23 = index;
                            num11 = (short) index;
                            num14 = index;
                            num13 = (float) GlobalVariables.vg_alpha[num14];
                            num10 = (short) num7;
                            float single6 = FootprintPedotransfer.fp_XMPOR(ref num11, ref GlobalVariables.vg_N[index], ref num13, ref num8, ref num10);
                            num7 = num10;
                            GlobalVariables.vg_alpha[num14] = num13;
                            index = num11;
                            GlobalVariables.tporv[num23] = num2 + single6;
                            GlobalVariables.tporv_c[index] = 3;
                            if (this.FindColumn("WILT") > 0)
                            {
                                int num24 = index;
                                num11 = (short) index;
                                num10 = (short) num7;
                                num7 = num10;
                                index = num11;
                                GlobalVariables.wilt[num24] = Conversions.ToSingle(FootprintPedotransfer.fp_WILT(ref num11, ref num8, ref num10));
                                GlobalVariables.wilt_c[index] = 3;
                            }
                            num5 = 1;
                            num5 = FootprintPedotransfer.fp_StructureClass(index, midpoint, frm);
                            GlobalVariables.ascale[index] = FootprintPedotransfer.fp_ASCALE(ref num5);
                            GlobalVariables.ascale_c[index] = 3;
                            GlobalVariables.zn[index] = FootprintPedotransfer.fp_ZN(ref num5);
                            GlobalVariables.zn_c[index] = 3;
                            int num25 = index;
                            num11 = (short) index;
                            num10 = (short) num7;
                            index = num11;
                            GlobalVariables.ksm[num25] = FootprintPedotransfer.fp_KSM(ref num11, ref num8, ref num10);
                            GlobalVariables.ksm_c[index] = 3;
                            int num26 = index;
                            num11 = (short) index;
                            num7 = num10;
                            index = num11;
                            GlobalVariables.ksatmin[num26] = FootprintPedotransfer.fp_KSATMIN(ref num2, ref FootprintPedotransfer.fp_ZN(ref num5)) + FootprintPedotransfer.fp_KSM(ref num11, ref num8, ref num10);
                            GlobalVariables.ksatmin_c[index] = 3;
                        }
                    }
                    else
                    {
                        int num1 = index;
                        num10 = (short) index;
                        num11 = (short) num7;
                        index = num10;
                        GlobalVariables.vg_N[num1] = FootprintPedotransfer.Nvg(ref num10, ref num11);
                        GlobalVariables.zlamb_c[index] = 3;
                        int num16 = index;
                        num11 = (short) index;
                        num10 = num11;
                        index = num11;
                        GlobalVariables.vg_alpha[num16] = FootprintPedotransfer.fp_Alphavg(ref num11, ref num10);
                        GlobalVariables.scalevg_c[index] = 3;
                        num11 = (short) index;
                        index = num11;
                        num8 = FootprintPedotransfer.fp_THETAS(ref num11, ref GlobalVariables.stone[index] / 100f, ref Conversions.ToSingle(frm.txtStonePorosity.Text), ref num10);
                        int num17 = index;
                        num11 = (short) index;
                        num14 = index;
                        num13 = (float) GlobalVariables.vg_alpha[num14];
                        float single1 = FootprintPedotransfer.fp_XMPOR(ref num11, ref GlobalVariables.vg_N[index], ref num13, ref num8, ref num10);
                        num7 = num10;
                        GlobalVariables.vg_alpha[num14] = num13;
                        index = num11;
                        GlobalVariables.xmpor[num17] = single1;
                        GlobalVariables.xmpor_c[index] = 3;
                        num11 = (short) index;
                        float single2 = FootprintPedotransfer.macroporosity(ref num11, ref FootprintPedotransfer.TextureClassification(ref GlobalVariables.Texture[index]), ref GlobalVariables.designat[index], ref midpoint, frm);
                        index = num11;
                        num2 = single2;
                        if (num2 == 0f)
                        {
                            Interaction.MsgBox("Error. Please check horizon designations.", MsgBoxStyle.Exclamation, "FOOTPRINT pedotransfer functions");
                            break;
                        }
                        int num18 = index;
                        num11 = (short) index;
                        num14 = index;
                        num13 = (float) GlobalVariables.vg_alpha[num14];
                        num10 = (short) num7;
                        float single3 = FootprintPedotransfer.fp_XMPOR(ref num11, ref GlobalVariables.vg_N[index], ref num13, ref num8, ref num10);
                        num7 = num10;
                        GlobalVariables.vg_alpha[num14] = num13;
                        index = num11;
                        GlobalVariables.tporv[num18] = num2 + single3;
                        GlobalVariables.tporv_c[index] = 3;
                        if (this.FindColumn("WILT") > 0)
                        {
                            int num19 = index;
                            num11 = (short) index;
                            num10 = (short) num7;
                            num7 = num10;
                            index = num11;
                            GlobalVariables.wilt[num19] = Conversions.ToSingle(FootprintPedotransfer.fp_WILT(ref num11, ref num8, ref num10));
                            GlobalVariables.wilt_c[index] = 3;
                        }
                        num5 = FootprintPedotransfer.fp_StructureClass(index, midpoint, frm);
                        GlobalVariables.ascale[index] = FootprintPedotransfer.fp_ASCALE(ref num5);
                        GlobalVariables.ascale_c[index] = 3;
                        GlobalVariables.zn[index] = FootprintPedotransfer.fp_ZN(ref num5);
                        GlobalVariables.zn_c[index] = 3;
                        int num20 = index;
                        num11 = (short) index;
                        num10 = (short) num7;
                        index = num11;
                        GlobalVariables.ksm[num20] = FootprintPedotransfer.fp_KSM(ref num11, ref num8, ref num10);
                        GlobalVariables.ksm_c[index] = 3;
                        int num21 = index;
                        num11 = (short) index;
                        num7 = num10;
                        index = num11;
                        GlobalVariables.ksatmin[num21] = FootprintPedotransfer.fp_KSATMIN(ref num2, ref FootprintPedotransfer.fp_ZN(ref num5)) + FootprintPedotransfer.fp_KSM(ref num11, ref num8, ref num10);
                        GlobalVariables.ksatmin_c[index] = 3;
                    }
                    left = Conversions.ToSingle(Operators.AddObject(left, GlobalVariables.thickness[index]));
                    index++;
                }
            }
        }

        private void frmParameters_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsEditing && !this.IsInitializing)
            {
                this.m_CurrIrrGroup = 1;
                this.bSkipStore = true;
                if (!this.Pedotransfer & !this.bCheckingValues)
                {
                    this.ShowAll();
                }
                this.FillYearsList();
                this.SetDefinitionYears();
                this.Pedotransfer = false;
                this.bCheckingValues = false;
                this.bSkipStore = false;
                this.SetTempIDSTARTandIHARV();
            }
            this.IsEditing = true;
        }

        private void frmParameters_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short charCode = (short) Strings.Asc(eventArgs.KeyChar);
            eventArgs.KeyChar = Strings.Chr(charCode);
            if (charCode == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void frmParameters_Load(object eventSender, EventArgs eventArgs)
        {
            this.bSkipStore = true;
            this.Icon = this.frmMain.Icon;
            this.flx_Parameters[2].Cols = 4;
            this.flx_Parameters[4].Cols = 0x11;
            this.flx_Parameters[3].Cols = 5;
            this.flx_Parameters[5].Cols = 3;
            this.flx_Parameters[3].set_ColWidth(0, 800);
            this.flx_Parameters[3].set_ColWidth(1, 800);
            this.flx_Parameters[3].set_ColWidth(2, 600);
            this.flx_Parameters[3].set_ColWidth(4, 700);
            this.flx_Parameters[4].set_ColWidth(0, 700);
            this.flx_Parameters[4].set_ColWidth(1, 600);
            this.flx_Parameters[4].set_ColWidth(2, 600);
            this.flx_Parameters[2].set_ColWidth(0, 700);
            this.flx_Parameters[2].set_ColWidth(1, 600);
            this.flx_Parameters[2].set_ColWidth(2, 600);
            this.flx_Parameters[5].set_ColWidth(0, 700);
            this.flx_Parameters[5].set_ColWidth(1, 600);
            this.flx_Parameters[5].set_ColWidth(2, 600);
            this.FillYearsList();
            if (!this.Pedotransfer)
            {
                this.ShowAll();
            }
            this.Pedotransfer = false;
            this.bSkipStore = false;
        }

        public void Hydraulic(ref short ix1, ref short ix2, ref short j, ref bool b_ksm, ref bool b_ksatmin)
        {
            string str4 = GlobalVariables.structur[j];
            short num5 = (short) Strings.InStr(1, str4, " ", CompareMethod.Binary);
            string str = Strings.Trim(Strings.Mid(str4, 1, num5 - 1));
            short start = (short) Strings.Len(str4);
            while (true)
            {
                float num;
                short num7;
                short num18 = 1;
                if (start >= num18)
                {
                    if (Strings.Mid(str4, start, 1) != " ")
                    {
                        start = (short) (start + -1);
                        continue;
                    }
                    num7 = start;
                }
                string str3 = Strings.Trim(Strings.Mid(str4, num7 + 1));
                string str2 = Strings.Trim(Strings.Mid(str4, num5 + 1, num7 - (num5 + 1)));
                short index = j;
                float num8 = (float) (GlobalVariables.orgc[j] * 1.724);
                short num14 = 0;
                if (j == 1)
                {
                    start = 1;
                    short num17 = (short) Strings.Len(GlobalVariables.designat[j]);
                    short length = 1;
                    while (true)
                    {
                        num18 = num17;
                        if (length > num18)
                        {
                            break;
                        }
                        if (Strings.Mid(GlobalVariables.designat[j], start, length) == "A")
                        {
                            num14 = 1;
                        }
                        length = (short) (length + 1);
                    }
                }
                float num11 = (float) ((((((((((0.002885 * Math.Pow((double) num8, 2.0)) - (12.81 / ((double) GlobalVariables.bulk[j]))) - (0.1524 / ((double) GlobalVariables.silt[j]))) - (0.01958 / ((double) num8))) - (0.2876 * Math.Log((double) GlobalVariables.silt[j]))) - (0.0709 * Math.Log((double) num8))) - (44.6 * Math.Log((double) GlobalVariables.bulk[j]))) - ((0.02264 * GlobalVariables.bulk[j]) * GlobalVariables.clay[j])) + ((0.0896 * num8) * GlobalVariables.bulk[j])) + ((0.00718 * num14) * GlobalVariables.clay[j]));
                float num13 = (float) (Math.Exp((double) ((((float) (((-25.23 - (0.02195 * GlobalVariables.clay[j])) + (0.0074 * GlobalVariables.silt[j])) - (0.194 * num8))) + ((float) (((45.5 * GlobalVariables.bulk[j]) - (7.24 * Math.Pow((double) GlobalVariables.bulk[j], 2.0))) + (0.0003658 * Math.Pow((double) GlobalVariables.clay[j], 2.0))))) + num11)) + 1.0);
                float num10 = (float) Math.Exp((double) ((float) ((((((((((((((-14.96 + (0.03135 * GlobalVariables.clay[j])) + (0.0351 * GlobalVariables.silt[j])) + (0.646 * num8)) + (15.29 * GlobalVariables.bulk[j])) - (0.192 * num14)) - (4.671 * Math.Pow((double) GlobalVariables.bulk[j], 2.0))) - (0.000781 * Math.Pow((double) GlobalVariables.clay[j], 2.0))) - (0.00687 * Math.Pow((double) num8, 2.0))) + (0.0449 / ((double) num8))) + (0.0663 * Math.Log((double) GlobalVariables.silt[j]))) + (0.1482 * Math.Log((double) num8))) - ((0.04546 * GlobalVariables.bulk[j]) * GlobalVariables.silt[j])) - ((0.4852 * num8) * GlobalVariables.bulk[j])) + ((0.00673 * num14) * GlobalVariables.clay[j]))));
                num11 = (float) (((double) ((float) ((((((((((((0.7919 + (0.001691 * GlobalVariables.clay[j])) - (0.29619 * GlobalVariables.bulk[j])) - (1.491E-06 * Math.Pow((double) GlobalVariables.silt[j], 2.0))) + (8.21E-05 * Math.Pow((double) num8, 2.0))) + (0.02427 / ((double) GlobalVariables.clay[j]))) + (0.01113 / ((double) GlobalVariables.silt[j]))) + (0.01472 * Math.Log((double) GlobalVariables.silt[j]))) - ((7.33E-05 * num8) * GlobalVariables.clay[j])) - ((0.000619 * GlobalVariables.bulk[j]) * GlobalVariables.clay[j])) - ((0.001183 * GlobalVariables.bulk[j]) * num8)) - ((0.0001664 * num14) * GlobalVariables.silt[j])) * 100.0))) / Math.Pow(1.0 + Math.Pow((double) (num10 * 50f), (double) num13), (double) (1f - (1f / num13))));
                float num9 = (float) ((((100.0 - GlobalVariables.orgc[j]) * 2.7) + GlobalVariables.orgc[j]) / 100.0);
                num10 = (float) (((1.0 - (GlobalVariables.bulk[j] / num9)) * 0.96) * 100.0);
                num9 = (float) (((Math.Log(0.001) * (GlobalVariables.clay[j] / 100f)) + (Math.Log(0.026) * (GlobalVariables.silt[j] / 100f))) + (Math.Log(1.025) * (GlobalVariables.sand[j] / 100f)));
                if (b_ksm)
                {
                    GlobalVariables.ksm[index] = (float) (25.2 * Math.Exp((double) num9));
                    GlobalVariables.ksm_c[index] = 3;
                }
                if ((num10 - num11) < 0.01)
                {
                    num = 0.01f;
                }
                if (b_ksatmin)
                {
                    if ((GlobalVariables.clay[j] < 16f) & ((GlobalVariables.silt[j] + (GlobalVariables.clay[j] * 2f)) < 31f))
                    {
                        GlobalVariables.ksatmin[index] = (num >= 7.5) ? ((float) (((8.03578 - (6.7707 * num)) + (0.833 * Math.Pow((double) num, 2.0))) * 0.41666666666666669)) : ((float) ((0.4535 * Math.Pow((double) num, 1.03423)) * 0.41666666666666669));
                    }
                    else
                    {
                        float num16 = (str != "none") ? ((str != "weak") ? ((str != "moderate") ? ((num <= 10f) ? ((float) Math.Pow(10.0, 1.0 + (0.1 * (10f - num)))) : 10f) : ((num <= 10f) ? ((float) Math.Pow(10.0, 0.7 + (0.05 * (10f - num)))) : 5.011872f)) : ((num <= 10f) ? ((float) Math.Pow(10.0, 0.5 + (0.03 * (10f - num)))) : 3.162278f)) : 1f;
                        GlobalVariables.ksatmin[index] = (num >= 4.0) ? ((float) ((((5.8521 - (5.4125 * num)) + (1.05138 * Math.Pow((double) num, 2.0))) * 0.41666666666666669) * num16)) : ((float) (((0.14143 * Math.Exp(0.46944 * num)) * 0.41666666666666669) * num16));
                        GlobalVariables.ksatmin_c[index] = 3;
                    }
                }
                return;
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmParameters));
            this.cmdApply = new Button();
            this.Command7 = new Button();
            this.Command11 = new Button();
            this.Command18 = new Button();
            this.cmdStore = new Button();
            this.cmdClear = new Button();
            this.cmdAggregate = new Button();
            this.cmdHelp = new Button();
            this.CommonDialog1Open = new OpenFileDialog();
            this.CommonDialog1Save = new SaveFileDialog();
            this.CommonDialog1Font = new FontDialog();
            this.CommonDialog1Color = new ColorDialog();
            this.CommonDialog1Print = new PrintDialog();
            this.cmdCancel = new Button();
            this.Command1 = new Button();
            this.SSTab1 = new TabControl();
            this._SSTab1_TabPage0 = new TabPage();
            this.txtCropParameters = new TextBox();
            this._flx_Parameters_0 = new AxMSFlexGrid();
            this.fraCropSw3 = new GroupBox();
            this.cmbYearSW3 = new ComboBox();
            this._txtCropDev3_2 = new TextBox();
            this._txtCropDev3_1 = new TextBox();
            this._txtCropDev3_0 = new TextBox();
            this.Label26 = new Label();
            this._lblCrop_2 = new Label();
            this._lblCrop_1 = new Label();
            this._lblCrop_0 = new Label();
            this._flx_Parameters_1 = new AxMSFlexGrid();
            this._txtBox_1 = new TextBox();
            this.fraCropSW2 = new GroupBox();
            this.cmbYearSW2 = new ComboBox();
            this._txtCropDev2_8 = new TextBox();
            this._txtCropDev2_7 = new TextBox();
            this._txtCropDev2_6 = new TextBox();
            this._txtCropDev2_5 = new TextBox();
            this._txtCropDev2_4 = new TextBox();
            this._txtCropDev2_3 = new TextBox();
            this._txtCropDev2_2 = new TextBox();
            this._txtCropDev2_1 = new TextBox();
            this._txtCropDev2_0 = new TextBox();
            this.Label25 = new Label();
            this._lblCrop_8 = new Label();
            this._lblCrop_7 = new Label();
            this._lblCrop_6 = new Label();
            this._lblCrop_5 = new Label();
            this._lblCrop_4 = new Label();
            this._lblCrop_3 = new Label();
            this.Label9 = new Label();
            this.Label8 = new Label();
            this._txtBox_0 = new TextBox();
            this.Frame7 = new GroupBox();
            this.cmbDeleteYear = new ComboBox();
            this._lblHelp_0 = new Label();
            this._SSTab1_TabPage1 = new TabPage();
            this.txtIBCond = new TextBox();
            this._lblHelp_2 = new Label();
            this._flx_Parameters_2 = new AxMSFlexGrid();
            this._txtBox_2 = new TextBox();
            this.Frame1 = new GroupBox();
            this.cmdBrowseForTensionFile = new Button();
            this.txtTensionFile = new TextBox();
            this._text1_5 = new TextBox();
            this._text1_4 = new TextBox();
            this._text1_0 = new TextBox();
            this._text1_1 = new TextBox();
            this._text1_2 = new TextBox();
            this._text1_3 = new TextBox();
            this._Label1_5 = new Label();
            this._Label1_4 = new Label();
            this._Label1_0 = new Label();
            this._Label1_1 = new Label();
            this._Label1_2 = new Label();
            this._Label1_3 = new Label();
            this.Frame3 = new GroupBox();
            this._Check1_9 = new CheckBox();
            this._optVariableToCopy_2 = new RadioButton();
            this._optVariableToCopy_1 = new RadioButton();
            this._optVariableToCopy_0 = new RadioButton();
            this._Check1_1 = new CheckBox();
            this.Command2 = new Button();
            this._Check1_0 = new CheckBox();
            this._Check1_2 = new CheckBox();
            this._Check1_3 = new CheckBox();
            this._Check1_4 = new CheckBox();
            this._Check1_5 = new CheckBox();
            this._Check1_6 = new CheckBox();
            this._Check1_7 = new CheckBox();
            this._Check1_8 = new CheckBox();
            this.Text3 = new TextBox();
            this.Command3 = new Button();
            this.Label22 = new Label();
            this.Label3 = new Label();
            this.Frame10 = new GroupBox();
            this.Command4 = new Button();
            this.Label4 = new Label();
            this._SSTab1_TabPage2 = new TabPage();
            this.Frame11 = new GroupBox();
            this.udNIRR = new NumericUpDown();
            this.Frame9 = new GroupBox();
            this.fraDefineSubSets = new GroupBox();
            this.lstYearSubSets = new ListBox();
            this.lstYears = new ListBox();
            this.Label19 = new Label();
            this.Label14 = new Label();
            this.Label6 = new Label();
            this._optDefinitionType_1 = new RadioButton();
            this._optDefinitionType_0 = new RadioButton();
            this._txtBox_3 = new TextBox();
            this.Text8 = new TextBox();
            this._flx_Parameters_3 = new AxMSFlexGrid();
            this.lblIrrigationYears = new Label();
            this.Label18 = new Label();
            this._lblHelp_3 = new Label();
            this.Label13 = new Label();
            this.Label12 = new Label();
            this._SSTab1_TabPage3 = new TabPage();
            this.Frame12 = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.btnCalculatePedotransfer = new Button();
            this.optFOOTPRINTPedotransfer = new RadioButton();
            this.optMACROPedotransfer = new RadioButton();
            this.Frame6 = new GroupBox();
            this._Check2_9 = new CheckBox();
            this.cmbVariables = new ComboBox();
            this.Command5 = new Button();
            this.Text13 = new TextBox();
            this._Check2_8 = new CheckBox();
            this._Check2_7 = new CheckBox();
            this._Check2_6 = new CheckBox();
            this._Check2_5 = new CheckBox();
            this._Check2_4 = new CheckBox();
            this._Check2_3 = new CheckBox();
            this._Check2_2 = new CheckBox();
            this._Check2_1 = new CheckBox();
            this._Check2_0 = new CheckBox();
            this.Label23 = new Label();
            this.Label36 = new Label();
            this.Label16 = new Label();
            this._txtBox_4 = new TextBox();
            this._flx_Parameters_4 = new AxMSFlexGrid();
            this._lblHelp_4 = new Label();
            this._SSTab1_TabPage4 = new TabPage();
            this.Frame4 = new GroupBox();
            this._Text4_13 = new TextBox();
            this._Text4_5 = new TextBox();
            this._Text4_4 = new TextBox();
            this._Text4_3 = new TextBox();
            this._Text4_2 = new TextBox();
            this._Text4_1 = new TextBox();
            this._Text4_0 = new TextBox();
            this._Text4_6 = new TextBox();
            this._Text4_7 = new TextBox();
            this._Text4_8 = new TextBox();
            this._Text4_9 = new TextBox();
            this._Text4_10 = new TextBox();
            this._Text4_11 = new TextBox();
            this._Text4_12 = new TextBox();
            this._Label11_13 = new Label();
            this.Label5 = new Label();
            this._Label11_4 = new Label();
            this._Label11_3 = new Label();
            this._Label11_2 = new Label();
            this._Label11_1 = new Label();
            this._Label11_0 = new Label();
            this._Label11_5 = new Label();
            this._Label11_6 = new Label();
            this._Label11_7 = new Label();
            this._Label11_8 = new Label();
            this._Label11_9 = new Label();
            this._Label11_10 = new Label();
            this._Label11_11 = new Label();
            this._Label11_12 = new Label();
            this.lblHelpSite = new Label();
            this._SSTab1_TabPage5 = new TabPage();
            this.txtSolute = new TextBox();
            this._lblHelp_5 = new Label();
            this.Label20 = new Label();
            this._flx_Parameters_5 = new AxMSFlexGrid();
            this.Frame13 = new GroupBox();
            this._Check4_9 = new CheckBox();
            this.cmbSoluteVariables = new ComboBox();
            this._Check4_0 = new CheckBox();
            this._Check4_1 = new CheckBox();
            this._Check4_2 = new CheckBox();
            this._Check4_3 = new CheckBox();
            this._Check4_4 = new CheckBox();
            this._Check4_5 = new CheckBox();
            this._Check4_6 = new CheckBox();
            this._Check4_7 = new CheckBox();
            this._Check4_8 = new CheckBox();
            this.Text27 = new TextBox();
            this.Command15 = new Button();
            this.Label24 = new Label();
            this.Label15 = new Label();
            this.Label28 = new Label();
            this._txtBox_5 = new TextBox();
            this.Frame2 = new GroupBox();
            this._text12_21 = new TextBox();
            this._text12_20 = new TextBox();
            this._text12_19 = new TextBox();
            this._text12_18 = new TextBox();
            this._text12_17 = new TextBox();
            this._text12_16 = new TextBox();
            this._text12_15 = new TextBox();
            this._text12_14 = new TextBox();
            this._text12_13 = new TextBox();
            this._text12_12 = new TextBox();
            this._text12_11 = new TextBox();
            this._text12_10 = new TextBox();
            this._text12_9 = new TextBox();
            this._text12_8 = new TextBox();
            this._text12_7 = new TextBox();
            this._text12_6 = new TextBox();
            this._text12_5 = new TextBox();
            this._text12_4 = new TextBox();
            this._text12_3 = new TextBox();
            this._text12_2 = new TextBox();
            this._text12_1 = new TextBox();
            this._text12_0 = new TextBox();
            this.cmbIndex = new ComboBox();
            this.cmbParameters = new ComboBox();
            this.Label2 = new Label();
            this.txtkoc = new TextBox();
            this.cmdKoc = new Button();
            this.cmdFOCUS = new Button();
            this._SSTab1_TabPage6 = new TabPage();
            this._fraManagement_0 = new GroupBox();
            this._txtMan_13 = new TextBox();
            this._txtMan_12 = new TextBox();
            this._txtMan_8 = new TextBox();
            this._txtMan_11 = new TextBox();
            this._txtMan_10 = new TextBox();
            this._txtMan_9 = new TextBox();
            this._txtMan_7 = new TextBox();
            this._txtMan_6 = new TextBox();
            this._txtMan_5 = new TextBox();
            this._txtMan_4 = new TextBox();
            this._txtMan_3 = new TextBox();
            this._txtMan_2 = new TextBox();
            this._txtMan_1 = new TextBox();
            this._txtMan_0 = new TextBox();
            this._txtBox_6 = new TextBox();
            this._flx_Parameters_6 = new AxMSFlexGrid();
            this._lblMan_13 = new Label();
            this._lblMan_12 = new Label();
            this._lblMan_11 = new Label();
            this._lblMan_10 = new Label();
            this._lblMan_9 = new Label();
            this._lblMan_8 = new Label();
            this._lblMan_5 = new Label();
            this._lblMan_0 = new Label();
            this._lblMan_1 = new Label();
            this._lblMan_3 = new Label();
            this._lblMan_6 = new Label();
            this._lblMan_7 = new Label();
            this._lblMan_4 = new Label();
            this._lblMan_2 = new Label();
            this._lblHelp_6 = new Label();
            this.Label17 = new Label();
            this._SSTab1_TabPage7 = new TabPage();
            this.Frame5 = new GroupBox();
            this._txtBox_8 = new TextBox();
            this.Frame8 = new GroupBox();
            this._lblHelp_7 = new Label();
            this._flx_Parameters_8 = new AxMSFlexGrid();
            this._txtBox_7 = new TextBox();
            this._flx_Parameters_7 = new AxMSFlexGrid();
            this.Label7 = new Label();
            this.Label10 = new Label();
            this.udNMAN = new AxUpDown();
            this.Check1 = new CheckBoxArray(this.components);
            this.Check2 = new CheckBoxArray(this.components);
            this.Check4 = new CheckBoxArray(this.components);
            this.Label1 = new LabelArray(this.components);
            this.Label11 = new LabelArray(this.components);
            this.Text4 = new TextBoxArray(this.components);
            this.flx_Parameters = new AxMSFlexGridArray.AxMSFlexGridArray(this.components);
            this.fraManagement = new GroupBoxArray(this.components);
            this.lblCrop = new LabelArray(this.components);
            this.lblHelp = new LabelArray(this.components);
            this.lblMan = new LabelArray(this.components);
            this.optDefinitionType = new RadioButtonArray(this.components);
            this.optVariableToCopy = new RadioButtonArray(this.components);
            this.text1 = new TextBoxArray(this.components);
            this.text12 = new TextBoxArray(this.components);
            this.txtBox = new TextBoxArray(this.components);
            this.txtCropDev2 = new TextBoxArray(this.components);
            this.txtCropDev3 = new TextBoxArray(this.components);
            this.txtMan = new TextBoxArray(this.components);
            this.txtNMan = new NumericUpDown();
            this.SSTab1.SuspendLayout();
            this._SSTab1_TabPage0.SuspendLayout();
            this._flx_Parameters_0.BeginInit();
            this.fraCropSw3.SuspendLayout();
            this._flx_Parameters_1.BeginInit();
            this.fraCropSW2.SuspendLayout();
            this.Frame7.SuspendLayout();
            this._SSTab1_TabPage1.SuspendLayout();
            this._flx_Parameters_2.BeginInit();
            this.Frame1.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame10.SuspendLayout();
            this._SSTab1_TabPage2.SuspendLayout();
            this.Frame11.SuspendLayout();
            this.udNIRR.BeginInit();
            this.Frame9.SuspendLayout();
            this.fraDefineSubSets.SuspendLayout();
            this._flx_Parameters_3.BeginInit();
            this._SSTab1_TabPage3.SuspendLayout();
            this.Frame12.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Frame6.SuspendLayout();
            this._flx_Parameters_4.BeginInit();
            this._SSTab1_TabPage4.SuspendLayout();
            this.Frame4.SuspendLayout();
            this._SSTab1_TabPage5.SuspendLayout();
            this._flx_Parameters_5.BeginInit();
            this.Frame13.SuspendLayout();
            this.Frame2.SuspendLayout();
            this._SSTab1_TabPage6.SuspendLayout();
            this._fraManagement_0.SuspendLayout();
            this._flx_Parameters_6.BeginInit();
            this._SSTab1_TabPage7.SuspendLayout();
            this.Frame5.SuspendLayout();
            this.Frame8.SuspendLayout();
            this._flx_Parameters_8.BeginInit();
            this._flx_Parameters_7.BeginInit();
            this.udNMAN.BeginInit();
            ((ISupportInitialize) this.Check1).BeginInit();
            ((ISupportInitialize) this.Check2).BeginInit();
            ((ISupportInitialize) this.Check4).BeginInit();
            ((ISupportInitialize) this.Label1).BeginInit();
            ((ISupportInitialize) this.Label11).BeginInit();
            ((ISupportInitialize) this.Text4).BeginInit();
            ((ISupportInitialize) this.flx_Parameters).BeginInit();
            ((ISupportInitialize) this.fraManagement).BeginInit();
            ((ISupportInitialize) this.lblCrop).BeginInit();
            ((ISupportInitialize) this.lblHelp).BeginInit();
            ((ISupportInitialize) this.lblMan).BeginInit();
            ((ISupportInitialize) this.optDefinitionType).BeginInit();
            ((ISupportInitialize) this.optVariableToCopy).BeginInit();
            ((ISupportInitialize) this.text1).BeginInit();
            ((ISupportInitialize) this.text12).BeginInit();
            ((ISupportInitialize) this.txtBox).BeginInit();
            ((ISupportInitialize) this.txtCropDev2).BeginInit();
            ((ISupportInitialize) this.txtCropDev3).BeginInit();
            ((ISupportInitialize) this.txtMan).BeginInit();
            this.txtNMan.BeginInit();
            this.SuspendLayout();
            this.cmdApply.BackColor = SystemColors.Control;
            this.cmdApply.Cursor = Cursors.Default;
            this.cmdApply.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdApply.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x1e8, 0x170);
            this.cmdApply.Location = point;
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.RightToLeft = RightToLeft.No;
            Size size = new Size(0x49, 0x19);
            this.cmdApply.Size = size;
            this.cmdApply.TabIndex = 0x73;
            this.cmdApply.TabStop = false;
            this.cmdApply.Text = "&Apply";
            this.cmdApply.UseVisualStyleBackColor = false;
            this.Command7.BackColor = SystemColors.Control;
            this.Command7.Cursor = Cursors.Default;
            this.Command7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command7.ForeColor = SystemColors.ControlText;
            point = new Point(80, 0x15);
            this.Command7.Location = point;
            this.Command7.Name = "Command7";
            this.Command7.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command7.Size = size;
            this.Command7.TabIndex = 0x67;
            this.Command7.TabStop = false;
            this.Command7.Text = "&Delete";
            this.Command7.UseVisualStyleBackColor = false;
            this.Command11.BackColor = SystemColors.Control;
            this.Command11.Cursor = Cursors.Default;
            this.Command11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command11.ForeColor = SystemColors.ControlText;
            point = new Point(0x269, 0xdf);
            this.Command11.Location = point;
            this.Command11.Name = "Command11";
            this.Command11.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command11.Size = size;
            this.Command11.TabIndex = 0x52;
            this.Command11.TabStop = false;
            this.Command11.Text = "&Switch";
            this.Command11.UseVisualStyleBackColor = false;
            this.Command11.Visible = false;
            this.Command18.BackColor = SystemColors.Control;
            this.Command18.Cursor = Cursors.Default;
            this.Command18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command18.ForeColor = SystemColors.ControlText;
            point = new Point(0x1bc, 0x7b);
            this.Command18.Location = point;
            this.Command18.Name = "Command18";
            this.Command18.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command18.Size = size;
            this.Command18.TabIndex = 0x54;
            this.Command18.TabStop = false;
            this.Command18.Text = "&Add Year";
            this.Command18.UseVisualStyleBackColor = false;
            this.cmdStore.BackColor = SystemColors.Control;
            this.cmdStore.Cursor = Cursors.Default;
            this.cmdStore.Enabled = false;
            this.cmdStore.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdStore.ForeColor = SystemColors.ControlText;
            point = new Point(320, 0x18);
            this.cmdStore.Location = point;
            this.cmdStore.Name = "cmdStore";
            this.cmdStore.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdStore.Size = size;
            this.cmdStore.TabIndex = 0xe3;
            this.cmdStore.TabStop = false;
            this.cmdStore.Text = "&Store";
            this.cmdStore.UseVisualStyleBackColor = false;
            this.cmdStore.Visible = false;
            this.cmdClear.BackColor = SystemColors.Control;
            this.cmdClear.Cursor = Cursors.Default;
            this.cmdClear.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdClear.ForeColor = SystemColors.ControlText;
            point = new Point(0xd0, 120);
            this.cmdClear.Location = point;
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdClear.Size = size;
            this.cmdClear.TabIndex = 0xde;
            this.cmdClear.TabStop = false;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdAggregate.BackColor = SystemColors.Control;
            this.cmdAggregate.Cursor = Cursors.Default;
            this.cmdAggregate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAggregate.ForeColor = SystemColors.ControlText;
            point = new Point(0x58, 0x20);
            this.cmdAggregate.Location = point;
            this.cmdAggregate.Name = "cmdAggregate";
            this.cmdAggregate.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x19);
            this.cmdAggregate.Size = size;
            this.cmdAggregate.TabIndex = 0xdd;
            this.cmdAggregate.TabStop = false;
            this.cmdAggregate.Text = "-&>";
            this.cmdAggregate.UseVisualStyleBackColor = false;
            this.cmdHelp.BackColor = SystemColors.Control;
            this.cmdHelp.Cursor = Cursors.Default;
            this.cmdHelp.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdHelp.ForeColor = SystemColors.ControlText;
            point = new Point(0x198, 0x170);
            this.cmdHelp.Location = point;
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdHelp.Size = size;
            this.cmdHelp.TabIndex = 230;
            this.cmdHelp.Text = "&Help";
            this.cmdHelp.UseVisualStyleBackColor = false;
            this.cmdHelp.Visible = false;
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x238, 0x170);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 0x72;
            this.cmdCancel.TabStop = false;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            point = new Point(0x288, 0x170);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 0;
            this.Command1.TabStop = false;
            this.Command1.Text = "&OK";
            this.Command1.UseVisualStyleBackColor = false;
            this.SSTab1.Appearance = TabAppearance.FlatButtons;
            this.SSTab1.Controls.Add(this._SSTab1_TabPage0);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage2);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage3);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage4);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage5);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage6);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage7);
            this.SSTab1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            size = new Size(0x2a, 14);
            this.SSTab1.ItemSize = size;
            point = new Point(3, 12);
            this.SSTab1.Location = point;
            this.SSTab1.Name = "SSTab1";
            point = new Point(10, 3);
            this.SSTab1.Padding = point;
            this.SSTab1.SelectedIndex = 5;
            size = new Size(0x31c, 350);
            this.SSTab1.Size = size;
            this.SSTab1.TabIndex = 1;
            this.SSTab1.TabStop = false;
            this._SSTab1_TabPage0.Controls.Add(this.txtCropParameters);
            this._SSTab1_TabPage0.Controls.Add(this._flx_Parameters_0);
            this._SSTab1_TabPage0.Controls.Add(this.fraCropSw3);
            this._SSTab1_TabPage0.Controls.Add(this._flx_Parameters_1);
            this._SSTab1_TabPage0.Controls.Add(this.Command11);
            this._SSTab1_TabPage0.Controls.Add(this._txtBox_1);
            this._SSTab1_TabPage0.Controls.Add(this.fraCropSW2);
            this._SSTab1_TabPage0.Controls.Add(this._txtBox_0);
            this._SSTab1_TabPage0.Controls.Add(this.Frame7);
            this._SSTab1_TabPage0.Controls.Add(this._lblHelp_0);
            this._SSTab1_TabPage0.Controls.Add(this.Command18);
            this._SSTab1_TabPage0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage0.Location = point;
            this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage0.Size = size;
            this._SSTab1_TabPage0.TabIndex = 0;
            this._SSTab1_TabPage0.Text = "CROP";
            this._SSTab1_TabPage0.UseVisualStyleBackColor = true;
            point = new Point(0x7d, 0x40);
            this.txtCropParameters.Location = point;
            this.txtCropParameters.Name = "txtCropParameters";
            size = new Size(0x3a, 20);
            this.txtCropParameters.Size = size;
            this.txtCropParameters.TabIndex = 0x6a;
            this.txtCropParameters.Visible = false;
            this.flx_Parameters.SetIndex(this._flx_Parameters_0, 0);
            point = new Point(10, 3);
            this._flx_Parameters_0.Location = point;
            this._flx_Parameters_0.Name = "_flx_Parameters_0";
            this._flx_Parameters_0.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_0.OcxState");
            size = new Size(0x1fb, 0x61);
            this._flx_Parameters_0.Size = size;
            this._flx_Parameters_0.TabIndex = 0x1b;
            this.fraCropSw3.BackColor = SystemColors.Control;
            this.fraCropSw3.Controls.Add(this.cmbYearSW3);
            this.fraCropSw3.Controls.Add(this._txtCropDev3_2);
            this.fraCropSw3.Controls.Add(this._txtCropDev3_1);
            this.fraCropSw3.Controls.Add(this._txtCropDev3_0);
            this.fraCropSw3.Controls.Add(this.Label26);
            this.fraCropSw3.Controls.Add(this._lblCrop_2);
            this.fraCropSw3.Controls.Add(this._lblCrop_1);
            this.fraCropSw3.Controls.Add(this._lblCrop_0);
            this.fraCropSw3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraCropSw3.ForeColor = SystemColors.ControlText;
            point = new Point(0x227, 0xd1);
            this.fraCropSw3.Location = point;
            this.fraCropSw3.Name = "fraCropSw3";
            this.fraCropSw3.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x71);
            this.fraCropSw3.Size = size;
            this.fraCropSw3.TabIndex = 0x1d;
            this.fraCropSw3.TabStop = false;
            this.fraCropSw3.Text = "Crop development";
            this.cmbYearSW3.BackColor = SystemColors.Window;
            this.cmbYearSW3.Cursor = Cursors.Default;
            this.cmbYearSW3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbYearSW3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbYearSW3.ForeColor = SystemColors.WindowText;
            point = new Point(0x38, 80);
            this.cmbYearSW3.Location = point;
            this.cmbYearSW3.Name = "cmbYearSW3";
            this.cmbYearSW3.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x16);
            this.cmbYearSW3.Size = size;
            this.cmbYearSW3.TabIndex = 0xb6;
            this._txtCropDev3_2.AcceptsReturn = true;
            this._txtCropDev3_2.BackColor = SystemColors.Window;
            this._txtCropDev3_2.Cursor = Cursors.IBeam;
            this._txtCropDev3_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev3_2.ForeColor = SystemColors.WindowText;
            this.txtCropDev3.SetIndex(this._txtCropDev3_2, 2);
            point = new Point(0x38, 0x30);
            this._txtCropDev3_2.Location = point;
            this._txtCropDev3_2.MaxLength = 0;
            this._txtCropDev3_2.Name = "_txtCropDev3_2";
            this._txtCropDev3_2.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev3_2.Size = size;
            this._txtCropDev3_2.TabIndex = 0x23;
            this._txtCropDev3_2.Text = "Text16";
            this._txtCropDev3_1.AcceptsReturn = true;
            this._txtCropDev3_1.BackColor = SystemColors.Window;
            this._txtCropDev3_1.Cursor = Cursors.IBeam;
            this._txtCropDev3_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev3_1.ForeColor = SystemColors.WindowText;
            this.txtCropDev3.SetIndex(this._txtCropDev3_1, 1);
            point = new Point(0x38, 0x20);
            this._txtCropDev3_1.Location = point;
            this._txtCropDev3_1.MaxLength = 0;
            this._txtCropDev3_1.Name = "_txtCropDev3_1";
            this._txtCropDev3_1.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev3_1.Size = size;
            this._txtCropDev3_1.TabIndex = 0x22;
            this._txtCropDev3_1.Text = "Text15";
            this._txtCropDev3_0.AcceptsReturn = true;
            this._txtCropDev3_0.BackColor = SystemColors.Window;
            this._txtCropDev3_0.Cursor = Cursors.IBeam;
            this._txtCropDev3_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev3_0.ForeColor = SystemColors.WindowText;
            this.txtCropDev3.SetIndex(this._txtCropDev3_0, 0);
            point = new Point(0x38, 0x10);
            this._txtCropDev3_0.Location = point;
            this._txtCropDev3_0.MaxLength = 0;
            this._txtCropDev3_0.Name = "_txtCropDev3_0";
            this._txtCropDev3_0.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev3_0.Size = size;
            this._txtCropDev3_0.TabIndex = 0x21;
            this._txtCropDev3_0.Text = "Text11";
            this.Label26.BackColor = SystemColors.Control;
            this.Label26.Cursor = Cursors.Default;
            this.Label26.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label26.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x54);
            this.Label26.Location = point;
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label26.Size = size;
            this.Label26.TabIndex = 0xb5;
            this.Label26.Text = "Year:";
            this._lblCrop_2.BackColor = SystemColors.Control;
            this._lblCrop_2.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_2.Cursor = Cursors.Default;
            this._lblCrop_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_2.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_2, 2);
            point = new Point(8, 0x30);
            this._lblCrop_2.Location = point;
            this._lblCrop_2.Name = "_lblCrop_2";
            this._lblCrop_2.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_2.Size = size;
            this._lblCrop_2.TabIndex = 0x20;
            this._lblCrop_2.Text = "HEIGHT";
            this._lblCrop_1.BackColor = SystemColors.Control;
            this._lblCrop_1.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_1.Cursor = Cursors.Default;
            this._lblCrop_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_1.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_1, 1);
            point = new Point(8, 0x20);
            this._lblCrop_1.Location = point;
            this._lblCrop_1.Name = "_lblCrop_1";
            this._lblCrop_1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_1.Size = size;
            this._lblCrop_1.TabIndex = 0x1f;
            this._lblCrop_1.Text = "LEAF";
            this._lblCrop_0.BackColor = SystemColors.Control;
            this._lblCrop_0.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_0.Cursor = Cursors.Default;
            this._lblCrop_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_0.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_0, 0);
            point = new Point(8, 0x10);
            this._lblCrop_0.Location = point;
            this._lblCrop_0.Name = "_lblCrop_0";
            this._lblCrop_0.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_0.Size = size;
            this._lblCrop_0.TabIndex = 30;
            this._lblCrop_0.Text = "ROOT";
            this.flx_Parameters.SetIndex(this._flx_Parameters_1, 1);
            point = new Point(0x27, 0x33);
            this._flx_Parameters_1.Location = point;
            this._flx_Parameters_1.Name = "_flx_Parameters_1";
            this._flx_Parameters_1.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_1.OcxState");
            size = new Size(0x201, 0x61);
            this._flx_Parameters_1.Size = size;
            this._flx_Parameters_1.TabIndex = 0x69;
            this._flx_Parameters_1.Visible = false;
            this._txtBox_1.AcceptsReturn = true;
            this._txtBox_1.BackColor = SystemColors.Window;
            this._txtBox_1.Cursor = Cursors.IBeam;
            this._txtBox_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_1.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_1, 1);
            point = new Point(0x178, 0xd5);
            this._txtBox_1.Location = point;
            this._txtBox_1.MaxLength = 0;
            this._txtBox_1.Name = "_txtBox_1";
            this._txtBox_1.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 20);
            this._txtBox_1.Size = size;
            this._txtBox_1.TabIndex = 0x68;
            this._txtBox_1.TabStop = false;
            this._txtBox_1.TextAlign = HorizontalAlignment.Right;
            this._txtBox_1.Visible = false;
            this.fraCropSW2.BackColor = SystemColors.Control;
            this.fraCropSW2.Controls.Add(this.cmbYearSW2);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_8);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_7);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_6);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_5);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_4);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_3);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_2);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_1);
            this.fraCropSW2.Controls.Add(this._txtCropDev2_0);
            this.fraCropSW2.Controls.Add(this.Label25);
            this.fraCropSW2.Controls.Add(this._lblCrop_8);
            this.fraCropSW2.Controls.Add(this._lblCrop_7);
            this.fraCropSW2.Controls.Add(this._lblCrop_6);
            this.fraCropSW2.Controls.Add(this._lblCrop_5);
            this.fraCropSW2.Controls.Add(this._lblCrop_4);
            this.fraCropSW2.Controls.Add(this._lblCrop_3);
            this.fraCropSW2.Controls.Add(this.Label9);
            this.fraCropSW2.Controls.Add(this.Label8);
            this.fraCropSW2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraCropSW2.ForeColor = SystemColors.ControlText;
            point = new Point(0x21f, 3);
            this.fraCropSW2.Location = point;
            this.fraCropSW2.Name = "fraCropSW2";
            this.fraCropSW2.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x89);
            this.fraCropSW2.Size = size;
            this.fraCropSW2.TabIndex = 0x24;
            this.fraCropSW2.TabStop = false;
            this.fraCropSW2.Text = "Crop development";
            this.cmbYearSW2.BackColor = SystemColors.Window;
            this.cmbYearSW2.Cursor = Cursors.Default;
            this.cmbYearSW2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbYearSW2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbYearSW2.ForeColor = SystemColors.WindowText;
            point = new Point(0x30, 0x60);
            this.cmbYearSW2.Location = point;
            this.cmbYearSW2.Name = "cmbYearSW2";
            this.cmbYearSW2.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x16);
            this.cmbYearSW2.Size = size;
            this.cmbYearSW2.TabIndex = 180;
            this.cmbYearSW2.TabStop = false;
            this._txtCropDev2_8.AcceptsReturn = true;
            this._txtCropDev2_8.BackColor = SystemColors.Window;
            this._txtCropDev2_8.Cursor = Cursors.IBeam;
            this._txtCropDev2_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_8.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_8, 8);
            point = new Point(0x88, 0x40);
            this._txtCropDev2_8.Location = point;
            this._txtCropDev2_8.MaxLength = 0;
            this._txtCropDev2_8.Name = "_txtCropDev2_8";
            this._txtCropDev2_8.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_8.Size = size;
            this._txtCropDev2_8.TabIndex = 0x35;
            this._txtCropDev2_8.TabStop = false;
            this._txtCropDev2_8.Text = "Text25";
            this._txtCropDev2_8.Visible = false;
            this._txtCropDev2_7.AcceptsReturn = true;
            this._txtCropDev2_7.BackColor = SystemColors.Window;
            this._txtCropDev2_7.Cursor = Cursors.IBeam;
            this._txtCropDev2_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_7.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_7, 7);
            point = new Point(0x60, 0x40);
            this._txtCropDev2_7.Location = point;
            this._txtCropDev2_7.MaxLength = 0;
            this._txtCropDev2_7.Name = "_txtCropDev2_7";
            this._txtCropDev2_7.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_7.Size = size;
            this._txtCropDev2_7.TabIndex = 0x34;
            this._txtCropDev2_7.TabStop = false;
            this._txtCropDev2_7.Text = "Text24";
            this._txtCropDev2_6.AcceptsReturn = true;
            this._txtCropDev2_6.BackColor = SystemColors.Window;
            this._txtCropDev2_6.Cursor = Cursors.IBeam;
            this._txtCropDev2_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_6.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_6, 6);
            point = new Point(0x38, 0x40);
            this._txtCropDev2_6.Location = point;
            this._txtCropDev2_6.MaxLength = 0;
            this._txtCropDev2_6.Name = "_txtCropDev2_6";
            this._txtCropDev2_6.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_6.Size = size;
            this._txtCropDev2_6.TabIndex = 0x33;
            this._txtCropDev2_6.TabStop = false;
            this._txtCropDev2_6.Text = "Text23";
            this._txtCropDev2_5.AcceptsReturn = true;
            this._txtCropDev2_5.BackColor = SystemColors.Window;
            this._txtCropDev2_5.Cursor = Cursors.IBeam;
            this._txtCropDev2_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_5.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_5, 5);
            point = new Point(0x88, 0x30);
            this._txtCropDev2_5.Location = point;
            this._txtCropDev2_5.MaxLength = 0;
            this._txtCropDev2_5.Name = "_txtCropDev2_5";
            this._txtCropDev2_5.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_5.Size = size;
            this._txtCropDev2_5.TabIndex = 50;
            this._txtCropDev2_5.TabStop = false;
            this._txtCropDev2_5.Text = "Text22";
            this._txtCropDev2_4.AcceptsReturn = true;
            this._txtCropDev2_4.BackColor = SystemColors.Window;
            this._txtCropDev2_4.Cursor = Cursors.IBeam;
            this._txtCropDev2_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_4.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_4, 4);
            point = new Point(0x60, 0x30);
            this._txtCropDev2_4.Location = point;
            this._txtCropDev2_4.MaxLength = 0;
            this._txtCropDev2_4.Name = "_txtCropDev2_4";
            this._txtCropDev2_4.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_4.Size = size;
            this._txtCropDev2_4.TabIndex = 0x31;
            this._txtCropDev2_4.TabStop = false;
            this._txtCropDev2_4.Text = "Text21";
            this._txtCropDev2_3.AcceptsReturn = true;
            this._txtCropDev2_3.BackColor = SystemColors.Window;
            this._txtCropDev2_3.Cursor = Cursors.IBeam;
            this._txtCropDev2_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_3.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_3, 3);
            point = new Point(0x38, 0x30);
            this._txtCropDev2_3.Location = point;
            this._txtCropDev2_3.MaxLength = 0;
            this._txtCropDev2_3.Name = "_txtCropDev2_3";
            this._txtCropDev2_3.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_3.Size = size;
            this._txtCropDev2_3.TabIndex = 0x30;
            this._txtCropDev2_3.TabStop = false;
            this._txtCropDev2_3.Text = "Text20";
            this._txtCropDev2_2.AcceptsReturn = true;
            this._txtCropDev2_2.BackColor = SystemColors.Window;
            this._txtCropDev2_2.Cursor = Cursors.IBeam;
            this._txtCropDev2_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_2.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_2, 2);
            point = new Point(0x88, 0x20);
            this._txtCropDev2_2.Location = point;
            this._txtCropDev2_2.MaxLength = 0;
            this._txtCropDev2_2.Name = "_txtCropDev2_2";
            this._txtCropDev2_2.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_2.Size = size;
            this._txtCropDev2_2.TabIndex = 0x2f;
            this._txtCropDev2_2.TabStop = false;
            this._txtCropDev2_2.Text = "Text19";
            this._txtCropDev2_2.Visible = false;
            this._txtCropDev2_1.AcceptsReturn = true;
            this._txtCropDev2_1.BackColor = SystemColors.Window;
            this._txtCropDev2_1.Cursor = Cursors.IBeam;
            this._txtCropDev2_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_1.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_1, 1);
            point = new Point(0x60, 0x20);
            this._txtCropDev2_1.Location = point;
            this._txtCropDev2_1.MaxLength = 0;
            this._txtCropDev2_1.Name = "_txtCropDev2_1";
            this._txtCropDev2_1.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_1.Size = size;
            this._txtCropDev2_1.TabIndex = 0x2e;
            this._txtCropDev2_1.TabStop = false;
            this._txtCropDev2_1.Text = "Text18";
            this._txtCropDev2_0.AcceptsReturn = true;
            this._txtCropDev2_0.BackColor = SystemColors.Window;
            this._txtCropDev2_0.Cursor = Cursors.IBeam;
            this._txtCropDev2_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtCropDev2_0.ForeColor = SystemColors.WindowText;
            this.txtCropDev2.SetIndex(this._txtCropDev2_0, 0);
            point = new Point(0x38, 0x20);
            this._txtCropDev2_0.Location = point;
            this._txtCropDev2_0.MaxLength = 0;
            this._txtCropDev2_0.Name = "_txtCropDev2_0";
            this._txtCropDev2_0.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtCropDev2_0.Size = size;
            this._txtCropDev2_0.TabIndex = 0x2d;
            this._txtCropDev2_0.TabStop = false;
            this._txtCropDev2_0.Text = "Text17";
            this.Label25.BackColor = SystemColors.Control;
            this.Label25.Cursor = Cursors.Default;
            this.Label25.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label25.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 100);
            this.Label25.Location = point;
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label25.Size = size;
            this.Label25.TabIndex = 0xb3;
            this.Label25.Text = "Year:";
            this._lblCrop_8.BackColor = SystemColors.Control;
            this._lblCrop_8.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_8.Cursor = Cursors.Default;
            this._lblCrop_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_8.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_8, 8);
            point = new Point(0x88, 0x10);
            this._lblCrop_8.Location = point;
            this._lblCrop_8.Name = "_lblCrop_8";
            this._lblCrop_8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_8.Size = size;
            this._lblCrop_8.TabIndex = 0x2c;
            this._lblCrop_8.Text = "Harvest";
            this._lblCrop_8.TextAlign = ContentAlignment.TopCenter;
            this._lblCrop_7.BackColor = SystemColors.Control;
            this._lblCrop_7.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_7.Cursor = Cursors.Default;
            this._lblCrop_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_7.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_7, 7);
            point = new Point(0x60, 0x10);
            this._lblCrop_7.Location = point;
            this._lblCrop_7.Name = "_lblCrop_7";
            this._lblCrop_7.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this._lblCrop_7.Size = size;
            this._lblCrop_7.TabIndex = 0x2b;
            this._lblCrop_7.Text = "Max.";
            this._lblCrop_7.TextAlign = ContentAlignment.TopCenter;
            this._lblCrop_6.BackColor = SystemColors.Control;
            this._lblCrop_6.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_6.Cursor = Cursors.Default;
            this._lblCrop_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_6.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_6, 6);
            point = new Point(0x38, 0x10);
            this._lblCrop_6.Location = point;
            this._lblCrop_6.Name = "_lblCrop_6";
            this._lblCrop_6.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this._lblCrop_6.Size = size;
            this._lblCrop_6.TabIndex = 0x2a;
            this._lblCrop_6.Text = "Initial";
            this._lblCrop_6.TextAlign = ContentAlignment.TopCenter;
            this._lblCrop_5.BackColor = SystemColors.Control;
            this._lblCrop_5.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_5.Cursor = Cursors.Default;
            this._lblCrop_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_5.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_5, 5);
            point = new Point(8, 0x40);
            this._lblCrop_5.Location = point;
            this._lblCrop_5.Name = "_lblCrop_5";
            this._lblCrop_5.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_5.Size = size;
            this._lblCrop_5.TabIndex = 0x29;
            this._lblCrop_5.Text = "Heights";
            this._lblCrop_4.BackColor = SystemColors.Control;
            this._lblCrop_4.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_4.Cursor = Cursors.Default;
            this._lblCrop_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_4.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_4, 4);
            point = new Point(8, 0x30);
            this._lblCrop_4.Location = point;
            this._lblCrop_4.Name = "_lblCrop_4";
            this._lblCrop_4.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x19);
            this._lblCrop_4.Size = size;
            this._lblCrop_4.TabIndex = 40;
            this._lblCrop_4.Text = "LAI";
            this._lblCrop_3.BackColor = SystemColors.Control;
            this._lblCrop_3.BorderStyle = BorderStyle.Fixed3D;
            this._lblCrop_3.Cursor = Cursors.Default;
            this._lblCrop_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblCrop_3.ForeColor = SystemColors.ControlText;
            this.lblCrop.SetIndex(this._lblCrop_3, 3);
            point = new Point(8, 0x20);
            this._lblCrop_3.Location = point;
            this._lblCrop_3.Name = "_lblCrop_3";
            this._lblCrop_3.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._lblCrop_3.Size = size;
            this._lblCrop_3.TabIndex = 0x27;
            this._lblCrop_3.Text = "Root";
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x20);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(1, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 0x26;
            this.Label9.Text = "Label9";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.BorderStyle = BorderStyle.Fixed3D;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 0x25;
            this.Label8.Text = "Dev.";
            this.Label8.TextAlign = ContentAlignment.TopCenter;
            this._txtBox_0.AcceptsReturn = true;
            this._txtBox_0.BackColor = SystemColors.Window;
            this._txtBox_0.Cursor = Cursors.IBeam;
            this._txtBox_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_0.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_0, 0);
            point = new Point(0x139, 0xe4);
            this._txtBox_0.Location = point;
            this._txtBox_0.MaxLength = 0;
            this._txtBox_0.Name = "_txtBox_0";
            this._txtBox_0.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 20);
            this._txtBox_0.Size = size;
            this._txtBox_0.TabIndex = 0x1c;
            this._txtBox_0.TabStop = false;
            this._txtBox_0.Text = "Text5";
            this._txtBox_0.TextAlign = HorizontalAlignment.Right;
            this._txtBox_0.Visible = false;
            this.Frame7.BackColor = SystemColors.Control;
            this.Frame7.Controls.Add(this.cmbDeleteYear);
            this.Frame7.Controls.Add(this.Command7);
            this.Frame7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame7.ForeColor = SystemColors.ControlText;
            point = new Point(0x221, 0x92);
            this.Frame7.Location = point;
            this.Frame7.Name = "Frame7";
            this.Frame7.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x39);
            this.Frame7.Size = size;
            this.Frame7.TabIndex = 0x66;
            this.Frame7.TabStop = false;
            this.Frame7.Text = "Delete year:";
            this.cmbDeleteYear.BackColor = SystemColors.Window;
            this.cmbDeleteYear.Cursor = Cursors.Default;
            this.cmbDeleteYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDeleteYear.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbDeleteYear.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x18);
            this.cmbDeleteYear.Location = point;
            this.cmbDeleteYear.Name = "cmbDeleteYear";
            this.cmbDeleteYear.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x16);
            this.cmbDeleteYear.Size = size;
            this.cmbDeleteYear.TabIndex = 0xc6;
            this.cmbDeleteYear.TabStop = false;
            this._lblHelp_0.BackColor = SystemColors.Control;
            this._lblHelp_0.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_0.Cursor = Cursors.Default;
            this._lblHelp_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_0.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_0, 0);
            point = new Point(10, 0xa7);
            this._lblHelp_0.Location = point;
            this._lblHelp_0.Name = "_lblHelp_0";
            this._lblHelp_0.RightToLeft = RightToLeft.No;
            size = new Size(0x1fd, 0x89);
            this._lblHelp_0.Size = size;
            this._lblHelp_0.TabIndex = 0x36;
            this._SSTab1_TabPage1.Controls.Add(this.txtIBCond);
            this._SSTab1_TabPage1.Controls.Add(this._lblHelp_2);
            this._SSTab1_TabPage1.Controls.Add(this._flx_Parameters_2);
            this._SSTab1_TabPage1.Controls.Add(this._txtBox_2);
            this._SSTab1_TabPage1.Controls.Add(this.Frame1);
            this._SSTab1_TabPage1.Controls.Add(this.Frame3);
            this._SSTab1_TabPage1.Controls.Add(this.Frame10);
            this._SSTab1_TabPage1.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage1.Location = point;
            this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage1.Size = size;
            this._SSTab1_TabPage1.TabIndex = 1;
            this._SSTab1_TabPage1.Text = "INITIAL/BOUNDARY";
            this._SSTab1_TabPage1.UseVisualStyleBackColor = true;
            point = new Point(190, 0xa7);
            this.txtIBCond.Location = point;
            this.txtIBCond.Name = "txtIBCond";
            size = new Size(0x49, 20);
            this.txtIBCond.Size = size;
            this.txtIBCond.TabIndex = 0x90;
            this.txtIBCond.Visible = false;
            this._lblHelp_2.BackColor = SystemColors.Control;
            this._lblHelp_2.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_2.Cursor = Cursors.Default;
            this._lblHelp_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_2.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_2, 2);
            point = new Point(6, 0xe1);
            this._lblHelp_2.Location = point;
            this._lblHelp_2.Name = "_lblHelp_2";
            this._lblHelp_2.RightToLeft = RightToLeft.No;
            size = new Size(0x1c1, 0x61);
            this._lblHelp_2.Size = size;
            this._lblHelp_2.TabIndex = 0x51;
            this.flx_Parameters.SetIndex(this._flx_Parameters_2, 2);
            point = new Point(6, 0x75);
            this._flx_Parameters_2.Location = point;
            this._flx_Parameters_2.Name = "_flx_Parameters_2";
            this._flx_Parameters_2.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_2.OcxState");
            size = new Size(0x1c1, 0x69);
            this._flx_Parameters_2.Size = size;
            this._flx_Parameters_2.TabIndex = 0x1a;
            this._txtBox_2.AcceptsReturn = true;
            this._txtBox_2.BackColor = SystemColors.Window;
            this._txtBox_2.Cursor = Cursors.IBeam;
            this._txtBox_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_2.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_2, 2);
            point = new Point(0x128, 0xc0);
            this._txtBox_2.Location = point;
            this._txtBox_2.MaxLength = 0;
            this._txtBox_2.Name = "_txtBox_2";
            this._txtBox_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._txtBox_2.Size = size;
            this._txtBox_2.TabIndex = 0x10;
            this._txtBox_2.TabStop = false;
            this._txtBox_2.TextAlign = HorizontalAlignment.Right;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.cmdBrowseForTensionFile);
            this.Frame1.Controls.Add(this.txtTensionFile);
            this.Frame1.Controls.Add(this._text1_5);
            this.Frame1.Controls.Add(this._text1_4);
            this.Frame1.Controls.Add(this._text1_0);
            this.Frame1.Controls.Add(this._text1_1);
            this.Frame1.Controls.Add(this._text1_2);
            this.Frame1.Controls.Add(this._text1_3);
            this.Frame1.Controls.Add(this._Label1_5);
            this.Frame1.Controls.Add(this._Label1_4);
            this.Frame1.Controls.Add(this._Label1_0);
            this.Frame1.Controls.Add(this._Label1_1);
            this.Frame1.Controls.Add(this._Label1_2);
            this.Frame1.Controls.Add(this._Label1_3);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(6, 3);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x1c1, 0x61);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0x11;
            this.Frame1.TabStop = false;
            this.cmdBrowseForTensionFile.BackColor = SystemColors.Control;
            this.cmdBrowseForTensionFile.Cursor = Cursors.Default;
            this.cmdBrowseForTensionFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForTensionFile.ForeColor = SystemColors.ControlText;
            point = new Point(0x188, 40);
            this.cmdBrowseForTensionFile.Location = point;
            this.cmdBrowseForTensionFile.Name = "cmdBrowseForTensionFile";
            this.cmdBrowseForTensionFile.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowseForTensionFile.Size = size;
            this.cmdBrowseForTensionFile.TabIndex = 0xf8;
            this.cmdBrowseForTensionFile.Text = "...";
            this.cmdBrowseForTensionFile.UseVisualStyleBackColor = false;
            this.cmdBrowseForTensionFile.Visible = false;
            this.txtTensionFile.AcceptsReturn = true;
            this.txtTensionFile.BackColor = SystemColors.Window;
            this.txtTensionFile.Cursor = Cursors.IBeam;
            this.txtTensionFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTensionFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x68, 40);
            this.txtTensionFile.Location = point;
            this.txtTensionFile.MaxLength = 0xff;
            this.txtTensionFile.Name = "txtTensionFile";
            this.txtTensionFile.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 20);
            this.txtTensionFile.Size = size;
            this.txtTensionFile.TabIndex = 0xf7;
            this.txtTensionFile.Text = "Text2";
            this.txtTensionFile.Visible = false;
            this._text1_5.AcceptsReturn = true;
            this._text1_5.BackColor = SystemColors.Window;
            this._text1_5.Cursor = Cursors.IBeam;
            this._text1_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_5.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_5, 5);
            point = new Point(280, 0x48);
            this._text1_5.Location = point;
            this._text1_5.MaxLength = 0;
            this._text1_5.Name = "_text1_5";
            this._text1_5.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_5.Size = size;
            this._text1_5.TabIndex = 0xba;
            this._text1_5.TabStop = false;
            this._text1_4.AcceptsReturn = true;
            this._text1_4.BackColor = SystemColors.Window;
            this._text1_4.Cursor = Cursors.IBeam;
            this._text1_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_4.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_4, 4);
            point = new Point(0x68, 0x48);
            this._text1_4.Location = point;
            this._text1_4.MaxLength = 0;
            this._text1_4.Name = "_text1_4";
            this._text1_4.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_4.Size = size;
            this._text1_4.TabIndex = 0xb8;
            this._text1_4.TabStop = false;
            this._text1_0.AcceptsReturn = true;
            this._text1_0.BackColor = SystemColors.Window;
            this._text1_0.Cursor = Cursors.IBeam;
            this._text1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_0.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_0, 0);
            point = new Point(8, 40);
            this._text1_0.Location = point;
            this._text1_0.MaxLength = 0;
            this._text1_0.Name = "_text1_0";
            this._text1_0.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_0.Size = size;
            this._text1_0.TabIndex = 0x15;
            this._text1_0.TabStop = false;
            this._text1_1.AcceptsReturn = true;
            this._text1_1.BackColor = SystemColors.Window;
            this._text1_1.Cursor = Cursors.IBeam;
            this._text1_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_1.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_1, 1);
            point = new Point(0x68, 40);
            this._text1_1.Location = point;
            this._text1_1.MaxLength = 0;
            this._text1_1.Name = "_text1_1";
            this._text1_1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_1.Size = size;
            this._text1_1.TabIndex = 20;
            this._text1_1.TabStop = false;
            this._text1_2.AcceptsReturn = true;
            this._text1_2.BackColor = SystemColors.Window;
            this._text1_2.Cursor = Cursors.IBeam;
            this._text1_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_2.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_2, 2);
            point = new Point(0xc0, 40);
            this._text1_2.Location = point;
            this._text1_2.MaxLength = 0;
            this._text1_2.Name = "_text1_2";
            this._text1_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_2.Size = size;
            this._text1_2.TabIndex = 0x13;
            this._text1_2.TabStop = false;
            this._text1_3.AcceptsReturn = true;
            this._text1_3.BackColor = SystemColors.Window;
            this._text1_3.Cursor = Cursors.IBeam;
            this._text1_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text1_3.ForeColor = SystemColors.WindowText;
            this.text1.SetIndex(this._text1_3, 3);
            point = new Point(280, 40);
            this._text1_3.Location = point;
            this._text1_3.MaxLength = 0;
            this._text1_3.Name = "_text1_3";
            this._text1_3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._text1_3.Size = size;
            this._text1_3.TabIndex = 0x12;
            this._text1_3.TabStop = false;
            this._Label1_5.BackColor = SystemColors.Control;
            this._Label1_5.Cursor = Cursors.Default;
            this._Label1_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_5.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_5, 5);
            point = new Point(0xb8, 0x4a);
            this._Label1_5.Location = point;
            this._Label1_5.Name = "_Label1_5";
            this._Label1_5.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._Label1_5.Size = size;
            this._Label1_5.TabIndex = 0xb9;
            this._Label1_5.Text = "INIT_ASCALE";
            this._Label1_4.BackColor = SystemColors.Control;
            this._Label1_4.Cursor = Cursors.Default;
            this._Label1_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_4.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_4, 4);
            point = new Point(8, 0x4a);
            this._Label1_4.Location = point;
            this._Label1_4.Name = "_Label1_4";
            this._Label1_4.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this._Label1_4.Size = size;
            this._Label1_4.TabIndex = 0xb7;
            this._Label1_4.Text = "CONSOL_STATE";
            this._Label1_0.BackColor = SystemColors.Control;
            this._Label1_0.Cursor = Cursors.Default;
            this._Label1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_0.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_0, 0);
            point = new Point(8, 0x10);
            this._Label1_0.Location = point;
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Label1_0.Size = size;
            this._Label1_0.TabIndex = 0x19;
            this._Label1_1.BackColor = SystemColors.Control;
            this._Label1_1.Cursor = Cursors.Default;
            this._Label1_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_1.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_1, 1);
            point = new Point(0x60, 0x10);
            this._Label1_1.Location = point;
            this._Label1_1.Name = "_Label1_1";
            this._Label1_1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Label1_1.Size = size;
            this._Label1_1.TabIndex = 0x18;
            this._Label1_2.BackColor = SystemColors.Control;
            this._Label1_2.Cursor = Cursors.Default;
            this._Label1_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_2.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_2, 2);
            point = new Point(0xc0, 0x10);
            this._Label1_2.Location = point;
            this._Label1_2.Name = "_Label1_2";
            this._Label1_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Label1_2.Size = size;
            this._Label1_2.TabIndex = 0x17;
            this._Label1_3.BackColor = SystemColors.Control;
            this._Label1_3.Cursor = Cursors.Default;
            this._Label1_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_3.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_3, 3);
            point = new Point(280, 0x10);
            this._Label1_3.Location = point;
            this._Label1_3.Name = "_Label1_3";
            this._Label1_3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Label1_3.Size = size;
            this._Label1_3.TabIndex = 0x16;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add(this._Check1_9);
            this.Frame3.Controls.Add(this._optVariableToCopy_2);
            this.Frame3.Controls.Add(this._optVariableToCopy_1);
            this.Frame3.Controls.Add(this._optVariableToCopy_0);
            this.Frame3.Controls.Add(this._Check1_1);
            this.Frame3.Controls.Add(this.Command2);
            this.Frame3.Controls.Add(this._Check1_0);
            this.Frame3.Controls.Add(this._Check1_2);
            this.Frame3.Controls.Add(this._Check1_3);
            this.Frame3.Controls.Add(this._Check1_4);
            this.Frame3.Controls.Add(this._Check1_5);
            this.Frame3.Controls.Add(this._Check1_6);
            this.Frame3.Controls.Add(this._Check1_7);
            this.Frame3.Controls.Add(this._Check1_8);
            this.Frame3.Controls.Add(this.Text3);
            this.Frame3.Controls.Add(this.Command3);
            this.Frame3.Controls.Add(this.Label22);
            this.Frame3.Controls.Add(this.Label3);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(0x1cd, 5);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0xf1, 0xd9);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 3;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Copy";
            this._Check1_9.BackColor = SystemColors.Control;
            this._Check1_9.Cursor = Cursors.Default;
            this._Check1_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_9.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_9, 9);
            point = new Point(0x70, 0xb8);
            this._Check1_9.Location = point;
            this._Check1_9.Name = "_Check1_9";
            this._Check1_9.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 13);
            this._Check1_9.Size = size;
            this._Check1_9.TabIndex = 0xd5;
            this._Check1_9.TabStop = false;
            this._Check1_9.Text = "Check3";
            this._Check1_9.UseVisualStyleBackColor = false;
            this._optVariableToCopy_2.BackColor = SystemColors.Control;
            this._optVariableToCopy_2.Cursor = Cursors.Default;
            this._optVariableToCopy_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optVariableToCopy_2.ForeColor = SystemColors.ControlText;
            this.optVariableToCopy.SetIndex(this._optVariableToCopy_2, 2);
            point = new Point(0x10, 0x40);
            this._optVariableToCopy_2.Location = point;
            this._optVariableToCopy_2.Name = "_optVariableToCopy_2";
            this._optVariableToCopy_2.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this._optVariableToCopy_2.Size = size;
            this._optVariableToCopy_2.TabIndex = 0x95;
            this._optVariableToCopy_2.Text = "Option2";
            this._optVariableToCopy_2.UseVisualStyleBackColor = false;
            this._optVariableToCopy_1.BackColor = SystemColors.Control;
            this._optVariableToCopy_1.Cursor = Cursors.Default;
            this._optVariableToCopy_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optVariableToCopy_1.ForeColor = SystemColors.ControlText;
            this.optVariableToCopy.SetIndex(this._optVariableToCopy_1, 1);
            point = new Point(0x10, 40);
            this._optVariableToCopy_1.Location = point;
            this._optVariableToCopy_1.Name = "_optVariableToCopy_1";
            this._optVariableToCopy_1.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this._optVariableToCopy_1.Size = size;
            this._optVariableToCopy_1.TabIndex = 0x94;
            this._optVariableToCopy_1.Text = "Option3";
            this._optVariableToCopy_1.UseVisualStyleBackColor = false;
            this._optVariableToCopy_0.BackColor = SystemColors.Control;
            this._optVariableToCopy_0.Checked = true;
            this._optVariableToCopy_0.Cursor = Cursors.Default;
            this._optVariableToCopy_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optVariableToCopy_0.ForeColor = SystemColors.ControlText;
            this.optVariableToCopy.SetIndex(this._optVariableToCopy_0, 0);
            point = new Point(0x10, 0x10);
            this._optVariableToCopy_0.Location = point;
            this._optVariableToCopy_0.Name = "_optVariableToCopy_0";
            this._optVariableToCopy_0.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x11);
            this._optVariableToCopy_0.Size = size;
            this._optVariableToCopy_0.TabIndex = 0x93;
            this._optVariableToCopy_0.TabStop = true;
            this._optVariableToCopy_0.Text = "Option2";
            this._optVariableToCopy_0.UseVisualStyleBackColor = false;
            this._Check1_1.BackColor = SystemColors.Control;
            this._Check1_1.Cursor = Cursors.Default;
            this._Check1_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_1.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_1, 1);
            point = new Point(0x10, 0x88);
            this._Check1_1.Location = point;
            this._Check1_1.Name = "_Check1_1";
            this._Check1_1.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Check1_1.Size = size;
            this._Check1_1.TabIndex = 0x8e;
            this._Check1_1.TabStop = false;
            this._Check1_1.UseVisualStyleBackColor = false;
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.ForeColor = SystemColors.ControlText;
            point = new Point(160, 0x90);
            this.Command2.Location = point;
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command2.Size = size;
            this.Command2.TabIndex = 14;
            this.Command2.TabStop = false;
            this.Command2.Text = "&Copy";
            this.Command2.UseVisualStyleBackColor = false;
            this._Check1_0.BackColor = SystemColors.Control;
            this._Check1_0.Cursor = Cursors.Default;
            this._Check1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_0.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_0, 0);
            point = new Point(0x10, 120);
            this._Check1_0.Location = point;
            this._Check1_0.Name = "_Check1_0";
            this._Check1_0.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Check1_0.Size = size;
            this._Check1_0.TabIndex = 13;
            this._Check1_0.TabStop = false;
            this._Check1_0.UseVisualStyleBackColor = false;
            this._Check1_2.BackColor = SystemColors.Control;
            this._Check1_2.Cursor = Cursors.Default;
            this._Check1_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_2.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_2, 2);
            point = new Point(0x10, 0x98);
            this._Check1_2.Location = point;
            this._Check1_2.Name = "_Check1_2";
            this._Check1_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check1_2.Size = size;
            this._Check1_2.TabIndex = 12;
            this._Check1_2.TabStop = false;
            this._Check1_2.UseVisualStyleBackColor = false;
            this._Check1_3.BackColor = SystemColors.Control;
            this._Check1_3.Cursor = Cursors.Default;
            this._Check1_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_3.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_3, 3);
            point = new Point(0x10, 0xa8);
            this._Check1_3.Location = point;
            this._Check1_3.Name = "_Check1_3";
            this._Check1_3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check1_3.Size = size;
            this._Check1_3.TabIndex = 11;
            this._Check1_3.TabStop = false;
            this._Check1_3.UseVisualStyleBackColor = false;
            this._Check1_4.BackColor = SystemColors.Control;
            this._Check1_4.Cursor = Cursors.Default;
            this._Check1_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_4.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_4, 4);
            point = new Point(0x10, 0xb8);
            this._Check1_4.Location = point;
            this._Check1_4.Name = "_Check1_4";
            this._Check1_4.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._Check1_4.Size = size;
            this._Check1_4.TabIndex = 10;
            this._Check1_4.TabStop = false;
            this._Check1_4.UseVisualStyleBackColor = false;
            this._Check1_5.BackColor = SystemColors.Control;
            this._Check1_5.Cursor = Cursors.Default;
            this._Check1_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_5.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_5, 5);
            point = new Point(0x70, 120);
            this._Check1_5.Location = point;
            this._Check1_5.Name = "_Check1_5";
            this._Check1_5.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._Check1_5.Size = size;
            this._Check1_5.TabIndex = 9;
            this._Check1_5.TabStop = false;
            this._Check1_5.UseVisualStyleBackColor = false;
            this._Check1_6.BackColor = SystemColors.Control;
            this._Check1_6.Cursor = Cursors.Default;
            this._Check1_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_6.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_6, 6);
            point = new Point(0x70, 0x88);
            this._Check1_6.Location = point;
            this._Check1_6.Name = "_Check1_6";
            this._Check1_6.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._Check1_6.Size = size;
            this._Check1_6.TabIndex = 8;
            this._Check1_6.TabStop = false;
            this._Check1_6.UseVisualStyleBackColor = false;
            this._Check1_7.BackColor = SystemColors.Control;
            this._Check1_7.Cursor = Cursors.Default;
            this._Check1_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_7.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_7, 7);
            point = new Point(0x70, 0x98);
            this._Check1_7.Location = point;
            this._Check1_7.Name = "_Check1_7";
            this._Check1_7.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._Check1_7.Size = size;
            this._Check1_7.TabIndex = 7;
            this._Check1_7.TabStop = false;
            this._Check1_7.UseVisualStyleBackColor = false;
            this._Check1_8.BackColor = SystemColors.Control;
            this._Check1_8.Cursor = Cursors.Default;
            this._Check1_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check1_8.ForeColor = SystemColors.ControlText;
            this.Check1.SetIndex(this._Check1_8, 8);
            point = new Point(0x70, 0xa8);
            this._Check1_8.Location = point;
            this._Check1_8.Name = "_Check1_8";
            this._Check1_8.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._Check1_8.Size = size;
            this._Check1_8.TabIndex = 6;
            this._Check1_8.TabStop = false;
            this._Check1_8.UseVisualStyleBackColor = false;
            this.Text3.AcceptsReturn = true;
            this.Text3.BackColor = SystemColors.Window;
            this.Text3.Cursor = Cursors.IBeam;
            this.Text3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text3.ForeColor = SystemColors.WindowText;
            point = new Point(0x60, 0x58);
            this.Text3.Location = point;
            this.Text3.MaxLength = 0;
            this.Text3.Name = "Text3";
            this.Text3.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.Text3.Size = size;
            this.Text3.TabIndex = 5;
            this.Text3.TabStop = false;
            this.Text3.Text = "0";
            this.Command3.BackColor = SystemColors.Control;
            this.Command3.Cursor = Cursors.Default;
            this.Command3.Enabled = false;
            this.Command3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command3.ForeColor = SystemColors.ControlText;
            point = new Point(0xb0, 0xb8);
            this.Command3.Location = point;
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command3.Size = size;
            this.Command3.TabIndex = 4;
            this.Command3.Text = "Cancel";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Visible = false;
            this.Label22.BackColor = SystemColors.Control;
            this.Label22.Cursor = Cursors.Default;
            this.Label22.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label22.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x68);
            this.Label22.Location = point;
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label22.Size = size;
            this.Label22.TabIndex = 0x92;
            this.Label22.Text = "Copy to:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x58);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Value to copy:";
            this.Frame10.BackColor = SystemColors.Control;
            this.Frame10.Controls.Add(this.Command4);
            this.Frame10.Controls.Add(this.Label4);
            this.Frame10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame10.ForeColor = SystemColors.ControlText;
            point = new Point(0x1cf, 0xec);
            this.Frame10.Location = point;
            this.Frame10.Name = "Frame10";
            this.Frame10.RightToLeft = RightToLeft.No;
            size = new Size(0xf1, 70);
            this.Frame10.Size = size;
            this.Frame10.TabIndex = 0x8f;
            this.Frame10.TabStop = false;
            this.Frame10.Text = "Initial temperature";
            this.Frame10.Visible = false;
            this.Command4.BackColor = SystemColors.Control;
            this.Command4.Cursor = Cursors.Default;
            this.Command4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command4.ForeColor = SystemColors.ControlText;
            point = new Point(0x9e, 0x27);
            this.Command4.Location = point;
            this.Command4.Name = "Command4";
            this.Command4.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command4.Size = size;
            this.Command4.TabIndex = 0x90;
            this.Command4.TabStop = false;
            this.Command4.Text = "Calc&ulate";
            this.Command4.UseVisualStyleBackColor = false;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x21);
            this.Label4.Size = size;
            this.Label4.TabIndex = 0x91;
            this.Label4.Text = "Calculate TEMPINI from analytical solution.";
            this._SSTab1_TabPage2.Controls.Add(this.Frame11);
            this._SSTab1_TabPage2.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage2.Location = point;
            this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage2.Size = size;
            this._SSTab1_TabPage2.TabIndex = 2;
            this._SSTab1_TabPage2.Text = "IRRIGATION";
            this._SSTab1_TabPage2.UseVisualStyleBackColor = true;
            this.Frame11.BackColor = SystemColors.Control;
            this.Frame11.Controls.Add(this.udNIRR);
            this.Frame11.Controls.Add(this.cmdStore);
            this.Frame11.Controls.Add(this.Frame9);
            this.Frame11.Controls.Add(this._txtBox_3);
            this.Frame11.Controls.Add(this.Text8);
            this.Frame11.Controls.Add(this._flx_Parameters_3);
            this.Frame11.Controls.Add(this.lblIrrigationYears);
            this.Frame11.Controls.Add(this.Label18);
            this.Frame11.Controls.Add(this._lblHelp_3);
            this.Frame11.Controls.Add(this.Label13);
            this.Frame11.Controls.Add(this.Label12);
            this.Frame11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame11.ForeColor = SystemColors.ControlText;
            point = new Point(6, 3);
            this.Frame11.Location = point;
            this.Frame11.Name = "Frame11";
            this.Frame11.RightToLeft = RightToLeft.No;
            size = new Size(0x2c9, 0x139);
            this.Frame11.Size = size;
            this.Frame11.TabIndex = 0x38;
            this.Frame11.TabStop = false;
            point = new Point(0x109, 0x16);
            this.udNIRR.Location = point;
            this.udNIRR.Name = "udNIRR";
            size = new Size(0x31, 20);
            this.udNIRR.Size = size;
            this.udNIRR.TabIndex = 0xe4;
            this.Frame9.BackColor = SystemColors.Control;
            this.Frame9.Controls.Add(this.fraDefineSubSets);
            this.Frame9.Controls.Add(this._optDefinitionType_1);
            this.Frame9.Controls.Add(this._optDefinitionType_0);
            this.Frame9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame9.ForeColor = SystemColors.ControlText;
            point = new Point(0x198, 0x10);
            this.Frame9.Location = point;
            this.Frame9.Name = "Frame9";
            this.Frame9.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x121);
            this.Frame9.Size = size;
            this.Frame9.TabIndex = 0xd7;
            this.Frame9.TabStop = false;
            this.Frame9.Text = "Definition";
            this.fraDefineSubSets.BackColor = SystemColors.Control;
            this.fraDefineSubSets.Controls.Add(this.cmdClear);
            this.fraDefineSubSets.Controls.Add(this.cmdAggregate);
            this.fraDefineSubSets.Controls.Add(this.lstYearSubSets);
            this.fraDefineSubSets.Controls.Add(this.lstYears);
            this.fraDefineSubSets.Controls.Add(this.Label19);
            this.fraDefineSubSets.Controls.Add(this.Label14);
            this.fraDefineSubSets.Controls.Add(this.Label6);
            this.fraDefineSubSets.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraDefineSubSets.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x48);
            this.fraDefineSubSets.Location = point;
            this.fraDefineSubSets.Name = "fraDefineSubSets";
            this.fraDefineSubSets.RightToLeft = RightToLeft.No;
            size = new Size(0x119, 0xd1);
            this.fraDefineSubSets.Size = size;
            this.fraDefineSubSets.TabIndex = 0xda;
            this.fraDefineSubSets.TabStop = false;
            this.fraDefineSubSets.Text = "Define subsets";
            this.fraDefineSubSets.Visible = false;
            this.lstYearSubSets.BackColor = SystemColors.Window;
            this.lstYearSubSets.Cursor = Cursors.Default;
            this.lstYearSubSets.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstYearSubSets.ForeColor = SystemColors.WindowText;
            this.lstYearSubSets.ItemHeight = 14;
            point = new Point(120, 0x20);
            this.lstYearSubSets.Location = point;
            this.lstYearSubSets.Name = "lstYearSubSets";
            this.lstYearSubSets.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x4a);
            this.lstYearSubSets.Size = size;
            this.lstYearSubSets.TabIndex = 220;
            this.lstYearSubSets.TabStop = false;
            this.lstYears.BackColor = SystemColors.Window;
            this.lstYears.Cursor = Cursors.Default;
            this.lstYears.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstYears.ForeColor = SystemColors.WindowText;
            this.lstYears.ItemHeight = 14;
            point = new Point(8, 0x20);
            this.lstYears.Location = point;
            this.lstYears.Name = "lstYears";
            this.lstYears.RightToLeft = RightToLeft.No;
            this.lstYears.SelectionMode = SelectionMode.MultiExtended;
            size = new Size(0x49, 0x4a);
            this.lstYears.Size = size;
            this.lstYears.TabIndex = 0xdb;
            this.lstYears.TabStop = false;
            this.Label19.BackColor = SystemColors.Control;
            this.Label19.BorderStyle = BorderStyle.Fixed3D;
            this.Label19.Cursor = Cursors.Default;
            this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label19.ForeColor = SystemColors.ControlText;
            point = new Point(8, 120);
            this.Label19.Location = point;
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x51);
            this.Label19.Size = size;
            this.Label19.TabIndex = 0xf9;
            this.Label19.Text = "Note: A subset is a set of years that have the same application pattern.                                                                Each year in the simulation period must be included in a subset.";
            this.Label14.BackColor = SystemColors.Control;
            this.Label14.Cursor = Cursors.Default;
            this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label14.ForeColor = SystemColors.ControlText;
            point = new Point(120, 0x10);
            this.Label14.Location = point;
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label14.Size = size;
            this.Label14.TabIndex = 0xe0;
            this.Label14.Text = "Subsets";
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 0xdf;
            this.Label6.Text = "Years:";
            this._optDefinitionType_1.BackColor = SystemColors.Control;
            this._optDefinitionType_1.Cursor = Cursors.Default;
            this._optDefinitionType_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optDefinitionType_1.ForeColor = SystemColors.ControlText;
            this.optDefinitionType.SetIndex(this._optDefinitionType_1, 1);
            point = new Point(0x10, 0x30);
            this._optDefinitionType_1.Location = point;
            this._optDefinitionType_1.Name = "_optDefinitionType_1";
            this._optDefinitionType_1.RightToLeft = RightToLeft.No;
            size = new Size(0xc9, 0x11);
            this._optDefinitionType_1.Size = size;
            this._optDefinitionType_1.TabIndex = 0xd9;
            this._optDefinitionType_1.TabStop = true;
            this._optDefinitionType_1.Text = "Define for sub-set of years";
            this._optDefinitionType_1.UseVisualStyleBackColor = false;
            this._optDefinitionType_0.BackColor = SystemColors.Control;
            this._optDefinitionType_0.Checked = true;
            this._optDefinitionType_0.Cursor = Cursors.Default;
            this._optDefinitionType_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optDefinitionType_0.ForeColor = SystemColors.ControlText;
            this.optDefinitionType.SetIndex(this._optDefinitionType_0, 0);
            point = new Point(0x10, 0x18);
            this._optDefinitionType_0.Location = point;
            this._optDefinitionType_0.Name = "_optDefinitionType_0";
            this._optDefinitionType_0.RightToLeft = RightToLeft.No;
            size = new Size(0xc9, 0x11);
            this._optDefinitionType_0.Size = size;
            this._optDefinitionType_0.TabIndex = 0xd8;
            this._optDefinitionType_0.TabStop = true;
            this._optDefinitionType_0.Text = "Same for all years";
            this._optDefinitionType_0.UseVisualStyleBackColor = false;
            this._txtBox_3.AcceptsReturn = true;
            this._txtBox_3.BackColor = SystemColors.Window;
            this._txtBox_3.Cursor = Cursors.IBeam;
            this._txtBox_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_3.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_3, 3);
            point = new Point(0x60, 0x88);
            this._txtBox_3.Location = point;
            this._txtBox_3.MaxLength = 0;
            this._txtBox_3.Name = "_txtBox_3";
            this._txtBox_3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._txtBox_3.Size = size;
            this._txtBox_3.TabIndex = 0x3e;
            this._txtBox_3.TabStop = false;
            this._txtBox_3.TextAlign = HorizontalAlignment.Right;
            this.Text8.AcceptsReturn = true;
            this.Text8.BackColor = SystemColors.Window;
            this.Text8.Cursor = Cursors.IBeam;
            this.Text8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text8.ForeColor = SystemColors.WindowText;
            point = new Point(0x220, 0x10);
            this.Text8.Location = point;
            this.Text8.MaxLength = 0;
            this.Text8.Name = "Text8";
            this.Text8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.Text8.Size = size;
            this.Text8.TabIndex = 60;
            this.Text8.Text = "Text8";
            this.Text8.Visible = false;
            this.flx_Parameters.SetIndex(this._flx_Parameters_3, 3);
            point = new Point(0x10, 80);
            this._flx_Parameters_3.Location = point;
            this._flx_Parameters_3.Name = "_flx_Parameters_3";
            this._flx_Parameters_3.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_3.OcxState");
            size = new Size(0x181, 0x91);
            this._flx_Parameters_3.Size = size;
            this._flx_Parameters_3.TabIndex = 0x3d;
            this.lblIrrigationYears.BackColor = SystemColors.Control;
            this.lblIrrigationYears.Cursor = Cursors.Default;
            this.lblIrrigationYears.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblIrrigationYears.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x20);
            this.lblIrrigationYears.Location = point;
            this.lblIrrigationYears.Name = "lblIrrigationYears";
            this.lblIrrigationYears.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x29);
            this.lblIrrigationYears.Size = size;
            this.lblIrrigationYears.TabIndex = 0xe2;
            this.lblIrrigationYears.Text = "1";
            this.Label18.BackColor = SystemColors.Control;
            this.Label18.Cursor = Cursors.Default;
            this.Label18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label18.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x10);
            this.Label18.Location = point;
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this.Label18.Size = size;
            this.Label18.TabIndex = 0xe1;
            this.Label18.Text = "Irrigation(s) defined for subset:";
            this._lblHelp_3.BackColor = SystemColors.Control;
            this._lblHelp_3.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_3.Cursor = Cursors.Default;
            this._lblHelp_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_3.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_3, 3);
            point = new Point(0x10, 0xe8);
            this._lblHelp_3.Location = point;
            this._lblHelp_3.Name = "_lblHelp_3";
            this._lblHelp_3.RightToLeft = RightToLeft.No;
            size = new Size(0x181, 0x49);
            this._lblHelp_3.Size = size;
            this._lblHelp_3.TabIndex = 0x3f;
            this.Label13.BackColor = SystemColors.Control;
            this.Label13.Cursor = Cursors.Default;
            this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label13.ForeColor = SystemColors.ControlText;
            point = new Point(120, 0x10);
            this.Label13.Location = point;
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label13.Size = size;
            this.Label13.TabIndex = 0x3b;
            this.Label13.Visible = false;
            this.Label12.BackColor = SystemColors.Control;
            this.Label12.Cursor = Cursors.Default;
            this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label12.ForeColor = SystemColors.ControlText;
            point = new Point(200, 0x18);
            this.Label12.Location = point;
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label12.Size = size;
            this.Label12.TabIndex = 0x39;
            this._SSTab1_TabPage3.Controls.Add(this.Frame12);
            this._SSTab1_TabPage3.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage3.Location = point;
            this._SSTab1_TabPage3.Name = "_SSTab1_TabPage3";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage3.Size = size;
            this._SSTab1_TabPage3.TabIndex = 3;
            this._SSTab1_TabPage3.Text = "PHYSICAL";
            this._SSTab1_TabPage3.UseVisualStyleBackColor = true;
            this.Frame12.BackColor = SystemColors.Control;
            this.Frame12.Controls.Add(this.GroupBox1);
            this.Frame12.Controls.Add(this.Frame6);
            this.Frame12.Controls.Add(this._txtBox_4);
            this.Frame12.Controls.Add(this._flx_Parameters_4);
            this.Frame12.Controls.Add(this._lblHelp_4);
            this.Frame12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame12.ForeColor = SystemColors.ControlText;
            point = new Point(6, 3);
            this.Frame12.Location = point;
            this.Frame12.Name = "Frame12";
            this.Frame12.RightToLeft = RightToLeft.No;
            size = new Size(0x30b, 0x131);
            this.Frame12.Size = size;
            this.Frame12.TabIndex = 0x40;
            this.Frame12.TabStop = false;
            this.GroupBox1.Controls.Add(this.btnCalculatePedotransfer);
            this.GroupBox1.Controls.Add(this.optFOOTPRINTPedotransfer);
            this.GroupBox1.Controls.Add(this.optMACROPedotransfer);
            point = new Point(0x257, 0xb0);
            this.GroupBox1.Location = point;
            this.GroupBox1.Name = "GroupBox1";
            size = new Size(0xae, 100);
            this.GroupBox1.Size = size;
            this.GroupBox1.TabIndex = 0x55;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Pedotransfer by:";
            point = new Point(6, 0x40);
            this.btnCalculatePedotransfer.Location = point;
            this.btnCalculatePedotransfer.Name = "btnCalculatePedotransfer";
            size = new Size(0x4b, 0x17);
            this.btnCalculatePedotransfer.Size = size;
            this.btnCalculatePedotransfer.TabIndex = 2;
            this.btnCalculatePedotransfer.Text = "Calculate";
            this.btnCalculatePedotransfer.UseVisualStyleBackColor = true;
            this.optFOOTPRINTPedotransfer.AutoSize = true;
            point = new Point(6, 0x2b);
            this.optFOOTPRINTPedotransfer.Location = point;
            this.optFOOTPRINTPedotransfer.Name = "optFOOTPRINTPedotransfer";
            size = new Size(0x51, 0x12);
            this.optFOOTPRINTPedotransfer.Size = size;
            this.optFOOTPRINTPedotransfer.TabIndex = 1;
            this.optFOOTPRINTPedotransfer.Text = "FOOTPRINT";
            this.optFOOTPRINTPedotransfer.UseVisualStyleBackColor = true;
            this.optMACROPedotransfer.AutoSize = true;
            this.optMACROPedotransfer.Checked = true;
            point = new Point(6, 0x13);
            this.optMACROPedotransfer.Location = point;
            this.optMACROPedotransfer.Name = "optMACROPedotransfer";
            size = new Size(0x63, 0x12);
            this.optMACROPedotransfer.Size = size;
            this.optMACROPedotransfer.TabIndex = 0;
            this.optMACROPedotransfer.TabStop = true;
            this.optMACROPedotransfer.Text = "MACRO 5.0/5.1";
            this.optMACROPedotransfer.UseVisualStyleBackColor = true;
            this.Frame6.BackColor = SystemColors.Control;
            this.Frame6.Controls.Add(this._Check2_9);
            this.Frame6.Controls.Add(this.cmbVariables);
            this.Frame6.Controls.Add(this.Command5);
            this.Frame6.Controls.Add(this.Text13);
            this.Frame6.Controls.Add(this._Check2_8);
            this.Frame6.Controls.Add(this._Check2_7);
            this.Frame6.Controls.Add(this._Check2_6);
            this.Frame6.Controls.Add(this._Check2_5);
            this.Frame6.Controls.Add(this._Check2_4);
            this.Frame6.Controls.Add(this._Check2_3);
            this.Frame6.Controls.Add(this._Check2_2);
            this.Frame6.Controls.Add(this._Check2_1);
            this.Frame6.Controls.Add(this._Check2_0);
            this.Frame6.Controls.Add(this.Label23);
            this.Frame6.Controls.Add(this.Label36);
            this.Frame6.Controls.Add(this.Label16);
            this.Frame6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame6.ForeColor = SystemColors.ControlText;
            point = new Point(0xd0, 0x88);
            this.Frame6.Location = point;
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0xa1);
            this.Frame6.Size = size;
            this.Frame6.TabIndex = 0x43;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Copy";
            this.Frame6.Visible = false;
            this._Check2_9.BackColor = SystemColors.Control;
            this._Check2_9.Cursor = Cursors.Default;
            this._Check2_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_9.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_9, 9);
            point = new Point(0x48, 0x88);
            this._Check2_9.Location = point;
            this._Check2_9.Name = "_Check2_9";
            this._Check2_9.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Check2_9.Size = size;
            this._Check2_9.TabIndex = 0xd6;
            this._Check2_9.Text = "Check3";
            this._Check2_9.UseVisualStyleBackColor = false;
            this.cmbVariables.BackColor = SystemColors.Window;
            this.cmbVariables.Cursor = Cursors.Default;
            this.cmbVariables.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbVariables.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbVariables.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 12);
            this.cmbVariables.Location = point;
            this.cmbVariables.Name = "cmbVariables";
            this.cmbVariables.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x16);
            this.cmbVariables.Size = size;
            this.cmbVariables.TabIndex = 0x97;
            this.Command5.BackColor = SystemColors.Control;
            this.Command5.Cursor = Cursors.Default;
            this.Command5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command5.ForeColor = SystemColors.ControlText;
            point = new Point(0x88, 0x80);
            this.Command5.Location = point;
            this.Command5.Name = "Command5";
            this.Command5.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command5.Size = size;
            this.Command5.TabIndex = 0x4e;
            this.Command5.Text = "&Copy";
            this.Command5.UseVisualStyleBackColor = false;
            this.Text13.AcceptsReturn = true;
            this.Text13.BackColor = SystemColors.Window;
            this.Text13.Cursor = Cursors.IBeam;
            this.Text13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text13.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 40);
            this.Text13.Location = point;
            this.Text13.MaxLength = 0;
            this.Text13.Name = "Text13";
            this.Text13.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.Text13.Size = size;
            this.Text13.TabIndex = 0x4d;
            this._Check2_8.BackColor = SystemColors.Control;
            this._Check2_8.Cursor = Cursors.Default;
            this._Check2_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_8.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_8, 8);
            point = new Point(0x48, 120);
            this._Check2_8.Location = point;
            this._Check2_8.Name = "_Check2_8";
            this._Check2_8.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_8.Size = size;
            this._Check2_8.TabIndex = 0x4c;
            this._Check2_8.Text = "Check2";
            this._Check2_8.UseVisualStyleBackColor = false;
            this._Check2_7.BackColor = SystemColors.Control;
            this._Check2_7.Cursor = Cursors.Default;
            this._Check2_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_7.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_7, 7);
            point = new Point(0x48, 0x68);
            this._Check2_7.Location = point;
            this._Check2_7.Name = "_Check2_7";
            this._Check2_7.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_7.Size = size;
            this._Check2_7.TabIndex = 0x4b;
            this._Check2_7.Text = "Check2";
            this._Check2_7.UseVisualStyleBackColor = false;
            this._Check2_6.BackColor = SystemColors.Control;
            this._Check2_6.Cursor = Cursors.Default;
            this._Check2_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_6.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_6, 6);
            point = new Point(0x48, 0x58);
            this._Check2_6.Location = point;
            this._Check2_6.Name = "_Check2_6";
            this._Check2_6.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_6.Size = size;
            this._Check2_6.TabIndex = 0x4a;
            this._Check2_6.Text = "Check2";
            this._Check2_6.UseVisualStyleBackColor = false;
            this._Check2_5.BackColor = SystemColors.Control;
            this._Check2_5.Cursor = Cursors.Default;
            this._Check2_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_5.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_5, 5);
            point = new Point(0x48, 0x48);
            this._Check2_5.Location = point;
            this._Check2_5.Name = "_Check2_5";
            this._Check2_5.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_5.Size = size;
            this._Check2_5.TabIndex = 0x49;
            this._Check2_5.Text = "Check2";
            this._Check2_5.UseVisualStyleBackColor = false;
            this._Check2_4.BackColor = SystemColors.Control;
            this._Check2_4.Cursor = Cursors.Default;
            this._Check2_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_4.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_4, 4);
            point = new Point(8, 0x88);
            this._Check2_4.Location = point;
            this._Check2_4.Name = "_Check2_4";
            this._Check2_4.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_4.Size = size;
            this._Check2_4.TabIndex = 0x48;
            this._Check2_4.Text = "Check2";
            this._Check2_4.UseVisualStyleBackColor = false;
            this._Check2_3.BackColor = SystemColors.Control;
            this._Check2_3.Cursor = Cursors.Default;
            this._Check2_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_3.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_3, 3);
            point = new Point(8, 120);
            this._Check2_3.Location = point;
            this._Check2_3.Name = "_Check2_3";
            this._Check2_3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_3.Size = size;
            this._Check2_3.TabIndex = 0x47;
            this._Check2_3.Text = "Check2";
            this._Check2_3.UseVisualStyleBackColor = false;
            this._Check2_2.BackColor = SystemColors.Control;
            this._Check2_2.Cursor = Cursors.Default;
            this._Check2_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_2.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_2, 2);
            point = new Point(8, 0x68);
            this._Check2_2.Location = point;
            this._Check2_2.Name = "_Check2_2";
            this._Check2_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_2.Size = size;
            this._Check2_2.TabIndex = 70;
            this._Check2_2.Text = "Check2";
            this._Check2_2.UseVisualStyleBackColor = false;
            this._Check2_1.BackColor = SystemColors.Control;
            this._Check2_1.Cursor = Cursors.Default;
            this._Check2_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_1.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_1, 1);
            point = new Point(8, 0x58);
            this._Check2_1.Location = point;
            this._Check2_1.Name = "_Check2_1";
            this._Check2_1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_1.Size = size;
            this._Check2_1.TabIndex = 0x45;
            this._Check2_1.Text = "Check2";
            this._Check2_1.UseVisualStyleBackColor = false;
            this._Check2_0.BackColor = SystemColors.Control;
            this._Check2_0.Cursor = Cursors.Default;
            this._Check2_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check2_0.ForeColor = SystemColors.ControlText;
            this.Check2.SetIndex(this._Check2_0, 0);
            point = new Point(8, 0x48);
            this._Check2_0.Location = point;
            this._Check2_0.Name = "_Check2_0";
            this._Check2_0.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check2_0.Size = size;
            this._Check2_0.TabIndex = 0x44;
            this._Check2_0.Text = "Check2";
            this._Check2_0.UseVisualStyleBackColor = false;
            this.Label23.BackColor = SystemColors.Control;
            this.Label23.Cursor = Cursors.Default;
            this.Label23.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label23.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label23.Location = point;
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label23.Size = size;
            this.Label23.TabIndex = 150;
            this.Label23.Text = "Copy:";
            this.Label36.BackColor = SystemColors.Control;
            this.Label36.Cursor = Cursors.Default;
            this.Label36.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label36.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label36.Location = point;
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label36.Size = size;
            this.Label36.TabIndex = 0x55;
            this.Label36.Text = "Copy to:";
            this.Label16.BackColor = SystemColors.Control;
            this.Label16.Cursor = Cursors.Default;
            this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label16.ForeColor = SystemColors.ControlText;
            point = new Point(8, 40);
            this.Label16.Location = point;
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.Label16.Size = size;
            this.Label16.TabIndex = 0x4f;
            this.Label16.Text = "Value:";
            this._txtBox_4.AcceptsReturn = true;
            this._txtBox_4.BackColor = SystemColors.Window;
            this._txtBox_4.Cursor = Cursors.IBeam;
            this._txtBox_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_4.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_4, 4);
            point = new Point(400, 0x68);
            this._txtBox_4.Location = point;
            this._txtBox_4.MaxLength = 0;
            this._txtBox_4.Name = "_txtBox_4";
            this._txtBox_4.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 20);
            this._txtBox_4.Size = size;
            this._txtBox_4.TabIndex = 0x42;
            this._txtBox_4.TabStop = false;
            this.flx_Parameters.SetIndex(this._flx_Parameters_4, 4);
            point = new Point(6, 0x11);
            this._flx_Parameters_4.Location = point;
            this._flx_Parameters_4.Name = "_flx_Parameters_4";
            this._flx_Parameters_4.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_4.OcxState");
            size = new Size(0x2a1, 0x99);
            this._flx_Parameters_4.Size = size;
            this._flx_Parameters_4.TabIndex = 0x41;
            this._lblHelp_4.BackColor = SystemColors.Control;
            this._lblHelp_4.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_4.Cursor = Cursors.Default;
            this._lblHelp_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_4.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_4, 4);
            point = new Point(0x10, 0xb0);
            this._lblHelp_4.Location = point;
            this._lblHelp_4.Name = "_lblHelp_4";
            this._lblHelp_4.RightToLeft = RightToLeft.No;
            size = new Size(0x241, 0x71);
            this._lblHelp_4.Size = size;
            this._lblHelp_4.TabIndex = 80;
            this._SSTab1_TabPage4.Controls.Add(this.Frame4);
            this._SSTab1_TabPage4.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage4.Location = point;
            this._SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage4.Size = size;
            this._SSTab1_TabPage4.TabIndex = 4;
            this._SSTab1_TabPage4.Text = "SITE";
            this._SSTab1_TabPage4.UseVisualStyleBackColor = true;
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add(this._Text4_13);
            this.Frame4.Controls.Add(this._Text4_5);
            this.Frame4.Controls.Add(this._Text4_4);
            this.Frame4.Controls.Add(this._Text4_3);
            this.Frame4.Controls.Add(this._Text4_2);
            this.Frame4.Controls.Add(this._Text4_1);
            this.Frame4.Controls.Add(this._Text4_0);
            this.Frame4.Controls.Add(this._Text4_6);
            this.Frame4.Controls.Add(this._Text4_7);
            this.Frame4.Controls.Add(this._Text4_8);
            this.Frame4.Controls.Add(this._Text4_9);
            this.Frame4.Controls.Add(this._Text4_10);
            this.Frame4.Controls.Add(this._Text4_11);
            this.Frame4.Controls.Add(this._Text4_12);
            this.Frame4.Controls.Add(this._Label11_13);
            this.Frame4.Controls.Add(this.Label5);
            this.Frame4.Controls.Add(this._Label11_4);
            this.Frame4.Controls.Add(this._Label11_3);
            this.Frame4.Controls.Add(this._Label11_2);
            this.Frame4.Controls.Add(this._Label11_1);
            this.Frame4.Controls.Add(this._Label11_0);
            this.Frame4.Controls.Add(this._Label11_5);
            this.Frame4.Controls.Add(this._Label11_6);
            this.Frame4.Controls.Add(this._Label11_7);
            this.Frame4.Controls.Add(this._Label11_8);
            this.Frame4.Controls.Add(this._Label11_9);
            this.Frame4.Controls.Add(this._Label11_10);
            this.Frame4.Controls.Add(this._Label11_11);
            this.Frame4.Controls.Add(this._Label11_12);
            this.Frame4.Controls.Add(this.lblHelpSite);
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(6, 3);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x2b9, 0x121);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 2;
            this.Frame4.TabStop = false;
            this._Text4_13.AcceptsReturn = true;
            this._Text4_13.BackColor = SystemColors.Window;
            this._Text4_13.Cursor = Cursors.IBeam;
            this._Text4_13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_13.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_13, 13);
            point = new Point(0x1e8, 80);
            this._Text4_13.Location = point;
            this._Text4_13.MaxLength = 0;
            this._Text4_13.Name = "_Text4_13";
            this._Text4_13.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_13.Size = size;
            this._Text4_13.TabIndex = 200;
            this._Text4_13.Text = "Text4";
            this._Text4_13.Visible = false;
            this._Text4_5.AcceptsReturn = true;
            this._Text4_5.BackColor = SystemColors.Window;
            this._Text4_5.Cursor = Cursors.IBeam;
            this._Text4_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_5.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_5, 5);
            point = new Point(0x260, 0x20);
            this._Text4_5.Location = point;
            this._Text4_5.MaxLength = 0;
            this._Text4_5.Name = "_Text4_5";
            this._Text4_5.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_5.Size = size;
            this._Text4_5.TabIndex = 0x80;
            this._Text4_5.Text = "Text4";
            this._Text4_5.Visible = false;
            this._Text4_4.AcceptsReturn = true;
            this._Text4_4.BackColor = SystemColors.Window;
            this._Text4_4.Cursor = Cursors.IBeam;
            this._Text4_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_4.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_4, 4);
            point = new Point(0x150, 0x20);
            this._Text4_4.Location = point;
            this._Text4_4.MaxLength = 0;
            this._Text4_4.Name = "_Text4_4";
            this._Text4_4.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_4.Size = size;
            this._Text4_4.TabIndex = 0x7f;
            this._Text4_4.Text = "Text4";
            this._Text4_3.AcceptsReturn = true;
            this._Text4_3.BackColor = SystemColors.Window;
            this._Text4_3.Cursor = Cursors.IBeam;
            this._Text4_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_3.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_3, 3);
            point = new Point(0x100, 0x20);
            this._Text4_3.Location = point;
            this._Text4_3.MaxLength = 0;
            this._Text4_3.Name = "_Text4_3";
            this._Text4_3.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_3.Size = size;
            this._Text4_3.TabIndex = 0x7e;
            this._Text4_3.Text = "Text4";
            this._Text4_2.AcceptsReturn = true;
            this._Text4_2.BackColor = SystemColors.Window;
            this._Text4_2.Cursor = Cursors.IBeam;
            this._Text4_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_2.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_2, 2);
            point = new Point(0xb0, 0x20);
            this._Text4_2.Location = point;
            this._Text4_2.MaxLength = 0;
            this._Text4_2.Name = "_Text4_2";
            this._Text4_2.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_2.Size = size;
            this._Text4_2.TabIndex = 0x7d;
            this._Text4_2.Text = "Text4";
            this._Text4_1.AcceptsReturn = true;
            this._Text4_1.BackColor = SystemColors.Window;
            this._Text4_1.Cursor = Cursors.IBeam;
            this._Text4_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_1.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_1, 1);
            point = new Point(0x60, 0x20);
            this._Text4_1.Location = point;
            this._Text4_1.MaxLength = 0;
            this._Text4_1.Name = "_Text4_1";
            this._Text4_1.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_1.Size = size;
            this._Text4_1.TabIndex = 0x7c;
            this._Text4_1.Text = "Text4";
            this._Text4_0.AcceptsReturn = true;
            this._Text4_0.BackColor = SystemColors.Window;
            this._Text4_0.Cursor = Cursors.IBeam;
            this._Text4_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_0.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_0, 0);
            point = new Point(0x10, 0x20);
            this._Text4_0.Location = point;
            this._Text4_0.MaxLength = 0;
            this._Text4_0.Name = "_Text4_0";
            this._Text4_0.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_0.Size = size;
            this._Text4_0.TabIndex = 0x7b;
            this._Text4_0.Text = "Text4";
            this._Text4_6.AcceptsReturn = true;
            this._Text4_6.BackColor = SystemColors.Window;
            this._Text4_6.Cursor = Cursors.IBeam;
            this._Text4_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_6.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_6, 6);
            point = new Point(0x1a0, 0x20);
            this._Text4_6.Location = point;
            this._Text4_6.MaxLength = 0;
            this._Text4_6.Name = "_Text4_6";
            this._Text4_6.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_6.Size = size;
            this._Text4_6.TabIndex = 0x7a;
            this._Text4_6.Text = "Text4";
            this._Text4_7.AcceptsReturn = true;
            this._Text4_7.BackColor = SystemColors.Window;
            this._Text4_7.Cursor = Cursors.IBeam;
            this._Text4_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_7.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_7, 7);
            point = new Point(0x10, 80);
            this._Text4_7.Location = point;
            this._Text4_7.MaxLength = 0;
            this._Text4_7.Name = "_Text4_7";
            this._Text4_7.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_7.Size = size;
            this._Text4_7.TabIndex = 0x79;
            this._Text4_7.Text = "Text4";
            this._Text4_8.AcceptsReturn = true;
            this._Text4_8.BackColor = SystemColors.Window;
            this._Text4_8.Cursor = Cursors.IBeam;
            this._Text4_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_8.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_8, 8);
            point = new Point(0x60, 80);
            this._Text4_8.Location = point;
            this._Text4_8.MaxLength = 0;
            this._Text4_8.Name = "_Text4_8";
            this._Text4_8.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_8.Size = size;
            this._Text4_8.TabIndex = 120;
            this._Text4_8.Text = "Text4";
            this._Text4_9.AcceptsReturn = true;
            this._Text4_9.BackColor = SystemColors.Window;
            this._Text4_9.Cursor = Cursors.IBeam;
            this._Text4_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_9.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_9, 9);
            point = new Point(0xb0, 80);
            this._Text4_9.Location = point;
            this._Text4_9.MaxLength = 0;
            this._Text4_9.Name = "_Text4_9";
            this._Text4_9.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_9.Size = size;
            this._Text4_9.TabIndex = 0x77;
            this._Text4_9.Text = "Text4";
            this._Text4_10.AcceptsReturn = true;
            this._Text4_10.BackColor = SystemColors.Window;
            this._Text4_10.Cursor = Cursors.IBeam;
            this._Text4_10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_10.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_10, 10);
            point = new Point(0x100, 80);
            this._Text4_10.Location = point;
            this._Text4_10.MaxLength = 0;
            this._Text4_10.Name = "_Text4_10";
            this._Text4_10.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_10.Size = size;
            this._Text4_10.TabIndex = 0x76;
            this._Text4_10.Text = "Text4";
            this._Text4_11.AcceptsReturn = true;
            this._Text4_11.BackColor = SystemColors.Window;
            this._Text4_11.Cursor = Cursors.IBeam;
            this._Text4_11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_11.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_11, 11);
            point = new Point(0x150, 80);
            this._Text4_11.Location = point;
            this._Text4_11.MaxLength = 0;
            this._Text4_11.Name = "_Text4_11";
            this._Text4_11.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_11.Size = size;
            this._Text4_11.TabIndex = 0x75;
            this._Text4_11.Text = "Text4";
            this._Text4_12.AcceptsReturn = true;
            this._Text4_12.BackColor = SystemColors.Window;
            this._Text4_12.Cursor = Cursors.IBeam;
            this._Text4_12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Text4_12.ForeColor = SystemColors.WindowText;
            this.Text4.SetIndex(this._Text4_12, 12);
            point = new Point(0x1a0, 80);
            this._Text4_12.Location = point;
            this._Text4_12.MaxLength = 0;
            this._Text4_12.Name = "_Text4_12";
            this._Text4_12.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._Text4_12.Size = size;
            this._Text4_12.TabIndex = 0x74;
            this._Text4_12.Text = "Text4";
            this._Label11_13.BackColor = SystemColors.Control;
            this._Label11_13.Cursor = Cursors.Default;
            this._Label11_13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_13.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_13, 13);
            point = new Point(0x1e8, 0x40);
            this._Label11_13.Location = point;
            this._Label11_13.Name = "_Label11_13";
            this._Label11_13.RightToLeft = RightToLeft.No;
            size = new Size(0x54, 14);
            this._Label11_13.Size = size;
            this._Label11_13.TabIndex = 0xc9;
            this._Label11_13.Text = "Label11";
            this._Label11_13.Visible = false;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(0x200, 0x10);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x29);
            this.Label5.Size = size;
            this.Label5.TabIndex = 0xc7;
            this.Label5.Text = "DWRL has been made invis:";
            this.Label5.Visible = false;
            this._Label11_4.BackColor = SystemColors.Control;
            this._Label11_4.Cursor = Cursors.Default;
            this._Label11_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_4.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_4, 4);
            point = new Point(0x150, 0x10);
            this._Label11_4.Location = point;
            this._Label11_4.Name = "_Label11_4";
            this._Label11_4.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Label11_4.Size = size;
            this._Label11_4.TabIndex = 0x8d;
            this._Label11_4.Text = "Label11";
            this._Label11_3.BackColor = SystemColors.Control;
            this._Label11_3.Cursor = Cursors.Default;
            this._Label11_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_3.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_3, 3);
            point = new Point(0x100, 0x10);
            this._Label11_3.Location = point;
            this._Label11_3.Name = "_Label11_3";
            this._Label11_3.RightToLeft = RightToLeft.No;
            size = new Size(0x4a, 0x11);
            this._Label11_3.Size = size;
            this._Label11_3.TabIndex = 140;
            this._Label11_3.Text = "Label11";
            this._Label11_2.BackColor = SystemColors.Control;
            this._Label11_2.Cursor = Cursors.Default;
            this._Label11_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_2.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_2, 2);
            point = new Point(0xb0, 0x10);
            this._Label11_2.Location = point;
            this._Label11_2.Name = "_Label11_2";
            this._Label11_2.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._Label11_2.Size = size;
            this._Label11_2.TabIndex = 0x8b;
            this._Label11_2.Text = "Label11";
            this._Label11_1.BackColor = SystemColors.Control;
            this._Label11_1.Cursor = Cursors.Default;
            this._Label11_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_1.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_1, 1);
            point = new Point(0x60, 0x10);
            this._Label11_1.Location = point;
            this._Label11_1.Name = "_Label11_1";
            this._Label11_1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._Label11_1.Size = size;
            this._Label11_1.TabIndex = 0x8a;
            this._Label11_1.Text = "Label11";
            this._Label11_0.BackColor = SystemColors.Control;
            this._Label11_0.Cursor = Cursors.Default;
            this._Label11_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_0.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_0, 0);
            point = new Point(0x10, 0x10);
            this._Label11_0.Location = point;
            this._Label11_0.Name = "_Label11_0";
            this._Label11_0.RightToLeft = RightToLeft.No;
            size = new Size(0x4a, 0x11);
            this._Label11_0.Size = size;
            this._Label11_0.TabIndex = 0x89;
            this._Label11_0.Text = "Label11";
            this._Label11_5.BackColor = SystemColors.Control;
            this._Label11_5.Cursor = Cursors.Default;
            this._Label11_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_5.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_5, 5);
            point = new Point(0x260, 0x10);
            this._Label11_5.Location = point;
            this._Label11_5.Name = "_Label11_5";
            this._Label11_5.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this._Label11_5.Size = size;
            this._Label11_5.TabIndex = 0x88;
            this._Label11_5.Text = "Label11";
            this._Label11_5.Visible = false;
            this._Label11_6.BackColor = SystemColors.Control;
            this._Label11_6.Cursor = Cursors.Default;
            this._Label11_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_6.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_6, 6);
            point = new Point(0x1a0, 0x10);
            this._Label11_6.Location = point;
            this._Label11_6.Name = "_Label11_6";
            this._Label11_6.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Label11_6.Size = size;
            this._Label11_6.TabIndex = 0x87;
            this._Label11_6.Text = "Label11";
            this._Label11_7.BackColor = SystemColors.Control;
            this._Label11_7.Cursor = Cursors.Default;
            this._Label11_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_7.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_7, 7);
            point = new Point(0x10, 0x40);
            this._Label11_7.Location = point;
            this._Label11_7.Name = "_Label11_7";
            this._Label11_7.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Label11_7.Size = size;
            this._Label11_7.TabIndex = 0x86;
            this._Label11_7.Text = "Label11";
            this._Label11_8.AutoSize = true;
            this._Label11_8.BackColor = SystemColors.Control;
            this._Label11_8.Cursor = Cursors.Default;
            this._Label11_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_8.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_8, 8);
            point = new Point(0x60, 0x3f);
            this._Label11_8.Location = point;
            this._Label11_8.Name = "_Label11_8";
            this._Label11_8.RightToLeft = RightToLeft.No;
            size = new Size(0x2d, 14);
            this._Label11_8.Size = size;
            this._Label11_8.TabIndex = 0x85;
            this._Label11_8.Text = "Label11";
            this._Label11_9.BackColor = SystemColors.Control;
            this._Label11_9.Cursor = Cursors.Default;
            this._Label11_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_9.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_9, 9);
            point = new Point(0xb0, 0x40);
            this._Label11_9.Location = point;
            this._Label11_9.Name = "_Label11_9";
            this._Label11_9.RightToLeft = RightToLeft.No;
            size = new Size(0x4a, 0x11);
            this._Label11_9.Size = size;
            this._Label11_9.TabIndex = 0x84;
            this._Label11_9.Text = "Label11";
            this._Label11_10.BackColor = SystemColors.Control;
            this._Label11_10.Cursor = Cursors.Default;
            this._Label11_10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_10.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_10, 10);
            point = new Point(0x100, 0x40);
            this._Label11_10.Location = point;
            this._Label11_10.Name = "_Label11_10";
            this._Label11_10.RightToLeft = RightToLeft.No;
            size = new Size(0x4a, 14);
            this._Label11_10.Size = size;
            this._Label11_10.TabIndex = 0x83;
            this._Label11_10.Text = "Label11";
            this._Label11_11.BackColor = SystemColors.Control;
            this._Label11_11.Cursor = Cursors.Default;
            this._Label11_11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_11.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_11, 11);
            point = new Point(0x150, 0x40);
            this._Label11_11.Location = point;
            this._Label11_11.Name = "_Label11_11";
            this._Label11_11.RightToLeft = RightToLeft.No;
            size = new Size(0x53, 0x11);
            this._Label11_11.Size = size;
            this._Label11_11.TabIndex = 130;
            this._Label11_11.Text = "Label11";
            this._Label11_12.BackColor = SystemColors.Control;
            this._Label11_12.Cursor = Cursors.Default;
            this._Label11_12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_12.ForeColor = SystemColors.ControlText;
            this.Label11.SetIndex(this._Label11_12, 12);
            point = new Point(0x1a0, 0x40);
            this._Label11_12.Location = point;
            this._Label11_12.Name = "_Label11_12";
            this._Label11_12.RightToLeft = RightToLeft.No;
            size = new Size(0x4c, 0x11);
            this._Label11_12.Size = size;
            this._Label11_12.TabIndex = 0x81;
            this._Label11_12.Text = "Label11";
            this.lblHelpSite.BackColor = SystemColors.Control;
            this.lblHelpSite.BorderStyle = BorderStyle.Fixed3D;
            this.lblHelpSite.Cursor = Cursors.Default;
            this.lblHelpSite.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblHelpSite.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x70);
            this.lblHelpSite.Location = point;
            this.lblHelpSite.Name = "lblHelpSite";
            this.lblHelpSite.RightToLeft = RightToLeft.No;
            size = new Size(0x2a1, 0x99);
            this.lblHelpSite.Size = size;
            this.lblHelpSite.TabIndex = 0x37;
            this._SSTab1_TabPage5.Controls.Add(this.txtSolute);
            this._SSTab1_TabPage5.Controls.Add(this._lblHelp_5);
            this._SSTab1_TabPage5.Controls.Add(this.Label20);
            this._SSTab1_TabPage5.Controls.Add(this._flx_Parameters_5);
            this._SSTab1_TabPage5.Controls.Add(this.Frame13);
            this._SSTab1_TabPage5.Controls.Add(this._txtBox_5);
            this._SSTab1_TabPage5.Controls.Add(this.Frame2);
            this._SSTab1_TabPage5.Controls.Add(this.txtkoc);
            this._SSTab1_TabPage5.Controls.Add(this.cmdKoc);
            this._SSTab1_TabPage5.Controls.Add(this.cmdFOCUS);
            this._SSTab1_TabPage5.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage5.Location = point;
            this._SSTab1_TabPage5.Name = "_SSTab1_TabPage5";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage5.Size = size;
            this._SSTab1_TabPage5.TabIndex = 5;
            this._SSTab1_TabPage5.Text = "SOLUTE";
            this._SSTab1_TabPage5.UseVisualStyleBackColor = true;
            point = new Point(0xe7, 0x74);
            this.txtSolute.Location = point;
            this.txtSolute.Name = "txtSolute";
            size = new Size(0x45, 20);
            this.txtSolute.Size = size;
            this.txtSolute.TabIndex = 0xfe;
            this.txtSolute.Visible = false;
            this._lblHelp_5.BackColor = SystemColors.Control;
            this._lblHelp_5.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_5.Cursor = Cursors.Default;
            this._lblHelp_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_5.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_5, 5);
            point = new Point(8, 0xf3);
            this._lblHelp_5.Location = point;
            this._lblHelp_5.Name = "_lblHelp_5";
            this._lblHelp_5.RightToLeft = RightToLeft.No;
            size = new Size(0x1f9, 0x51);
            this._lblHelp_5.Size = size;
            this._lblHelp_5.TabIndex = 0x65;
            this.Label20.BackColor = SystemColors.Control;
            this.Label20.Cursor = Cursors.Default;
            this.Label20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label20.ForeColor = SystemColors.ControlText;
            point = new Point(0x1d0, 220);
            this.Label20.Location = point;
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label20.Size = size;
            this.Label20.TabIndex = 0xfd;
            this.Label20.Text = "cm3/g";
            this.flx_Parameters.SetIndex(this._flx_Parameters_5, 5);
            point = new Point(8, 15);
            this._flx_Parameters_5.Location = point;
            this._flx_Parameters_5.Name = "_flx_Parameters_5";
            this._flx_Parameters_5.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_5.OcxState");
            size = new Size(0x1f9, 0xc1);
            this._flx_Parameters_5.Size = size;
            this._flx_Parameters_5.TabIndex = 0x56;
            this.Frame13.BackColor = SystemColors.Control;
            this.Frame13.Controls.Add(this._Check4_9);
            this.Frame13.Controls.Add(this.cmbSoluteVariables);
            this.Frame13.Controls.Add(this._Check4_0);
            this.Frame13.Controls.Add(this._Check4_1);
            this.Frame13.Controls.Add(this._Check4_2);
            this.Frame13.Controls.Add(this._Check4_3);
            this.Frame13.Controls.Add(this._Check4_4);
            this.Frame13.Controls.Add(this._Check4_5);
            this.Frame13.Controls.Add(this._Check4_6);
            this.Frame13.Controls.Add(this._Check4_7);
            this.Frame13.Controls.Add(this._Check4_8);
            this.Frame13.Controls.Add(this.Text27);
            this.Frame13.Controls.Add(this.Command15);
            this.Frame13.Controls.Add(this.Label24);
            this.Frame13.Controls.Add(this.Label15);
            this.Frame13.Controls.Add(this.Label28);
            this.Frame13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame13.ForeColor = SystemColors.ControlText;
            point = new Point(0x207, 0x77);
            this.Frame13.Location = point;
            this.Frame13.Name = "Frame13";
            this.Frame13.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0xd1);
            this.Frame13.Size = size;
            this.Frame13.TabIndex = 0x57;
            this.Frame13.TabStop = false;
            this.Frame13.Text = "Copy";
            this._Check4_9.BackColor = SystemColors.Control;
            this._Check4_9.Cursor = Cursors.Default;
            this._Check4_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_9.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_9, 9);
            point = new Point(0x58, 0x98);
            this._Check4_9.Location = point;
            this._Check4_9.Name = "_Check4_9";
            this._Check4_9.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check4_9.Size = size;
            this._Check4_9.TabIndex = 0xd4;
            this._Check4_9.TabStop = false;
            this._Check4_9.Text = "Check3";
            this._Check4_9.UseVisualStyleBackColor = false;
            this.cmbSoluteVariables.BackColor = SystemColors.Window;
            this.cmbSoluteVariables.Cursor = Cursors.Default;
            this.cmbSoluteVariables.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSoluteVariables.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbSoluteVariables.ForeColor = SystemColors.WindowText;
            point = new Point(0x38, 0x18);
            this.cmbSoluteVariables.Location = point;
            this.cmbSoluteVariables.Name = "cmbSoluteVariables";
            this.cmbSoluteVariables.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x16);
            this.cmbSoluteVariables.Size = size;
            this.cmbSoluteVariables.TabIndex = 0xb1;
            this.cmbSoluteVariables.TabStop = false;
            this._Check4_0.BackColor = SystemColors.Control;
            this._Check4_0.Cursor = Cursors.Default;
            this._Check4_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_0.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_0, 0);
            point = new Point(8, 0x58);
            this._Check4_0.Location = point;
            this._Check4_0.Name = "_Check4_0";
            this._Check4_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_0.Size = size;
            this._Check4_0.TabIndex = 0x62;
            this._Check4_0.TabStop = false;
            this._Check4_0.Text = "Check4";
            this._Check4_0.UseVisualStyleBackColor = false;
            this._Check4_1.BackColor = SystemColors.Control;
            this._Check4_1.Cursor = Cursors.Default;
            this._Check4_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_1.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_1, 1);
            point = new Point(8, 0x68);
            this._Check4_1.Location = point;
            this._Check4_1.Name = "_Check4_1";
            this._Check4_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_1.Size = size;
            this._Check4_1.TabIndex = 0x61;
            this._Check4_1.TabStop = false;
            this._Check4_1.Text = "Check4";
            this._Check4_1.UseVisualStyleBackColor = false;
            this._Check4_2.BackColor = SystemColors.Control;
            this._Check4_2.Cursor = Cursors.Default;
            this._Check4_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_2.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_2, 2);
            point = new Point(8, 120);
            this._Check4_2.Location = point;
            this._Check4_2.Name = "_Check4_2";
            this._Check4_2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_2.Size = size;
            this._Check4_2.TabIndex = 0x60;
            this._Check4_2.TabStop = false;
            this._Check4_2.Text = "Check4";
            this._Check4_2.UseVisualStyleBackColor = false;
            this._Check4_3.BackColor = SystemColors.Control;
            this._Check4_3.Cursor = Cursors.Default;
            this._Check4_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_3.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_3, 3);
            point = new Point(8, 0x88);
            this._Check4_3.Location = point;
            this._Check4_3.Name = "_Check4_3";
            this._Check4_3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_3.Size = size;
            this._Check4_3.TabIndex = 0x5f;
            this._Check4_3.TabStop = false;
            this._Check4_3.Text = "Check4";
            this._Check4_3.UseVisualStyleBackColor = false;
            this._Check4_4.BackColor = SystemColors.Control;
            this._Check4_4.Cursor = Cursors.Default;
            this._Check4_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_4.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_4, 4);
            point = new Point(8, 0x98);
            this._Check4_4.Location = point;
            this._Check4_4.Name = "_Check4_4";
            this._Check4_4.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_4.Size = size;
            this._Check4_4.TabIndex = 0x5e;
            this._Check4_4.TabStop = false;
            this._Check4_4.Text = "Check4";
            this._Check4_4.UseVisualStyleBackColor = false;
            this._Check4_5.BackColor = SystemColors.Control;
            this._Check4_5.Cursor = Cursors.Default;
            this._Check4_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_5.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_5, 5);
            point = new Point(0x58, 0x58);
            this._Check4_5.Location = point;
            this._Check4_5.Name = "_Check4_5";
            this._Check4_5.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_5.Size = size;
            this._Check4_5.TabIndex = 0x5d;
            this._Check4_5.TabStop = false;
            this._Check4_5.Text = "Check4";
            this._Check4_5.UseVisualStyleBackColor = false;
            this._Check4_6.BackColor = SystemColors.Control;
            this._Check4_6.Cursor = Cursors.Default;
            this._Check4_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_6.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_6, 6);
            point = new Point(0x58, 0x68);
            this._Check4_6.Location = point;
            this._Check4_6.Name = "_Check4_6";
            this._Check4_6.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check4_6.Size = size;
            this._Check4_6.TabIndex = 0x5c;
            this._Check4_6.TabStop = false;
            this._Check4_6.Text = "Check4";
            this._Check4_6.UseVisualStyleBackColor = false;
            this._Check4_7.BackColor = SystemColors.Control;
            this._Check4_7.Cursor = Cursors.Default;
            this._Check4_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_7.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_7, 7);
            point = new Point(0x58, 120);
            this._Check4_7.Location = point;
            this._Check4_7.Name = "_Check4_7";
            this._Check4_7.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check4_7.Size = size;
            this._Check4_7.TabIndex = 0x5b;
            this._Check4_7.TabStop = false;
            this._Check4_7.Text = "Check4";
            this._Check4_7.UseVisualStyleBackColor = false;
            this._Check4_8.BackColor = SystemColors.Control;
            this._Check4_8.Cursor = Cursors.Default;
            this._Check4_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check4_8.ForeColor = SystemColors.ControlText;
            this.Check4.SetIndex(this._Check4_8, 8);
            point = new Point(0x58, 0x88);
            this._Check4_8.Location = point;
            this._Check4_8.Name = "_Check4_8";
            this._Check4_8.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._Check4_8.Size = size;
            this._Check4_8.TabIndex = 90;
            this._Check4_8.TabStop = false;
            this._Check4_8.Text = "Check4";
            this._Check4_8.UseVisualStyleBackColor = false;
            this.Text27.AcceptsReturn = true;
            this.Text27.BackColor = SystemColors.Window;
            this.Text27.Cursor = Cursors.IBeam;
            this.Text27.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text27.ForeColor = SystemColors.WindowText;
            point = new Point(0x38, 0x30);
            this.Text27.Location = point;
            this.Text27.MaxLength = 0;
            this.Text27.Name = "Text27";
            this.Text27.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.Text27.Size = size;
            this.Text27.TabIndex = 0x59;
            this.Text27.TabStop = false;
            this.Command15.BackColor = SystemColors.Control;
            this.Command15.Cursor = Cursors.Default;
            this.Command15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command15.ForeColor = SystemColors.ControlText;
            point = new Point(120, 0xb0);
            this.Command15.Location = point;
            this.Command15.Name = "Command15";
            this.Command15.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command15.Size = size;
            this.Command15.TabIndex = 0x58;
            this.Command15.TabStop = false;
            this.Command15.Text = "&Copy";
            this.Command15.UseVisualStyleBackColor = false;
            this.Label24.BackColor = SystemColors.Control;
            this.Label24.Cursor = Cursors.Default;
            this.Label24.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label24.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x48);
            this.Label24.Location = point;
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label24.Size = size;
            this.Label24.TabIndex = 0xb2;
            this.Label24.Text = "Copy to:";
            this.Label15.BackColor = SystemColors.Control;
            this.Label15.Cursor = Cursors.Default;
            this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label15.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label15.Location = point;
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this.Label15.Size = size;
            this.Label15.TabIndex = 0xb0;
            this.Label15.Text = "Copy:";
            this.Label28.BackColor = SystemColors.Control;
            this.Label28.Cursor = Cursors.Default;
            this.Label28.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label28.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Label28.Location = point;
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label28.Size = size;
            this.Label28.TabIndex = 0x63;
            this.Label28.Text = "Value:";
            this._txtBox_5.AcceptsReturn = true;
            this._txtBox_5.BackColor = SystemColors.Window;
            this._txtBox_5.Cursor = Cursors.IBeam;
            this._txtBox_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_5.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_5, 5);
            point = new Point(0xd0, 80);
            this._txtBox_5.Location = point;
            this._txtBox_5.MaxLength = 0;
            this._txtBox_5.Name = "_txtBox_5";
            this._txtBox_5.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtBox_5.Size = size;
            this._txtBox_5.TabIndex = 100;
            this._txtBox_5.TabStop = false;
            this._txtBox_5.Text = "Text28";
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this._text12_21);
            this.Frame2.Controls.Add(this._text12_20);
            this.Frame2.Controls.Add(this._text12_19);
            this.Frame2.Controls.Add(this._text12_18);
            this.Frame2.Controls.Add(this._text12_17);
            this.Frame2.Controls.Add(this._text12_16);
            this.Frame2.Controls.Add(this._text12_15);
            this.Frame2.Controls.Add(this._text12_14);
            this.Frame2.Controls.Add(this._text12_13);
            this.Frame2.Controls.Add(this._text12_12);
            this.Frame2.Controls.Add(this._text12_11);
            this.Frame2.Controls.Add(this._text12_10);
            this.Frame2.Controls.Add(this._text12_9);
            this.Frame2.Controls.Add(this._text12_8);
            this.Frame2.Controls.Add(this._text12_7);
            this.Frame2.Controls.Add(this._text12_6);
            this.Frame2.Controls.Add(this._text12_5);
            this.Frame2.Controls.Add(this._text12_4);
            this.Frame2.Controls.Add(this._text12_3);
            this.Frame2.Controls.Add(this._text12_2);
            this.Frame2.Controls.Add(this._text12_1);
            this.Frame2.Controls.Add(this._text12_0);
            this.Frame2.Controls.Add(this.cmbIndex);
            this.Frame2.Controls.Add(this.cmbParameters);
            this.Frame2.Controls.Add(this.Label2);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(0x207, 0x10);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x61);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 0x98;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Other parameters";
            this._text12_21.AcceptsReturn = true;
            this._text12_21.BackColor = SystemColors.Window;
            this._text12_21.Cursor = Cursors.IBeam;
            this._text12_21.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_21.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_21, 0x15);
            point = new Point(0x30, 0x40);
            this._text12_21.Location = point;
            this._text12_21.MaxLength = 0;
            this._text12_21.Name = "_text12_21";
            this._text12_21.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_21.Size = size;
            this._text12_21.TabIndex = 0xe5;
            this._text12_21.TabStop = false;
            this._text12_21.Text = "Text2";
            this._text12_20.AcceptsReturn = true;
            this._text12_20.BackColor = SystemColors.Window;
            this._text12_20.Cursor = Cursors.IBeam;
            this._text12_20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_20.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_20, 20);
            point = new Point(0x30, 0x40);
            this._text12_20.Location = point;
            this._text12_20.MaxLength = 0;
            this._text12_20.Name = "_text12_20";
            this._text12_20.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_20.Size = size;
            this._text12_20.TabIndex = 0xe4;
            this._text12_20.Text = "Text2";
            this._text12_19.AcceptsReturn = true;
            this._text12_19.BackColor = SystemColors.Window;
            this._text12_19.Cursor = Cursors.IBeam;
            this._text12_19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_19.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_19, 0x13);
            point = new Point(0x30, 0x40);
            this._text12_19.Location = point;
            this._text12_19.MaxLength = 0;
            this._text12_19.Name = "_text12_19";
            this._text12_19.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_19.Size = size;
            this._text12_19.TabIndex = 0xaf;
            this._text12_19.Text = "Text5";
            this._text12_18.AcceptsReturn = true;
            this._text12_18.BackColor = SystemColors.Window;
            this._text12_18.Cursor = Cursors.IBeam;
            this._text12_18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_18.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_18, 0x12);
            point = new Point(0x30, 0x40);
            this._text12_18.Location = point;
            this._text12_18.MaxLength = 0;
            this._text12_18.Name = "_text12_18";
            this._text12_18.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_18.Size = size;
            this._text12_18.TabIndex = 0xae;
            this._text12_18.Text = "Text5";
            this._text12_17.AcceptsReturn = true;
            this._text12_17.BackColor = SystemColors.Window;
            this._text12_17.Cursor = Cursors.IBeam;
            this._text12_17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_17.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_17, 0x11);
            point = new Point(0x30, 0x40);
            this._text12_17.Location = point;
            this._text12_17.MaxLength = 0;
            this._text12_17.Name = "_text12_17";
            this._text12_17.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_17.Size = size;
            this._text12_17.TabIndex = 0xad;
            this._text12_17.Text = "Text5";
            this._text12_16.AcceptsReturn = true;
            this._text12_16.BackColor = SystemColors.Window;
            this._text12_16.Cursor = Cursors.IBeam;
            this._text12_16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_16.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_16, 0x10);
            point = new Point(0x30, 0x40);
            this._text12_16.Location = point;
            this._text12_16.MaxLength = 0;
            this._text12_16.Name = "_text12_16";
            this._text12_16.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_16.Size = size;
            this._text12_16.TabIndex = 0xac;
            this._text12_16.Text = "Text5";
            this._text12_15.AcceptsReturn = true;
            this._text12_15.BackColor = SystemColors.Window;
            this._text12_15.Cursor = Cursors.IBeam;
            this._text12_15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_15.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_15, 15);
            point = new Point(0x30, 0x40);
            this._text12_15.Location = point;
            this._text12_15.MaxLength = 0;
            this._text12_15.Name = "_text12_15";
            this._text12_15.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_15.Size = size;
            this._text12_15.TabIndex = 0xab;
            this._text12_15.Text = "Text5";
            this._text12_14.AcceptsReturn = true;
            this._text12_14.BackColor = SystemColors.Window;
            this._text12_14.Cursor = Cursors.IBeam;
            this._text12_14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_14.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_14, 14);
            point = new Point(0x30, 0x40);
            this._text12_14.Location = point;
            this._text12_14.MaxLength = 0;
            this._text12_14.Name = "_text12_14";
            this._text12_14.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_14.Size = size;
            this._text12_14.TabIndex = 170;
            this._text12_14.Text = "Text5";
            this._text12_13.AcceptsReturn = true;
            this._text12_13.BackColor = SystemColors.Window;
            this._text12_13.Cursor = Cursors.IBeam;
            this._text12_13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_13.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_13, 13);
            point = new Point(0x30, 0x40);
            this._text12_13.Location = point;
            this._text12_13.MaxLength = 0;
            this._text12_13.Name = "_text12_13";
            this._text12_13.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_13.Size = size;
            this._text12_13.TabIndex = 0xa9;
            this._text12_13.Text = "Text5";
            this._text12_12.AcceptsReturn = true;
            this._text12_12.BackColor = SystemColors.Window;
            this._text12_12.Cursor = Cursors.IBeam;
            this._text12_12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_12.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_12, 12);
            point = new Point(0x30, 0x40);
            this._text12_12.Location = point;
            this._text12_12.MaxLength = 0;
            this._text12_12.Name = "_text12_12";
            this._text12_12.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_12.Size = size;
            this._text12_12.TabIndex = 0xa8;
            this._text12_12.Text = "Text5";
            this._text12_11.AcceptsReturn = true;
            this._text12_11.BackColor = SystemColors.Window;
            this._text12_11.Cursor = Cursors.IBeam;
            this._text12_11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_11.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_11, 11);
            point = new Point(0x30, 0x40);
            this._text12_11.Location = point;
            this._text12_11.MaxLength = 0;
            this._text12_11.Name = "_text12_11";
            this._text12_11.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_11.Size = size;
            this._text12_11.TabIndex = 0xa7;
            this._text12_11.Text = "Text5";
            this._text12_10.AcceptsReturn = true;
            this._text12_10.BackColor = SystemColors.Window;
            this._text12_10.Cursor = Cursors.IBeam;
            this._text12_10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_10.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_10, 10);
            point = new Point(0x30, 0x40);
            this._text12_10.Location = point;
            this._text12_10.MaxLength = 0;
            this._text12_10.Name = "_text12_10";
            this._text12_10.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_10.Size = size;
            this._text12_10.TabIndex = 0xa6;
            this._text12_10.Text = "Text5";
            this._text12_9.AcceptsReturn = true;
            this._text12_9.BackColor = SystemColors.Window;
            this._text12_9.Cursor = Cursors.IBeam;
            this._text12_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_9.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_9, 9);
            point = new Point(0x30, 0x40);
            this._text12_9.Location = point;
            this._text12_9.MaxLength = 0;
            this._text12_9.Name = "_text12_9";
            this._text12_9.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_9.Size = size;
            this._text12_9.TabIndex = 0xa5;
            this._text12_9.Text = "Text5";
            this._text12_8.AcceptsReturn = true;
            this._text12_8.BackColor = SystemColors.Window;
            this._text12_8.Cursor = Cursors.IBeam;
            this._text12_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_8.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_8, 8);
            point = new Point(0x30, 0x40);
            this._text12_8.Location = point;
            this._text12_8.MaxLength = 0;
            this._text12_8.Name = "_text12_8";
            this._text12_8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_8.Size = size;
            this._text12_8.TabIndex = 0xa4;
            this._text12_8.Text = "Text5";
            this._text12_7.AcceptsReturn = true;
            this._text12_7.BackColor = SystemColors.Window;
            this._text12_7.Cursor = Cursors.IBeam;
            this._text12_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_7.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_7, 7);
            point = new Point(0x30, 0x40);
            this._text12_7.Location = point;
            this._text12_7.MaxLength = 0;
            this._text12_7.Name = "_text12_7";
            this._text12_7.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_7.Size = size;
            this._text12_7.TabIndex = 0xa3;
            this._text12_7.Text = "Text5";
            this._text12_6.AcceptsReturn = true;
            this._text12_6.BackColor = SystemColors.Window;
            this._text12_6.Cursor = Cursors.IBeam;
            this._text12_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_6.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_6, 6);
            point = new Point(0x30, 0x40);
            this._text12_6.Location = point;
            this._text12_6.MaxLength = 0;
            this._text12_6.Name = "_text12_6";
            this._text12_6.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_6.Size = size;
            this._text12_6.TabIndex = 0xa2;
            this._text12_6.Text = "Text5";
            this._text12_5.AcceptsReturn = true;
            this._text12_5.BackColor = SystemColors.Window;
            this._text12_5.Cursor = Cursors.IBeam;
            this._text12_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_5.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_5, 5);
            point = new Point(0x30, 0x40);
            this._text12_5.Location = point;
            this._text12_5.MaxLength = 0;
            this._text12_5.Name = "_text12_5";
            this._text12_5.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_5.Size = size;
            this._text12_5.TabIndex = 0xa1;
            this._text12_5.Text = "Text5";
            this._text12_4.AcceptsReturn = true;
            this._text12_4.BackColor = SystemColors.Window;
            this._text12_4.Cursor = Cursors.IBeam;
            this._text12_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_4.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_4, 4);
            point = new Point(0x30, 0x40);
            this._text12_4.Location = point;
            this._text12_4.MaxLength = 0;
            this._text12_4.Name = "_text12_4";
            this._text12_4.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_4.Size = size;
            this._text12_4.TabIndex = 160;
            this._text12_4.Text = "Text5";
            this._text12_3.AcceptsReturn = true;
            this._text12_3.BackColor = SystemColors.Window;
            this._text12_3.Cursor = Cursors.IBeam;
            this._text12_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_3.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_3, 3);
            point = new Point(0x30, 0x40);
            this._text12_3.Location = point;
            this._text12_3.MaxLength = 0;
            this._text12_3.Name = "_text12_3";
            this._text12_3.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_3.Size = size;
            this._text12_3.TabIndex = 0x9f;
            this._text12_3.Text = "Text5";
            this._text12_2.AcceptsReturn = true;
            this._text12_2.BackColor = SystemColors.Window;
            this._text12_2.Cursor = Cursors.IBeam;
            this._text12_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_2.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_2, 2);
            point = new Point(0x30, 0x40);
            this._text12_2.Location = point;
            this._text12_2.MaxLength = 0;
            this._text12_2.Name = "_text12_2";
            this._text12_2.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_2.Size = size;
            this._text12_2.TabIndex = 0x9e;
            this._text12_1.AcceptsReturn = true;
            this._text12_1.BackColor = SystemColors.Window;
            this._text12_1.Cursor = Cursors.IBeam;
            this._text12_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_1.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_1, 1);
            point = new Point(0x30, 0x40);
            this._text12_1.Location = point;
            this._text12_1.MaxLength = 0;
            this._text12_1.Name = "_text12_1";
            this._text12_1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_1.Size = size;
            this._text12_1.TabIndex = 0x9d;
            this._text12_0.AcceptsReturn = true;
            this._text12_0.BackColor = SystemColors.Window;
            this._text12_0.Cursor = Cursors.IBeam;
            this._text12_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._text12_0.ForeColor = SystemColors.WindowText;
            this.text12.SetIndex(this._text12_0, 0);
            point = new Point(0x30, 0x40);
            this._text12_0.Location = point;
            this._text12_0.MaxLength = 0;
            this._text12_0.Name = "_text12_0";
            this._text12_0.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._text12_0.Size = size;
            this._text12_0.TabIndex = 0x9c;
            this.cmbIndex.BackColor = SystemColors.Window;
            this.cmbIndex.Cursor = Cursors.Default;
            this.cmbIndex.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbIndex.ForeColor = SystemColors.WindowText;
            point = new Point(0x98, 0x38);
            this.cmbIndex.Location = point;
            this.cmbIndex.Name = "cmbIndex";
            this.cmbIndex.RightToLeft = RightToLeft.No;
            size = new Size(0x1a, 0x16);
            this.cmbIndex.Size = size;
            this.cmbIndex.TabIndex = 0x9b;
            this.cmbIndex.TabStop = false;
            this.cmbIndex.Text = "Combo1";
            this.cmbIndex.Visible = false;
            this.cmbParameters.BackColor = SystemColors.Window;
            this.cmbParameters.Cursor = Cursors.Default;
            this.cmbParameters.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbParameters.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbParameters.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x18);
            this.cmbParameters.Location = point;
            this.cmbParameters.Name = "cmbParameters";
            this.cmbParameters.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x16);
            this.cmbParameters.Size = size;
            this.cmbParameters.TabIndex = 0x99;
            this.cmbParameters.TabStop = false;
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x40);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 0x9a;
            this.Label2.Text = "Value:";
            this.txtkoc.AcceptsReturn = true;
            this.txtkoc.BackColor = SystemColors.Window;
            this.txtkoc.Cursor = Cursors.IBeam;
            this.txtkoc.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtkoc.ForeColor = SystemColors.WindowText;
            point = new Point(0x192, 0xd9);
            this.txtkoc.Location = point;
            this.txtkoc.MaxLength = 0;
            this.txtkoc.Name = "txtkoc";
            this.txtkoc.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 20);
            this.txtkoc.Size = size;
            this.txtkoc.TabIndex = 250;
            this.txtkoc.Text = "10";
            this.cmdKoc.BackColor = SystemColors.Control;
            this.cmdKoc.Cursor = Cursors.Default;
            this.cmdKoc.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdKoc.ForeColor = SystemColors.ControlText;
            point = new Point(0xf7, 0xd7);
            this.cmdKoc.Location = point;
            this.cmdKoc.Name = "cmdKoc";
            this.cmdKoc.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x19);
            this.cmdKoc.Size = size;
            this.cmdKoc.TabIndex = 0xfb;
            this.cmdKoc.Text = "Calculate ZKD from Koc:";
            this.cmdKoc.UseVisualStyleBackColor = false;
            this.cmdFOCUS.BackColor = SystemColors.Control;
            this.cmdFOCUS.Cursor = Cursors.Default;
            this.cmdFOCUS.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdFOCUS.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xd7);
            this.cmdFOCUS.Location = point;
            this.cmdFOCUS.Name = "cmdFOCUS";
            this.cmdFOCUS.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x19);
            this.cmdFOCUS.Size = size;
            this.cmdFOCUS.TabIndex = 0xfc;
            this.cmdFOCUS.Text = "Calculate rate coefficients acc. to FOCUS";
            this.cmdFOCUS.UseVisualStyleBackColor = false;
            this._SSTab1_TabPage6.Controls.Add(this._fraManagement_0);
            this._SSTab1_TabPage6.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage6.Location = point;
            this._SSTab1_TabPage6.Name = "_SSTab1_TabPage6";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage6.Size = size;
            this._SSTab1_TabPage6.TabIndex = 6;
            this._SSTab1_TabPage6.Text = "TILLAGE";
            this._SSTab1_TabPage6.UseVisualStyleBackColor = true;
            this._fraManagement_0.BackColor = SystemColors.Control;
            this._fraManagement_0.Controls.Add(this.txtNMan);
            this._fraManagement_0.Controls.Add(this._txtMan_13);
            this._fraManagement_0.Controls.Add(this._txtMan_12);
            this._fraManagement_0.Controls.Add(this._txtMan_8);
            this._fraManagement_0.Controls.Add(this._txtMan_11);
            this._fraManagement_0.Controls.Add(this._txtMan_10);
            this._fraManagement_0.Controls.Add(this._txtMan_9);
            this._fraManagement_0.Controls.Add(this._txtMan_7);
            this._fraManagement_0.Controls.Add(this._txtMan_6);
            this._fraManagement_0.Controls.Add(this._txtMan_5);
            this._fraManagement_0.Controls.Add(this._txtMan_4);
            this._fraManagement_0.Controls.Add(this._txtMan_3);
            this._fraManagement_0.Controls.Add(this._txtMan_2);
            this._fraManagement_0.Controls.Add(this._txtMan_1);
            this._fraManagement_0.Controls.Add(this._txtMan_0);
            this._fraManagement_0.Controls.Add(this._txtBox_6);
            this._fraManagement_0.Controls.Add(this._flx_Parameters_6);
            this._fraManagement_0.Controls.Add(this._lblMan_13);
            this._fraManagement_0.Controls.Add(this._lblMan_12);
            this._fraManagement_0.Controls.Add(this._lblMan_11);
            this._fraManagement_0.Controls.Add(this._lblMan_10);
            this._fraManagement_0.Controls.Add(this._lblMan_9);
            this._fraManagement_0.Controls.Add(this._lblMan_8);
            this._fraManagement_0.Controls.Add(this._lblMan_5);
            this._fraManagement_0.Controls.Add(this._lblMan_0);
            this._fraManagement_0.Controls.Add(this._lblMan_1);
            this._fraManagement_0.Controls.Add(this._lblMan_3);
            this._fraManagement_0.Controls.Add(this._lblMan_6);
            this._fraManagement_0.Controls.Add(this._lblMan_7);
            this._fraManagement_0.Controls.Add(this._lblMan_4);
            this._fraManagement_0.Controls.Add(this._lblMan_2);
            this._fraManagement_0.Controls.Add(this._lblHelp_6);
            this._fraManagement_0.Controls.Add(this.Label17);
            this._fraManagement_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraManagement_0.ForeColor = SystemColors.ControlText;
            this.fraManagement.SetIndex(this._fraManagement_0, 0);
            point = new Point(6, 3);
            this._fraManagement_0.Location = point;
            this._fraManagement_0.Name = "_fraManagement_0";
            this._fraManagement_0.RightToLeft = RightToLeft.No;
            size = new Size(0x2b9, 0x119);
            this._fraManagement_0.Size = size;
            this._fraManagement_0.TabIndex = 0x6a;
            this._fraManagement_0.TabStop = false;
            this._txtMan_13.AcceptsReturn = true;
            this._txtMan_13.BackColor = SystemColors.Window;
            this._txtMan_13.Cursor = Cursors.IBeam;
            this._txtMan_13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_13.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_13, 13);
            point = new Point(0x250, 120);
            this._txtMan_13.Location = point;
            this._txtMan_13.MaxLength = 0;
            this._txtMan_13.Name = "_txtMan_13";
            this._txtMan_13.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_13.Size = size;
            this._txtMan_13.TabIndex = 0xf6;
            this._txtMan_13.Text = "0";
            this._txtMan_12.AcceptsReturn = true;
            this._txtMan_12.BackColor = SystemColors.Window;
            this._txtMan_12.Cursor = Cursors.IBeam;
            this._txtMan_12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_12.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_12, 12);
            point = new Point(0x1c0, 120);
            this._txtMan_12.Location = point;
            this._txtMan_12.MaxLength = 0;
            this._txtMan_12.Name = "_txtMan_12";
            this._txtMan_12.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_12.Size = size;
            this._txtMan_12.TabIndex = 0xf5;
            this._txtMan_12.Text = "0";
            this._txtMan_8.AcceptsReturn = true;
            this._txtMan_8.BackColor = SystemColors.Window;
            this._txtMan_8.Cursor = Cursors.IBeam;
            this._txtMan_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_8.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_8, 8);
            point = new Point(440, 200);
            this._txtMan_8.Location = point;
            this._txtMan_8.MaxLength = 0;
            this._txtMan_8.Name = "_txtMan_8";
            this._txtMan_8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_8.Size = size;
            this._txtMan_8.TabIndex = 0xf2;
            this._txtMan_8.Text = "0";
            this._txtMan_8.Visible = false;
            this._txtMan_11.AcceptsReturn = true;
            this._txtMan_11.BackColor = SystemColors.Window;
            this._txtMan_11.Cursor = Cursors.IBeam;
            this._txtMan_11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_11.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_11, 11);
            point = new Point(0x268, 0xe0);
            this._txtMan_11.Location = point;
            this._txtMan_11.MaxLength = 0;
            this._txtMan_11.Name = "_txtMan_11";
            this._txtMan_11.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_11.Size = size;
            this._txtMan_11.TabIndex = 0xf1;
            this._txtMan_11.Text = "0";
            this._txtMan_11.Visible = false;
            this._txtMan_10.AcceptsReturn = true;
            this._txtMan_10.BackColor = SystemColors.Window;
            this._txtMan_10.Cursor = Cursors.IBeam;
            this._txtMan_10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_10.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_10, 10);
            point = new Point(0x268, 200);
            this._txtMan_10.Location = point;
            this._txtMan_10.MaxLength = 0;
            this._txtMan_10.Name = "_txtMan_10";
            this._txtMan_10.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_10.Size = size;
            this._txtMan_10.TabIndex = 0xef;
            this._txtMan_10.Text = "0";
            this._txtMan_10.Visible = false;
            this._txtMan_9.AcceptsReturn = true;
            this._txtMan_9.BackColor = SystemColors.Window;
            this._txtMan_9.Cursor = Cursors.IBeam;
            this._txtMan_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_9.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_9, 9);
            point = new Point(440, 0xe0);
            this._txtMan_9.Location = point;
            this._txtMan_9.MaxLength = 0;
            this._txtMan_9.Name = "_txtMan_9";
            this._txtMan_9.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_9.Size = size;
            this._txtMan_9.TabIndex = 0xed;
            this._txtMan_9.Text = "0";
            this._txtMan_9.Visible = false;
            this._txtMan_7.AcceptsReturn = true;
            this._txtMan_7.BackColor = SystemColors.Window;
            this._txtMan_7.Cursor = Cursors.IBeam;
            this._txtMan_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_7.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_7, 7);
            point = new Point(0x108, 0xd0);
            this._txtMan_7.Location = point;
            this._txtMan_7.MaxLength = 0;
            this._txtMan_7.Name = "_txtMan_7";
            this._txtMan_7.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_7.Size = size;
            this._txtMan_7.TabIndex = 0xd3;
            this._txtMan_7.TabStop = false;
            this._txtMan_7.Text = "0";
            this._txtMan_7.Visible = false;
            this._txtMan_6.AcceptsReturn = true;
            this._txtMan_6.BackColor = SystemColors.Window;
            this._txtMan_6.Cursor = Cursors.IBeam;
            this._txtMan_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_6.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_6, 6);
            point = new Point(0x250, 0x38);
            this._txtMan_6.Location = point;
            this._txtMan_6.MaxLength = 0;
            this._txtMan_6.Name = "_txtMan_6";
            this._txtMan_6.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_6.Size = size;
            this._txtMan_6.TabIndex = 0xd1;
            this._txtMan_6.TabStop = false;
            this._txtMan_6.Text = "0";
            this._txtMan_5.AcceptsReturn = true;
            this._txtMan_5.BackColor = SystemColors.Window;
            this._txtMan_5.Cursor = Cursors.IBeam;
            this._txtMan_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_5.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_5, 5);
            point = new Point(440, 0xb0);
            this._txtMan_5.Location = point;
            this._txtMan_5.MaxLength = 0;
            this._txtMan_5.Name = "_txtMan_5";
            this._txtMan_5.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_5.Size = size;
            this._txtMan_5.TabIndex = 0xd0;
            this._txtMan_5.TabStop = false;
            this._txtMan_5.Text = "0";
            this._txtMan_5.Visible = false;
            this._txtMan_4.AcceptsReturn = true;
            this._txtMan_4.BackColor = SystemColors.Window;
            this._txtMan_4.Cursor = Cursors.IBeam;
            this._txtMan_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_4.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_4, 4);
            point = new Point(0x268, 0xb0);
            this._txtMan_4.Location = point;
            this._txtMan_4.MaxLength = 0;
            this._txtMan_4.Name = "_txtMan_4";
            this._txtMan_4.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_4.Size = size;
            this._txtMan_4.TabIndex = 0xcf;
            this._txtMan_4.TabStop = false;
            this._txtMan_4.Text = "0";
            this._txtMan_4.Visible = false;
            this._txtMan_3.AcceptsReturn = true;
            this._txtMan_3.BackColor = SystemColors.Window;
            this._txtMan_3.Cursor = Cursors.IBeam;
            this._txtMan_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_3.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_3, 3);
            point = new Point(0x250, 0x20);
            this._txtMan_3.Location = point;
            this._txtMan_3.MaxLength = 0;
            this._txtMan_3.Name = "_txtMan_3";
            this._txtMan_3.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_3.Size = size;
            this._txtMan_3.TabIndex = 0xbf;
            this._txtMan_3.TabStop = false;
            this._txtMan_3.Text = "0";
            this._txtMan_2.AcceptsReturn = true;
            this._txtMan_2.BackColor = SystemColors.Window;
            this._txtMan_2.Cursor = Cursors.IBeam;
            this._txtMan_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_2.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_2, 2);
            point = new Point(0x1c0, 80);
            this._txtMan_2.Location = point;
            this._txtMan_2.MaxLength = 0;
            this._txtMan_2.Name = "_txtMan_2";
            this._txtMan_2.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_2.Size = size;
            this._txtMan_2.TabIndex = 190;
            this._txtMan_2.TabStop = false;
            this._txtMan_2.Text = "0";
            this._txtMan_1.AcceptsReturn = true;
            this._txtMan_1.BackColor = SystemColors.Window;
            this._txtMan_1.Cursor = Cursors.IBeam;
            this._txtMan_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_1.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_1, 1);
            point = new Point(0x1c0, 0x38);
            this._txtMan_1.Location = point;
            this._txtMan_1.MaxLength = 0;
            this._txtMan_1.Name = "_txtMan_1";
            this._txtMan_1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_1.Size = size;
            this._txtMan_1.TabIndex = 0xbd;
            this._txtMan_1.TabStop = false;
            this._txtMan_1.Text = "0";
            this._txtMan_0.AcceptsReturn = true;
            this._txtMan_0.BackColor = SystemColors.Window;
            this._txtMan_0.Cursor = Cursors.IBeam;
            this._txtMan_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtMan_0.ForeColor = SystemColors.WindowText;
            this.txtMan.SetIndex(this._txtMan_0, 0);
            point = new Point(0x1c0, 0x20);
            this._txtMan_0.Location = point;
            this._txtMan_0.MaxLength = 0;
            this._txtMan_0.Name = "_txtMan_0";
            this._txtMan_0.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this._txtMan_0.Size = size;
            this._txtMan_0.TabIndex = 0xbc;
            this._txtMan_0.TabStop = false;
            this._txtMan_0.Text = "0";
            this._txtBox_6.AcceptsReturn = true;
            this._txtBox_6.BackColor = SystemColors.Window;
            this._txtBox_6.Cursor = Cursors.IBeam;
            this._txtBox_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_6.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_6, 6);
            point = new Point(0xc0, 0x10);
            this._txtBox_6.Location = point;
            this._txtBox_6.MaxLength = 0;
            this._txtBox_6.Name = "_txtBox_6";
            this._txtBox_6.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 20);
            this._txtBox_6.Size = size;
            this._txtBox_6.TabIndex = 0x70;
            this._txtBox_6.TabStop = false;
            this._txtBox_6.Text = "Text10";
            this._txtBox_6.Visible = false;
            this.flx_Parameters.SetIndex(this._flx_Parameters_6, 6);
            point = new Point(8, 40);
            this._flx_Parameters_6.Location = point;
            this._flx_Parameters_6.Name = "_flx_Parameters_6";
            this._flx_Parameters_6.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_6.OcxState");
            size = new Size(0x151, 0x61);
            this._flx_Parameters_6.Size = size;
            this._flx_Parameters_6.TabIndex = 0x6f;
            this._lblMan_13.BackColor = SystemColors.Control;
            this._lblMan_13.Cursor = Cursors.Default;
            this._lblMan_13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_13.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_13, 13);
            point = new Point(0x200, 0x7a);
            this._lblMan_13.Location = point;
            this._lblMan_13.Name = "_lblMan_13";
            this._lblMan_13.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._lblMan_13.Size = size;
            this._lblMan_13.TabIndex = 0xf4;
            this._lblMan_13.Text = "INIT_ASCALE";
            this._lblMan_12.BackColor = SystemColors.Control;
            this._lblMan_12.Cursor = Cursors.Default;
            this._lblMan_12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_12.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_12, 12);
            point = new Point(0x160, 0x7a);
            this._lblMan_12.Location = point;
            this._lblMan_12.Name = "_lblMan_12";
            this._lblMan_12.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this._lblMan_12.Size = size;
            this._lblMan_12.TabIndex = 0xf3;
            this._lblMan_12.Text = "CONSOL_STATE";
            this._lblMan_11.BackColor = SystemColors.Control;
            this._lblMan_11.Cursor = Cursors.Default;
            this._lblMan_11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_11.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_11, 11);
            point = new Point(0x1f0, 0xe2);
            this._lblMan_11.Location = point;
            this._lblMan_11.Name = "_lblMan_11";
            this._lblMan_11.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._lblMan_11.Size = size;
            this._lblMan_11.TabIndex = 240;
            this._lblMan_11.Text = "KSM_SEAL";
            this._lblMan_11.Visible = false;
            this._lblMan_10.BackColor = SystemColors.Control;
            this._lblMan_10.Cursor = Cursors.Default;
            this._lblMan_10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_10.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_10, 10);
            point = new Point(0x1f0, 0xcc);
            this._lblMan_10.Location = point;
            this._lblMan_10.Name = "_lblMan_10";
            this._lblMan_10.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this._lblMan_10.Size = size;
            this._lblMan_10.TabIndex = 0xee;
            this._lblMan_10.Text = "XMPOR_SEAL";
            this._lblMan_10.Visible = false;
            this._lblMan_9.BackColor = SystemColors.Control;
            this._lblMan_9.Cursor = Cursors.Default;
            this._lblMan_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_9.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_9, 9);
            point = new Point(0x160, 0xe2);
            this._lblMan_9.Location = point;
            this._lblMan_9.Name = "_lblMan_9";
            this._lblMan_9.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._lblMan_9.Size = size;
            this._lblMan_9.TabIndex = 0xec;
            this._lblMan_9.Text = "ZN_SEAL";
            this._lblMan_9.Visible = false;
            this._lblMan_8.BackColor = SystemColors.Control;
            this._lblMan_8.Cursor = Cursors.Default;
            this._lblMan_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_8.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_8, 8);
            point = new Point(0x160, 0xcc);
            this._lblMan_8.Location = point;
            this._lblMan_8.Name = "_lblMan_8";
            this._lblMan_8.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this._lblMan_8.Size = size;
            this._lblMan_8.TabIndex = 0xeb;
            this._lblMan_8.Text = "GAMMA_SEAL";
            this._lblMan_8.Visible = false;
            this._lblMan_5.BackColor = SystemColors.Control;
            this._lblMan_5.Cursor = Cursors.Default;
            this._lblMan_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_5.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_5, 5);
            point = new Point(0x160, 0xb0);
            this._lblMan_5.Location = point;
            this._lblMan_5.Name = "_lblMan_5";
            this._lblMan_5.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this._lblMan_5.Size = size;
            this._lblMan_5.TabIndex = 0xce;
            this._lblMan_5.Text = "SEAL_STATE";
            this._lblMan_5.Visible = false;
            this._lblMan_0.BackColor = SystemColors.Control;
            this._lblMan_0.Cursor = Cursors.Default;
            this._lblMan_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_0.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_0, 0);
            point = new Point(0x160, 0x20);
            this._lblMan_0.Location = point;
            this._lblMan_0.Name = "_lblMan_0";
            this._lblMan_0.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this._lblMan_0.Size = size;
            this._lblMan_0.TabIndex = 0xea;
            this._lblMan_0.Text = "GAMMA_TILLED";
            this._lblMan_1.BackColor = SystemColors.Control;
            this._lblMan_1.Cursor = Cursors.Default;
            this._lblMan_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_1.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_1, 1);
            point = new Point(0x160, 60);
            this._lblMan_1.Location = point;
            this._lblMan_1.Name = "_lblMan_1";
            this._lblMan_1.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this._lblMan_1.Size = size;
            this._lblMan_1.TabIndex = 0xe9;
            this._lblMan_1.Text = "XMPOR_TILLED";
            this._lblMan_3.BackColor = SystemColors.Control;
            this._lblMan_3.Cursor = Cursors.Default;
            this._lblMan_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_3.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_3, 3);
            point = new Point(0x200, 0x20);
            this._lblMan_3.Location = point;
            this._lblMan_3.Name = "_lblMan_3";
            this._lblMan_3.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this._lblMan_3.Size = size;
            this._lblMan_3.TabIndex = 0xe8;
            this._lblMan_3.Text = "HALFRAIN";
            this._lblMan_6.BackColor = SystemColors.Control;
            this._lblMan_6.Cursor = Cursors.Default;
            this._lblMan_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_6.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_6, 6);
            point = new Point(0x200, 60);
            this._lblMan_6.Location = point;
            this._lblMan_6.Name = "_lblMan_6";
            this._lblMan_6.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this._lblMan_6.Size = size;
            this._lblMan_6.TabIndex = 0xe7;
            this._lblMan_6.Text = "KSM_TILLED";
            this._lblMan_7.BackColor = SystemColors.Control;
            this._lblMan_7.Cursor = Cursors.Default;
            this._lblMan_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_7.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_7, 7);
            point = new Point(0xd8, 0xd0);
            this._lblMan_7.Location = point;
            this._lblMan_7.Name = "_lblMan_7";
            this._lblMan_7.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._lblMan_7.Size = size;
            this._lblMan_7.TabIndex = 210;
            this._lblMan_7.Text = "DUMMY";
            this._lblMan_7.Visible = false;
            this._lblMan_4.BackColor = SystemColors.Control;
            this._lblMan_4.Cursor = Cursors.Default;
            this._lblMan_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_4.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_4, 4);
            point = new Point(0x1f0, 0xb0);
            this._lblMan_4.Location = point;
            this._lblMan_4.Name = "_lblMan_4";
            this._lblMan_4.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this._lblMan_4.Size = size;
            this._lblMan_4.TabIndex = 0xcd;
            this._lblMan_4.Text = "HALFAMOUNT_SEAL";
            this._lblMan_4.Visible = false;
            this._lblMan_2.BackColor = SystemColors.Control;
            this._lblMan_2.Cursor = Cursors.Default;
            this._lblMan_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblMan_2.ForeColor = SystemColors.ControlText;
            this.lblMan.SetIndex(this._lblMan_2, 2);
            point = new Point(0x160, 0x58);
            this._lblMan_2.Location = point;
            this._lblMan_2.Name = "_lblMan_2";
            this._lblMan_2.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this._lblMan_2.Size = size;
            this._lblMan_2.TabIndex = 0xbb;
            this._lblMan_2.Text = "ZN_TILLED";
            this._lblHelp_6.BackColor = SystemColors.Control;
            this._lblHelp_6.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_6.Cursor = Cursors.Default;
            this._lblHelp_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_6.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_6, 6);
            point = new Point(8, 0x90);
            this._lblHelp_6.Location = point;
            this._lblHelp_6.Name = "_lblHelp_6";
            this._lblHelp_6.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x79);
            this._lblHelp_6.Size = size;
            this._lblHelp_6.TabIndex = 0x71;
            this.Label17.BackColor = SystemColors.Control;
            this.Label17.Cursor = Cursors.Default;
            this.Label17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label17.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x10);
            this.Label17.Location = point;
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this.Label17.Size = size;
            this.Label17.TabIndex = 0x6c;
            this.Label17.Text = "NTILL:";
            this._SSTab1_TabPage7.Controls.Add(this.Frame5);
            this._SSTab1_TabPage7.Font = new Font("Arial", 8f);
            point = new Point(4, 0x12);
            this._SSTab1_TabPage7.Location = point;
            this._SSTab1_TabPage7.Name = "_SSTab1_TabPage7";
            size = new Size(0x314, 0x148);
            this._SSTab1_TabPage7.Size = size;
            this._SSTab1_TabPage7.TabIndex = 7;
            this._SSTab1_TabPage7.Text = "LAYERS";
            this._SSTab1_TabPage7.UseVisualStyleBackColor = true;
            this.Frame5.BackColor = SystemColors.Control;
            this.Frame5.Controls.Add(this._txtBox_8);
            this.Frame5.Controls.Add(this.Frame8);
            this.Frame5.Controls.Add(this._flx_Parameters_8);
            this.Frame5.Controls.Add(this._txtBox_7);
            this.Frame5.Controls.Add(this._flx_Parameters_7);
            this.Frame5.Controls.Add(this.Label7);
            this.Frame5.Controls.Add(this.Label10);
            this.Frame5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame5.ForeColor = SystemColors.ControlText;
            point = new Point(6, 3);
            this.Frame5.Location = point;
            this.Frame5.Name = "Frame5";
            this.Frame5.RightToLeft = RightToLeft.No;
            size = new Size(0x2d8, 0x139);
            this.Frame5.Size = size;
            this.Frame5.TabIndex = 0xc0;
            this.Frame5.TabStop = false;
            this._txtBox_8.AcceptsReturn = true;
            this._txtBox_8.BackColor = SystemColors.Window;
            this._txtBox_8.Cursor = Cursors.IBeam;
            this._txtBox_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_8.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_8, 8);
            point = new Point(80, 0x90);
            this._txtBox_8.Location = point;
            this._txtBox_8.MaxLength = 0;
            this._txtBox_8.Name = "_txtBox_8";
            this._txtBox_8.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._txtBox_8.Size = size;
            this._txtBox_8.TabIndex = 0xcc;
            this._txtBox_8.Text = "Text2";
            this.Frame8.BackColor = SystemColors.Control;
            this.Frame8.Controls.Add(this._lblHelp_7);
            this.Frame8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame8.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xb8);
            this.Frame8.Location = point;
            this.Frame8.Name = "Frame8";
            this.Frame8.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x79);
            this.Frame8.Size = size;
            this.Frame8.TabIndex = 0xca;
            this.Frame8.TabStop = false;
            this._lblHelp_7.BackColor = SystemColors.Control;
            this._lblHelp_7.BorderStyle = BorderStyle.Fixed3D;
            this._lblHelp_7.Cursor = Cursors.Default;
            this._lblHelp_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelp_7.ForeColor = SystemColors.ControlText;
            this.lblHelp.SetIndex(this._lblHelp_7, 7);
            point = new Point(8, 0x10);
            this._lblHelp_7.Location = point;
            this._lblHelp_7.Name = "_lblHelp_7";
            this._lblHelp_7.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x61);
            this._lblHelp_7.Size = size;
            this._lblHelp_7.TabIndex = 0xcb;
            this.flx_Parameters.SetIndex(this._flx_Parameters_8, 8);
            point = new Point(8, 0x20);
            this._flx_Parameters_8.Location = point;
            this._flx_Parameters_8.Name = "_flx_Parameters_8";
            this._flx_Parameters_8.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_8.OcxState");
            size = new Size(0xd1, 0x91);
            this._flx_Parameters_8.Size = size;
            this._flx_Parameters_8.TabIndex = 0xc2;
            this._txtBox_7.AcceptsReturn = true;
            this._txtBox_7.BackColor = SystemColors.Window;
            this._txtBox_7.Cursor = Cursors.IBeam;
            this._txtBox_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtBox_7.ForeColor = SystemColors.WindowText;
            this.txtBox.SetIndex(this._txtBox_7, 7);
            point = new Point(0x178, 0x38);
            this._txtBox_7.Location = point;
            this._txtBox_7.MaxLength = 0;
            this._txtBox_7.Name = "_txtBox_7";
            this._txtBox_7.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this._txtBox_7.Size = size;
            this._txtBox_7.TabIndex = 0xc1;
            this.flx_Parameters.SetIndex(this._flx_Parameters_7, 7);
            point = new Point(0xf8, 0x20);
            this._flx_Parameters_7.Location = point;
            this._flx_Parameters_7.Name = "_flx_Parameters_7";
            this._flx_Parameters_7.OcxState = (AxHost.State) manager.GetObject("_flx_Parameters_7.OcxState");
            size = new Size(0x131, 0x111);
            this._flx_Parameters_7.Size = size;
            this._flx_Parameters_7.TabIndex = 0xc4;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(0xf8, 0x10);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0xc5;
            this.Label7.Text = "Numerical layers:";
            this.Label10.BackColor = SystemColors.Control;
            this.Label10.Cursor = Cursors.Default;
            this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this.Label10.Size = size;
            this.Label10.TabIndex = 0xc3;
            this.Label10.Text = "Horizons:";
            point = new Point(0, 0);
            this.udNMAN.Location = point;
            this.udNMAN.Name = "udNMAN";
            this.udNMAN.TabIndex = 0;
            point = new Point(50, 13);
            this.txtNMan.Location = point;
            decimal num = new decimal(new int[] { 10, 0, 0, 0 });
            this.txtNMan.Maximum = num;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtNMan.Minimum = num;
            this.txtNMan.Name = "txtNMan";
            size = new Size(0x26, 20);
            this.txtNMan.Size = size;
            this.txtNMan.TabIndex = 0xf7;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtNMan.Value = num;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x32b, 0x18f);
            this.ClientSize = size;
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.SSTab1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(0x54, 0x15);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmParameters";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Parameters";
            this.SSTab1.ResumeLayout(false);
            this._SSTab1_TabPage0.ResumeLayout(false);
            this._SSTab1_TabPage0.PerformLayout();
            this._flx_Parameters_0.EndInit();
            this.fraCropSw3.ResumeLayout(false);
            this.fraCropSw3.PerformLayout();
            this._flx_Parameters_1.EndInit();
            this.fraCropSW2.ResumeLayout(false);
            this.fraCropSW2.PerformLayout();
            this.Frame7.ResumeLayout(false);
            this._SSTab1_TabPage1.ResumeLayout(false);
            this._SSTab1_TabPage1.PerformLayout();
            this._flx_Parameters_2.EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.Frame3.PerformLayout();
            this.Frame10.ResumeLayout(false);
            this._SSTab1_TabPage2.ResumeLayout(false);
            this.Frame11.ResumeLayout(false);
            this.Frame11.PerformLayout();
            this.udNIRR.EndInit();
            this.Frame9.ResumeLayout(false);
            this.fraDefineSubSets.ResumeLayout(false);
            this._flx_Parameters_3.EndInit();
            this._SSTab1_TabPage3.ResumeLayout(false);
            this.Frame12.ResumeLayout(false);
            this.Frame12.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            this._flx_Parameters_4.EndInit();
            this._SSTab1_TabPage4.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame4.PerformLayout();
            this._SSTab1_TabPage5.ResumeLayout(false);
            this._SSTab1_TabPage5.PerformLayout();
            this._flx_Parameters_5.EndInit();
            this.Frame13.ResumeLayout(false);
            this.Frame13.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this._SSTab1_TabPage6.ResumeLayout(false);
            this._fraManagement_0.ResumeLayout(false);
            this._fraManagement_0.PerformLayout();
            this._flx_Parameters_6.EndInit();
            this._SSTab1_TabPage7.ResumeLayout(false);
            this.Frame5.ResumeLayout(false);
            this.Frame5.PerformLayout();
            this.Frame8.ResumeLayout(false);
            this._flx_Parameters_8.EndInit();
            this._flx_Parameters_7.EndInit();
            this.udNMAN.EndInit();
            ((ISupportInitialize) this.Check1).EndInit();
            ((ISupportInitialize) this.Check2).EndInit();
            ((ISupportInitialize) this.Check4).EndInit();
            ((ISupportInitialize) this.Label1).EndInit();
            ((ISupportInitialize) this.Label11).EndInit();
            ((ISupportInitialize) this.Text4).EndInit();
            ((ISupportInitialize) this.flx_Parameters).EndInit();
            ((ISupportInitialize) this.fraManagement).EndInit();
            ((ISupportInitialize) this.lblCrop).EndInit();
            ((ISupportInitialize) this.lblHelp).EndInit();
            ((ISupportInitialize) this.lblMan).EndInit();
            ((ISupportInitialize) this.optDefinitionType).EndInit();
            ((ISupportInitialize) this.optVariableToCopy).EndInit();
            ((ISupportInitialize) this.text1).EndInit();
            ((ISupportInitialize) this.text12).EndInit();
            ((ISupportInitialize) this.txtBox).EndInit();
            ((ISupportInitialize) this.txtCropDev2).EndInit();
            ((ISupportInitialize) this.txtCropDev3).EndInit();
            ((ISupportInitialize) this.txtMan).EndInit();
            this.txtNMan.EndInit();
            this.ResumeLayout(false);
        }

        private bool IsInGroup(ref short varno)
        {
            bool flag;
            short num3 = (short) Information.UBound(GlobalVariables.Groups, 1);
            short num = 1;
            while (true)
            {
                if (num <= num3)
                {
                    short num4 = (short) Information.UBound(GlobalVariables.Groups, 2);
                    short num2 = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num2 <= num5)
                        {
                            if (GlobalVariables.Groups[num, num2] != varno)
                            {
                                num2 = (short) (num2 + 1);
                                continue;
                            }
                            return true;
                        }
                        else
                        {
                            num = (short) (num + 1);
                        }
                        break;
                    }
                    continue;
                }
                else
                {
                    flag = false;
                }
                break;
            }
            return flag;
        }

        private void Label1_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.Label1.GetIndex((Label) eventSender);
            Label label = this.Label1[index];
            string text = label.Text;
            HelpFunctions.Help_IBcond(ref text, ref this.lblHelp[2]);
            label.Text = text;
        }

        private void Label11_MouseMove(object sender, MouseEventArgs e)
        {
            short index = this.Label11.GetIndex((Label) sender);
            Label lblHelpSite = this.lblHelpSite;
            Label label2 = this.Label11[index];
            string text = label2.Text;
            HelpFunctions.HELP_Site(ref index, ref lblHelpSite, ref text);
            label2.Text = text;
            this.lblHelpSite = lblHelpSite;
        }

        private void Label17_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            HelpFunctions.Help_Management(ref "NTILL", ref this.lblHelp[6]);
        }

        private void lblMan_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.lblMan.GetIndex((Label) eventSender);
            Label label = this.lblMan[index];
            string text = label.Text;
            HelpFunctions.Help_Management(ref text, ref this.lblHelp[6]);
            label.Text = text;
        }

        private void lstYearSubSets_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                if (this.b_ok)
                {
                    if (!ChecksAndAssignments.CheckIrrigation(ref this.frmMain, ref false))
                    {
                        return;
                    }
                    else
                    {
                        this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref 0);
                        this.m_CurrIrrGroup = (short) (this.lstYearSubSets.SelectedIndex + 1);
                    }
                }
                this.SetDefinitionYears();
                this.ShowIrr(ref GlobalVariables.Groups[this.lstYearSubSets.SelectedIndex + 1, 1]);
                this.udNIRR.Enabled = true;
            }
        }

        private void MACROPedotransfer()
        {
            frmPedotransfer frm = new frmPedotransfer(ref this.frmMain);
            frmPedotransfer pedotransfer2 = frm;
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num5 = nhorizon;
                if (index > num5)
                {
                    short num3 = pedotransfer2.Check5.Count();
                    index = (short) (GlobalVariables.Nhorizon + 1);
                    while (true)
                    {
                        num5 = num3;
                        if (index > num5)
                        {
                            short num4 = (short) (pedotransfer2.Check6.Count() - 1);
                            index = 0;
                            while (true)
                            {
                                num5 = num4;
                                if (index > num5)
                                {
                                    pedotransfer2 = null;
                                    frm.ShowDialog();
                                    if (frm.IDOK)
                                    {
                                        ChecksAndAssignments.AssignPhysicalParameters(ref this.frmMain, ref true);
                                        this.PedotransferFuncs(ref frm);
                                    }
                                    frm.Close();
                                    this.SSTab1.SelectedIndex = 3;
                                    this.Pedotransfer = true;
                                    return;
                                }
                                pedotransfer2.Check6[index].CheckState = CheckState.Unchecked;
                                index = (short) (index + 1);
                            }
                        }
                        pedotransfer2.Check5[(short) (index - 1)].Visible = false;
                        index = (short) (index + 1);
                    }
                }
                pedotransfer2.Check5[(short) (index - 1)].Visible = true;
                pedotransfer2.Check5[(short) (index - 1)].CheckState = CheckState.Unchecked;
                pedotransfer2.Check5[(short) (index - 1)].Text = GlobalVariables.designat[index];
                index = (short) (index + 1);
            }
        }

        private void MoveTextBox(ref AxMSFlexGrid flx, ref TextBox box)
        {
            AxMSFlexGrid grid = flx;
            if (!(grid.get_RowIsVisible(grid.Row) & grid.get_ColIsVisible(grid.Col)))
            {
                box.Visible = false;
            }
            else
            {
                box.Visible = true;
                box.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grid.Left) + grid.get_ColPos(grid.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grid.Top) + grid.get_RowPos(grid.Row))), 0, 0, BoundsSpecified.Location);
            }
            grid = null;
        }

        private float numofdays(ref string S)
        {
            short num3;
            short num = (short) Math.Round(Conversion.Val(Strings.Mid(S, 1, 4)));
            short num4 = (short) Math.Round(Conversion.Val(Strings.Mid(S, 6, 2)));
            short num2 = (short) Math.Round(Conversion.Val(Strings.Mid(S, 9, 2)));
            short num6 = 0;
            if ((num % 4) == 0)
            {
                num6 = -1;
            }
            if (num == 0x76c)
            {
                num6 = 0;
            }
            switch (num4)
            {
                case 1:
                    num3 = 0;
                    break;

                case 2:
                    num3 = 0x1f;
                    break;

                case 3:
                    num3 = 0x3b;
                    break;

                case 4:
                    num3 = 90;
                    break;

                case 5:
                    num3 = 120;
                    break;

                case 6:
                    num3 = 0x97;
                    break;

                case 7:
                    num3 = 0xb5;
                    break;

                case 8:
                    num3 = 0xd4;
                    break;

                case 9:
                    num3 = 0xf3;
                    break;

                case 10:
                    num3 = 0x111;
                    break;

                case 11:
                    num3 = 0x130;
                    break;

                case 12:
                    num3 = 0x14e;
                    break;

                default:
                    break;
            }
            if ((num6 == -1) & (num4 > 2))
            {
                num3 = (short) (num3 + 1);
            }
            return (float) ((short) (num3 + num2));
        }

        private void optDefinitionType_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                short num;
                short num9;
                short index = this.optDefinitionType.GetIndex((RadioButton) eventSender);
                string item = "";
                GlobalVariables.b_irrsame = !this.optDefinitionType[1].Checked;
                this.fraDefineSubSets.Visible = this.optDefinitionType[1].Checked;
                if (GlobalVariables.b_irrsame)
                {
                    this.lstYearSubSets.Items.Clear();
                    this.udNIRR.Enabled = true;
                    short count = (short) this.lstYears.Items.Count;
                    num = 1;
                    while (true)
                    {
                        num9 = count;
                        if (num > num9)
                        {
                            this.lstYearSubSets.Items.Add(item);
                            this.m_CurrIrrGroup = 1;
                            this.SetGroupArray();
                            MiscFUncs.RedimIrrigationArrays(ref this.lstYears.Items.Count);
                            this.Update_Irr(ref 1);
                            break;
                        }
                        item = item + " " + Support.GetItemString(this.lstYears, num - 1);
                        num = (short) (num + 1);
                    }
                }
                else
                {
                    this.lstYearSubSets.Items.Clear();
                    item = "";
                    short num7 = (short) Information.UBound(GlobalVariables.Groups, 1);
                    num = 1;
                    while (true)
                    {
                        if (num > num7)
                        {
                            MiscFUncs.RedimIrrigationArrays(ref this.lstYearSubSets.Items.Count);
                            break;
                        }
                        short num8 = (short) Information.UBound(GlobalVariables.Groups, 2);
                        short num3 = 1;
                        while (true)
                        {
                            num9 = num8;
                            if (num3 > num9)
                            {
                                this.lstYearSubSets.Items.Add(Strings.Trim(item));
                                item = "";
                                num = (short) (num + 1);
                                break;
                            }
                            if (GlobalVariables.Groups[num, num3] > 0)
                            {
                                item = item + Conversions.ToString((int) GlobalVariables.Groups[num, num3]) + " ";
                            }
                            num3 = (short) (num3 + 1);
                        }
                    }
                }
                if (this.lstYearSubSets.Items.Count > 0)
                {
                    this.m_CurrIrrGroup = 1;
                    this.b_ok = false;
                    this.lstYearSubSets.SelectedIndex = 0;
                    this.b_ok = true;
                }
            }
        }

        public void PedFuncAll_2()
        {
            string str4 = GlobalVariables.structur[1];
            short num7 = (short) Strings.InStr(1, str4, " ", CompareMethod.Binary);
            string expression = Strings.Trim(Strings.Mid(str4, 1, num7 - 1));
            short start = (short) Strings.Len(str4);
            while (true)
            {
                short num9;
                short num19 = 1;
                if (start >= num19)
                {
                    if (Strings.Mid(str4, start, 1) != " ")
                    {
                        start = (short) (start + -1);
                        continue;
                    }
                    num9 = start;
                }
                string str3 = Strings.Trim(Strings.Mid(str4, num9 + 1));
                string str2 = Strings.Trim(Strings.Mid(str4, num7 + 1, num9 - (num7 + 1)));
                short num6 = GlobalVariables.N_Layer[1];
                short index = 1;
                short nhorizon = GlobalVariables.Nhorizon;
                short num3 = 1;
                while (true)
                {
                    if (num3 <= nhorizon)
                    {
                        str4 = GlobalVariables.structur[num3];
                        num7 = (short) Strings.InStr(1, str4, " ", CompareMethod.Binary);
                        expression = Strings.Trim(Strings.Mid(str4, 1, num7 - 1));
                        start = (short) Strings.Len(str4);
                        while (true)
                        {
                            float num2;
                            num19 = 1;
                            if (start >= num19)
                            {
                                if (Strings.Mid(str4, start, 1) != " ")
                                {
                                    start = (short) (start + -1);
                                    continue;
                                }
                                num9 = start;
                            }
                            str3 = Strings.Trim(Strings.Mid(str4, num9 + 1));
                            str2 = Strings.Trim(Strings.Mid(str4, num7 + 1, num9 - (num7 + 1)));
                            num6 = GlobalVariables.N_Layer[num3];
                            index = num3;
                            float num10 = (float) (GlobalVariables.orgc[index] * 1.724);
                            start = 1;
                            short num15 = 0;
                            if (num3 == 1)
                            {
                                short num18 = (short) Strings.Len(GlobalVariables.designat[num3]);
                                index = 1;
                                while (true)
                                {
                                    num19 = num18;
                                    if (index > num19)
                                    {
                                        break;
                                    }
                                    if (Strings.Mid(GlobalVariables.designat[num3], start, index) == "A")
                                    {
                                        num15 = 1;
                                    }
                                    index = (short) (index + 1);
                                }
                            }
                            index = num3;
                            GlobalVariables.resid[num3] = 0f;
                            GlobalVariables.resid_c[num3] = 3;
                            GlobalVariables.tporv[num3] = (float) (((1.0 - (GlobalVariables.bulk[num3] / ((float) ((((100.0 - GlobalVariables.orgc[num3]) * 2.7) + GlobalVariables.orgc[num3]) / 100.0)))) * 0.96) * 100.0);
                            GlobalVariables.tporv_c[num3] = 3;
                            float num16 = (float) ((((((((((((0.7919 + (0.001691 * GlobalVariables.clay[num3])) - (0.29619 * GlobalVariables.bulk[num3])) - (1.491E-06 * Math.Pow((double) GlobalVariables.silt[num3], 2.0))) + (8.21E-05 * Math.Pow((double) num10, 2.0))) + (0.02427 / ((double) GlobalVariables.clay[num3]))) + (0.01113 / ((double) GlobalVariables.silt[num3]))) + (0.01472 * Math.Log((double) GlobalVariables.silt[num3]))) - ((7.33E-05 * num10) * GlobalVariables.clay[num3])) - ((0.000619 * GlobalVariables.bulk[num3]) * GlobalVariables.clay[num3])) - ((0.001183 * GlobalVariables.bulk[num3]) * num10)) - ((0.0001664 * num15) * GlobalVariables.silt[num3])) * 100.0);
                            GlobalVariables.cten[num3] = 10f;
                            GlobalVariables.cten_c[num3] = 3;
                            float num14 = (float) ((((((((((0.002885 * Math.Pow((double) num10, 2.0)) - (12.81 / ((double) GlobalVariables.bulk[num3]))) - (0.1524 / ((double) GlobalVariables.silt[num3]))) - (0.01958 / ((double) num10))) - (0.2876 * Math.Log((double) GlobalVariables.silt[num3]))) - (0.0709 * Math.Log((double) num10))) - (44.6 * Math.Log((double) GlobalVariables.bulk[num3]))) - ((0.02264 * GlobalVariables.bulk[num3]) * GlobalVariables.clay[num3])) + ((0.0896 * num10) * GlobalVariables.bulk[num3])) + ((0.00718 * num15) * GlobalVariables.clay[num3]));
                            GlobalVariables.vg_N[num3] = (float) (Math.Exp((double) ((((float) (((-25.23 - (0.02195 * GlobalVariables.clay[num3])) + (0.0074 * GlobalVariables.silt[num3])) - (0.194 * num10))) + ((float) (((45.5 * GlobalVariables.bulk[num3]) - (7.24 * Math.Pow((double) GlobalVariables.bulk[num3], 2.0))) + (0.0003658 * Math.Pow((double) GlobalVariables.clay[num3], 2.0))))) + num14)) + 1.0);
                            GlobalVariables.zlamb_c[num3] = 3;
                            GlobalVariables.vg_alpha[num3] = Math.Exp((double) ((float) ((((((((((((((-14.96 + (0.03135 * GlobalVariables.clay[num3])) + (0.0351 * GlobalVariables.silt[num3])) + (0.646 * num10)) + (15.29 * GlobalVariables.bulk[num3])) - (0.192 * num15)) - (4.671 * Math.Pow((double) GlobalVariables.bulk[num3], 2.0))) - (0.000781 * Math.Pow((double) GlobalVariables.clay[index], 2.0))) - (0.00687 * Math.Pow((double) num10, 2.0))) + (0.0449 / ((double) num10))) + (0.0663 * Math.Log((double) GlobalVariables.silt[index]))) + (0.1482 * Math.Log((double) num10))) - ((0.04546 * GlobalVariables.bulk[num3]) * GlobalVariables.silt[num3])) - ((0.4852 * num10) * GlobalVariables.bulk[num3])) + ((0.00673 * num15) * GlobalVariables.clay[num3]))));
                            GlobalVariables.scalevg_c[num3] = 3;
                            GlobalVariables.xmpor[num3] = (float) (((double) num16) / Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[num3] * GlobalVariables.cten[num3], (double) GlobalVariables.vg_N[num3]), (double) (1f - (1f / GlobalVariables.vg_N[num3]))));
                            if ((GlobalVariables.xmpor[num3] + 1.0) >= GlobalVariables.tporv[num3])
                            {
                                GlobalVariables.xmpor[num3] = GlobalVariables.tporv[num3] - ((float) 1.0);
                            }
                            GlobalVariables.xmpor_c[num3] = 3;
                            GlobalVariables.ksm[num3] = (float) (25.2 * Math.Exp((double) ((float) (((Math.Log(0.001) * (GlobalVariables.clay[num3] / 100f)) + (Math.Log(0.026) * (GlobalVariables.silt[num3] / 100f))) + (Math.Log(1.025) * (GlobalVariables.sand[num3] / 100f))))));
                            GlobalVariables.ksm_c[num3] = 3;
                            GlobalVariables.wilt[num3] = (float) (((double) num16) / Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[num3] * 15000.0, (double) GlobalVariables.vg_N[num3]), (double) (1f - (1f / GlobalVariables.vg_N[num3]))));
                            GlobalVariables.wilt_c[num3] = 3;
                            if ((expression == "none") | (Strings.Len(expression) == 0))
                            {
                                GlobalVariables.ascale[num3] = 1f;
                            }
                            else
                            {
                                num2 = (expression != "weak") ? ((expression != "moderate") ? 3f : 2f) : 1f;
                                if (str2 == "fine")
                                {
                                    string str5 = str3;
                                    if (str5 == "granular")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 2.0);
                                    }
                                    else if (str5 == "platy")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 10.0);
                                    }
                                    else if (str5 == "blocky")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 5.0);
                                    }
                                    else if (str5 == "prismatic")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 10.0);
                                    }
                                }
                                else if (str2 == "medium")
                                {
                                    string str6 = str3;
                                    if (str6 == "granular")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 3.0);
                                    }
                                    else if (str6 == "platy")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 25.0);
                                    }
                                    else if (str6 == "blocky")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 10.0);
                                    }
                                    else if (str6 == "prismatic")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 25.0);
                                    }
                                }
                                else if (str2 == "coarse")
                                {
                                    string str7 = str3;
                                    if (str7 == "granular")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 5.0);
                                    }
                                    else if (str7 == "platy")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 50.0);
                                    }
                                    else if (str7 == "blocky")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 25.0);
                                    }
                                    else if (str7 == "prismatic")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 50.0);
                                    }
                                }
                                else
                                {
                                    string str8 = str3;
                                    if (str8 == "granular")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 10.0);
                                    }
                                    else if (str8 == "platy")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 50.0);
                                    }
                                    else if (str8 == "blocky")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 50.0);
                                    }
                                    else if (str8 == "prismatic")
                                    {
                                        GlobalVariables.ascale[num3] = (float) (num2 * 100.0);
                                    }
                                }
                            }
                            GlobalVariables.ascale_c[num3] = 3;
                            this.theta50[num3] = (float) (((double) num16) / Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[num3] * 50.0, (double) GlobalVariables.vg_N[num3]), (double) (1f - (1f / GlobalVariables.vg_N[num3]))));
                            float num = GlobalVariables.tporv[num3] - this.theta50[num3];
                            if (num >= 0f)
                            {
                                if ((GlobalVariables.clay[index] < 16f) & ((GlobalVariables.silt[index] + (GlobalVariables.clay[index] * 2f)) < 31f))
                                {
                                    GlobalVariables.ksatmin[num3] = (num >= 7.5) ? ((float) (((8.03578 - (6.7707 * num)) + (0.833 * Math.Pow((double) num, 2.0))) * 0.41666666666666669)) : ((float) ((0.4535 * Math.Pow((double) num, 1.03423)) * 0.41666666666666669));
                                }
                                else
                                {
                                    num2 = (expression != "none") ? ((expression != "weak") ? ((expression != "moderate") ? ((num <= 10f) ? ((float) Math.Pow(10.0, 1.0 + (0.1 * (10f - num)))) : 10f) : ((num <= 10f) ? ((float) Math.Pow(10.0, 0.7 + (0.05 * (10f - num)))) : 5.011872f)) : ((num <= 10f) ? ((float) Math.Pow(10.0, 0.5 + (0.03 * (10f - num)))) : 3.162278f)) : 1f;
                                    GlobalVariables.ksatmin[num3] = (num >= 4.0) ? ((float) ((((5.8521 - (5.4125 * num)) + (1.05138 * Math.Pow((double) num, 2.0))) * 0.41666666666666669) * num2)) : ((float) (((0.14143 * Math.Exp(0.46944 * num)) * 0.41666666666666669) * num2));
                                }
                                GlobalVariables.ksatmin_c[num3] = 3;
                                index = (short) (index + 1);
                                num3 = (short) (num3 + 1);
                            }
                            else
                            {
                                break;
                            }
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        this.ShowPhysical();
                    }
                    break;
                }
                break;
            }
        }

        public void PedotransferFuncs(ref frmPedotransfer frm)
        {
            frmPedotransfer pedotransfer = frm;
            if (pedotransfer.Check6[4].CheckState == CheckState.Checked)
            {
                this.PedFuncAll_2();
            }
            else
            {
                this.chk = 0;
                short nhorizon = GlobalVariables.Nhorizon;
                short index = 1;
                while (true)
                {
                    short num2;
                    short num3;
                    short num6 = nhorizon;
                    if (index > num6)
                    {
                        break;
                    }
                    if (index == 1)
                    {
                        if (pedotransfer.Check5[(short) (index - 1)].CheckState == CheckState.Checked)
                        {
                            this.chk = -1;
                            num2 = 1;
                            num3 = GlobalVariables.laysum[1];
                            if (pedotransfer.Check6[0].CheckState == CheckState.Checked)
                            {
                                this.pF(ref num2, ref num3, ref 1);
                            }
                            if (pedotransfer.Check6[1].CheckState == CheckState.Checked)
                            {
                                this.Hydraulic(ref num2, ref num3, ref 1, ref true, ref false);
                            }
                            if (pedotransfer.Check6[2].CheckState == CheckState.Checked)
                            {
                                this.Hydraulic(ref num2, ref num3, ref 1, ref false, ref true);
                            }
                            if (pedotransfer.Check6[3].CheckState == CheckState.Checked)
                            {
                                this.Diffusion(ref num2, ref num3, ref 1);
                            }
                        }
                    }
                    else if (pedotransfer.Check5[(short) (index - 1)].CheckState == CheckState.Checked)
                    {
                        this.chk = -1;
                        num2 = (short) (GlobalVariables.laysum[index - 1] + 1);
                        num3 = GlobalVariables.laysum[index];
                        if (pedotransfer.Check6[0].CheckState == CheckState.Checked)
                        {
                            this.pF(ref num2, ref num3, ref index);
                        }
                        if (pedotransfer.Check6[1].CheckState == CheckState.Checked)
                        {
                            this.Hydraulic(ref num2, ref num3, ref index, ref true, ref false);
                        }
                        if (pedotransfer.Check6[2].CheckState == CheckState.Checked)
                        {
                            this.Hydraulic(ref num2, ref num3, ref index, ref false, ref true);
                        }
                        if (pedotransfer.Check6[3].CheckState == CheckState.Checked)
                        {
                            this.Diffusion(ref num2, ref num3, ref index);
                        }
                    }
                    index = (short) (index + 1);
                }
            }
            pedotransfer = null;
            this.ShowPhysical();
        }

        public void pF(ref short ix1, ref short ix2, ref short k)
        {
            short length = k;
            float num3 = (float) (GlobalVariables.orgc[k] * 1.724);
            short start = 1;
            short num8 = 0;
            if (k == 1)
            {
                short num10 = (short) Strings.Len(GlobalVariables.designat[k]);
                length = 1;
                while (true)
                {
                    short num11 = num10;
                    if (length > num11)
                    {
                        break;
                    }
                    if (Strings.Mid(GlobalVariables.designat[k], start, length) == "A")
                    {
                        num8 = 1;
                    }
                    length = (short) (length + 1);
                }
            }
            start = 0;
            length = k;
            GlobalVariables.resid[length] = 0f;
            GlobalVariables.resid_c[length] = 3;
            float num4 = (float) ((((100.0 - GlobalVariables.orgc[k]) * 2.7) + GlobalVariables.orgc[k]) / 100.0);
            GlobalVariables.tporv[length] = (float) (((1.0 - (GlobalVariables.bulk[k] / num4)) * 0.96) * 100.0);
            GlobalVariables.tporv_c[length] = 3;
            float num9 = (float) ((((((((((((0.7919 + (0.001691 * GlobalVariables.clay[k])) - (0.29619 * GlobalVariables.bulk[k])) - (1.491E-06 * Math.Pow((double) GlobalVariables.silt[k], 2.0))) + (8.21E-05 * Math.Pow((double) num3, 2.0))) + (0.02427 / ((double) GlobalVariables.clay[k]))) + (0.01113 / ((double) GlobalVariables.silt[k]))) + (0.01472 * Math.Log((double) GlobalVariables.silt[k]))) - ((7.33E-05 * num3) * GlobalVariables.clay[k])) - ((0.000619 * GlobalVariables.bulk[k]) * GlobalVariables.clay[k])) - ((0.001183 * GlobalVariables.bulk[k]) * num3)) - ((0.0001664 * num8) * GlobalVariables.silt[k])) * 100.0);
            GlobalVariables.cten[length] = 10f;
            GlobalVariables.cten_c[length] = 3;
            float num7 = (float) ((((((((((0.002885 * Math.Pow((double) num3, 2.0)) - (12.81 / ((double) GlobalVariables.bulk[k]))) - (0.1524 / ((double) GlobalVariables.silt[k]))) - (0.01958 / ((double) num3))) - (0.2876 * Math.Log((double) GlobalVariables.silt[k]))) - (0.0709 * Math.Log((double) num3))) - (44.6 * Math.Log((double) GlobalVariables.bulk[k]))) - ((0.02264 * GlobalVariables.bulk[k]) * GlobalVariables.clay[k])) + ((0.0896 * num3) * GlobalVariables.bulk[k])) + ((0.00718 * num8) * GlobalVariables.clay[k]));
            GlobalVariables.vg_N[length] = (float) (Math.Exp((double) ((((float) (((-25.23 - (0.02195 * GlobalVariables.clay[k])) + (0.0074 * GlobalVariables.silt[k])) - (0.194 * num3))) + ((float) (((45.5 * GlobalVariables.bulk[k]) - (7.24 * Math.Pow((double) GlobalVariables.bulk[k], 2.0))) + (0.0003658 * Math.Pow((double) GlobalVariables.clay[k], 2.0))))) + num7)) + 1.0);
            GlobalVariables.zlamb_c[length] = 3;
            GlobalVariables.vg_alpha[length] = Math.Exp((double) ((float) ((((((((((((((-14.96 + (0.03135 * GlobalVariables.clay[k])) + (0.0351 * GlobalVariables.silt[k])) + (0.646 * num3)) + (15.29 * GlobalVariables.bulk[k])) - (0.192 * num8)) - (4.671 * Math.Pow((double) GlobalVariables.bulk[k], 2.0))) - (0.000781 * Math.Pow((double) GlobalVariables.clay[k], 2.0))) - (0.00687 * Math.Pow((double) num3, 2.0))) + (0.0449 / ((double) num3))) + (0.0663 * Math.Log((double) GlobalVariables.silt[k]))) + (0.1482 * Math.Log((double) num3))) - ((0.04546 * GlobalVariables.bulk[k]) * GlobalVariables.silt[k])) - ((0.4852 * num3) * GlobalVariables.bulk[k])) + ((0.00673 * num8) * GlobalVariables.clay[k]))));
            GlobalVariables.scalevg_c[length] = 3;
            GlobalVariables.xmpor[length] = (float) (((double) num9) / Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[length] * GlobalVariables.cten[length], (double) GlobalVariables.vg_N[length]), (double) (1f - (1f / GlobalVariables.vg_N[length]))));
            if ((GlobalVariables.xmpor[length] + 1.0) >= GlobalVariables.tporv[length])
            {
                GlobalVariables.xmpor[length] = GlobalVariables.tporv[length] - ((float) 1.0);
            }
            GlobalVariables.xmpor_c[length] = 3;
            GlobalVariables.wilt[length] = (float) (((double) num9) / Math.Pow(1.0 + Math.Pow(GlobalVariables.vg_alpha[length] * 15000.0, (double) GlobalVariables.vg_N[length]), (double) (1f - (1f / GlobalVariables.vg_N[length]))));
            GlobalVariables.wilt_c[length] = 3;
        }

        private void SaveCropDevelopment()
        {
            short num;
            short num2;
            short num5;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                num = 0;
                short num3 = (short) (((this.cmbYearSW2.SelectedIndex * this.txtCropDev2.Count()) + this.txtCropDev2.Count()) - 1);
                num2 = (short) (this.cmbYearSW2.SelectedIndex * this.txtCropDev2.Count());
                while (true)
                {
                    num5 = num3;
                    if (num2 > num5)
                    {
                        break;
                    }
                    GlobalVariables.CropDevelopment2[num2] = (float) Conversions.ToDouble(this.txtCropDev2[num].Text);
                    num = (short) (num + 1);
                    num2 = (short) (num2 + 1);
                }
            }
            else if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                num = 0;
                short num4 = (short) (((this.cmbYearSW3.SelectedIndex * this.txtCropDev3.Count()) + this.txtCropDev3.Count()) - 1);
                num2 = (short) (this.cmbYearSW3.SelectedIndex * this.txtCropDev3.Count());
                while (true)
                {
                    num5 = num4;
                    if (num2 > num5)
                    {
                        break;
                    }
                    GlobalVariables.CropDevelopment3[num2] = (float) Conversions.ToDouble(this.txtCropDev3[num].Text);
                    num = (short) (num + 1);
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private void SetDefinitionYears()
        {
            this.lblIrrigationYears.Text = this.optDefinitionType[1].Checked ? Support.GetItemString(this.lstYearSubSets, this.m_CurrIrrGroup - 1) : "All years.";
        }

        private void SetDEG(ref short row, ref float[] degrate, ref float frac)
        {
            short col = 5;
            while (true)
            {
                object obj2 = degrate[col - 4] * frac;
                string fmt = "0.0000E+00";
                this.flx_Parameters[5].set_TextMatrix(row, col, Indump.rformat(ref obj2, ref fmt));
                col = (short) (col + 1);
                short num2 = 8;
                if (col > num2)
                {
                    return;
                }
            }
        }

        private void SetGroupArray()
        {
            GlobalVariables.Groups = new short[((this.frmMain.frmSetup.dtEndDate.Value.Year - this.frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1, ((this.frmMain.frmSetup.dtEndDate.Value.Year - this.frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1];
            short count = (short) this.lstYearSubSets.Items.Count;
            short num = 1;
            while (true)
            {
                short num6 = count;
                if (num > num6)
                {
                    return;
                }
                short start = 1;
                string str = Strings.Trim(Support.GetItemString(this.lstYearSubSets, num - 1));
                short num4 = (short) Strings.InStr(start, str, " ", CompareMethod.Binary);
                short num2 = 0;
                while (true)
                {
                    if (num4 == 0)
                    {
                        GlobalVariables.Groups[num, (short) (num2 + 1)] = Conversions.ToShort(Strings.Mid(str, start));
                        num = (short) (num + 1);
                        break;
                    }
                    num2 = (short) (num2 + 1);
                    GlobalVariables.Groups[num, num2] = Conversions.ToShort(Strings.Mid(str, start, (short) (num4 - start)));
                    start = num4;
                    num4 = (short) Strings.InStr(start + 1, str, " ", CompareMethod.Binary);
                }
            }
        }

        private void SetInitialYearsForIHARVandIDSTART()
        {
            GlobalVariables.YearsForIDSTART = new int[GlobalVariables.NumOfYears + 1];
            GlobalVariables.YearsForIHARV = new int[GlobalVariables.NumOfYears + 1];
            int year = this.frmMain.frmSetup.dtStartDate.Value.Year;
            int numOfYears = GlobalVariables.NumOfYears;
            int index = 1;
            while (true)
            {
                int num5 = numOfYears;
                if (index > num5)
                {
                    return;
                }
                if (index > 1)
                {
                    if (GlobalVariables.idstart[index] > GlobalVariables.iharv[index - 1])
                    {
                        GlobalVariables.YearsForIDSTART[index] = GlobalVariables.YearsForIHARV[index - 1];
                        GlobalVariables.YearsForIHARV[index] = (GlobalVariables.iharv[index] <= GlobalVariables.idstart[index]) ? (GlobalVariables.YearsForIDSTART[index] + 1) : GlobalVariables.YearsForIDSTART[index];
                    }
                    else
                    {
                        GlobalVariables.YearsForIDSTART[index] = GlobalVariables.YearsForIHARV[index - 1] + 1;
                        GlobalVariables.YearsForIHARV[index] = (GlobalVariables.iharv[index] <= GlobalVariables.idstart[index]) ? (GlobalVariables.YearsForIDSTART[index] + 1) : GlobalVariables.YearsForIDSTART[index];
                    }
                }
                else if (GlobalVariables.iharv[index] >= GlobalVariables.idstart[index])
                {
                    GlobalVariables.YearsForIDSTART[index] = year;
                    GlobalVariables.YearsForIHARV[index] = year;
                }
                else
                {
                    GlobalVariables.YearsForIDSTART[index] = year - 1;
                    GlobalVariables.YearsForIHARV[index] = year;
                    year++;
                }
                index++;
            }
        }

        private void SetTempIDSTARTandIHARV()
        {
            this.tmp_idstart = new int[GlobalVariables.NumOfYears + 1];
            this.tmp_iharv = new int[GlobalVariables.NumOfYears + 1];
            int numOfYears = GlobalVariables.NumOfYears;
            int index = 1;
            while (true)
            {
                int num3 = numOfYears;
                if (index > num3)
                {
                    return;
                }
                this.tmp_idstart[index] = GlobalVariables.idstart[index];
                this.tmp_iharv[index] = this.tmp_iharv[index];
                index++;
            }
        }

        private void SetYearsForIHARVandIDSTART()
        {
            GlobalVariables.YearsForIDSTART = new int[(this.flx_Parameters[0].Rows - 1) + 1];
            GlobalVariables.YearsForIHARV = new int[(this.flx_Parameters[0].Rows - 1) + 1];
            int year = this.frmMain.frmSetup.dtStartDate.Value.Year;
            this.tmp_idstart = new int[(this.flx_Parameters[0].Rows - 1) + 1];
            this.tmp_iharv = new int[(this.flx_Parameters[0].Rows - 1) + 1];
            int num4 = this.flx_Parameters[0].Rows - 1;
            int index = 1;
            while (true)
            {
                int num5 = num4;
                if (index > num5)
                {
                    return;
                }
                this.tmp_idstart[index] = Conversions.ToShort(this.flx_Parameters[0].get_TextMatrix(index, 2));
                this.tmp_iharv[index] = Conversions.ToShort(this.flx_Parameters[0].get_TextMatrix(index, 6));
                if (index > 1)
                {
                    if (this.tmp_idstart[index] > this.tmp_iharv[index - 1])
                    {
                        GlobalVariables.YearsForIDSTART[index] = GlobalVariables.YearsForIHARV[index - 1];
                        GlobalVariables.YearsForIHARV[index] = (this.tmp_iharv[index] <= this.tmp_idstart[index]) ? (GlobalVariables.YearsForIDSTART[index] + 1) : GlobalVariables.YearsForIDSTART[index];
                    }
                    else
                    {
                        GlobalVariables.YearsForIDSTART[index] = GlobalVariables.YearsForIHARV[index - 1] + 1;
                        GlobalVariables.YearsForIHARV[index] = (this.tmp_iharv[index] <= this.tmp_idstart[index]) ? (GlobalVariables.YearsForIDSTART[index] + 1) : GlobalVariables.YearsForIDSTART[index];
                    }
                }
                else if (this.tmp_iharv[index] >= this.tmp_idstart[index])
                {
                    GlobalVariables.YearsForIDSTART[index] = year;
                    GlobalVariables.YearsForIHARV[index] = year;
                }
                else
                {
                    GlobalVariables.YearsForIDSTART[index] = year - 1;
                    GlobalVariables.YearsForIHARV[index] = year;
                    year++;
                }
                index++;
            }
        }

        public void ShowAll()
        {
            if (!this.IsInitializing)
            {
                this.UserEdit = false;
                this.bLoading = true;
                this.Pedotransfer = false;
                this.tabort = 0;
                this.Frame2.Visible = true;
                this.Refresh();
                Cursor.Current = Cursors.WaitCursor;
                this.SSTab1.SelectedIndex = 1;
                short num3 = (short) (this.flx_Parameters.Count() - 1);
                short num2 = 0;
                while (true)
                {
                    short num6 = num3;
                    if (num2 > num6)
                    {
                        short num = 0;
                        while (true)
                        {
                            this.Check1[num].Visible = true;
                            num = (short) (num + 1);
                            num6 = 8;
                            if (num > num6)
                            {
                                short num4 = (short) (this.flx_Parameters.Count() - 1);
                                num = 0;
                                while (true)
                                {
                                    num6 = num4;
                                    if (num > num6)
                                    {
                                        num = 0;
                                        while (true)
                                        {
                                            this.text1[num].Visible = false;
                                            this.Label1[num].Visible = false;
                                            num = (short) (num + 1);
                                            num6 = 3;
                                            if (num > num6)
                                            {
                                                num = 7;
                                                while (true)
                                                {
                                                    this.Text4[num].Visible = false;
                                                    this.Label11[num].Visible = false;
                                                    num = (short) (num + 1);
                                                    num6 = 12;
                                                    if (num > num6)
                                                    {
                                                        num = 0;
                                                        while (true)
                                                        {
                                                            this.text12[num].Visible = false;
                                                            num = (short) (num + 1);
                                                            num6 = 0x13;
                                                            if (num > num6)
                                                            {
                                                                this.ShowNumerical();
                                                                this.ShowIBConditions();
                                                                this.ShowPhysical();
                                                                if (GlobalVariables.sw_irrigate != MACROConstants.Switch.BareSoil)
                                                                {
                                                                    this.SSTab1.TabPages[2].Enabled = false;
                                                                }
                                                                else
                                                                {
                                                                    this.SSTab1.TabPages[2].Enabled = true;
                                                                    this.ShowIrr(ref GlobalVariables.Groups[1, 1]);
                                                                }
                                                                this.SSTab1.TabPages[5].Enabled = true;
                                                                if ((GlobalVariables.sw_solute == MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_immobile < MACROConstants.Switch.Annual))
                                                                {
                                                                    this.SSTab1.TabPages[5].Enabled = false;
                                                                }
                                                                else
                                                                {
                                                                    this.ShowSolute();
                                                                }
                                                                if (GlobalVariables.sw_crop == MACROConstants.Switch.BareSoil)
                                                                {
                                                                    this.SSTab1.TabPages[0].Enabled = false;
                                                                }
                                                                else
                                                                {
                                                                    this.SSTab1.TabPages[0].Enabled = true;
                                                                    this.ShowCrop();
                                                                }
                                                                this.SSTab1.TabPages[6].Enabled = GlobalVariables.sw_management != MACROConstants.Switch.NoMetabolite;
                                                                if (GlobalVariables.sw_management != MACROConstants.Switch.NoMetabolite)
                                                                {
                                                                    if (GlobalVariables.NTILL == 0)
                                                                    {
                                                                        GlobalVariables.NTILL = 1;
                                                                    }
                                                                    this.bLoading = true;
                                                                    this.ShowManagement();
                                                                    this.bLoading = false;
                                                                }
                                                                this.showSite();
                                                                this.SSTab1.SelectedIndex = 4;
                                                                Cursor.Current = Cursors.Default;
                                                                this.UserEdit = true;
                                                                this.bLoading = false;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    }
                                                }
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    this.txtBox[num].Visible = false;
                                    num = (short) (num + 1);
                                }
                                break;
                            }
                        }
                        break;
                    }
                    this.flx_Parameters[num2].Clear();
                    num2 = (short) (num2 + 1);
                }
            }
        }

        public void ShowCrop()
        {
            short num6 = 0;
            short numOfYears = GlobalVariables.NumOfYears;
            short index = 1;
            while (true)
            {
                short num15 = numOfYears;
                if (index > num15)
                {
                    short num;
                    short num3;
                    short num4;
                    short cols;
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                    {
                        GlobalVariables.CropDevelopment2 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment2, new float[((short) (GlobalVariables.NumOfYears * this.txtCropDev2.Count())) + 1]);
                    }
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
                    {
                        GlobalVariables.CropDevelopment3 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment3, new float[((short) (GlobalVariables.NumOfYears * this.txtCropDev2.Count())) + 1]);
                    }
                    this.flx_Parameters[0].Rows = GlobalVariables.NumOfYears + 1;
                    this.flx_Parameters[0].Cols = 2;
                    this.flx_Parameters[0].set_ColWidth(0, 900);
                    this.flx_Parameters[0].set_TextMatrix(0, 0, "Crop no.");
                    this.flx_Parameters[0].set_ColWidth(1, 0x7d0);
                    this.flx_Parameters[0].set_TextMatrix(0, 1, "Crop");
                    if (GlobalVariables.sw_crop != MACROConstants.Switch.Annual)
                    {
                        if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
                        {
                            num = 0;
                            GlobalVariables.CropDevelopment3 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment3, new float[((short) (GlobalVariables.NumOfYears * this.txtCropDev3.Count())) + 1]);
                            if (this.bLoading)
                            {
                                short num11 = this.txtCropDev3.Count();
                                short num10 = (short) (((short) (GlobalVariables.NumOfYears * this.txtCropDev3.Count())) - 1);
                                index = 0;
                                while (true)
                                {
                                    num15 = (short) ((num11 >> 15) ^ num10);
                                    if (((num11 >> 15) ^ index) > num15)
                                    {
                                        break;
                                    }
                                    num = (short) (num + 1);
                                    GlobalVariables.CropDevelopment3[index] = GlobalVariables.rootdep[num];
                                    GlobalVariables.CropDevelopment3[index + 1] = GlobalVariables.laic[num];
                                    GlobalVariables.CropDevelopment3[index + 2] = GlobalVariables.hcrop[num];
                                    index = (short) (index + num11);
                                }
                            }
                        }
                    }
                    else
                    {
                        this.SetInitialYearsForIHARVandIDSTART();
                        this.flx_Parameters[0].Cols = 8;
                        this.flx_Parameters[0].set_TextMatrix(0, 2, "IDSTART");
                        this.flx_Parameters[0].set_TextMatrix(0, 3, "STARTYEAR");
                        this.flx_Parameters[0].set_TextMatrix(0, 4, "ZDATEMIN");
                        this.flx_Parameters[0].set_TextMatrix(0, 5, "IDMAX");
                        this.flx_Parameters[0].set_TextMatrix(0, 6, "IHARV");
                        this.flx_Parameters[0].set_TextMatrix(0, 7, "HARVYEAR");
                        num4 = 4;
                        if (num6 == -1)
                        {
                            this.flx_Parameters[0].Cols = 12;
                            this.flx_Parameters[0].set_ColWidth(7, 0x4b0);
                            this.flx_Parameters[0].set_TextMatrix(0, 8, "IDSTART2");
                            this.flx_Parameters[0].set_TextMatrix(0, 9, "ZDATEMIN2");
                            this.flx_Parameters[0].set_TextMatrix(0, 10, "IDMAX2");
                            this.flx_Parameters[0].set_TextMatrix(0, 11, "IHARV2");
                            num4 = (short) (num4 + 4);
                        }
                        num3 = num4;
                        GlobalVariables.CropDevelopment2 = (float[]) Utils.CopyArray((Array) GlobalVariables.CropDevelopment2, new float[((short) (GlobalVariables.NumOfYears * this.txtCropDev2.Count())) + 1]);
                        num = 0;
                        if (this.bLoading)
                        {
                            short num9 = this.txtCropDev2.Count();
                            short num8 = (short) (((short) (GlobalVariables.NumOfYears * this.txtCropDev2.Count())) - 1);
                            index = 0;
                            while (true)
                            {
                                num15 = (short) ((num9 >> 15) ^ num8);
                                if (((num9 >> 15) ^ index) > num15)
                                {
                                    break;
                                }
                                num = (short) (num + 1);
                                GlobalVariables.CropDevelopment2[index] = GlobalVariables.rootinit[num];
                                GlobalVariables.CropDevelopment2[index + 1] = GlobalVariables.rootmax[num];
                                GlobalVariables.CropDevelopment2[index + 2] = GlobalVariables.rootmax[num];
                                GlobalVariables.CropDevelopment2[index + 3] = GlobalVariables.laimin[num];
                                GlobalVariables.CropDevelopment2[index + 4] = GlobalVariables.laimax[num];
                                GlobalVariables.CropDevelopment2[index + 5] = GlobalVariables.laihar[num];
                                GlobalVariables.CropDevelopment2[index + 6] = GlobalVariables.zhmin[num];
                                if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                                {
                                    this.txtCropDev2[7].Enabled = true;
                                    GlobalVariables.CropDevelopment2[index + 7] = GlobalVariables.hmax[num];
                                    GlobalVariables.CropDevelopment2[index + 8] = GlobalVariables.hmax[num];
                                }
                                index = (short) (index + num9);
                            }
                        }
                    }
                    this.flx_Parameters[0].LeftCol = 1;
                    if (!this.bSkip)
                    {
                        short num12 = GlobalVariables.NumOfYears;
                        index = 1;
                        while (true)
                        {
                            num15 = num12;
                            if (index > num15)
                            {
                                break;
                            }
                            this.flx_Parameters[0].Row = index;
                            this.flx_Parameters[0].RowSel = index;
                            this.flx_Parameters[0].set_TextMatrix(index, 0, Conversions.ToString((int) index));
                            this.flx_Parameters[0].set_TextMatrix(index, 1, GlobalVariables.cropname[index]);
                            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                            {
                                this.flx_Parameters[0].set_TextMatrix(index, 2, Conversions.ToString((int) GlobalVariables.idstart[index]));
                                this.flx_Parameters[0].Col = 2;
                                this.flx_Parameters[0].ColSel = 2;
                                this.qb_c = 0;
                                if (GlobalVariables.idstart_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.idstart_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, 3, Conversions.ToString(GlobalVariables.YearsForIDSTART[index]));
                                this.flx_Parameters[0].Col = 3;
                                this.flx_Parameters[0].ColSel = 3;
                                this.flx_Parameters[0].set_TextMatrix(index, 4, Conversions.ToString((int) GlobalVariables.zdatemin[index]));
                                this.flx_Parameters[0].Col = 4;
                                this.flx_Parameters[0].ColSel = 4;
                                this.qb_c = 0;
                                if (GlobalVariables.zdatemin_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.zdatemin_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, 5, Conversions.ToString((int) GlobalVariables.idmax[index]));
                                this.flx_Parameters[0].Col = 5;
                                this.flx_Parameters[0].ColSel = 5;
                                this.qb_c = 0;
                                if (GlobalVariables.idmax_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.idmax_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, 6, Conversions.ToString((int) GlobalVariables.iharv[index]));
                                this.flx_Parameters[0].Col = 6;
                                this.flx_Parameters[0].ColSel = 6;
                                this.qb_c = 0;
                                if (GlobalVariables.iharv_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.iharv_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, 7, Conversions.ToString(GlobalVariables.YearsForIHARV[index]));
                                this.flx_Parameters[0].Col = 7;
                                this.flx_Parameters[0].ColSel = 7;
                                if (GlobalVariables.ncrop[index] == 2)
                                {
                                    this.flx_Parameters[0].set_TextMatrix(index, 8, Conversions.ToString((int) GlobalVariables.idstart2[index]));
                                    this.flx_Parameters[0].Col = 8;
                                    this.flx_Parameters[0].ColSel = 8;
                                    this.qb_c = 0;
                                    if (GlobalVariables.idstart2_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.idstart2_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, 9, Conversions.ToString((int) GlobalVariables.zdatemin2[index]));
                                    this.flx_Parameters[0].Col = 9;
                                    this.flx_Parameters[0].ColSel = 9;
                                    this.qb_c = 0;
                                    if (GlobalVariables.zdatemin2_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.zdatemin2_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, 10, Conversions.ToString((int) GlobalVariables.idmax2[index]));
                                    this.flx_Parameters[0].Col = 10;
                                    this.flx_Parameters[0].ColSel = 10;
                                    this.qb_c = 0;
                                    if (GlobalVariables.idmax2_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.idmax2_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, 11, Conversions.ToString((int) GlobalVariables.iharv2[index]));
                                    this.flx_Parameters[0].Col = 11;
                                    this.flx_Parameters[0].ColSel = 11;
                                    this.qb_c = 0;
                                    if (GlobalVariables.iharv2_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.iharv2_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                            }
                            index = (short) (index + 1);
                        }
                    }
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                    {
                        cols = (short) this.flx_Parameters[0].Cols;
                        this.flx_Parameters[0].Cols += 8;
                        this.flx_Parameters[0].set_TextMatrix(0, cols, "CFORM");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 1, "DFORM");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 2, "RPIN");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 3, "FAWC");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 4, "CRITAIR");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 5, "BETA");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 6, "CANCAP");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 7, "ZALP");
                        if (GlobalVariables.sw_evaporate != MACROConstants.Switch.Annual)
                        {
                            this.flx_Parameters[0].Cols = cols + 8;
                        }
                        else
                        {
                            cols = (short) this.flx_Parameters[0].Cols;
                            this.flx_Parameters[0].Cols = cols + 4;
                            this.flx_Parameters[0].set_TextMatrix(0, cols, "ATTEN");
                            this.flx_Parameters[0].set_TextMatrix(0, cols + 1, "RSMIN");
                            this.flx_Parameters[0].set_TextMatrix(0, cols + 2, "RI50");
                            this.flx_Parameters[0].set_TextMatrix(0, cols + 3, "VPD50");
                        }
                        if (!this.bSkip)
                        {
                            this.cmbYearSW2.Items.Clear();
                            this.cmbYearSW3.Items.Clear();
                            this.cmbDeleteYear.Items.Clear();
                        }
                        if (!this.bSkip)
                        {
                            short num13 = GlobalVariables.NumOfYears;
                            index = 1;
                            while (true)
                            {
                                num15 = num13;
                                if (index > num15)
                                {
                                    break;
                                }
                                this.cmbYearSW2.Items.Add(Conversions.ToString((int) index));
                                this.cmbYearSW3.Items.Add(Conversions.ToString((int) index));
                                this.cmbDeleteYear.Items.Add(Conversions.ToString((int) index));
                                num4 = (short) (num3 + 4);
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.cform[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.cform_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.cform_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.dform[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.dform_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.dform_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.rpin[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.rpin_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.rpin_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.fawc[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.fawc_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.fawc_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.critair[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.critair_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.critair_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.beta[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.beta_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.beta_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.cancap[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.cancap_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.cancap_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.zalp[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.zalp_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.zalp_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                                {
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.atten[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.atten_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.atten_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.rsmin[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.rsmin_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.rsmin_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.ri50[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.ri50_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.ri50_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.vpd50[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.vpd50_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.vpd50_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                index = (short) (index + 1);
                            }
                        }
                    }
                    if (GlobalVariables.sw_crop > MACROConstants.Switch.Annual)
                    {
                        cols = (short) this.flx_Parameters[0].Cols;
                        this.flx_Parameters[0].Cols += 6;
                        this.flx_Parameters[0].set_TextMatrix(0, cols, "RPIN");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 1, "FAWC");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 2, "CRITAIR");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 3, "BETA");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 4, "CANCAP");
                        this.flx_Parameters[0].set_TextMatrix(0, cols + 5, "ZALP");
                        if (GlobalVariables.sw_evaporate != MACROConstants.Switch.Annual)
                        {
                            this.flx_Parameters[0].Cols = cols + 6;
                        }
                        else
                        {
                            this.flx_Parameters[0].Cols = cols + 8;
                            this.flx_Parameters[0].set_TextMatrix(0, cols + 6, "ATTEN");
                            this.flx_Parameters[0].set_TextMatrix(0, cols + 7, "RSURF");
                        }
                        this.cmbYearSW2.Items.Clear();
                        this.cmbYearSW3.Items.Clear();
                        this.cmbDeleteYear.Items.Clear();
                        if (!this.bSkip)
                        {
                            short num14 = GlobalVariables.NumOfYears;
                            index = 1;
                            while (true)
                            {
                                num15 = num14;
                                if (index > num15)
                                {
                                    break;
                                }
                                this.flx_Parameters[0].Row = index;
                                this.flx_Parameters[0].RowSel = index;
                                this.flx_Parameters[0].set_TextMatrix(index, 0, Conversions.ToString((int) GlobalVariables.Y_ear[index]));
                                this.cmbYearSW2.Items.Add(Conversions.ToString((int) GlobalVariables.Y_ear[index]));
                                this.cmbYearSW3.Items.Add(Conversions.ToString((int) GlobalVariables.Y_ear[index]));
                                this.cmbDeleteYear.Items.Add(Conversions.ToString((int) GlobalVariables.Y_ear[index]));
                                num4 = (short) (num3 + 2);
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.rpin[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.rpin_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.rpin_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.fawc[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.fawc_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.fawc_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.critair[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.critair_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.critair_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.beta[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.beta_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.beta_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.cancap[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.cancap_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.cancap_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.zalp[index]));
                                this.flx_Parameters[0].Col = num4;
                                this.flx_Parameters[0].ColSel = num4;
                                num4 = (short) (num4 + 1);
                                this.qb_c = 0;
                                if (GlobalVariables.zalp_c[index] == 2)
                                {
                                    this.qb_c = 2;
                                }
                                if (GlobalVariables.zalp_c[index] == 3)
                                {
                                    this.qb_c = 12;
                                }
                                this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                                {
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.atten[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.atten_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.atten_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    this.flx_Parameters[0].set_TextMatrix(index, num4, Conversions.ToString(GlobalVariables.rsurf[index]));
                                    this.flx_Parameters[0].Col = num4;
                                    this.flx_Parameters[0].ColSel = num4;
                                    num4 = (short) (num4 + 1);
                                    this.qb_c = 0;
                                    if (GlobalVariables.rsurf_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.rsurf_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[0].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                index = (short) (index + 1);
                            }
                        }
                    }
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                    {
                        this.fraCropSW2.Visible = true;
                        this.fraCropSw3.Visible = false;
                    }
                    else
                    {
                        this.fraCropSW2.Visible = false;
                        this.fraCropSw3.Visible = true;
                        this.fraCropSw3.Left = 0x21f;
                        this.fraCropSw3.Top = 3;
                    }
                    if (GlobalVariables.sw_evaporate == MACROConstants.Switch.BareSoil)
                    {
                        this.txtCropDev2[6].Visible = false;
                        this.txtCropDev2[7].Visible = false;
                    }
                    else
                    {
                        this.txtCropDev2[6].Visible = true;
                        this.txtCropDev2[7].Visible = true;
                    }
                    this.ShowCropDevelopment();
                    this.cmbYearSW2.SelectedIndex = 0;
                    this.cmbYearSW3.SelectedIndex = 0;
                    this.cmbDeleteYear.SelectedIndex = 0;
                    return;
                }
                if (GlobalVariables.ncrop[index] == 2)
                {
                    num6 = -1;
                }
                index = (short) (index + 1);
            }
        }

        private void ShowCropDevelopment()
        {
            short num;
            short num2;
            short num5;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                num2 = (this.cmbYearSW2.SelectedIndex != -1) ? ((short) (this.cmbYearSW2.SelectedIndex * this.txtCropDev2.Count())) : 0;
                short num3 = (short) (((short) (num2 + this.txtCropDev2.Count())) - 1);
                num = num2;
                while (true)
                {
                    num5 = num3;
                    if (num > num5)
                    {
                        break;
                    }
                    this.txtCropDev2[(short) (num - num2)].Text = Conversions.ToString(GlobalVariables.CropDevelopment2[num]);
                    num = (short) (num + 1);
                }
            }
            else if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                num2 = (this.cmbYearSW3.SelectedIndex != -1) ? ((short) (this.cmbYearSW3.SelectedIndex * this.txtCropDev3.Count())) : 0;
                short num4 = (short) (((short) (num2 + this.txtCropDev3.Count())) - 1);
                num = num2;
                while (true)
                {
                    num5 = num4;
                    if (num > num5)
                    {
                        break;
                    }
                    this.txtCropDev3[(short) (num - num2)].Text = Conversions.ToString(GlobalVariables.CropDevelopment3[num]);
                    num = (short) (num + 1);
                }
            }
        }

        public void ShowIBConditions()
        {
            if (GlobalVariables.sw_vartension == MACROConstants.Switch.NoMetabolite)
            {
                this.txtTensionFile.Visible = false;
                this.cmdBrowseForTensionFile.Visible = false;
            }
            short index = -1;
            this.text1[4].Text = Conversions.ToString(GlobalVariables.cons_sta);
            this.text1[4].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.cons_sta_c)));
            this.text1[5].Text = Conversions.ToString(GlobalVariables.i_ascale);
            this.text1[5].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.i_ascale_c)));
            this.text1[4].Visible = false;
            this.text1[5].Visible = false;
            this.Label1[4].Visible = false;
            this.Label1[5].Visible = false;
            if (GlobalVariables.sw_boundary == MACROConstants.Switch.BareSoil)
            {
                index = (short) (index + 1);
                this.text1[index].Visible = true;
                this.text1[index].Text = Conversions.ToString(GlobalVariables.bgrad);
                if (GlobalVariables.bgrad_c == 2)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.bgrad_c == 3)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label1[index].Visible = true;
                this.Label1[index].Text = "GRAD";
            }
            if (((GlobalVariables.sw_boundary > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_boundary < MACROConstants.Switch.LysimeterWithFreeDrainage)) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil))
            {
                index = (short) (index + 1);
                this.text1[index].Visible = true;
                this.text1[index].Text = Conversions.ToString(GlobalVariables.concin);
                if (GlobalVariables.concin_c == 2)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.concin_c == 3)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label1[index].Visible = true;
                this.Label1[index].Text = "CONCIN";
            }
            if (GlobalVariables.sw_boundary == MACROConstants.Switch.Perennial)
            {
                index = (short) (index + 1);
                this.text1[index].Visible = true;
                this.text1[index].Text = Conversions.ToString(GlobalVariables.Area);
                if (GlobalVariables.area_c == 2)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.area_c == 3)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label1[index].Visible = true;
                this.Label1[index].Text = "AREA";
                index = (short) (index + 1);
                this.text1[index].Visible = true;
                this.text1[index].Text = Conversions.ToString(GlobalVariables.gwflux);
                if (GlobalVariables.gwflux_c == 2)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.gwflux_c == 3)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label1[index].Visible = true;
                this.Label1[index].Text = "BGRAD";
            }
            if (GlobalVariables.sw_boundary == MACROConstants.Switch.Tritium)
            {
                if (GlobalVariables.sw_vartension != MACROConstants.Switch.NoMetabolite)
                {
                    index = (short) (index + 1);
                    this.txtTensionFile.Visible = true;
                    this.cmdBrowseForTensionFile.Visible = true;
                    this.txtTensionFile.Text = GlobalVariables.TensionFile;
                    this.Label1[index].Visible = true;
                    this.Label1[index].Text = "BOTEN";
                }
                else
                {
                    index = (short) (index + 1);
                    this.text1[index].Visible = true;
                    this.text1[index].Text = Conversions.ToString(GlobalVariables.boten);
                    if (GlobalVariables.boten_c == 2)
                    {
                        this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                    }
                    if (GlobalVariables.boten_c == 3)
                    {
                        this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                    }
                    this.Label1[index].Visible = true;
                    this.Label1[index].Text = "BOTEN";
                }
            }
            if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
            {
                index = (short) (index + 1);
                this.text1[index].Visible = true;
                this.text1[index].Text = Conversions.ToString(GlobalVariables.partinit);
                if (GlobalVariables.partinit_c == 2)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.partinit_c == 3)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label1[index].Visible = true;
                this.Label1[index].Text = "PARTINIT";
            }
            GlobalVariables.num_boundary = index;
            this.flx_Parameters[2].Cols = 3;
            this.flx_Parameters[2].set_TextMatrix(0, 0, "Horizon");
            this.flx_Parameters[2].set_TextMatrix(0, 1, "Upper");
            this.flx_Parameters[2].set_TextMatrix(0, 2, "Lower");
            if (GlobalVariables.sw_tempini == MACROConstants.Switch.NoMetabolite)
            {
                this.flx_Parameters[2].Cols++;
                this.flx_Parameters[2].set_TextMatrix(0, this.flx_Parameters[2].Cols - 1, "TEMPINI");
            }
            this.optVariableToCopy[0].Text = "TEMPINI";
            this.optVariableToCopy[1].Text = "SOLINIT";
            this.optVariableToCopy[2].Text = "THETAINI";
            this.optVariableToCopy[0].Enabled = true;
            this.optVariableToCopy[0].Visible = GlobalVariables.sw_tempini == MACROConstants.Switch.NoMetabolite;
            if (GlobalVariables.sw_initial != MACROConstants.Switch.Annual)
            {
                this.optVariableToCopy[2].Visible = false;
            }
            else
            {
                this.flx_Parameters[2].Cols++;
                this.flx_Parameters[2].set_TextMatrix(0, this.flx_Parameters[2].Cols - 1, "THETAINI");
                this.optVariableToCopy[2].Visible = true;
            }
            if (GlobalVariables.sw_solute <= MACROConstants.Switch.BareSoil)
            {
                this.optVariableToCopy[1].Visible = false;
            }
            else
            {
                this.flx_Parameters[2].Cols++;
                this.flx_Parameters[2].set_TextMatrix(0, this.flx_Parameters[2].Cols - 1, "SOLINIT");
                this.optVariableToCopy[1].Visible = true;
            }
            this.flx_Parameters[2].Rows = GlobalVariables.TotalLayers + 1;
            GlobalVariables.laysum[1] = GlobalVariables.N_Layer[1];
            short nhorizon = GlobalVariables.Nhorizon;
            index = 2;
            while (true)
            {
                short num10 = nhorizon;
                if (index > num10)
                {
                    float expression = 0f;
                    short num3 = 1;
                    short num6 = GlobalVariables.N_NUMERICAL_LAYERS;
                    index = 1;
                    while (true)
                    {
                        num10 = num6;
                        if (index > num10)
                        {
                            short totalLayers = GlobalVariables.TotalLayers;
                            short row = 1;
                            while (true)
                            {
                                num10 = totalLayers;
                                if (row > num10)
                                {
                                    short num8 = GlobalVariables.Nhorizon;
                                    index = 1;
                                    while (true)
                                    {
                                        num10 = num8;
                                        if (index > num10)
                                        {
                                            short num9 = this.Check1.Count();
                                            index = (short) (GlobalVariables.Nhorizon + 1);
                                            while (true)
                                            {
                                                num10 = num9;
                                                if (index > num10)
                                                {
                                                    return;
                                                }
                                                this.Check1[(short) (index - 1)].Visible = false;
                                                index = (short) (index + 1);
                                            }
                                        }
                                        this.Check1[(short) (index - 1)].Text = GlobalVariables.designat[index];
                                        this.Check1[(short) (index - 1)].Visible = true;
                                        index = (short) (index + 1);
                                    }
                                }
                                if (GlobalVariables.sw_tempini != MACROConstants.Switch.NoMetabolite)
                                {
                                    this.CalcTempIni();
                                }
                                else
                                {
                                    this.flx_Parameters[2].set_TextMatrix(row, 3, Support.Format(GlobalVariables.tempini[row], "##0.0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                                    this.flx_Parameters[2].Col = 3;
                                    this.flx_Parameters[2].Row = row;
                                    this.flx_Parameters[2].ColSel = 3;
                                    this.flx_Parameters[2].RowSel = row;
                                    this.qb_c = 0;
                                    if (GlobalVariables.tempini_c[row] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.tempini_c[row] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[2].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if (GlobalVariables.sw_initial == MACROConstants.Switch.Annual)
                                {
                                    if (GlobalVariables.sw_tempini == MACROConstants.Switch.NoMetabolite)
                                    {
                                        this.flx_Parameters[2].set_TextMatrix(row, 4, Conversions.ToString(GlobalVariables.thetaini[row]));
                                        this.flx_Parameters[2].Col = 4;
                                        this.flx_Parameters[2].ColSel = 4;
                                    }
                                    else
                                    {
                                        this.flx_Parameters[2].set_TextMatrix(row, 3, Conversions.ToString(GlobalVariables.thetaini[row]));
                                        this.flx_Parameters[2].Col = 3;
                                        this.flx_Parameters[2].ColSel = 3;
                                    }
                                    this.qb_c = 0;
                                    if (GlobalVariables.thetaini_c[row] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.thetaini_c[row] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[2].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                                {
                                    this.flx_Parameters[2].set_TextMatrix(row, this.flx_Parameters[2].Cols - 1, Conversions.ToString(GlobalVariables.solinit[row]));
                                    this.flx_Parameters[2].Col = this.flx_Parameters[2].Cols - 1;
                                    this.flx_Parameters[2].ColSel = this.flx_Parameters[2].Cols - 1;
                                    this.qb_c = 0;
                                    if (GlobalVariables.solinit_c[row] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.solinit_c[row] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    this.flx_Parameters[2].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                row = (short) (row + 1);
                            }
                        }
                        if (index <= GlobalVariables.laysum[num3])
                        {
                            this.flx_Parameters[2].set_TextMatrix(index, 0, GlobalVariables.designat[num3]);
                        }
                        else
                        {
                            num3 = (short) (num3 + 1);
                            this.flx_Parameters[2].set_TextMatrix(index, 0, GlobalVariables.designat[num3]);
                        }
                        this.flx_Parameters[2].set_TextMatrix(index, 1, Support.Format(expression, "##0.0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                        this.flx_Parameters[2].set_TextMatrix(index, 2, Support.Format(expression + GlobalVariables.Z[index], "##0.0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                        index = (short) (index + 1);
                    }
                }
                GlobalVariables.laysum[index] = (short) (GlobalVariables.laysum[index - 1] + GlobalVariables.N_Layer[index]);
                index = (short) (index + 1);
            }
        }

        public void ShowIrr(ref short yearno)
        {
            short num3;
            short num9;
            string item = "";
            short num4 = (short) Information.UBound(GlobalVariables.Groups, 1);
            short row = 1;
            while (row <= num4)
            {
                short num5 = (short) Information.UBound(GlobalVariables.Groups, 1);
                num3 = 1;
                while (true)
                {
                    num9 = num5;
                    if (num3 > num9)
                    {
                        row = (short) (row + 1);
                        break;
                    }
                    if (GlobalVariables.Groups[row, num3] == yearno)
                    {
                        this.m_CurrIrrGroup = row;
                    }
                    num3 = (short) (num3 + 1);
                }
            }
            this.optDefinitionType[1].Checked = !GlobalVariables.b_irrsame;
            this.Text8.Text = Conversion.Str(GlobalVariables.critdef);
            if (GlobalVariables.b_irrsame)
            {
                this.optDefinitionType[0].Checked = true;
            }
            else
            {
                this.optDefinitionType[1].Checked = true;
            }
            this.lstYearSubSets.Items.Clear();
            short num6 = (short) Information.UBound(GlobalVariables.Groups, 1);
            row = 1;
            while (true)
            {
                num9 = num6;
                if (row > num9)
                {
                    this.Label12.Text = "NIRR";
                    this.Label13.Text = "CRITDEF";
                    this.flx_Parameters[3].Cols = 5;
                    this.flx_Parameters[3].Rows = (int) Math.Round((double) (GlobalVariables.nirr[yearno] + 1f));
                    short col = 5;
                    this.flx_Parameters[3].set_TextMatrix(0, 0, "Irrig. no.");
                    this.flx_Parameters[3].set_TextMatrix(0, 1, "IRRDAY");
                    this.flx_Parameters[3].set_TextMatrix(0, 2, "AMIR");
                    this.flx_Parameters[3].set_TextMatrix(0, 3, "IRRSTART");
                    this.flx_Parameters[3].set_TextMatrix(0, 4, "IRREND");
                    if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                    {
                        this.flx_Parameters[3].Cols++;
                        this.flx_Parameters[3].set_TextMatrix(0, col, "ZFINT");
                        col = (short) (col + 1);
                    }
                    if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                    {
                        this.flx_Parameters[3].Cols++;
                        this.flx_Parameters[3].set_TextMatrix(0, col, "CONCI");
                    }
                    this.irr_x = this.flx_Parameters[3].get_ColPos(1);
                    short num8 = (short) Math.Round((double) GlobalVariables.nirr[yearno]);
                    row = 1;
                    while (true)
                    {
                        num9 = num8;
                        if (row > num9)
                        {
                            this.udNIRR.Value = Conversions.ToDecimal(Conversion.Str(GlobalVariables.nirr[yearno]));
                            return;
                        }
                        col = 5;
                        this.flx_Parameters[3].Row = row;
                        this.flx_Parameters[3].RowSel = row;
                        this.flx_Parameters[3].set_TextMatrix(row, 0, Conversions.ToString((int) GlobalVariables.irrig_no[row, yearno]));
                        this.flx_Parameters[3].set_TextMatrix(row, 1, Conversions.ToString(GlobalVariables.i_rrday[row, yearno]));
                        this.flx_Parameters[3].Col = 1;
                        this.flx_Parameters[3].ColSel = 1;
                        this.qb_c = 0;
                        if (GlobalVariables.irrday_c[row] == 2)
                        {
                            this.qb_c = 2;
                        }
                        if (GlobalVariables.irrday_c[row] == 3)
                        {
                            this.qb_c = 12;
                        }
                        this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                        this.flx_Parameters[3].set_TextMatrix(row, 2, Conversions.ToString(GlobalVariables.amir[row, yearno]));
                        this.flx_Parameters[3].Col = 2;
                        this.flx_Parameters[3].ColSel = 2;
                        this.qb_c = 0;
                        if (GlobalVariables.amir_c[row] == 2)
                        {
                            this.qb_c = 2;
                        }
                        if (GlobalVariables.amir_c[row] == 3)
                        {
                            this.qb_c = 12;
                        }
                        this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                        this.flx_Parameters[3].set_TextMatrix(row, 3, Conversions.ToString(GlobalVariables.irrstart[row, yearno]));
                        this.flx_Parameters[3].Col = 3;
                        this.flx_Parameters[3].ColSel = 3;
                        this.qb_c = 0;
                        if (GlobalVariables.irrstart_c[row] == 2)
                        {
                            this.qb_c = 2;
                        }
                        if (GlobalVariables.irrstart_c[row] == 3)
                        {
                            this.qb_c = 12;
                        }
                        this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                        this.flx_Parameters[3].set_TextMatrix(row, 4, Conversions.ToString(GlobalVariables.irrend[row, yearno]));
                        this.flx_Parameters[3].Col = 4;
                        this.flx_Parameters[3].ColSel = 4;
                        this.qb_c = 0;
                        if (GlobalVariables.irrend_c[row] == 2)
                        {
                            this.qb_c = 2;
                        }
                        if (GlobalVariables.irrend_c[row] == 3)
                        {
                            this.qb_c = 12;
                        }
                        this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                        if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                        {
                            this.flx_Parameters[3].set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.z_fint[row, yearno]));
                            this.flx_Parameters[3].Col = col;
                            this.flx_Parameters[3].ColSel = col;
                            this.qb_c = 0;
                            if (GlobalVariables.zfint_c[row] == 2)
                            {
                                this.qb_c = 2;
                            }
                            if (GlobalVariables.zfint_c[row] == 3)
                            {
                                this.qb_c = 12;
                            }
                            this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                            col = (short) (col + 1);
                        }
                        if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                        {
                            this.flx_Parameters[3].set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.c_onci[row, yearno]));
                            this.flx_Parameters[3].Col = col;
                            this.flx_Parameters[3].ColSel = col;
                            this.qb_c = 0;
                            if (GlobalVariables.conci_c[row] == 2)
                            {
                                this.qb_c = 2;
                            }
                            if (GlobalVariables.conci_c[row] == 3)
                            {
                                this.qb_c = 12;
                            }
                            this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                        }
                        row = (short) (row + 1);
                    }
                }
                if (GlobalVariables.Groups[row, 1] > 0)
                {
                    short num7 = (short) Information.UBound(GlobalVariables.Groups, 2);
                    num3 = 1;
                    while (true)
                    {
                        num9 = num7;
                        if (num3 > num9)
                        {
                            this.lstYearSubSets.Items.Add(item);
                            item = "";
                            break;
                        }
                        if (GlobalVariables.Groups[row, num3] > 0)
                        {
                            item = item + " " + Conversions.ToString((int) GlobalVariables.Groups[row, num3]);
                        }
                        num3 = (short) (num3 + 1);
                    }
                }
                row = (short) (row + 1);
            }
        }

        private void ShowManagement()
        {
            this.txtNMan.Text = Conversions.ToString((int) GlobalVariables.NTILL);
            this.udNMAN.Value = GlobalVariables.NTILL;
            AxMSFlexGrid grid = this.flx_Parameters[6];
            grid.Cols = 6;
            grid.Rows = GlobalVariables.NTILL + 1;
            grid.set_TextMatrix(0, 0, "Man. no.");
            grid.set_TextMatrix(0, 1, "TILL_DAY");
            grid.set_TextMatrix(0, 2, "TILL_LAY");
            grid.set_TextMatrix(0, 3, "TILL_INT");
            grid.set_TextMatrix(0, 4, "T_ASCALE");
            grid.set_TextMatrix(0, 5, "TILLCONS");
            grid.Row = 0;
            short num2 = (short) (GlobalVariables.NTILL - 1);
            short index = 0;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    grid = null;
                    if (GlobalVariables.sw_crust == MACROConstants.Switch.NoMetabolite)
                    {
                        GlobalVariables.gammaseal = GlobalVariables.gamma[1];
                        GlobalVariables.znseal = GlobalVariables.zn[1];
                        GlobalVariables.xmporseal = GlobalVariables.xmpor[1];
                        GlobalVariables.ksmseal = GlobalVariables.ksm[1];
                    }
                    this.txtMan[0].Text = Conversions.ToString(GlobalVariables.gamma_ch);
                    this.txtMan[0].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.gamma_ch_c)));
                    this.txtMan[1].Text = Conversions.ToString(GlobalVariables.macp_ch);
                    this.txtMan[1].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.macp_ch_c)));
                    this.txtMan[2].Text = Conversions.ToString(GlobalVariables.macd_ch);
                    this.txtMan[2].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.macd_ch_c)));
                    this.txtMan[3].Text = Conversions.ToString(GlobalVariables.halfrain);
                    this.txtMan[3].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.halfrain_c)));
                    this.txtMan[4].Text = Conversions.ToString(GlobalVariables.halfcrus);
                    this.txtMan[4].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.halfcrus_c)));
                    this.txtMan[5].Text = Conversions.ToString(GlobalVariables.cruststa);
                    this.txtMan[5].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.cruststa_c)));
                    this.txtMan[6].Text = Conversions.ToString(GlobalVariables.ksmtille);
                    this.txtMan[6].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.ksmtille_c)));
                    this.txtMan[7].Text = Conversions.ToString(GlobalVariables.dummy);
                    this.txtMan[7].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.dummy_c)));
                    this.txtMan[8].Text = Conversions.ToString(GlobalVariables.gammaseal);
                    this.txtMan[8].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.gammaseal_c)));
                    this.txtMan[9].Text = Conversions.ToString(GlobalVariables.znseal);
                    this.txtMan[9].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.znseal_c)));
                    this.txtMan[10].Text = Conversions.ToString(GlobalVariables.xmporseal);
                    this.txtMan[10].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.xmporseal_c)));
                    this.txtMan[11].Text = Conversions.ToString(GlobalVariables.ksmseal);
                    this.txtMan[11].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.ksmseal_c)));
                    this.txtMan[12].Text = Conversions.ToString(GlobalVariables.cons_sta);
                    this.txtMan[12].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.cons_sta_c)));
                    this.txtMan[13].Text = Conversions.ToString(GlobalVariables.i_ascale);
                    this.txtMan[13].ForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.i_ascale_c)));
                    bool flag = GlobalVariables.sw_crust == MACROConstants.Switch.BareSoil;
                    index = 4;
                    while (true)
                    {
                        this.txtMan[index].Visible = flag;
                        this.lblMan[index].Visible = flag;
                        index = (short) (index + 1);
                        num3 = 5;
                        if (index > num3)
                        {
                            index = 8;
                            while (true)
                            {
                                this.txtMan[index].Visible = flag;
                                this.lblMan[index].Visible = flag;
                                index = (short) (index + 1);
                                num3 = 11;
                                if (index > num3)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                grid.Row++;
                grid.set_TextMatrix(index + 1, 0, Conversions.ToString((int) (index + 1)));
                grid.set_TextMatrix(index + 1, 1, Conversions.ToString((int) GlobalVariables.till_day[index]));
                grid.Col = 1;
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.till_day_c[index])));
                grid.set_TextMatrix(index + 1, 2, Conversions.ToString((int) GlobalVariables.till_lay[index]));
                grid.Col = 2;
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.till_lay_c[index])));
                grid.set_TextMatrix(index + 1, 3, Conversions.ToString(GlobalVariables.till_int[index]));
                grid.Col = 3;
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.till_int_c[index])));
                grid.set_TextMatrix(index + 1, 4, Conversions.ToString(GlobalVariables.t_ascale[index]));
                grid.Col = 4;
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.t_ascale_c[index])));
                grid.set_TextMatrix(index + 1, 5, Conversions.ToString(GlobalVariables.tillcons[index]));
                grid.Col = 5;
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.ColorID(ref GlobalVariables.tillcons_c[index])));
                index = (short) (index + 1);
            }
        }

        private void ShowNumerical()
        {
            AxMSFlexGrid grid = this._flx_Parameters_8;
            short num5 = (short) (grid.Cols - 1);
            short row = 0;
            while (true)
            {
                short num8 = num5;
                if (row > num8)
                {
                    grid.set_TextMatrix(0, 0, "Horizon:");
                    grid.set_TextMatrix(0, 1, "Thickness:");
                    grid.set_TextMatrix(0, 2, "Difference:");
                    grid.Rows = GlobalVariables.Nhorizon + 1;
                    grid = null;
                    AxMSFlexGrid grid2 = this.flx_Parameters[7];
                    grid2.set_ColWidth(0, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) grid2.Width) / 3.0) - 200.0)));
                    grid2.set_ColWidth(1, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) grid2.Width) / 3.0) - 200.0)));
                    grid2.Rows = GlobalVariables.N_NUMERICAL_LAYERS + 1;
                    grid2.set_TextMatrix(0, 0, "Horizon:");
                    grid2.set_TextMatrix(0, 1, "Layer number:");
                    grid2.set_TextMatrix(0, 2, "Thickness:");
                    short num4 = 1;
                    short nhorizon = GlobalVariables.Nhorizon;
                    short index = 1;
                    while (index <= nhorizon)
                    {
                        short num = num4;
                        short num7 = (short) (((short) (num4 + GlobalVariables.N_Layer[index])) - 1);
                        row = num;
                        while (true)
                        {
                            num8 = num7;
                            if (row > num8)
                            {
                                this.flx_Parameters[8].set_TextMatrix(index, 0, GlobalVariables.designat[index]);
                                this.flx_Parameters[8].set_TextMatrix(index, 1, Conversions.ToString(GlobalVariables.Hthick[index]));
                                index = (short) (index + 1);
                                break;
                            }
                            grid2.set_TextMatrix(row, 0, GlobalVariables.designat[index]);
                            num4 = (short) (num4 + 1);
                            grid2.set_TextMatrix(row, 1, Conversions.ToString((int) row));
                            grid2.set_TextMatrix(row, 2, Conversions.ToString(GlobalVariables.Z[row]));
                            row = (short) (row + 1);
                        }
                    }
                    grid2 = null;
                    this.ComputeDifference();
                    return;
                }
                grid.set_ColWidth(row, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) grid.Width) / ((double) grid.Cols)) - 200.0)));
                row = (short) (row + 1);
            }
        }

        public void ShowPhysical()
        {
            this.flx_Parameters[4].Clear();
            this.flx_Parameters[4].Cols = 0x10;
            this.flx_Parameters[4].set_TextMatrix(0, 0, "Horizon");
            this.flx_Parameters[4].set_TextMatrix(0, 1, "Upper");
            this.flx_Parameters[4].set_TextMatrix(0, 2, "Lower");
            this.flx_Parameters[4].set_TextMatrix(0, 3, "TPORV");
            this.flx_Parameters[4].set_TextMatrix(0, 4, "XMPOR");
            short col = 5;
            if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
            {
                this.flx_Parameters[4].Cols++;
                this.flx_Parameters[4].set_TextMatrix(0, col, "WILT");
                col = (short) (col + 1);
            }
            this.flx_Parameters[4].set_TextMatrix(0, col, "RESID");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "GAMMA");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "CTEN");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "N");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "KSATMIN");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "KSM");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "ZN");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "ZM");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "ZP");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "ZA");
            col = (short) (col + 1);
            this.flx_Parameters[4].set_TextMatrix(0, col, "ASCALE");
            col = (short) (col + 1);
            if (GlobalVariables.sw_hysteres == MACROConstants.Switch.Annual)
            {
                this.flx_Parameters[4].Cols++;
                this.flx_Parameters[4].set_TextMatrix(0, col, "SCALEPSI");
                col = (short) (col + 1);
            }
            if (GlobalVariables.sw_hydraulic == MACROConstants.Switch.BareSoil)
            {
                this.flx_Parameters[4].Cols++;
                this.flx_Parameters[4].set_TextMatrix(0, col, "ALPHA");
            }
            this.flx_Parameters[4].Cols++;
            this.flx_Parameters[4].set_TextMatrix(0, col + 1, "TRAP_AIR");
            col = (short) (col + 1);
            this.flx_Parameters[4].Cols++;
            this.flx_Parameters[4].set_TextMatrix(0, col + 1, "STONE");
            this.flx_Parameters[4].LeftCol = 3;
            this.flx_Parameters[4].TopRow = 1;
            this.ph_x = this.flx_Parameters[4].get_ColPos(3);
            this.ph_rp = this.flx_Parameters[4].get_RowPos(1);
            this.flx_Parameters[4].Rows = GlobalVariables.Nhorizon + 1;
            AxMSFlexGrid grid = this.flx_Parameters[4];
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num11 = nhorizon;
                if (index > num11)
                {
                    grid = null;
                    AxMSFlexGrid grid2 = this.flx_Parameters[4];
                    grid2.Row = 0;
                    short num8 = (short) (grid2.Cols - 1);
                    short num4 = 3;
                    while (true)
                    {
                        num11 = num8;
                        if (num4 > num11)
                        {
                            this.cmbVariables.SelectedIndex = 0;
                            grid2 = null;
                            short num9 = GlobalVariables.Nhorizon;
                            index = 1;
                            while (true)
                            {
                                num11 = num9;
                                if (index > num11)
                                {
                                    short num10 = this.Check2.Count();
                                    index = (short) (GlobalVariables.Nhorizon + 1);
                                    while (true)
                                    {
                                        num11 = num10;
                                        if (index > num11)
                                        {
                                            return;
                                        }
                                        this.Check2[(short) (index - 1)].Visible = false;
                                        index = (short) (index + 1);
                                    }
                                }
                                this.Check2[(short) (index - 1)].Text = GlobalVariables.designat[index];
                                this.Check2[(short) (index - 1)].Visible = true;
                                index = (short) (index + 1);
                            }
                        }
                        grid2.Col = num4;
                        this.cmbVariables.Items.Add(grid2.Text);
                        num4 = (short) (num4 + 1);
                    }
                }
                grid.set_TextMatrix(index, 0, GlobalVariables.designat[index]);
                if (index == 1)
                {
                    grid.set_TextMatrix(index, 1, Conversions.ToString(0));
                    grid.set_TextMatrix(index, 2, Support.Format(GlobalVariables.Hthick[index], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                }
                else
                {
                    grid.set_TextMatrix(index, 1, grid.get_TextMatrix(index - 1, 2));
                    grid.set_TextMatrix(index, 2, Support.Format(Conversions.ToDouble(grid.get_TextMatrix(index - 1, 2)) + GlobalVariables.Hthick[index], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                }
                short num3 = 0;
                num3 = index;
                col = 5;
                grid.set_TextMatrix(index, 3, Support.Format(GlobalVariables.tporv[num3], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = 3;
                grid.Row = index;
                grid.ColSel = 3;
                grid.RowSel = index;
                this.qb_c = 0;
                if (GlobalVariables.tporv_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.tporv_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                grid.set_TextMatrix(index, 4, Support.Format(GlobalVariables.xmpor[num3], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = 4;
                grid.ColSel = 4;
                this.qb_c = 0;
                if (GlobalVariables.xmpor_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.xmpor_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                {
                    grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.wilt[num3], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                    grid.Col = col;
                    grid.ColSel = col;
                    this.qb_c = 0;
                    if (GlobalVariables.wilt_c[num3] == 2)
                    {
                        this.qb_c = 2;
                    }
                    if (GlobalVariables.wilt_c[num3] == 3)
                    {
                        this.qb_c = 12;
                    }
                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                    col = (short) (col + 1);
                }
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.resid[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.resid_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.resid_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.gamma[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.gamma_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.gamma_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.cten[num3], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.cten_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.cten_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.vg_N[num3], "###0.000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.zlamb_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.zlamb_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.ksatmin[num3], "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.ksatmin_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.ksatmin_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.ksm[num3], "0.0000E+00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.ksm_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.ksm_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.zn[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.zn_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.zn_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.zm[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.zm_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.zm_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.zp[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.zp_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.zp_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.za[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.za_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.za_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.ascale[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.ascale_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.ascale_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                if (GlobalVariables.sw_hysteres == MACROConstants.Switch.Annual)
                {
                    grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.scalepsi[num3]));
                    grid.Col = col;
                    grid.ColSel = col;
                    this.qb_c = 0;
                    if (GlobalVariables.scalepsi_c[num3] == 2)
                    {
                        this.qb_c = 2;
                    }
                    if (GlobalVariables.scalepsi_c[num3] == 3)
                    {
                        this.qb_c = 12;
                    }
                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                    col = (short) (col + 1);
                }
                if (GlobalVariables.sw_hydraulic == MACROConstants.Switch.BareSoil)
                {
                    grid.set_TextMatrix(index, col, Support.Format(GlobalVariables.vg_alpha[num3], "###0.0#####", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                    grid.Col = col;
                    grid.ColSel = col;
                    this.qb_c = 0;
                    if (GlobalVariables.scalevg_c[num3] == 2)
                    {
                        this.qb_c = 2;
                    }
                    if (GlobalVariables.scalevg_c[num3] == 3)
                    {
                        this.qb_c = 12;
                    }
                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                    col = (short) (col + 1);
                }
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.trap_air[num3]));
                grid.Col = col;
                grid.ColSel = col;
                this.qb_c = 0;
                if (GlobalVariables.trap_air_c[num3] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.trap_air_c[num3] == 3)
                {
                    this.qb_c = 12;
                }
                grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                col = (short) (col + 1);
                grid.set_TextMatrix(index, col, Conversions.ToString(GlobalVariables.stone[num3]));
                grid.Col = col;
                grid.ColSel = col;
                col = (short) (col + 1);
                index = (short) (index + 1);
            }
        }

        public void showSite()
        {
            this.Text4[0].Text = Conversions.ToString(GlobalVariables.anntav);
            if (GlobalVariables.anntav_c == 2)
            {
                this.Text4[0].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.anntav_c == 3)
            {
                this.Text4[0].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[1].Text = Conversions.ToString(GlobalVariables.annamp);
            if (GlobalVariables.annamp_c == 2)
            {
                this.Text4[1].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.annamp_c == 3)
            {
                this.Text4[1].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[2].Text = Conversions.ToString(GlobalVariables.rainco);
            if (GlobalVariables.rainco_c == 2)
            {
                this.Text4[2].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.rainco_c == 3)
            {
                this.Text4[2].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[3].Text = Conversions.ToString(GlobalVariables.snowco);
            if (GlobalVariables.snowco_c == 2)
            {
                this.Text4[3].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.snowco_c == 3)
            {
                this.Text4[3].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[4].Text = Conversions.ToString(GlobalVariables.snowmf);
            if (GlobalVariables.snowmf_c == 2)
            {
                this.Text4[4].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.snowmf_c == 3)
            {
                this.Text4[4].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[5].Text = Conversions.ToString(GlobalVariables.dwrl);
            if (GlobalVariables.dwrl_c == 2)
            {
                this.Text4[5].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.dwrl_c == 3)
            {
                this.Text4[5].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Text4[6].Text = Conversions.ToString(GlobalVariables.phi);
            if (GlobalVariables.phi_c == 2)
            {
                this.Text4[6].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
            if (GlobalVariables.phi_c == 3)
            {
                this.Text4[6].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
            }
            this.Label11[0].Text = "ANNTAV";
            this.Label11[1].Text = "ANNAMP";
            this.Label11[2].Text = "RAINCO";
            this.Label11[3].Text = "SNOWCO";
            this.Label11[4].Text = "SNOWMF";
            this.Label11[5].Text = "DWRL";
            this.Label11[6].Text = "PHI";
            short num = 6;
            if (GlobalVariables.sw_rainfall == MACROConstants.Switch.BareSoil)
            {
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.rinten);
                if (GlobalVariables.rinten_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.rinten_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "RINTEN";
            }
            if (GlobalVariables.sw_boundary == MACROConstants.Switch.Perennial)
            {
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.layerd);
                if (GlobalVariables.layerd_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.layerd_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "LAYERD";
            }
            if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
            {
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.albedo);
                if (GlobalVariables.albedo_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.albedo_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "ALBEDO";
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.zmet);
                if (GlobalVariables.zmet_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.zmet_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "ZMET";
            }
            if (((GlobalVariables.sw_boundary > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_boundary < MACROConstants.Switch.Tritium)) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil))
            {
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.rgwflow);
                if (GlobalVariables.rgwflow_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.rgwflow_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "RGWFLOW";
            }
            if (GlobalVariables.sw_tiledrain == MACROConstants.Switch.BareSoil)
            {
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.draindep);
                if (GlobalVariables.draindep_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.draindep_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "DRAINDEP";
                num = (short) (num + 1);
                this.Text4[num].Visible = true;
                this.Text4[num].Text = Conversions.ToString(GlobalVariables.s_pace);
                if (GlobalVariables.space_c == 2)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                if (GlobalVariables.space_c == 3)
                {
                    this.Text4[num].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                }
                this.Label11[num].Visible = true;
                this.Label11[num].Text = "SPACE";
            }
        }

        public void ShowSolute()
        {
            this.cmdFOCUS.Enabled = false;
            this.cmdKoc.Enabled = false;
            short num7 = (short) (this.text12.Count() - 1);
            short row = 0;
            while (true)
            {
                short num12 = num7;
                if (row > num12)
                {
                    row = -1;
                    this.cmbParameters.Items.Clear();
                    this.cmbIndex.Items.Clear();
                    this.cmbSoluteVariables.Items.Clear();
                    this.txtkoc.Text = Conversions.ToString(GlobalVariables.Koc);
                    if (GlobalVariables.sw_immobile == MACROConstants.Switch.Annual)
                    {
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.pf1);
                        if (GlobalVariables.pf1_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.pf1_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("PFI");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.pf2);
                        if (GlobalVariables.pf2_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.pf2_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("PFI2");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                    }
                    if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                    {
                        this.cmdFOCUS.Enabled = true;
                        this.cmdKoc.Enabled = true;
                        if (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil)
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.pmax);
                            if (GlobalVariables.pmax_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.pmax_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("PMAX");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.genkd);
                            if (GlobalVariables.genkd_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.genkd_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("GENKD");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.vref);
                            if (GlobalVariables.vref_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.vref_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("VREF");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.settle);
                            if (GlobalVariables.settle_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.settle_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("SETTLE");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.filtermi);
                            if (GlobalVariables.filtermi_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.filtermi_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("FILTERMI");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.refilter);
                            if (GlobalVariables.refilter_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.refilter_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("REFILTER");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.replen);
                            if (GlobalVariables.replen_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.replen_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("REPLEN");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                    }
                    if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                    {
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.zmix);
                        if (GlobalVariables.zmix_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.zmix_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("ZMIX");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.conc);
                        if (GlobalVariables.conc_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.conc_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("CONC");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.d_iff);
                            if (GlobalVariables.diff_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.diff_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("DIFF");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.dv);
                            if (GlobalVariables.dv_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.dv_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("DV");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                    }
                    if (GlobalVariables.sw_immobile > MACROConstants.Switch.NoMetabolite)
                    {
                        row = (short) (row + 1);
                        this.text12[row].Visible = false;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.frack);
                        if (GlobalVariables.frack_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.frack_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                    }
                    if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | (((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)))
                    {
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.fstar);
                        if (GlobalVariables.fstar_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.fstar_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("FSTAR");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                    }
                    if ((GlobalVariables.sw_solute == ((MACROConstants.Switch) 0x13)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                    {
                        row = (short) (row + 1);
                        this.text12[row].Visible = true;
                        this.text12[row].Text = Conversions.ToString(GlobalVariables.gravit);
                        if (GlobalVariables.gravit_c == 2)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                        }
                        if (GlobalVariables.gravit_c == 3)
                        {
                            this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                        }
                        this.cmbParameters.Items.Add("GRAVIT");
                        this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                    }
                    if (GlobalVariables.sw_solute != MACROConstants.Switch.BareSoil)
                    {
                        if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.fracmac);
                            if (GlobalVariables.fracmac_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.fracmac_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("FRACMAC");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                        if (((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil))
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.candeg);
                            if (GlobalVariables.candeg_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.candeg_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("CANDEG");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.fext);
                            if (GlobalVariables.fext_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.fext_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("FEXT");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                        if (((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_driving == MACROConstants.Switch.Annual))
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.zkdpc);
                            if (GlobalVariables.zkdpc_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.zkdpc_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("ZKDPC");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                        if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.expb);
                            if (GlobalVariables.expb_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.expb_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("EXPB");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.tresp);
                            if (GlobalVariables.tresp_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.tresp_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("TRESP");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.tref);
                            if (GlobalVariables.tref_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.tref_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("TREF");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            if (GlobalVariables.sw_driving == MACROConstants.Switch.BareSoil)
                            {
                                row = (short) (row + 1);
                                this.text12[row].Visible = true;
                                this.text12[row].Text = Conversions.ToString(GlobalVariables.f_convert);
                                if (GlobalVariables.fconvert_c == 2)
                                {
                                    this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                                }
                                if (GlobalVariables.fconvert_c == 3)
                                {
                                    this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                                }
                                this.cmbParameters.Items.Add("FCONVERT");
                                this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            }
                        }
                        if (GlobalVariables.sw_kinetic == MACROConstants.Switch.BareSoil)
                        {
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.sorp_rate);
                            if (GlobalVariables.sorp_rate_c == 2)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.sorp_rate_c == 3)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("SORP_RATE");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                            row = (short) (row + 1);
                            this.text12[row].Visible = true;
                            this.text12[row].Text = Conversions.ToString(GlobalVariables.frac_eq);
                            if (GlobalVariables.frac_eq == 2f)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                            }
                            if (GlobalVariables.frac_eq == 3f)
                            {
                                this.text12[row].ForeColor = ColorTranslator.FromOle(Information.QBColor(12));
                            }
                            this.cmbParameters.Items.Add("FRAC_KIN");
                            this.cmbIndex.Items.Add(Conversions.ToString((int) row));
                        }
                        this.cmbVariables.SelectedIndex = 0;
                        this.cmbParameters.SelectedIndex = 0;
                        this.flx_Parameters[5].Rows = GlobalVariables.TotalLayers + 1;
                        this.flx_Parameters[5].Cols = 3;
                        short col = 2;
                        this.flx_Parameters[5].set_TextMatrix(0, 0, "Horizon");
                        this.flx_Parameters[5].set_TextMatrix(0, 1, "Upper");
                        this.flx_Parameters[5].set_TextMatrix(0, 2, "Lower");
                        if (GlobalVariables.sw_immobile == MACROConstants.Switch.Perennial)
                        {
                            col = (short) (col + 1);
                            this.flx_Parameters[5].Cols++;
                            this.flx_Parameters[5].set_TextMatrix(0, col, "FMOBILE");
                        }
                        if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | ((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)))
                        {
                            col = (short) (col + 1);
                            this.flx_Parameters[5].Cols++;
                            this.flx_Parameters[5].set_TextMatrix(0, col, "AEXC");
                        }
                        if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                        {
                            col = (short) (col + 1);
                            this.flx_Parameters[5].Cols++;
                            this.flx_Parameters[5].set_TextMatrix(0, col, "PSEXC");
                        }
                        if (((GlobalVariables.sw_immobile > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                        {
                            col = (short) (col + 1);
                            this.flx_Parameters[5].Cols++;
                            this.flx_Parameters[5].set_TextMatrix(0, col, "ALPHA");
                        }
                        if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                        {
                            col = (short) (col + 1);
                            this.flx_Parameters[5].Cols++;
                            this.flx_Parameters[5].set_TextMatrix(0, col, "ZKD");
                            if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                            {
                                col = (short) (col + 1);
                                this.flx_Parameters[5].Cols++;
                                this.flx_Parameters[5].set_TextMatrix(0, col, "DEGMIL");
                                col = (short) (col + 1);
                                this.flx_Parameters[5].Cols++;
                                this.flx_Parameters[5].set_TextMatrix(0, col, "DEGMAL");
                                col = (short) (col + 1);
                                this.flx_Parameters[5].Cols++;
                                this.flx_Parameters[5].set_TextMatrix(0, col, "DEGMIS");
                                col = (short) (col + 1);
                                this.flx_Parameters[5].Cols++;
                                this.flx_Parameters[5].set_TextMatrix(0, col, "DEGMAS");
                                col = (short) (col + 1);
                                this.flx_Parameters[5].Cols++;
                                this.flx_Parameters[5].set_TextMatrix(0, col, "FREUND");
                            }
                        }
                        if (GlobalVariables.sw_solute == MACROConstants.Switch.Tritium)
                        {
                            this.flx_Parameters[5].Cols = 1;
                            this.flx_Parameters[5].Rows = 1;
                            this.flx_Parameters[5].set_TextMatrix(0, 0, "No parameters");
                        }
                        else
                        {
                            this.flx_Parameters[5].FixedCols = 3;
                            this.flx_Parameters[5].LeftCol = 3;
                            this.flx_Parameters[5].Rows = GlobalVariables.Nhorizon + 1;
                            this.solute_x = this.flx_Parameters[5].get_ColPos(3);
                            this.solute_rp = this.flx_Parameters[5].get_RowPos(1);
                            AxMSFlexGrid grid = this.flx_Parameters[5];
                            short nhorizon = GlobalVariables.Nhorizon;
                            row = 1;
                            while (true)
                            {
                                num12 = nhorizon;
                                if (row > num12)
                                {
                                    grid = null;
                                    break;
                                }
                                grid.set_TextMatrix(row, 0, GlobalVariables.designat[row]);
                                if (row == 1)
                                {
                                    grid.set_TextMatrix(row, 1, Conversions.ToString(0));
                                    grid.set_TextMatrix(row, 2, Conversions.ToString(GlobalVariables.Hthick[row]));
                                }
                                else
                                {
                                    grid.set_TextMatrix(row, 1, grid.get_TextMatrix(row - 1, 2));
                                    grid.set_TextMatrix(row, 2, Conversions.ToString((double) (Conversions.ToDouble(grid.get_TextMatrix(row - 1, 2)) + GlobalVariables.Hthick[row])));
                                }
                                short index = 0;
                                index = row;
                                col = 2;
                                grid.Row = row;
                                grid.RowSel = row;
                                if (GlobalVariables.sw_immobile == MACROConstants.Switch.Perennial)
                                {
                                    col = (short) (col + 1);
                                    grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.fmobile[index]));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    this.qb_c = 0;
                                    if (GlobalVariables.fmobile_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.fmobile_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | ((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)))
                                {
                                    col = (short) (col + 1);
                                    grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.aexc[index]));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    this.qb_c = 0;
                                    if (GlobalVariables.aexc_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.aexc_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                                {
                                    col = (short) (col + 1);
                                    grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.psexc[index]));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    this.qb_c = 0;
                                    if (GlobalVariables.psexc_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.psexc_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if (((GlobalVariables.sw_immobile > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                                {
                                    col = (short) (col + 1);
                                    grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.a_lpha[index]));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    this.qb_c = 0;
                                    if (GlobalVariables.alpha_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.alpha_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                }
                                if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                                {
                                    col = (short) (col + 1);
                                    grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.zkd[index]));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    this.qb_c = 0;
                                    if (GlobalVariables.zkd_c[index] == 2)
                                    {
                                        this.qb_c = 2;
                                    }
                                    if (GlobalVariables.zkd_c[index] == 3)
                                    {
                                        this.qb_c = 12;
                                    }
                                    grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                                    {
                                        col = (short) (col + 1);
                                        grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.degmil[index]));
                                        grid.Col = col;
                                        grid.ColSel = col;
                                        this.qb_c = 0;
                                        if (GlobalVariables.degmil_c[index] == 2)
                                        {
                                            this.qb_c = 2;
                                        }
                                        if (GlobalVariables.degmil_c[index] == 3)
                                        {
                                            this.qb_c = 12;
                                        }
                                        grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                        col = (short) (col + 1);
                                        grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.degmal[index]));
                                        grid.Col = col;
                                        grid.ColSel = col;
                                        this.qb_c = 0;
                                        if (GlobalVariables.degmal_c[index] == 2)
                                        {
                                            this.qb_c = 2;
                                        }
                                        if (GlobalVariables.degmal_c[index] == 3)
                                        {
                                            this.qb_c = 12;
                                        }
                                        grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                        col = (short) (col + 1);
                                        grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.degmis[index]));
                                        grid.Col = col;
                                        grid.ColSel = col;
                                        this.qb_c = 0;
                                        if (GlobalVariables.degmis_c[index] == 2)
                                        {
                                            this.qb_c = 2;
                                        }
                                        if (GlobalVariables.degmis_c[index] == 3)
                                        {
                                            this.qb_c = 12;
                                        }
                                        grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                        col = (short) (col + 1);
                                        grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.degmas[index]));
                                        grid.Col = col;
                                        grid.ColSel = col;
                                        this.qb_c = 0;
                                        if (GlobalVariables.degmas_c[index] == 2)
                                        {
                                            this.qb_c = 2;
                                        }
                                        if (GlobalVariables.degmas_c[index] == 3)
                                        {
                                            this.qb_c = 12;
                                        }
                                        grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                        col = (short) (col + 1);
                                        grid.set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.f_reund[index]));
                                        grid.Col = col;
                                        grid.ColSel = col;
                                        this.qb_c = 0;
                                        if (GlobalVariables.freund_c[index] == 2)
                                        {
                                            this.qb_c = 2;
                                        }
                                        if (GlobalVariables.freund_c[index] == 3)
                                        {
                                            this.qb_c = 12;
                                        }
                                        grid.CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                                    }
                                }
                                row = (short) (row + 1);
                            }
                        }
                        AxMSFlexGrid grid2 = this.flx_Parameters[5];
                        grid2.Row = 0;
                        short num9 = (short) (grid2.Cols - 1);
                        short num4 = 3;
                        while (true)
                        {
                            num12 = num9;
                            if (num4 > num12)
                            {
                                if (this.cmbSoluteVariables.Items.Count > 0)
                                {
                                    this.cmbSoluteVariables.SelectedIndex = 0;
                                }
                                grid2 = null;
                                short nhorizon = GlobalVariables.Nhorizon;
                                row = 1;
                                while (true)
                                {
                                    num12 = nhorizon;
                                    if (row > num12)
                                    {
                                        short num11 = this.Check2.Count();
                                        row = (short) (GlobalVariables.Nhorizon + 1);
                                        while (true)
                                        {
                                            num12 = num11;
                                            if (row > num12)
                                            {
                                                this.txtkoc.Text = Conversions.ToString(GlobalVariables.Koc);
                                                break;
                                            }
                                            this.Check4[(short) (row - 1)].Visible = false;
                                            row = (short) (row + 1);
                                        }
                                        break;
                                    }
                                    this.Check4[(short) (row - 1)].Text = GlobalVariables.designat[row];
                                    this.Check4[(short) (row - 1)].Visible = true;
                                    this.Check4[(short) (row - 1)].Enabled = true;
                                    row = (short) (row + 1);
                                }
                                break;
                            }
                            grid2.Col = num4;
                            this.cmbSoluteVariables.Items.Add(grid2.Text);
                            num4 = (short) (num4 + 1);
                        }
                    }
                    return;
                }
                this.text12[row].Visible = false;
                row = (short) (row + 1);
            }
        }

        private void ShowTextBox(ref short index, ref string str_Renamed = "")
        {
            AxMSFlexGrid grid = this.flx_Parameters[index];
            GlobalVariables.grddata_col[index] = (short) grid.Col;
            GlobalVariables.grddata_row[index] = (short) grid.Row;
            if ((grid.Col >= 0) & (grid.Row >= 0))
            {
                if ((index == 0) | (index == 1))
                {
                    this.txtCropParameters.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grid.Left) + grid.get_ColPos(grid.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grid.Top) + grid.get_RowPos(grid.Row))), 0, 0, BoundsSpecified.Location);
                    this.txtCropParameters.Text = grid.Text;
                    if (Strings.Len((string) str_Renamed) == 0)
                    {
                        this.txtCropParameters.SelectionLength = Strings.Len(this.txtCropParameters.Text);
                        this.txtCropParameters.Visible = true;
                        this.txtCropParameters.Focus();
                    }
                    if (Strings.Len((string) str_Renamed) > 0)
                    {
                        this.txtCropParameters.Text = str_Renamed;
                        this.txtCropParameters.SelectionStart = 2;
                        this.txtCropParameters.SelectionLength = 0;
                        this.txtCropParameters.Visible = true;
                        this.txtCropParameters.Focus();
                    }
                }
                else if (index == 2)
                {
                    this.txtIBCond.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grid.Left) + grid.get_ColPos(grid.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grid.Top) + grid.get_RowPos(grid.Row))), 0, 0, BoundsSpecified.Location);
                    this.txtIBCond.Text = grid.Text;
                    if (Strings.Len((string) str_Renamed) == 0)
                    {
                        this.txtIBCond.SelectionLength = Strings.Len(this.txtIBCond.Text);
                        this.txtIBCond.Visible = true;
                        this.txtIBCond.Focus();
                    }
                    if (Strings.Len((string) str_Renamed) > 0)
                    {
                        this.txtIBCond.Text = str_Renamed;
                        this.txtIBCond.SelectionStart = 2;
                        this.txtIBCond.SelectionLength = 0;
                        this.txtIBCond.Visible = true;
                        this.txtIBCond.Focus();
                    }
                }
                else if (index == 5)
                {
                    this.txtSolute.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grid.Left) + grid.get_ColPos(grid.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grid.Top) + grid.get_RowPos(grid.Row))), 0, 0, BoundsSpecified.Location);
                    this.txtSolute.Text = grid.Text;
                    if (Strings.Len((string) str_Renamed) == 0)
                    {
                        this.txtSolute.SelectionLength = Strings.Len(this.txtSolute.Text);
                        this.txtSolute.Visible = true;
                        this.txtSolute.Focus();
                    }
                    if (Strings.Len((string) str_Renamed) > 0)
                    {
                        this.txtSolute.Text = str_Renamed;
                        this.txtSolute.SelectionStart = 2;
                        this.txtSolute.SelectionLength = 0;
                        this.txtSolute.Visible = true;
                        this.txtSolute.Focus();
                    }
                }
                else
                {
                    this.txtBox[index].SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grid.Left) + grid.get_ColPos(grid.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grid.Top) + grid.get_RowPos(grid.Row))), 0, 0, BoundsSpecified.Location);
                    this.txtBox[index].Text = grid.Text;
                    if (Strings.Len((string) str_Renamed) == 0)
                    {
                        this.txtBox[index].SelectionLength = Strings.Len(this.txtBox[index].Text);
                        this.txtBox[index].Visible = true;
                        this.txtBox[index].Focus();
                    }
                    if (Strings.Len((string) str_Renamed) > 0)
                    {
                        this.txtBox[index].Text = str_Renamed;
                        this.txtBox[index].SelectionStart = 2;
                        this.txtBox[index].SelectionLength = 0;
                        this.txtBox[index].Visible = true;
                        this.txtBox[index].Focus();
                    }
                }
            }
            grid = null;
        }

        private void ShowYears()
        {
            int num2 = this.flx_Parameters[0].Rows - 1;
            int row = 1;
            while (true)
            {
                int num3 = num2;
                if (row > num3)
                {
                    return;
                }
                if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                {
                    this.flx_Parameters[0].set_TextMatrix(row, 3, Conversions.ToString(GlobalVariables.YearsForIDSTART[row]));
                    this.flx_Parameters[0].Col = 3;
                    this.flx_Parameters[0].ColSel = 3;
                    this.flx_Parameters[0].set_TextMatrix(row, 7, Conversions.ToString(GlobalVariables.YearsForIHARV[row]));
                    this.flx_Parameters[0].Col = 7;
                    this.flx_Parameters[0].ColSel = 7;
                }
                row++;
            }
        }

        private void SSTab1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            Monitor.Enter(this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init);
            try
            {
                if (this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init.State == 0)
                {
                    this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init.State = 2;
                    this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab = (short) this.SSTab1.SelectedIndex;
                }
                else if (this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init.State == 2)
                {
                    throw new IncompleteInitialization();
                }
            }
            finally
            {
                this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init.State = 1;
                Monitor.Exit(this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab$Init);
            }
            this.cmdApply.Enabled = true;
            this.$STATIC$SSTab1_SelectedIndexChanged$20211C1259$PreviousTab = (short) this.SSTab1.SelectedIndex;
        }

        private void StoreSubSetValues(ref short grp, ref short modif)
        {
            short num2 = (short) Information.UBound(GlobalVariables.Groups, 2);
            short num = 1;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    return;
                }
                if (GlobalVariables.Groups[grp, num] > 0)
                {
                    ChecksAndAssignments.AssignIrrigation(ref GlobalVariables.Groups[grp, num], ref this.frmMain, ref modif);
                }
                num = (short) (num + 1);
            }
        }

        private void Text1_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.text1.GetIndex((TextBox) eventSender);
            Label label = this.Label1[index];
            string text = label.Text;
            HelpFunctions.Help_IBcond(ref text, ref this.lblHelp[2]);
            label.Text = text;
        }

        private void Text1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.text1.GetIndex((TextBox) eventSender);
                if (this.UserEdit)
                {
                    this.text1[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                    Label label = this.Label1[index];
                    string text = label.Text;
                    HelpFunctions.Help_IBcond(ref text, ref this.lblHelp[2]);
                    label.Text = text;
                }
            }
        }

        private void Text12_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.text12.GetIndex((TextBox) eventSender);
            HelpFunctions.Help_Solute(ref this.cmbParameters.Text, ref this.lblHelp[5]);
        }

        private void Text12_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.text12.GetIndex((TextBox) eventSender);
                if (this.UserEdit)
                {
                    this.text12[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                HelpFunctions.Help_Solute(ref this.cmbSoluteVariables.Text, ref this.lblHelp[5]);
            }
        }

        private void Text4_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.Text4.GetIndex((TextBox) eventSender);
            Label lblHelpSite = this.lblHelpSite;
            Label label2 = this.Label11[index];
            string text = label2.Text;
            HelpFunctions.HELP_Site(ref index, ref lblHelpSite, ref text);
            label2.Text = text;
            this.lblHelpSite = lblHelpSite;
        }

        private void Text4_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.Text4.GetIndex((TextBox) eventSender);
                if (this.UserEdit)
                {
                    this.Text4[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
            }
        }

        private void Text7_Click(object eventSender, EventArgs eventArgs)
        {
            HelpFunctions.HELP_Irr(ref "NIRR", ref this.lblHelp[3]);
        }

        private void Text7_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.lblHelp[3].Text = "NIRR = The number of irrigations.\rYou may specify up to 100 irrigations per year.";
        }

        private void Text7_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && (Versioned.IsNumeric(this.udNIRR.Value) && (Strings.Len(this.Label12.Text) != 0)))
            {
                if (Conversion.Val(this.udNIRR.Value) < 0.0)
                {
                    this.udNIRR.Value = 0M;
                }
                if (Conversion.Val(this.udNIRR.Value) > 100.0)
                {
                    GlobalVariables.nirr[this.m_CurrIrrGroup] = 100f;
                    this.udNIRR.Value = Conversions.ToDecimal(Conversions.ToString(100));
                }
                if (!this.bSkipStore)
                {
                    if (GlobalVariables.nirr[this.m_CurrIrrGroup] < Convert.ToDouble(this.udNIRR.Value))
                    {
                        this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref -1);
                    }
                    else
                    {
                        this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref 0);
                    }
                    this.udNIRR.ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                    short num3 = (short) Information.UBound(GlobalVariables.Groups, 2);
                    short num = 1;
                    while (true)
                    {
                        short num4 = num3;
                        if (num > num4)
                        {
                            break;
                        }
                        if (GlobalVariables.Groups[this.m_CurrIrrGroup, num] > 0)
                        {
                            GlobalVariables.nirr[GlobalVariables.Groups[this.m_CurrIrrGroup, num]] = (float) Conversion.Val(this.udNIRR.Value);
                        }
                        num = (short) (num + 1);
                    }
                }
                this.Update_Irr(ref GlobalVariables.Groups[this.m_CurrIrrGroup, 1]);
            }
        }

        private void Text8_Click(object eventSender, EventArgs eventArgs)
        {
            HelpFunctions.HELP_Irr(ref "CRITDEF", ref this.lblHelp[3]);
        }

        private void Text8_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.lblHelp[3].Text = "CRITDEF = Critical soil water deficit for irrigation scheduling (mm)\rWhen the soil water deficit in the root zone exceeds this value, irrigation\rwill automatically take place. An amount equal to 90% of the deficit will be applied\r\rFor SOLUTE > 1, this water is assumed to have zero solute concentration.\r\rA negative number implies no automatic irrigation scheduling.";
        }

        private void Text8_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && this.UserEdit)
            {
                this.Text8.ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
            }
        }

        private void txtBox_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short charCode = (short) Strings.Asc(eventArgs.KeyChar);
            if (!this.IsInitializing)
            {
                short index = this.txtBox.GetIndex((TextBox) eventSender);
                if (charCode == 13)
                {
                    this.txtBox[index].Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                else if (charCode == 0x1b)
                {
                    this.txtBox[index].Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                eventArgs.KeyChar = Strings.Chr(charCode);
                if (charCode == 0)
                {
                    eventArgs.Handled = true;
                }
            }
        }

        private void txtBox_Leave(object eventSender, EventArgs eventArgs)
        {
            short index = this.txtBox.GetIndex((TextBox) eventSender);
            if ((GlobalVariables.grddata_row[index] <= (this.flx_Parameters[index].Rows - 1)) && (Strings.Len(this.flx_Parameters[index].get_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index])) == 0))
            {
                this.flx_Parameters[index].set_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index], "0");
            }
            this.txtBox[index].Visible = false;
            GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
            GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
            this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
            this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
        }

        private void txtBox_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.txtBox.GetIndex((TextBox) eventSender);
                AxMSFlexGrid grid = this.flx_Parameters[index];
                grid.Text = this.txtBox[index].Text;
                if (!this.bKeepColor)
                {
                    grid.CellForeColor = !this.UserEdit ? (!this.Pedotransfer ? Color.Black : Color.Red) : ColorTranslator.FromOle(Information.QBColor(2));
                }
                grid = null;
                if (index == 7)
                {
                    this.ComputeDifference();
                }
            }
        }

        private void txtCropDev2_Click(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                HelpFunctions.HELP_CropDev2(ref this.txtCropDev2.GetIndex((TextBox) eventSender), ref this.lblHelp[0]);
            }
        }

        private void txtCropDev2_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            HelpFunctions.HELP_CropDev2(ref this.txtCropDev2.GetIndex((TextBox) eventSender), ref this.lblHelp[0]);
        }

        private void txtCropDev2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.txtCropDev2.GetIndex((TextBox) eventSender);
                if (!this.bLoading)
                {
                    this.txtCropDev2[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
            }
        }

        private void txtCropDev3_Click(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                HelpFunctions.HELP_CropDev3(ref this.txtCropDev3.GetIndex((TextBox) eventSender), ref this.lblHelp[0]);
            }
        }

        private void txtCropDev3_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short num = (short) (eventArgs.Button / MouseButtons.Left);
                short num3 = (short) (Control.ModifierKeys / Keys.Shift);
                float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
                float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
                HelpFunctions.HELP_CropDev3(ref this.txtCropDev3.GetIndex((TextBox) eventSender), ref this.lblHelp[0]);
            }
        }

        private void txtCropDev3_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.txtCropDev3.GetIndex((TextBox) eventSender);
                if (!this.bLoading)
                {
                    this.txtCropDev3[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
            }
        }

        private void txtcropparameters_KeyPress(object sender, KeyPressEventArgs e)
        {
            short charCode = (short) Strings.Asc(e.KeyChar);
            if (!this.IsInitializing)
            {
                short index = 0;
                if (charCode == 13)
                {
                    this.txtCropParameters.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                else if (charCode == 0x1b)
                {
                    this.txtCropParameters.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                e.KeyChar = Strings.Chr(charCode);
                if (charCode == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtcropparameters_Leave(object sender, EventArgs e)
        {
            short index = 0;
            if ((GlobalVariables.grddata_row[index] <= (this.flx_Parameters[index].Rows - 1)) && (Strings.Len(this.flx_Parameters[index].get_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index])) == 0))
            {
                this.flx_Parameters[index].set_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index], "0");
            }
            this.txtCropParameters.Visible = false;
            GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
            GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
            this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
            this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
            {
                this.SetYearsForIHARVandIDSTART();
                this.ShowYears();
            }
        }

        private void txtcropparameters_TextChanged(object sender, EventArgs e)
        {
            if (!this.IsInitializing)
            {
                short num = 0;
                AxMSFlexGrid grid = this.flx_Parameters[num];
                grid.Text = this.txtCropParameters.Text;
                if (!this.bKeepColor)
                {
                    grid.CellForeColor = !this.UserEdit ? (!this.Pedotransfer ? Color.Black : Color.Red) : ColorTranslator.FromOle(Information.QBColor(2));
                }
                grid = null;
            }
        }

        private void txtIBCond_KeyPress(object sender, KeyPressEventArgs e)
        {
            short charCode = (short) Strings.Asc(e.KeyChar);
            if (!this.IsInitializing)
            {
                short index = 2;
                if (charCode == 13)
                {
                    this.txtIBCond.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                else if (charCode == 0x1b)
                {
                    this.txtIBCond.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                e.KeyChar = Strings.Chr(charCode);
                if (charCode == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtIBCond_Leave(object sender, EventArgs e)
        {
            short index = 2;
            if ((GlobalVariables.grddata_row[index] <= (this.flx_Parameters[index].Rows - 1)) && (Strings.Len(this.flx_Parameters[index].get_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index])) == 0))
            {
                this.flx_Parameters[index].set_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index], "0");
            }
            this.txtIBCond.Visible = false;
            GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
            GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
            this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
            this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
        }

        private void txtIBCond_TextChanged(object sender, EventArgs e)
        {
            if (!this.IsInitializing)
            {
                short num = 2;
                AxMSFlexGrid grid = this.flx_Parameters[num];
                grid.Text = this.txtIBCond.Text;
                if (!this.bKeepColor)
                {
                    grid.CellForeColor = !this.UserEdit ? (!this.Pedotransfer ? Color.Black : Color.Red) : ColorTranslator.FromOle(Information.QBColor(2));
                }
                grid = null;
            }
        }

        private void txtMan_Leave(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.txtMan.GetIndex((TextBox) eventSender);
                if (Strings.Len(this.txtMan[index].Text) == 0)
                {
                    this.txtMan[index].Text = "0";
                }
            }
        }

        private void txtMan_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num3 = (short) (Control.ModifierKeys / Keys.Shift);
            float num4 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num5 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            short index = this.txtMan.GetIndex((TextBox) eventSender);
            Label label = this.lblMan[index];
            string text = label.Text;
            HelpFunctions.Help_Management(ref text, ref this.lblHelp[6]);
            label.Text = text;
        }

        private void txtMan_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                short index = this.txtMan.GetIndex((TextBox) eventSender);
                if (this.UserEdit)
                {
                    this.txtMan[index].ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                }
                Label label = this.lblMan[index];
                string text = label.Text;
                HelpFunctions.Help_Management(ref text, ref this.lblHelp[6]);
                label.Text = text;
            }
        }

        private void txtNMAN_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && !this.bLoading)
            {
                this.Update_Management();
            }
        }

        private void txtsolute_KeyPress(object sender, KeyPressEventArgs e)
        {
            short charCode = (short) Strings.Asc(e.KeyChar);
            if (!this.IsInitializing)
            {
                short index = 5;
                if (charCode == 13)
                {
                    this.txtSolute.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                else if (charCode == 0x1b)
                {
                    this.txtSolute.Visible = false;
                    GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
                    GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
                    this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
                    this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
                }
                e.KeyChar = Strings.Chr(charCode);
                if (charCode == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtsolute_Leave(object sender, EventArgs e)
        {
            short index = 5;
            if ((GlobalVariables.grddata_row[index] <= (this.flx_Parameters[index].Rows - 1)) && (Strings.Len(this.flx_Parameters[index].get_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index])) == 0))
            {
                this.flx_Parameters[index].set_TextMatrix(GlobalVariables.grddata_row[index], GlobalVariables.grddata_col[index], "0");
            }
            this.txtSolute.Visible = false;
            GlobalVariables.grddata_col[index] = (short) this.flx_Parameters[index].Col;
            GlobalVariables.grddata_row[index] = (short) this.flx_Parameters[index].Row;
            this.flx_Parameters[index].Col = GlobalVariables.grddata_col[index];
            this.flx_Parameters[index].Row = GlobalVariables.grddata_row[index];
        }

        private void txtsolute_TextChanged(object sender, EventArgs e)
        {
            if (!this.IsInitializing)
            {
                short num = 5;
                AxMSFlexGrid grid = this.flx_Parameters[num];
                grid.Text = this.txtSolute.Text;
                if (!this.bKeepColor)
                {
                    grid.CellForeColor = !this.UserEdit ? (!this.Pedotransfer ? Color.Black : Color.Red) : ColorTranslator.FromOle(Information.QBColor(2));
                }
                grid = null;
            }
        }

        private void udNIRR_ValueChanged(object sender, EventArgs e)
        {
            this.txtBox[3].Visible = false;
            if (!this.IsInitializing && (Versioned.IsNumeric(this.udNIRR.Value) && (Strings.Len(this.Label12.Text) != 0)))
            {
                if (Conversion.Val(this.udNIRR.Value) < 0.0)
                {
                    this.udNIRR.Value = 0M;
                }
                this.frmMain.frmParameters.flx_Parameters[3].Rows = Convert.ToInt32(decimal.Add(this.udNIRR.Value, 1M));
                if (Conversion.Val(this.udNIRR.Value) > 100.0)
                {
                    GlobalVariables.nirr[this.m_CurrIrrGroup] = 100f;
                    this.udNIRR.Value = Conversions.ToDecimal(Conversions.ToString(100));
                }
                if (!this.bSkipStore)
                {
                    if (GlobalVariables.nirr[this.m_CurrIrrGroup] < Convert.ToDouble(this.udNIRR.Value))
                    {
                        this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref -1);
                    }
                    else
                    {
                        this.StoreSubSetValues(ref this.m_CurrIrrGroup, ref 0);
                    }
                    this.udNIRR.ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
                    short num3 = (short) Information.UBound(GlobalVariables.Groups, 2);
                    short num = 1;
                    while (true)
                    {
                        short num4 = num3;
                        if (num > num4)
                        {
                            break;
                        }
                        if (GlobalVariables.Groups[this.m_CurrIrrGroup, num] > 0)
                        {
                            GlobalVariables.nirr[GlobalVariables.Groups[this.m_CurrIrrGroup, num]] = (float) Conversion.Val(this.udNIRR.Value);
                        }
                        num = (short) (num + 1);
                    }
                }
                this.Update_Irr(ref GlobalVariables.Groups[this.m_CurrIrrGroup, 1]);
            }
        }

        public void Update_Irr(ref short Y)
        {
            this.flx_Parameters[3].Rows = (int) Math.Round((double) (GlobalVariables.nirr[Y] + 1f));
            this.irr_x = this.flx_Parameters[3].get_ColPos(1);
            short num3 = (short) Math.Round((double) GlobalVariables.nirr[Y]);
            short row = 1;
            while (true)
            {
                short num4 = num3;
                if (row > num4)
                {
                    return;
                }
                short col = 5;
                this.flx_Parameters[3].Row = row;
                this.flx_Parameters[3].RowSel = row;
                GlobalVariables.irrig_no[row, Y] = row;
                this.flx_Parameters[3].set_TextMatrix(row, 0, Conversions.ToString((int) GlobalVariables.irrig_no[row, Y]));
                this.flx_Parameters[3].set_TextMatrix(row, 1, Conversions.ToString(GlobalVariables.i_rrday[row, Y]));
                this.flx_Parameters[3].Col = 1;
                this.flx_Parameters[3].ColSel = 1;
                this.qb_c = 0;
                if (GlobalVariables.irrday_c[row] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.irrday_c[row] == 3)
                {
                    this.qb_c = 12;
                }
                this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                this.flx_Parameters[3].set_TextMatrix(row, 2, Conversions.ToString(GlobalVariables.amir[row, Y]));
                this.flx_Parameters[3].Col = 2;
                this.flx_Parameters[3].ColSel = 2;
                this.qb_c = 0;
                if (GlobalVariables.amir_c[row] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.amir_c[row] == 3)
                {
                    this.qb_c = 12;
                }
                this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                this.flx_Parameters[3].set_TextMatrix(row, 3, Conversions.ToString(GlobalVariables.irrstart[row, Y]));
                this.flx_Parameters[3].Col = 3;
                this.flx_Parameters[3].ColSel = 3;
                this.qb_c = 0;
                if (GlobalVariables.irrstart_c[row] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.irrstart_c[row] == 3)
                {
                    this.qb_c = 12;
                }
                this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                this.flx_Parameters[3].set_TextMatrix(row, 4, Conversions.ToString(GlobalVariables.irrend[row, Y]));
                this.flx_Parameters[3].Col = 4;
                this.flx_Parameters[3].ColSel = 4;
                this.qb_c = 0;
                if (GlobalVariables.irrend_c[row] == 2)
                {
                    this.qb_c = 2;
                }
                if (GlobalVariables.irrend_c[row] == 3)
                {
                    this.qb_c = 12;
                }
                this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                {
                    this.flx_Parameters[3].set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.z_fint[row, Y]));
                    this.flx_Parameters[3].Col = col;
                    this.flx_Parameters[3].ColSel = col;
                    this.qb_c = 0;
                    if (GlobalVariables.zfint_c[row] == 2)
                    {
                        this.qb_c = 2;
                    }
                    if (GlobalVariables.zfint_c[row] == 3)
                    {
                        this.qb_c = 12;
                    }
                    this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                    col = (short) (col + 1);
                }
                if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                {
                    this.flx_Parameters[3].set_TextMatrix(row, col, Conversions.ToString(GlobalVariables.c_onci[row, Y]));
                    this.flx_Parameters[3].Col = col;
                    this.flx_Parameters[3].ColSel = col;
                    this.qb_c = 0;
                    if (GlobalVariables.conci_c[row] == 2)
                    {
                        this.qb_c = 2;
                    }
                    if (GlobalVariables.conci_c[row] == 3)
                    {
                        this.qb_c = 12;
                    }
                    this.flx_Parameters[3].CellForeColor = ColorTranslator.FromOle(Information.QBColor(this.qb_c));
                }
                row = (short) (row + 1);
            }
        }

        public void Update_Management()
        {
            AxMSFlexGrid grid = this.flx_Parameters[6];
            if ((grid.Rows - 1) >= this.udNMAN.Value)
            {
                grid.Rows--;
            }
            else
            {
                grid.Rows = this.udNMAN.Value + 1;
                grid.set_TextMatrix(grid.Rows - 1, 0, Conversions.ToString((int) (grid.Rows - 1)));
                grid.set_TextMatrix(grid.Rows - 1, 1, Conversions.ToString(0));
                grid.set_TextMatrix(grid.Rows - 1, 2, Conversions.ToString(0));
                grid.set_TextMatrix(grid.Rows - 1, 3, Conversions.ToString(0));
                grid.set_TextMatrix(grid.Rows - 1, 4, Conversions.ToString(0));
                grid.set_TextMatrix(grid.Rows - 1, 5, Conversions.ToString(0));
            }
            grid = null;
        }

        public virtual Button cmdHelp
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdHelp;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmdHelp = value;
        }

        public virtual Button cmdApply
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdApply;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdApply_Click);
                if (!ReferenceEquals(this._cmdApply, null))
                {
                    this._cmdApply.Click -= handler;
                }
                this._cmdApply = value;
                if (!ReferenceEquals(this._cmdApply, null))
                {
                    this._cmdApply.Click += handler;
                }
            }
        }

        public virtual Button cmdCancel
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdCancel;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdCancel_Click);
                if (!ReferenceEquals(this._cmdCancel, null))
                {
                    this._cmdCancel.Click -= handler;
                }
                this._cmdCancel = value;
                if (!ReferenceEquals(this._cmdCancel, null))
                {
                    this._cmdCancel.Click += handler;
                }
            }
        }

        public virtual Button Command1
        {
            [DebuggerNonUserCode]
            get => 
                this._Command1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command1_Click);
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click -= handler;
                }
                this._Command1 = value;
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click += handler;
                }
            }
        }

        public virtual TextBox _txtBox_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_1 = value;
        }

        public virtual TextBox _txtBox_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this._txtBox_0_TextChanged);
                if (!ReferenceEquals(this.__txtBox_0, null))
                {
                    this.__txtBox_0.TextChanged -= handler;
                }
                this.__txtBox_0 = value;
                if (!ReferenceEquals(this.__txtBox_0, null))
                {
                    this.__txtBox_0.TextChanged += handler;
                }
            }
        }

        public virtual AxMSFlexGrid _flx_Parameters_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_1 = value;
        }

        public virtual ComboBox cmbDeleteYear
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbDeleteYear;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmbDeleteYear = value;
        }

        public virtual Button Command7
        {
            [DebuggerNonUserCode]
            get => 
                this._Command7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command7_Click);
                if (!ReferenceEquals(this._Command7, null))
                {
                    this._Command7.Click -= handler;
                }
                this._Command7 = value;
                if (!ReferenceEquals(this._Command7, null))
                {
                    this._Command7.Click += handler;
                }
            }
        }

        public virtual GroupBox Frame7
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame7 = value;
        }

        public virtual ComboBox cmbYearSW2
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbYearSW2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbYearSW2_Enter);
                EventHandler handler2 = new EventHandler(this.cmbYearSW2_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbYearSW2, null))
                {
                    this._cmbYearSW2.Enter -= handler;
                    this._cmbYearSW2.SelectedIndexChanged -= handler2;
                }
                this._cmbYearSW2 = value;
                if (!ReferenceEquals(this._cmbYearSW2, null))
                {
                    this._cmbYearSW2.Enter += handler;
                    this._cmbYearSW2.SelectedIndexChanged += handler2;
                }
            }
        }

        public virtual TextBox _txtCropDev2_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_8 = value;
        }

        public virtual TextBox _txtCropDev2_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_7 = value;
        }

        public virtual TextBox _txtCropDev2_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_6 = value;
        }

        public virtual TextBox _txtCropDev2_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_5 = value;
        }

        public virtual TextBox _txtCropDev2_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_4 = value;
        }

        public virtual TextBox _txtCropDev2_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_3 = value;
        }

        public virtual TextBox _txtCropDev2_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_2 = value;
        }

        public virtual TextBox _txtCropDev2_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_1 = value;
        }

        public virtual TextBox _txtCropDev2_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev2_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev2_0 = value;
        }

        public virtual Label Label25
        {
            [DebuggerNonUserCode]
            get => 
                this._Label25;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label25 = value;
        }

        public virtual Label _lblCrop_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_8 = value;
        }

        public virtual Label _lblCrop_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_7 = value;
        }

        public virtual Label _lblCrop_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_6 = value;
        }

        public virtual Label _lblCrop_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_5 = value;
        }

        public virtual Label _lblCrop_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_4 = value;
        }

        public virtual Label _lblCrop_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_3 = value;
        }

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
        }

        public virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
        }

        public virtual GroupBox fraCropSW2
        {
            [DebuggerNonUserCode]
            get => 
                this._fraCropSW2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraCropSW2 = value;
        }

        public virtual ComboBox cmbYearSW3
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbYearSW3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbYearSW3_Enter);
                EventHandler handler2 = new EventHandler(this.cmbYearSW3_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbYearSW3, null))
                {
                    this._cmbYearSW3.Enter -= handler;
                    this._cmbYearSW3.SelectedIndexChanged -= handler2;
                }
                this._cmbYearSW3 = value;
                if (!ReferenceEquals(this._cmbYearSW3, null))
                {
                    this._cmbYearSW3.Enter += handler;
                    this._cmbYearSW3.SelectedIndexChanged += handler2;
                }
            }
        }

        public virtual TextBox _txtCropDev3_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev3_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev3_2 = value;
        }

        public virtual TextBox _txtCropDev3_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev3_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev3_1 = value;
        }

        public virtual TextBox _txtCropDev3_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtCropDev3_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtCropDev3_0 = value;
        }

        public virtual Label Label26
        {
            [DebuggerNonUserCode]
            get => 
                this._Label26;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label26 = value;
        }

        public virtual Label _lblCrop_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_2 = value;
        }

        public virtual Label _lblCrop_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_1 = value;
        }

        public virtual Label _lblCrop_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblCrop_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblCrop_0 = value;
        }

        public virtual GroupBox fraCropSw3
        {
            [DebuggerNonUserCode]
            get => 
                this._fraCropSw3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraCropSw3 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_0 = value;
        }

        public virtual Button Command11
        {
            [DebuggerNonUserCode]
            get => 
                this._Command11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command11_Click);
                if (!ReferenceEquals(this._Command11, null))
                {
                    this._Command11.Click -= handler;
                }
                this._Command11 = value;
                if (!ReferenceEquals(this._Command11, null))
                {
                    this._Command11.Click += handler;
                }
            }
        }

        public virtual Button Command18
        {
            [DebuggerNonUserCode]
            get => 
                this._Command18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command18_Click);
                if (!ReferenceEquals(this._Command18, null))
                {
                    this._Command18.Click -= handler;
                }
                this._Command18 = value;
                if (!ReferenceEquals(this._Command18, null))
                {
                    this._Command18.Click += handler;
                }
            }
        }

        public virtual Label _lblHelp_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_0 = value;
        }

        public virtual TabPage _SSTab1_TabPage0
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage0 = value;
        }

        public virtual Label _lblHelp_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_2 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_2 = value;
        }

        public virtual TextBox _txtBox_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_2 = value;
        }

        public virtual Button cmdBrowseForTensionFile
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForTensionFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseForTensionFile_Click);
                if (!ReferenceEquals(this._cmdBrowseForTensionFile, null))
                {
                    this._cmdBrowseForTensionFile.Click -= handler;
                }
                this._cmdBrowseForTensionFile = value;
                if (!ReferenceEquals(this._cmdBrowseForTensionFile, null))
                {
                    this._cmdBrowseForTensionFile.Click += handler;
                }
            }
        }

        public virtual TextBox txtTensionFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtTensionFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtTensionFile = value;
        }

        public virtual TextBox _text1_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_5 = value;
        }

        public virtual TextBox _text1_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_4 = value;
        }

        public virtual TextBox _text1_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_0 = value;
        }

        public virtual TextBox _text1_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_1 = value;
        }

        public virtual TextBox _text1_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_2 = value;
        }

        public virtual TextBox _text1_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__text1_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text1_3 = value;
        }

        public virtual Label _Label1_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_5 = value;
        }

        public virtual Label _Label1_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_4 = value;
        }

        public virtual Label _Label1_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_0 = value;
        }

        public virtual Label _Label1_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_1 = value;
        }

        public virtual Label _Label1_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_2 = value;
        }

        public virtual Label _Label1_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_3 = value;
        }

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
        }

        public virtual CheckBox _Check1_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_9 = value;
        }

        public virtual RadioButton _optVariableToCopy_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__optVariableToCopy_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optVariableToCopy_2 = value;
        }

        public virtual RadioButton _optVariableToCopy_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optVariableToCopy_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optVariableToCopy_1 = value;
        }

        public virtual RadioButton _optVariableToCopy_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optVariableToCopy_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optVariableToCopy_0 = value;
        }

        public virtual CheckBox _Check1_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_1 = value;
        }

        public virtual Button Command2
        {
            [DebuggerNonUserCode]
            get => 
                this._Command2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command2_Click);
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click -= handler;
                }
                this._Command2 = value;
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click += handler;
                }
            }
        }

        public virtual CheckBox _Check1_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_0 = value;
        }

        public virtual CheckBox _Check1_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_2 = value;
        }

        public virtual CheckBox _Check1_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_3 = value;
        }

        public virtual CheckBox _Check1_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_4 = value;
        }

        public virtual CheckBox _Check1_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_5 = value;
        }

        public virtual CheckBox _Check1_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_6 = value;
        }

        public virtual CheckBox _Check1_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_7 = value;
        }

        public virtual CheckBox _Check1_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check1_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check1_8 = value;
        }

        public virtual TextBox Text3
        {
            [DebuggerNonUserCode]
            get => 
                this._Text3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text3 = value;
        }

        public virtual Button Command3
        {
            [DebuggerNonUserCode]
            get => 
                this._Command3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command3_Click);
                if (!ReferenceEquals(this._Command3, null))
                {
                    this._Command3.Click -= handler;
                }
                this._Command3 = value;
                if (!ReferenceEquals(this._Command3, null))
                {
                    this._Command3.Click += handler;
                }
            }
        }

        public virtual Label Label22
        {
            [DebuggerNonUserCode]
            get => 
                this._Label22;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label22 = value;
        }

        public virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
        }

        public virtual GroupBox Frame3
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame3 = value;
        }

        public virtual Button Command4
        {
            [DebuggerNonUserCode]
            get => 
                this._Command4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Command4 = value;
        }

        public virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
        }

        public virtual GroupBox Frame10
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame10 = value;
        }

        public virtual TabPage _SSTab1_TabPage1
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage1 = value;
        }

        public virtual Button cmdStore
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdStore;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmdStore = value;
        }

        public virtual Button cmdClear
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdClear;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdClear_Click);
                if (!ReferenceEquals(this._cmdClear, null))
                {
                    this._cmdClear.Click -= handler;
                }
                this._cmdClear = value;
                if (!ReferenceEquals(this._cmdClear, null))
                {
                    this._cmdClear.Click += handler;
                }
            }
        }

        public virtual Button cmdAggregate
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAggregate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAggregate_Click);
                if (!ReferenceEquals(this._cmdAggregate, null))
                {
                    this._cmdAggregate.Click -= handler;
                }
                this._cmdAggregate = value;
                if (!ReferenceEquals(this._cmdAggregate, null))
                {
                    this._cmdAggregate.Click += handler;
                }
            }
        }

        public virtual ListBox lstYearSubSets
        {
            [DebuggerNonUserCode]
            get => 
                this._lstYearSubSets;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstYearSubSets_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstYearSubSets, null))
                {
                    this._lstYearSubSets.SelectedIndexChanged -= handler;
                }
                this._lstYearSubSets = value;
                if (!ReferenceEquals(this._lstYearSubSets, null))
                {
                    this._lstYearSubSets.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual ListBox lstYears
        {
            [DebuggerNonUserCode]
            get => 
                this._lstYears;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstYears = value;
        }

        public virtual Label Label19
        {
            [DebuggerNonUserCode]
            get => 
                this._Label19;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label19 = value;
        }

        public virtual Label Label14
        {
            [DebuggerNonUserCode]
            get => 
                this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label14 = value;
        }

        public virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
        }

        public virtual GroupBox fraDefineSubSets
        {
            [DebuggerNonUserCode]
            get => 
                this._fraDefineSubSets;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraDefineSubSets = value;
        }

        public virtual RadioButton _optDefinitionType_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optDefinitionType_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optDefinitionType_1 = value;
        }

        public virtual RadioButton _optDefinitionType_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optDefinitionType_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optDefinitionType_0 = value;
        }

        public virtual GroupBox Frame9
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame9 = value;
        }

        public virtual TextBox _txtBox_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_3 = value;
        }

        public virtual TextBox Text8
        {
            [DebuggerNonUserCode]
            get => 
                this._Text8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Text8_MouseMove);
                EventHandler handler2 = new EventHandler(this.Text8_Click);
                EventHandler handler3 = new EventHandler(this.Text8_TextChanged);
                if (!ReferenceEquals(this._Text8, null))
                {
                    this._Text8.MouseMove -= handler;
                    this._Text8.Click -= handler2;
                    this._Text8.TextChanged -= handler3;
                }
                this._Text8 = value;
                if (!ReferenceEquals(this._Text8, null))
                {
                    this._Text8.MouseMove += handler;
                    this._Text8.Click += handler2;
                    this._Text8.TextChanged += handler3;
                }
            }
        }

        public virtual AxMSFlexGrid _flx_Parameters_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_3 = value;
        }

        public virtual Label lblIrrigationYears
        {
            [DebuggerNonUserCode]
            get => 
                this._lblIrrigationYears;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblIrrigationYears = value;
        }

        public virtual Label Label18
        {
            [DebuggerNonUserCode]
            get => 
                this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label18 = value;
        }

        public virtual Label _lblHelp_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_3 = value;
        }

        public virtual Label Label13
        {
            [DebuggerNonUserCode]
            get => 
                this._Label13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label13 = value;
        }

        public virtual Label Label12
        {
            [DebuggerNonUserCode]
            get => 
                this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label12 = value;
        }

        public virtual GroupBox Frame11
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame11 = value;
        }

        public virtual TabPage _SSTab1_TabPage2
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage2 = value;
        }

        public virtual CheckBox _Check2_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_9 = value;
        }

        public virtual ComboBox cmbVariables
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbVariables;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbVariables_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbVariables, null))
                {
                    this._cmbVariables.SelectedIndexChanged -= handler;
                }
                this._cmbVariables = value;
                if (!ReferenceEquals(this._cmbVariables, null))
                {
                    this._cmbVariables.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual Button Command5
        {
            [DebuggerNonUserCode]
            get => 
                this._Command5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command5_Click);
                if (!ReferenceEquals(this._Command5, null))
                {
                    this._Command5.Click -= handler;
                }
                this._Command5 = value;
                if (!ReferenceEquals(this._Command5, null))
                {
                    this._Command5.Click += handler;
                }
            }
        }

        public virtual TextBox Text13
        {
            [DebuggerNonUserCode]
            get => 
                this._Text13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text13 = value;
        }

        public virtual CheckBox _Check2_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_8 = value;
        }

        public virtual CheckBox _Check2_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_7 = value;
        }

        public virtual CheckBox _Check2_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_6 = value;
        }

        public virtual CheckBox _Check2_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_5 = value;
        }

        public virtual CheckBox _Check2_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_4 = value;
        }

        public virtual CheckBox _Check2_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_3 = value;
        }

        public virtual CheckBox _Check2_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_2 = value;
        }

        public virtual CheckBox _Check2_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_1 = value;
        }

        public virtual CheckBox _Check2_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check2_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check2_0 = value;
        }

        public virtual Label Label23
        {
            [DebuggerNonUserCode]
            get => 
                this._Label23;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label23 = value;
        }

        public virtual Label Label36
        {
            [DebuggerNonUserCode]
            get => 
                this._Label36;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label36 = value;
        }

        public virtual Label Label16
        {
            [DebuggerNonUserCode]
            get => 
                this._Label16;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label16 = value;
        }

        public virtual GroupBox Frame6
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame6 = value;
        }

        public virtual TextBox _txtBox_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_4 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_4 = value;
        }

        public virtual Label _lblHelp_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_4 = value;
        }

        public virtual GroupBox Frame12
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame12 = value;
        }

        public virtual TabPage _SSTab1_TabPage3
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage3 = value;
        }

        public virtual TextBox _Text4_13
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_13 = value;
        }

        public virtual TextBox _Text4_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_5 = value;
        }

        public virtual TextBox _Text4_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_4 = value;
        }

        public virtual TextBox _Text4_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_3 = value;
        }

        public virtual TextBox _Text4_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_2 = value;
        }

        public virtual TextBox _Text4_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_1 = value;
        }

        public virtual TextBox _Text4_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_0 = value;
        }

        public virtual TextBox _Text4_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_6 = value;
        }

        public virtual TextBox _Text4_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_7 = value;
        }

        public virtual TextBox _Text4_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_8 = value;
        }

        public virtual TextBox _Text4_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_9 = value;
        }

        public virtual TextBox _Text4_10
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_10 = value;
        }

        public virtual TextBox _Text4_11
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_11 = value;
        }

        public virtual TextBox _Text4_12
        {
            [DebuggerNonUserCode]
            get => 
                this.__Text4_12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Text4_12 = value;
        }

        public virtual Label _Label11_13
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_13 = value;
        }

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        public virtual Label _Label11_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_4 = value;
        }

        public virtual Label _Label11_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_3 = value;
        }

        public virtual Label _Label11_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_2 = value;
        }

        public virtual Label _Label11_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_1 = value;
        }

        public virtual Label _Label11_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_0 = value;
        }

        public virtual Label _Label11_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_5 = value;
        }

        public virtual Label _Label11_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_6 = value;
        }

        public virtual Label _Label11_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_7 = value;
        }

        public virtual Label _Label11_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_8 = value;
        }

        public virtual Label _Label11_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_9 = value;
        }

        public virtual Label _Label11_10
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_10 = value;
        }

        public virtual Label _Label11_11
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_11 = value;
        }

        public virtual Label _Label11_12
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_12 = value;
        }

        public virtual Label lblHelpSite
        {
            [DebuggerNonUserCode]
            get => 
                this._lblHelpSite;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblHelpSite = value;
        }

        public virtual GroupBox Frame4
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame4 = value;
        }

        public virtual TabPage _SSTab1_TabPage4
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage4 = value;
        }

        public virtual Label _lblHelp_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_5 = value;
        }

        public virtual Label Label20
        {
            [DebuggerNonUserCode]
            get => 
                this._Label20;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label20 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_5 = value;
        }

        public virtual CheckBox _Check4_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_9 = value;
        }

        public virtual ComboBox cmbSoluteVariables
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbSoluteVariables;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbSoluteVariables_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbSoluteVariables, null))
                {
                    this._cmbSoluteVariables.SelectedIndexChanged -= handler;
                }
                this._cmbSoluteVariables = value;
                if (!ReferenceEquals(this._cmbSoluteVariables, null))
                {
                    this._cmbSoluteVariables.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual CheckBox _Check4_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_0 = value;
        }

        public virtual CheckBox _Check4_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_1 = value;
        }

        public virtual CheckBox _Check4_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_2 = value;
        }

        public virtual CheckBox _Check4_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_3 = value;
        }

        public virtual CheckBox _Check4_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_4 = value;
        }

        public virtual CheckBox _Check4_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_5 = value;
        }

        public virtual CheckBox _Check4_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_6 = value;
        }

        public virtual CheckBox _Check4_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_7 = value;
        }

        public virtual CheckBox _Check4_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check4_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check4_8 = value;
        }

        public virtual TextBox Text27
        {
            [DebuggerNonUserCode]
            get => 
                this._Text27;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text27 = value;
        }

        public virtual Button Command15
        {
            [DebuggerNonUserCode]
            get => 
                this._Command15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command15_Click);
                if (!ReferenceEquals(this._Command15, null))
                {
                    this._Command15.Click -= handler;
                }
                this._Command15 = value;
                if (!ReferenceEquals(this._Command15, null))
                {
                    this._Command15.Click += handler;
                }
            }
        }

        public virtual Label Label24
        {
            [DebuggerNonUserCode]
            get => 
                this._Label24;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label24 = value;
        }

        public virtual Label Label15
        {
            [DebuggerNonUserCode]
            get => 
                this._Label15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label15 = value;
        }

        public virtual Label Label28
        {
            [DebuggerNonUserCode]
            get => 
                this._Label28;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label28 = value;
        }

        public virtual GroupBox Frame13
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame13 = value;
        }

        public virtual TextBox _txtBox_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_5 = value;
        }

        public virtual TextBox _text12_21
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_21;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_21 = value;
        }

        public virtual TextBox _text12_20
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_20;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_20 = value;
        }

        public virtual TextBox _text12_19
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_19;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_19 = value;
        }

        public virtual TextBox _text12_18
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_18 = value;
        }

        public virtual TextBox _text12_17
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_17;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_17 = value;
        }

        public virtual TextBox _text12_16
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_16;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_16 = value;
        }

        public virtual TextBox _text12_15
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_15 = value;
        }

        public virtual TextBox _text12_14
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_14 = value;
        }

        public virtual TextBox _text12_13
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_13 = value;
        }

        public virtual TextBox _text12_12
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_12 = value;
        }

        public virtual TextBox _text12_11
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_11 = value;
        }

        public virtual TextBox _text12_10
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_10 = value;
        }

        public virtual TextBox _text12_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_9 = value;
        }

        public virtual TextBox _text12_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_8 = value;
        }

        public virtual TextBox _text12_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_7 = value;
        }

        public virtual TextBox _text12_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_6 = value;
        }

        public virtual TextBox _text12_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_5 = value;
        }

        public virtual TextBox _text12_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_4 = value;
        }

        public virtual TextBox _text12_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_3 = value;
        }

        public virtual TextBox _text12_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_2 = value;
        }

        public virtual TextBox _text12_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_1 = value;
        }

        public virtual TextBox _text12_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__text12_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__text12_0 = value;
        }

        public virtual ComboBox cmbIndex
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbIndex;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmbIndex = value;
        }

        public virtual ComboBox cmbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbParameters_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.SelectedIndexChanged -= handler;
                }
                this._cmbParameters = value;
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
        }

        public virtual TextBox txtkoc
        {
            [DebuggerNonUserCode]
            get => 
                this._txtkoc;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtkoc = value;
        }

        public virtual Button cmdKoc
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdKoc;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdKoc_Click);
                if (!ReferenceEquals(this._cmdKoc, null))
                {
                    this._cmdKoc.Click -= handler;
                }
                this._cmdKoc = value;
                if (!ReferenceEquals(this._cmdKoc, null))
                {
                    this._cmdKoc.Click += handler;
                }
            }
        }

        public virtual Button cmdFOCUS
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdFOCUS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdFOCUS_Click);
                if (!ReferenceEquals(this._cmdFOCUS, null))
                {
                    this._cmdFOCUS.Click -= handler;
                }
                this._cmdFOCUS = value;
                if (!ReferenceEquals(this._cmdFOCUS, null))
                {
                    this._cmdFOCUS.Click += handler;
                }
            }
        }

        public virtual TabPage _SSTab1_TabPage5
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage5 = value;
        }

        public virtual TextBox _txtMan_13
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_13 = value;
        }

        public virtual TextBox _txtMan_12
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_12 = value;
        }

        public virtual TextBox _txtMan_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_8 = value;
        }

        public virtual TextBox _txtMan_11
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_11 = value;
        }

        public virtual TextBox _txtMan_10
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_10 = value;
        }

        public virtual TextBox _txtMan_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_9 = value;
        }

        public virtual TextBox _txtMan_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_7 = value;
        }

        public virtual TextBox _txtMan_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_6 = value;
        }

        public virtual TextBox _txtMan_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_5 = value;
        }

        public virtual TextBox _txtMan_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_4 = value;
        }

        public virtual TextBox _txtMan_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_3 = value;
        }

        public virtual TextBox _txtMan_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_2 = value;
        }

        public virtual TextBox _txtMan_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_1 = value;
        }

        public virtual TextBox _txtMan_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtMan_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtMan_0 = value;
        }

        public virtual TextBox _txtBox_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_6 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_6 = value;
        }

        public virtual Label _lblMan_13
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_13 = value;
        }

        public virtual Label _lblMan_12
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_12 = value;
        }

        public virtual Label _lblMan_11
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_11 = value;
        }

        public virtual Label _lblMan_10
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_10 = value;
        }

        public virtual Label _lblMan_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_9 = value;
        }

        public virtual Label _lblMan_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_8 = value;
        }

        public virtual Label _lblMan_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_5 = value;
        }

        public virtual Label _lblMan_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_0 = value;
        }

        public virtual Label _lblMan_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_1 = value;
        }

        public virtual Label _lblMan_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_3 = value;
        }

        public virtual Label _lblMan_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_6 = value;
        }

        public virtual Label _lblMan_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_7 = value;
        }

        public virtual Label _lblMan_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_4 = value;
        }

        public virtual Label _lblMan_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblMan_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblMan_2 = value;
        }

        public virtual Label _lblHelp_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_6 = value;
        }

        public virtual Label Label17
        {
            [DebuggerNonUserCode]
            get => 
                this._Label17;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Label17_MouseMove);
                if (!ReferenceEquals(this._Label17, null))
                {
                    this._Label17.MouseMove -= handler;
                }
                this._Label17 = value;
                if (!ReferenceEquals(this._Label17, null))
                {
                    this._Label17.MouseMove += handler;
                }
            }
        }

        public virtual GroupBox _fraManagement_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraManagement_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraManagement_0 = value;
        }

        public virtual TabPage _SSTab1_TabPage6
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage6 = value;
        }

        public virtual TextBox _txtBox_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_8 = value;
        }

        public virtual Label _lblHelp_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelp_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelp_7 = value;
        }

        public virtual GroupBox Frame8
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame8 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_8 = value;
        }

        public virtual TextBox _txtBox_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtBox_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtBox_7 = value;
        }

        public virtual AxMSFlexGrid _flx_Parameters_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__flx_Parameters_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__flx_Parameters_7 = value;
        }

        public virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
        }

        public virtual Label Label10
        {
            [DebuggerNonUserCode]
            get => 
                this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label10 = value;
        }

        public virtual GroupBox Frame5
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame5 = value;
        }

        public virtual TabPage _SSTab1_TabPage7
        {
            [DebuggerNonUserCode]
            get => 
                this.__SSTab1_TabPage7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__SSTab1_TabPage7 = value;
        }

        public virtual TabControl SSTab1
        {
            [DebuggerNonUserCode]
            get => 
                this._SSTab1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.SSTab1_SelectedIndexChanged);
                if (!ReferenceEquals(this._SSTab1, null))
                {
                    this._SSTab1.SelectedIndexChanged -= handler;
                }
                this._SSTab1 = value;
                if (!ReferenceEquals(this._SSTab1, null))
                {
                    this._SSTab1.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual CheckBoxArray Check1
        {
            [DebuggerNonUserCode]
            get => 
                this._Check1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Check1_CheckStateChanged);
                if (!ReferenceEquals(this._Check1, null))
                {
                    this._Check1.CheckStateChanged -= handler;
                }
                this._Check1 = value;
                if (!ReferenceEquals(this._Check1, null))
                {
                    this._Check1.CheckStateChanged += handler;
                }
            }
        }

        public virtual CheckBoxArray Check2
        {
            [DebuggerNonUserCode]
            get => 
                this._Check2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Check2_CheckStateChanged);
                if (!ReferenceEquals(this._Check2, null))
                {
                    this._Check2.CheckStateChanged -= handler;
                }
                this._Check2 = value;
                if (!ReferenceEquals(this._Check2, null))
                {
                    this._Check2.CheckStateChanged += handler;
                }
            }
        }

        public virtual CheckBoxArray Check4
        {
            [DebuggerNonUserCode]
            get => 
                this._Check4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Check4 = value;
        }

        public virtual LabelArray Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Label1_MouseMove);
                if (!ReferenceEquals(this._Label1, null))
                {
                    this._Label1.MouseMove -= handler;
                }
                this._Label1 = value;
                if (!ReferenceEquals(this._Label1, null))
                {
                    this._Label1.MouseMove += handler;
                }
            }
        }

        public virtual LabelArray Label11
        {
            [DebuggerNonUserCode]
            get => 
                this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Label11_MouseMove);
                if (!ReferenceEquals(this._Label11, null))
                {
                    this._Label11.MouseMove -= handler;
                }
                this._Label11 = value;
                if (!ReferenceEquals(this._Label11, null))
                {
                    this._Label11.MouseMove += handler;
                }
            }
        }

        public virtual TextBoxArray Text4
        {
            [DebuggerNonUserCode]
            get => 
                this._Text4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Text4_TextChanged);
                MouseEventHandler handler2 = new MouseEventHandler(this.Text4_MouseMove);
                if (!ReferenceEquals(this._Text4, null))
                {
                    this._Text4.TextChanged -= handler;
                    this._Text4.MouseMove -= handler2;
                }
                this._Text4 = value;
                if (!ReferenceEquals(this._Text4, null))
                {
                    this._Text4.TextChanged += handler;
                    this._Text4.MouseMove += handler2;
                }
            }
        }

        public virtual AxMSFlexGridArray.AxMSFlexGridArray flx_Parameters
        {
            [DebuggerNonUserCode]
            get => 
                this._flx_Parameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                AxMSFlexGridArray.AxMSFlexGridArray.ScrollEventHandler handler = new AxMSFlexGridArray.AxMSFlexGridArray.ScrollEventHandler(this.flx_Parameters_Scroll);
                AxMSFlexGridArray.AxMSFlexGridArray.MouseMoveEventEventHandler handler2 = new AxMSFlexGridArray.AxMSFlexGridArray.MouseMoveEventEventHandler(this.flx_Parameters_MouseMoveEvent);
                AxMSFlexGridArray.AxMSFlexGridArray.LeaveCellEventHandler handler3 = new AxMSFlexGridArray.AxMSFlexGridArray.LeaveCellEventHandler(this.flx_Parameters_LeaveCell);
                AxMSFlexGridArray.AxMSFlexGridArray.KeyDownEventEventHandler handler4 = new AxMSFlexGridArray.AxMSFlexGridArray.KeyDownEventEventHandler(this.flx_Parameters_KeyDownEvent);
                AxMSFlexGridArray.AxMSFlexGridArray.ClickEventEventHandler handler5 = new AxMSFlexGridArray.AxMSFlexGridArray.ClickEventEventHandler(this.flx_Parameters_ClickEvent);
                if (!ReferenceEquals(this._flx_Parameters, null))
                {
                    this._flx_Parameters.Scroll -= handler;
                    this._flx_Parameters.MouseMoveEvent -= handler2;
                    this._flx_Parameters.LeaveCell -= handler3;
                    this._flx_Parameters.KeyDownEvent -= handler4;
                    this._flx_Parameters.ClickEvent -= handler5;
                }
                this._flx_Parameters = value;
                if (!ReferenceEquals(this._flx_Parameters, null))
                {
                    this._flx_Parameters.Scroll += handler;
                    this._flx_Parameters.MouseMoveEvent += handler2;
                    this._flx_Parameters.LeaveCell += handler3;
                    this._flx_Parameters.KeyDownEvent += handler4;
                    this._flx_Parameters.ClickEvent += handler5;
                }
            }
        }

        public virtual GroupBoxArray fraManagement
        {
            [DebuggerNonUserCode]
            get => 
                this._fraManagement;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraManagement = value;
        }

        public virtual LabelArray lblCrop
        {
            [DebuggerNonUserCode]
            get => 
                this._lblCrop;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblCrop = value;
        }

        public virtual LabelArray lblHelp
        {
            [DebuggerNonUserCode]
            get => 
                this._lblHelp;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblHelp = value;
        }

        public virtual LabelArray lblMan
        {
            [DebuggerNonUserCode]
            get => 
                this._lblMan;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.lblMan_MouseMove);
                if (!ReferenceEquals(this._lblMan, null))
                {
                    this._lblMan.MouseMove -= handler;
                }
                this._lblMan = value;
                if (!ReferenceEquals(this._lblMan, null))
                {
                    this._lblMan.MouseMove += handler;
                }
            }
        }

        public virtual RadioButtonArray optDefinitionType
        {
            [DebuggerNonUserCode]
            get => 
                this._optDefinitionType;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optDefinitionType_CheckedChanged);
                if (!ReferenceEquals(this._optDefinitionType, null))
                {
                    this._optDefinitionType.CheckedChanged -= handler;
                }
                this._optDefinitionType = value;
                if (!ReferenceEquals(this._optDefinitionType, null))
                {
                    this._optDefinitionType.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optVariableToCopy
        {
            [DebuggerNonUserCode]
            get => 
                this._optVariableToCopy;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optVariableToCopy = value;
        }

        public virtual TextBoxArray text1
        {
            [DebuggerNonUserCode]
            get => 
                this._text1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Text1_MouseMove);
                EventHandler handler2 = new EventHandler(this.Text1_TextChanged);
                if (!ReferenceEquals(this._text1, null))
                {
                    this._text1.MouseMove -= handler;
                    this._text1.TextChanged -= handler2;
                }
                this._text1 = value;
                if (!ReferenceEquals(this._text1, null))
                {
                    this._text1.MouseMove += handler;
                    this._text1.TextChanged += handler2;
                }
            }
        }

        public virtual TextBoxArray text12
        {
            [DebuggerNonUserCode]
            get => 
                this._text12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Text12_MouseMove);
                EventHandler handler2 = new EventHandler(this.Text12_TextChanged);
                if (!ReferenceEquals(this._text12, null))
                {
                    this._text12.MouseMove -= handler;
                    this._text12.TextChanged -= handler2;
                }
                this._text12 = value;
                if (!ReferenceEquals(this._text12, null))
                {
                    this._text12.MouseMove += handler;
                    this._text12.TextChanged += handler2;
                }
            }
        }

        public virtual TextBoxArray txtBox
        {
            [DebuggerNonUserCode]
            get => 
                this._txtBox;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtBox_Leave);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtBox_KeyPress);
                EventHandler handler3 = new EventHandler(this.txtBox_TextChanged);
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.Leave -= handler;
                    this._txtBox.KeyPress -= handler2;
                    this._txtBox.TextChanged -= handler3;
                }
                this._txtBox = value;
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.Leave += handler;
                    this._txtBox.KeyPress += handler2;
                    this._txtBox.TextChanged += handler3;
                }
            }
        }

        public virtual TextBoxArray txtCropDev2
        {
            [DebuggerNonUserCode]
            get => 
                this._txtCropDev2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.txtCropDev2_MouseMove);
                EventHandler handler2 = new EventHandler(this.txtCropDev2_Click);
                EventHandler handler3 = new EventHandler(this.txtCropDev2_TextChanged);
                if (!ReferenceEquals(this._txtCropDev2, null))
                {
                    this._txtCropDev2.MouseMove -= handler;
                    this._txtCropDev2.Click -= handler2;
                    this._txtCropDev2.TextChanged -= handler3;
                }
                this._txtCropDev2 = value;
                if (!ReferenceEquals(this._txtCropDev2, null))
                {
                    this._txtCropDev2.MouseMove += handler;
                    this._txtCropDev2.Click += handler2;
                    this._txtCropDev2.TextChanged += handler3;
                }
            }
        }

        public virtual TextBoxArray txtCropDev3
        {
            [DebuggerNonUserCode]
            get => 
                this._txtCropDev3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.txtCropDev3_MouseMove);
                EventHandler handler2 = new EventHandler(this.txtCropDev3_Click);
                EventHandler handler3 = new EventHandler(this.txtCropDev3_TextChanged);
                if (!ReferenceEquals(this._txtCropDev3, null))
                {
                    this._txtCropDev3.MouseMove -= handler;
                    this._txtCropDev3.Click -= handler2;
                    this._txtCropDev3.TextChanged -= handler3;
                }
                this._txtCropDev3 = value;
                if (!ReferenceEquals(this._txtCropDev3, null))
                {
                    this._txtCropDev3.MouseMove += handler;
                    this._txtCropDev3.Click += handler2;
                    this._txtCropDev3.TextChanged += handler3;
                }
            }
        }

        public virtual TextBoxArray txtMan
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMan;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.txtMan_MouseMove);
                EventHandler handler2 = new EventHandler(this.txtMan_Leave);
                EventHandler handler3 = new EventHandler(this.txtMan_TextChanged);
                if (!ReferenceEquals(this._txtMan, null))
                {
                    this._txtMan.MouseMove -= handler;
                    this._txtMan.Leave -= handler2;
                    this._txtMan.TextChanged -= handler3;
                }
                this._txtMan = value;
                if (!ReferenceEquals(this._txtMan, null))
                {
                    this._txtMan.MouseMove += handler;
                    this._txtMan.Leave += handler2;
                    this._txtMan.TextChanged += handler3;
                }
            }
        }

        internal virtual NumericUpDown udNIRR
        {
            [DebuggerNonUserCode]
            get => 
                this._udNIRR;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.udNIRR_ValueChanged);
                if (!ReferenceEquals(this._udNIRR, null))
                {
                    this._udNIRR.ValueChanged -= handler;
                }
                this._udNIRR = value;
                if (!ReferenceEquals(this._udNIRR, null))
                {
                    this._udNIRR.ValueChanged += handler;
                }
            }
        }

        internal virtual TextBox txtCropParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._txtCropParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtcropparameters_TextChanged);
                EventHandler handler2 = new EventHandler(this.txtcropparameters_Leave);
                KeyPressEventHandler handler3 = new KeyPressEventHandler(this.txtcropparameters_KeyPress);
                if (!ReferenceEquals(this._txtCropParameters, null))
                {
                    this._txtCropParameters.TextChanged -= handler;
                    this._txtCropParameters.Leave -= handler2;
                    this._txtCropParameters.KeyPress -= handler3;
                }
                this._txtCropParameters = value;
                if (!ReferenceEquals(this._txtCropParameters, null))
                {
                    this._txtCropParameters.TextChanged += handler;
                    this._txtCropParameters.Leave += handler2;
                    this._txtCropParameters.KeyPress += handler3;
                }
            }
        }

        internal virtual TextBox txtIBCond
        {
            [DebuggerNonUserCode]
            get => 
                this._txtIBCond;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtIBCond_TextChanged);
                EventHandler handler2 = new EventHandler(this.txtIBCond_Leave);
                KeyPressEventHandler handler3 = new KeyPressEventHandler(this.txtIBCond_KeyPress);
                if (!ReferenceEquals(this._txtIBCond, null))
                {
                    this._txtIBCond.TextChanged -= handler;
                    this._txtIBCond.Leave -= handler2;
                    this._txtIBCond.KeyPress -= handler3;
                }
                this._txtIBCond = value;
                if (!ReferenceEquals(this._txtIBCond, null))
                {
                    this._txtIBCond.TextChanged += handler;
                    this._txtIBCond.Leave += handler2;
                    this._txtIBCond.KeyPress += handler3;
                }
            }
        }

        internal virtual TextBox txtSolute
        {
            [DebuggerNonUserCode]
            get => 
                this._txtSolute;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtsolute_TextChanged);
                EventHandler handler2 = new EventHandler(this.txtsolute_Leave);
                KeyPressEventHandler handler3 = new KeyPressEventHandler(this.txtsolute_KeyPress);
                if (!ReferenceEquals(this._txtSolute, null))
                {
                    this._txtSolute.TextChanged -= handler;
                    this._txtSolute.Leave -= handler2;
                    this._txtSolute.KeyPress -= handler3;
                }
                this._txtSolute = value;
                if (!ReferenceEquals(this._txtSolute, null))
                {
                    this._txtSolute.TextChanged += handler;
                    this._txtSolute.Leave += handler2;
                    this._txtSolute.KeyPress += handler3;
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get => 
                this._GroupBox1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._GroupBox1 = value;
        }

        internal virtual Button btnCalculatePedotransfer
        {
            [DebuggerNonUserCode]
            get => 
                this._btnCalculatePedotransfer;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnCalculatePedotransfer_Click);
                if (!ReferenceEquals(this._btnCalculatePedotransfer, null))
                {
                    this._btnCalculatePedotransfer.Click -= handler;
                }
                this._btnCalculatePedotransfer = value;
                if (!ReferenceEquals(this._btnCalculatePedotransfer, null))
                {
                    this._btnCalculatePedotransfer.Click += handler;
                }
            }
        }

        internal virtual RadioButton optFOOTPRINTPedotransfer
        {
            [DebuggerNonUserCode]
            get => 
                this._optFOOTPRINTPedotransfer;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optFOOTPRINTPedotransfer = value;
        }

        internal virtual RadioButton optMACROPedotransfer
        {
            [DebuggerNonUserCode]
            get => 
                this._optMACROPedotransfer;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optMACROPedotransfer = value;
        }

        private AxUpDown udNMAN
        {
            [DebuggerNonUserCode]
            get => 
                this._udNMAN;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._udNMAN = value;
        }

        internal virtual NumericUpDown txtNMan
        {
            [DebuggerNonUserCode]
            get => 
                this._txtNMan;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtNMan = value;
        }

        public bool IsEditing
        {
            get => 
                this.m_IsEditing;
            set => 
                this.m_IsEditing = value;
        }
    }
}

