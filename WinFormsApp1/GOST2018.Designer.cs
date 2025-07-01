namespace WinFormsApp1
{
    partial class GOST2018
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelSVBAuthors;
        private Label labelSVBTitle;
        private Label labelSVBPublishingLocation;
        private Label labelSVBPublisher;
        private Label labelSVBPublishYear;
        private Label labelSVBPagesCount;
        private TextBox tbSVBAuthors;
        private Button buttonSVBAuthorsAdd;
        private ListBox lbSVBAuthors;
        private Label labelSVBDocumentType;
        private Label labelSVBEditor;
        private Label labelSVBEditionNumber;
        private Label labelSVBSeries;
        private Label labelSVBISBN;
        private Label labelSVBTranslator;
        private Label labelSVBOrganization;
        private SplitContainer splitContainer1;
        private TabControl tcSVTypes;
        private TabPage tpSVBook;
        private TabPage tpSVGOST;
        private GroupBox gpSVBookRequired;
        private GroupBox gpSVBookOptional;
        private TextBox tbSVBTitle;
        private TextBox tbSVBPublishingLocation;
        private TextBox tbSVBPublisher;
        private TextBox tbSVBPublishYear;
        private TextBox tbSVBPagesCount;
        private TextBox tbSVBDocumentType;
        private TextBox tbSVBEditor;
        private TextBox tbSVBEditionNumber;
        private TextBox tbSVBSeries;
        private TextBox tbSVBISBN;
        private TextBox tbSVBTranslator;
        private TextBox tbSVBOrganization;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new global::System.ComponentModel.Container();
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WinFormsApp1.GOST2018));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            buttonToGOST2008 = new Button();
            buttonFillForm = new Button();
            panelRtbMLA = new Panel();
            rtbMLA = new RichTextBox();
            cmsRichTextBox_TextBox = new ContextMenuStrip(this.components);
            tsmiClearRichTextBox = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiUndoRichTextBox = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiCutRichTextBox = new ToolStripMenuItem();
            tsmiCopyRichTextBox = new ToolStripMenuItem();
            tsmiPasteRichTextBox = new ToolStripMenuItem();
            tsmiDeleteRichTextBox = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsmiSelectAllRichTextBox = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            tsmiUnableClearingRichTextBox1 = new ToolStripMenuItem();
            tsmiUnableClearingRichTextBox2 = new ToolStripMenuItem();
            panelRtbGOST = new Panel();
            rtbGOST = new RichTextBox();
            panelConvertTitle = new Panel();
            labelConvert = new Label();
            labelGOST = new Label();
            labelMLA = new Label();
            buttonConvert = new Button();
            buttonPDFExportResult = new Button();
            buttonWordExportResult = new Button();
            buttonCopyResult = new Button();
            labelResult = new Label();
            lbResult = new ListBox();
            cmsListBox = new ContextMenuStrip(this.components);
            tsmiUndo = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            tsmiDeleteAll = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            tsmiDeleteSelected = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            tsmiCopy = new ToolStripMenuItem();
            tsmiRestoreEntry = new ToolStripMenuItem();
            panelAddRecord = new Panel();
            buttonAddRecord = new Button();
            cbWordAbbreviation = new CheckBox();
            tcCategories = new TabControl();
            cmsMainTabControl = new ContextMenuStrip(this.components);
            tsmiSaveFormData = new ToolStripMenuItem();
            tsmiRestoreLastEntry = new ToolStripMenuItem();
            tsmiClearForm = new ToolStripMenuItem();
            tpSingleVolume = new TabPage();
            tcSVTypes = new TabControl();
            tpSVBook = new TabPage();
            gpSVBookRequired = new GroupBox();
            panelSVBookRequired = new Panel();
            lbSVBPublishingLocationSelect = new ListBox();
            cbSVBPublisher = new CheckBox();
            cbSVBAuthors = new CheckBox();
            buttonSVBPublisherAdd = new Button();
            lbSVBPublisher = new ListBox();
            buttonSVBPublishingLocationAdd = new Button();
            lbSVBPublishingLocation = new ListBox();
            labelSVBAuthors = new Label();
            tbSVBAuthors = new TextBox();
            buttonSVBAuthorsAdd = new Button();
            lbSVBAuthors = new ListBox();
            tbSVBPublishYear = new TextBox();
            labelSVBTitle = new Label();
            labelSVBPublishYear = new Label();
            tbSVBTitle = new TextBox();
            tbSVBPublisher = new TextBox();
            labelSVBPublishingLocation = new Label();
            labelSVBPublisher = new Label();
            tbSVBPublishingLocation = new TextBox();
            gpSVBookOptional = new GroupBox();
            panelSVBookOptional = new Panel();
            cbSVBEditorType = new ComboBox();
            labelSVBOrganization = new Label();
            tbSVBOrganization = new TextBox();
            lbSVBEditor = new ListBox();
            buttonSVBEditorAdd = new Button();
            labelSVBParallelTitle = new Label();
            tbSVBParallelTitle = new TextBox();
            tbSVBPagesCount = new TextBox();
            labelSVBContentType = new Label();
            labelSVBPagesCount = new Label();
            tbSVBContentType = new TextBox();
            labelSVBDocumentType = new Label();
            tbSVBDocumentType = new TextBox();
            labelSVBEditor = new Label();
            tbSVBTranslator = new TextBox();
            tbSVBEditor = new TextBox();
            labelSVBTranslator = new Label();
            labelSVBEditionNumber = new Label();
            tbSVBISBN = new TextBox();
            tbSVBEditionNumber = new TextBox();
            labelSVBISBN = new Label();
            labelSVBSeries = new Label();
            tbSVBSeries = new TextBox();
            tpSVConferenceMaterials = new TabPage();
            gbSVConferenceMaterialsRequired = new GroupBox();
            panelSVConferenceMaterialsRequired = new Panel();
            lbSVCMPublishingLocationSelect = new ListBox();
            cbSVCMPublisher = new CheckBox();
            buttonSVCMPublisherAdd = new Button();
            lbSVCMPublisher = new ListBox();
            buttonSVCMPublishingLocationAdd = new Button();
            lbSVCMPublishingLocation = new ListBox();
            tbSVCMPublisher = new TextBox();
            labelSVCMPublisher = new Label();
            tbSVCMPublishingLocation = new TextBox();
            labelSVCMPublishingLocation = new Label();
            tbSVCMEventDate = new TextBox();
            labelSVCMEventDate = new Label();
            labelSVCMEventTitle = new Label();
            tbSVCMEventTitle = new TextBox();
            tbSVCMPublishYear = new TextBox();
            labelSVCMPublishYear = new Label();
            tbSVCMEventPlace = new TextBox();
            labelSVCMPublicationType = new Label();
            labelSVCMEventPlace = new Label();
            tbSVCMPublicationType = new TextBox();
            gbSVConferenceMaterialsOptional = new GroupBox();
            panelSVConferenceMaterialsOptional = new Panel();
            cbSVCMEditorType = new ComboBox();
            lbSVCMEditor = new ListBox();
            buttonSVCMEditorAdd = new Button();
            labelSVCMPartNumberAndTitle = new Label();
            tbSVCMPartNumberAndTitle = new TextBox();
            labelSVCMContentType = new Label();
            tbSVCMContentType = new TextBox();
            labelSVCMPartCount = new Label();
            tbSVCMPartCount = new TextBox();
            tbSVCMPagesCount = new TextBox();
            labelSVCMISBN = new Label();
            labelSVCMPagesCount = new Label();
            tbSVCMEditor = new TextBox();
            tbSVCMISBN = new TextBox();
            labelSVCMEditor = new Label();
            tpSVGOST = new TabPage();
            gbSVGOSTRequired = new GroupBox();
            panelSVGOSTRequired = new Panel();
            lbSVGOSTPublishingLocationSelect = new ListBox();
            cbSVGOSTPublisher = new CheckBox();
            buttonSVGOSTPublisher = new Button();
            lbSVGOSTPublisher = new ListBox();
            tbSVGOSTPublisher = new TextBox();
            buttonSVGOSTPublishingLocationAdd = new Button();
            lbSVGOSTPublishingLocation = new ListBox();
            tbSVGOSTPublishingLocation = new TextBox();
            labelSVGOSTTitle = new Label();
            labelSVGOSTDocumentNumber = new Label();
            tbSVGOSTPublishYear = new TextBox();
            tbSVGOSTDocumentNumber = new TextBox();
            labelSVGOSTPublishYear = new Label();
            tbSVGOSTTitle = new TextBox();
            labelSVGOSTPublisher = new Label();
            labelSVGOSTPublishingLocation = new Label();
            gbSVGOSTOptional = new GroupBox();
            panelSVGOSTOptional = new Panel();
            cbGOSTFirstTime = new CheckBox();
            labelSVGOSTAdditions = new Label();
            tbSVGOSTAdditions = new TextBox();
            labelSVGOSTParallelTitle = new Label();
            tbSVGOSTParallelTitle = new TextBox();
            labelSVGOSTDocumentType = new Label();
            tbSVGOSTContentType = new TextBox();
            labelSVGOSTPagesCount = new Label();
            labelSVGOSTContentType = new Label();
            tbSVGOSTPagesCount = new TextBox();
            tbSVGOSTDeveloper = new TextBox();
            labelSVGOSTDeveloper = new Label();
            tbSVGOSTDocumentType = new TextBox();
            tbSVGOSTImplementDate = new TextBox();
            labelSVGOSTApprovalDate = new Label();
            labelSVGOSTImplementDate = new Label();
            tbSVGOSTApprovalDate = new TextBox();
            tpSVLegislativeMaterial = new TabPage();
            gbSVLegislativeMaterialRequired = new GroupBox();
            panelSVLegislativeMaterialRequired = new Panel();
            lbSVLMPublishingLocationSelect = new ListBox();
            cbSVLMPublisher = new CheckBox();
            buttonSVLMPublisher = new Button();
            lbSVLMPublisher = new ListBox();
            tbSVLMPublisher = new TextBox();
            buttonSVLMPublishingLocationAdd = new Button();
            lbSVLMPublishingLocation = new ListBox();
            tbSVLMPublishingLocation = new TextBox();
            labelSVLMTitle = new Label();
            tbSVLMPublishYear = new TextBox();
            labelSVLMPublishYear = new Label();
            tbSVLMTitle = new TextBox();
            labelSVLMPublisher = new Label();
            labelSVLMPublishingLocation = new Label();
            gbSVLegislativeMaterialOptional = new GroupBox();
            panelSVLegislativeMaterialOptional = new Panel();
            tbSVLMImplementDate = new TextBox();
            labelSVLMImplementDate = new Label();
            labelSVLMDocumentType = new Label();
            tbSVLMDocumentType = new TextBox();
            tbSVLMApprovalDate = new TextBox();
            labelSVLMApprovalDate = new Label();
            tbSVLMISBN = new TextBox();
            labelSVLMISBN = new Label();
            labelSVLMAbbreviation = new Label();
            tbSVLMAbbreviation = new TextBox();
            labelSVLMAdditions = new Label();
            tbSVLMContentType = new TextBox();
            labelSVLMPagesCount = new Label();
            labelSVLMContentType = new Label();
            tbSVLMPagesCount = new TextBox();
            tbSVLMSeries = new TextBox();
            labelSVLMSeries = new Label();
            tbSVLMAdditions = new TextBox();
            tpSVDissertationAbstract = new TabPage();
            gbSVDissertationAbstractRequired = new GroupBox();
            panelSVDissertationAbstractRequired = new Panel();
            labelSVDADefenseLocation = new Label();
            labelSVDAAuthor = new Label();
            tbSVDADefenseLocation = new TextBox();
            tbSVDAPublishingLocation = new TextBox();
            labelSVDAPublishingLocation = new Label();
            tbSVDADegree = new TextBox();
            labelSVDAPublishYear = new Label();
            labelSVDADegree = new Label();
            tbSVDAPublishYear = new TextBox();
            tbSVDASpecialty = new TextBox();
            labelSVDATitle = new Label();
            labelSVDASpecialty = new Label();
            tbSVDATitle = new TextBox();
            tbSVDAAuthor = new TextBox();
            gbSVDissertationAbstractOptional = new GroupBox();
            panelSVDissertationAbstractOptional = new Panel();
            labelSVDAContentType = new Label();
            tbSVDABibliography = new TextBox();
            tbSVDAContentType = new TextBox();
            labelSVDABibliography = new Label();
            labelSVDAPagesCount = new Label();
            tbSVDAOrganization = new TextBox();
            tbSVDAPagesCount = new TextBox();
            labelSVDAOrganization = new Label();
            tpSVDissertation = new TabPage();
            gbSVDissertationRequired = new GroupBox();
            panelSVDissertationRequired = new Panel();
            labelSVDAuthor = new Label();
            tbSVDPublishingLocation = new TextBox();
            labelSVDPublishingLocation = new Label();
            tbSVDDegree = new TextBox();
            labelSVDPublishYear = new Label();
            labelSVDDegree = new Label();
            tbSVDPublishYear = new TextBox();
            tbSVDSpecialty = new TextBox();
            labelSVDTitle = new Label();
            labelSVDSpecialty = new Label();
            tbSVDTitle = new TextBox();
            tbSVDAuthor = new TextBox();
            gbSVDissertationOptional = new GroupBox();
            panelSVDissertationOptional = new Panel();
            labelSVDContentType = new Label();
            tbSVDBibliography = new TextBox();
            tbSVDContentType = new TextBox();
            labelSVDBibliography = new Label();
            labelSVDPagesCount = new Label();
            tbSVDOrganization = new TextBox();
            tbSVDPagesCount = new TextBox();
            labelSVDOrganization = new Label();
            tpMultiVolume = new TabPage();
            tcMVTypes = new TabControl();
            tpMVWholeMultivolume = new TabPage();
            gbMVWholeMultivolumeRequired = new GroupBox();
            panelMVWholeMultivolumeRequired = new Panel();
            lbMVWMPublishingLocationSelect = new ListBox();
            cbMVWMPublisher = new CheckBox();
            cbMVWMAuthors = new CheckBox();
            buttonMVWMPublisherAdd = new Button();
            lbMVWMPublisher = new ListBox();
            buttonMVWMPublishingLocationAdd = new Button();
            lbMVWMPublishingLocation = new ListBox();
            labelMVWMAuthors = new Label();
            tbMVWMPublishYear = new TextBox();
            labelMVWMPublishYear = new Label();
            tbMVWMAuthors = new TextBox();
            tbMVWMPublisher = new TextBox();
            buttonMVWMAuthorsAdd = new Button();
            labelMVWMPublisher = new Label();
            lbMVWMAuthors = new ListBox();
            tbMVWMPublishingLocation = new TextBox();
            labelMVWMTitle = new Label();
            labelMVWMPublishingLocation = new Label();
            tbMVWMTitle = new TextBox();
            tbMVWMVolumesCount = new TextBox();
            labelMVWMVolumesCount = new Label();
            gbMVWholeMultivolumeOptional = new GroupBox();
            panelMVWholeMultivolumeOptional = new Panel();
            labelMVWMTranslator = new Label();
            tbMVWMTranslator = new TextBox();
            labelMVWMOrganization = new Label();
            tbMVWMOrganization = new TextBox();
            labelMVWMParallelTitle = new Label();
            tbMVWMParallelTitle = new TextBox();
            labelMVWMContentType = new Label();
            tbMVWMContentType = new TextBox();
            cbMVWMEditorType = new ComboBox();
            lbMVWMEditor = new ListBox();
            buttonMVWMEditorAdd = new Button();
            labelMVWMDocumentType = new Label();
            tbMVWMISBN = new TextBox();
            labelMVWMSeries = new Label();
            tbMVWMEditor = new TextBox();
            labelMVWMPagesCount = new Label();
            tbMVWMSeries = new TextBox();
            tbMVWMPagesCount = new TextBox();
            tbMVWMEditionNumber = new TextBox();
            labelMVWMISBN = new Label();
            tbMVWMDocumentType = new TextBox();
            labelMVWMEditionNumber = new Label();
            labelMVWMEditor = new Label();
            tpMVSeparateVolume = new TabPage();
            gbMVSeparateVolumeRequired = new GroupBox();
            panelMVSeparateVolumeRequired = new Panel();
            lbMVSVPublishingLocationSelect = new ListBox();
            cbMVSVPublisher = new CheckBox();
            cbMVSVAuthors = new CheckBox();
            buttonMVSVPublisherAdd = new Button();
            lbMVSVPublisher = new ListBox();
            buttonMVSVPublishingLocationAdd = new Button();
            lbMVSVPublishingLocation = new ListBox();
            labelMVSVAuthors = new Label();
            tbMVSVPublishingLocation = new TextBox();
            labelMVSVPublishYear = new Label();
            labelMVSVPublishingLocation = new Label();
            tbMVSVPublishYear = new TextBox();
            labelMVSVPublisher = new Label();
            tbMVSVPublisher = new TextBox();
            tbMVSVVolumeNumber = new TextBox();
            labelMVSVVolumeNumber = new Label();
            tbMVSVAuthors = new TextBox();
            tbMVSVVolumesCount = new TextBox();
            buttonMVSVAuthorsAdd = new Button();
            labelMVSVVolumesCount = new Label();
            lbMVSVAuthors = new ListBox();
            tbMVSVTitle = new TextBox();
            labelMVSVTitle = new Label();
            gbMVSeparateVolumeOptional = new GroupBox();
            panelMVSeparateVolumeOptional = new Panel();
            labelMVSVTranslator = new Label();
            tbMVSVTranslator = new TextBox();
            labelMVSVOrganization = new Label();
            tbMVSVOrganization = new TextBox();
            labelMVSVParallelTitle = new Label();
            tbMVSVParallelTitle = new TextBox();
            cbMVSVEditorType = new ComboBox();
            lbMVSVEditor = new ListBox();
            buttonMVSVEditorAdd = new Button();
            labelMVSVContentType = new Label();
            tbMVSVVolumeTitle = new TextBox();
            tbMVSVContentType = new TextBox();
            labelMVSVDocumentType = new Label();
            labelMVSVVolumeTitle = new Label();
            tbMVSVEditor = new TextBox();
            tbMVSVDocumentType = new TextBox();
            labelMVSVISBN = new Label();
            labelMVSVPagesCount = new Label();
            tbMVSVSeries = new TextBox();
            tbMVSVPagesCount = new TextBox();
            labelMVSVEditionNumber = new Label();
            labelMVSVSeries = new Label();
            labelMVSVEditor = new Label();
            tbMVSVEditionNumber = new TextBox();
            tbMVSVISBN = new TextBox();
            tpElectronicResources = new TabPage();
            tcERTypes = new TabControl();
            tpEREbook = new TabPage();
            gbEREbookRequired = new GroupBox();
            panelEREbookRequired = new Panel();
            lbEREbPublishingLocationSelect = new ListBox();
            cbEREbPublisher = new CheckBox();
            cbEREbAuthors = new CheckBox();
            buttonEREbPublisherAdd = new Button();
            lbEREbPublisher = new ListBox();
            buttonEREbPublishingLocationAdd = new Button();
            lbEREbPublishingLocation = new ListBox();
            labelEREbAccessMode = new Label();
            tbEREbAccessMode = new TextBox();
            labelEREbAccessDate = new Label();
            labelEREbAuthors = new Label();
            tbEREbAccessDate = new TextBox();
            tbEREbURL = new TextBox();
            labelEREbURL = new Label();
            tbEREbAuthors = new TextBox();
            tbEREbPublishYear = new TextBox();
            labelEREbAuthorsAdd = new Button();
            labelEREbPublishYear = new Label();
            lbEREbAuthors = new ListBox();
            tbEREbPublisher = new TextBox();
            labelEREbTitle = new Label();
            labelEREbPublisher = new Label();
            tbEREbTitle = new TextBox();
            tbEREbPublishingLocation = new TextBox();
            labelEREbPublishingLocation = new Label();
            gbEREbookOptional = new GroupBox();
            panelEREbookOptional = new Panel();
            labelEREbTranslator = new Label();
            tbEREbTranslator = new TextBox();
            labelEREbOrganization = new Label();
            tbEREbOrganization = new TextBox();
            labelEREbParallelTitle = new Label();
            tbEREbParallelTitle = new TextBox();
            labelEREbContentType = new Label();
            tbEREbContentType = new TextBox();
            cbEREbEditorType = new ComboBox();
            lbEREbEditor = new ListBox();
            buttonEREbEditorAdd = new Button();
            labelEREbISBN = new Label();
            tbEREbISBN = new TextBox();
            labelEREbDocumentType = new Label();
            tbEREbSeries = new TextBox();
            tbEREbDocumentType = new TextBox();
            labelEREbSeries = new Label();
            tbEREbPagesCount = new TextBox();
            labelEREbPagesCount = new Label();
            labelEREbEditor = new Label();
            tbEREbEditionNumber = new TextBox();
            tbEREbEditor = new TextBox();
            labelEREbEditionNumber = new Label();
            tpERWholeElectronicEdition = new TabPage();
            gbERWholeElectronicEditionRequired = new GroupBox();
            panelERWholeElectronicEditionRequired = new Panel();
            lbERWEEPublishingLocationSelect = new ListBox();
            cbERWEEPublisher = new CheckBox();
            tbERWEEAccessMode = new TextBox();
            labelERWEEAccessMode = new Label();
            tbERWEEAccessDate = new TextBox();
            labelERWEEAccessDate = new Label();
            tbERWEEURL = new TextBox();
            labelERWEEURL = new Label();
            cbERWEEAuthors = new CheckBox();
            buttonERWEEPublisherAdd = new Button();
            lbERWEEPublisher = new ListBox();
            buttonERWEEPublishingLocationAdd = new Button();
            lbERWEEPublishingLocation = new ListBox();
            panelERWEEAuthors = new Label();
            tbERWEEPublishYear = new TextBox();
            labelERWEEPublishYear = new Label();
            tbERWEEAuthors = new TextBox();
            tbERWEEPublisher = new TextBox();
            buttonERWEEAuthorsAdd = new Button();
            labelERWEEPublisher = new Label();
            lbERWEEAuthors = new ListBox();
            tbERWEEPublishingLocation = new TextBox();
            labelERWEETitle = new Label();
            labelERWEEPublishingLocation = new Label();
            tbERWEETitle = new TextBox();
            tbERWEEVolumesCount = new TextBox();
            labelERWEEVolumesCount = new Label();
            gbERWholeElectronicEditionOptional = new GroupBox();
            panelERWholeElectronicEditionOptional = new Panel();
            labelERWEETranslator = new Label();
            tbERWEETranslator = new TextBox();
            labelERWEEOrganization = new Label();
            tbERWEEOrganization = new TextBox();
            labelERWEEParallelTitle = new Label();
            tbERWEEParallelTitle = new TextBox();
            labelERWEEContentType = new Label();
            tbERWEEContentType = new TextBox();
            cbERWEEEditorType = new ComboBox();
            lbERWEEEditor = new ListBox();
            buttonERWEEEditorAdd = new Button();
            labelERWEEDocumentType = new Label();
            tbERWEEISBN = new TextBox();
            labelERWEESeries = new Label();
            tbERWEEEditor = new TextBox();
            labelERWEEPagesCount = new Label();
            tbERWEESeries = new TextBox();
            tbERWEEPagesCount = new TextBox();
            tbERWEEEditionNumber = new TextBox();
            labelERWEEISBN = new Label();
            tbERWEEDocumentType = new TextBox();
            labelERWEEEditionNumber = new Label();
            labelERWEEEditor = new Label();
            tpERElectronicEditionSeparateVolume = new TabPage();
            gbERElectronicEditionSeparateVolumeRequired = new GroupBox();
            panelERElectronicEditionSeparateVolumeRequired = new Panel();
            lbEREESVPublishingLocationSelect = new ListBox();
            cbEREESVPublisher = new CheckBox();
            tbEREESVVolumeNumber = new TextBox();
            labelEREESVVolumeNumber = new Label();
            tbEREESVAccessMode = new TextBox();
            labelEREESVAccessMode = new Label();
            tbEREESVAccessDate = new TextBox();
            labelEREESVAccessDate = new Label();
            tbEREESVURL = new TextBox();
            labelEREESVURL = new Label();
            cbEREESVAuthors = new CheckBox();
            buttonEREESVPublisherAdd = new Button();
            lbEREESVPublisher = new ListBox();
            buttonEREESVPublishingLocationAdd = new Button();
            lbEREESVPublishingLocation = new ListBox();
            labelEREESVAuthors = new Label();
            tbEREESVPublishYear = new TextBox();
            labelEREESVPublishYear = new Label();
            tbEREESVAuthors = new TextBox();
            tbEREESVPublisher = new TextBox();
            buttonEREESVAuthorsAdd = new Button();
            labelEREESVPublisher = new Label();
            lbEREESVAuthors = new ListBox();
            tbEREESVPublishingLocation = new TextBox();
            labelEREESVTitle = new Label();
            labelEREESVPublishingLocation = new Label();
            tbEREESVTitle = new TextBox();
            tbEREESVVolumesCount = new TextBox();
            labelEREESVVolumesCount = new Label();
            gbERElectronicEditionSeparateVolumeOptional = new GroupBox();
            panelERElectronicEditionSeparateVolumeOptional = new Panel();
            tbEREESVVolumeTitle = new TextBox();
            labelEREESVVolumeTitle = new Label();
            labelEREESVTranslator = new Label();
            tbEREESVTranslator = new TextBox();
            labelEREESVOrganization = new Label();
            tbEREESVOrganization = new TextBox();
            labelEREESVParallelTitle = new Label();
            tbEREESVParallelTitle = new TextBox();
            labelEREESVContentType = new Label();
            tbEREESVContentType = new TextBox();
            cbEREESVEditorType = new ComboBox();
            lbEREESVEditor = new ListBox();
            buttonEREESVEditorAdd = new Button();
            labelEREESVDocumentType = new Label();
            tbEREESVISBN = new TextBox();
            labelEREESVSeries = new Label();
            tbEREESVEditor = new TextBox();
            labelEREESVPagesCount = new Label();
            tbEREESVSeries = new TextBox();
            tbEREESVPagesCount = new TextBox();
            tbEREESVEditionNumber = new TextBox();
            labelEREESVISBN = new Label();
            tbEREESVDocumentType = new TextBox();
            labelEREESVEditionNumber = new Label();
            labelEREESVEditor = new Label();
            tpERElectronicConferenceMaterials = new TabPage();
            gbERElectronicConferenceMaterialsRequired = new GroupBox();
            panelERElectronicConferenceMaterialsRequired = new Panel();
            lbERECMPublishingLocationSelect = new ListBox();
            cbERECMPublisher = new CheckBox();
            tbERECMAccessMode = new TextBox();
            labelERECMAccessMode = new Label();
            tbERECMAccessDate = new TextBox();
            labelERECMAccessDate = new Label();
            tbERECMURL = new TextBox();
            labelERECMURL = new Label();
            buttonERECMPublisherAdd = new Button();
            lbERECMPublisher = new ListBox();
            buttonERECMPublishingLocationAdd = new Button();
            lbERECMPublishingLocation = new ListBox();
            tbERECMPublisher = new TextBox();
            labelERECMPublisher = new Label();
            tbERECMPublishingLocation = new TextBox();
            labelERECMPublishingLocation = new Label();
            tbERECMEventDate = new TextBox();
            labelERECMEventDate = new Label();
            labelERECMEventTitle = new Label();
            tbERECMEventTitle = new TextBox();
            tbERECMPublishYear = new TextBox();
            labelERECMPublishYear = new Label();
            tbERECMEventPlace = new TextBox();
            labelERECMPublicationType = new Label();
            labelERECMEventPlace = new Label();
            tbERECMPublicationType = new TextBox();
            gbERElectronicConferenceMaterialsOptional = new GroupBox();
            panelERElectronicConferenceMaterialsOptional = new Panel();
            labelERECMAccessNote = new Label();
            tbERECMAccessNote = new TextBox();
            cbERECMEditorType = new ComboBox();
            lbERECMEditor = new ListBox();
            buttonERECMEditorAdd = new Button();
            tbERECMEditor = new TextBox();
            labelERECMEditor = new Label();
            lbERECMEditorialBoard = new ListBox();
            buttonERECMEditorialBoardAdd = new Button();
            labelERECMPartNumberAndTitle = new Label();
            tbERECMPartNumberAndTitle = new TextBox();
            labelERECMContentType = new Label();
            tbERECMContentType = new TextBox();
            labelERECMPartCount = new Label();
            tbERECMPartCount = new TextBox();
            tbERECMPagesCount = new TextBox();
            labelERECMISBN = new Label();
            labelERECMPagesCount = new Label();
            tbERECMEditorialBoard = new TextBox();
            tbERECMISBN = new TextBox();
            labelERECMEditorialBoard = new Label();
            tpERElectronicCollections = new TabPage();
            gbERElectronicCollectionsRequired = new GroupBox();
            panelERElectronicCollectionsRequired = new Panel();
            lbERECPublishingLocationSelect = new ListBox();
            cbERECPublisher = new CheckBox();
            tbERECAccessMode = new TextBox();
            labelERECAccessMode = new Label();
            tbERECAccessDate = new TextBox();
            labelERECAccessDate = new Label();
            tbERECURL = new TextBox();
            labelERECURL = new Label();
            buttonERECPublisherAdd = new Button();
            lbERECPublisher = new ListBox();
            buttonERECPublishingLocationAdd = new Button();
            lbERECPublishingLocation = new ListBox();
            tbERECPublisher = new TextBox();
            labelERECPublisher = new Label();
            tbERECPublishingLocation = new TextBox();
            labelERECPublishingLocation = new Label();
            labelERECCollectionTitle = new Label();
            tbERECCollectionTitle = new TextBox();
            tbERECPublishYear = new TextBox();
            labelERECPublishYear = new Label();
            labelERECPublicationType = new Label();
            tbERECPublicationType = new TextBox();
            gbERElectronicCollectionsOptional = new GroupBox();
            panelERElectronicCollectionsOptional = new Panel();
            cbERECEditorType = new ComboBox();
            lbERECEditor = new ListBox();
            buttonERECEditor = new Button();
            tbERECEditor = new TextBox();
            labelERECEditor = new Label();
            labelERECAccessNote = new Label();
            tbERECAccessNote = new TextBox();
            lbERECEditorialBoard = new ListBox();
            buttonERECEditorialBoardAdd = new Button();
            labelERECContentType = new Label();
            tbERECContentType = new TextBox();
            tbERECPagesCount = new TextBox();
            labelERECISBN = new Label();
            labelERECPagesCount = new Label();
            tbERECEditorialBoard = new TextBox();
            tbERECISBN = new TextBox();
            labelERECEditorialBoard = new Label();
            tpEREjournalArticle = new TabPage();
            gbEREjournalArticleReqired = new GroupBox();
            panelEREjournalArticleReqired = new Panel();
            cbEREjAAuthors = new CheckBox();
            labelEREjAAccessDate = new Label();
            labelEREjAAuthors = new Label();
            tbEREjAAccessDate = new TextBox();
            tbEREjAPages = new TextBox();
            labelEREjAURL = new Label();
            labelEREjAPages = new Label();
            tbEREjAURL = new TextBox();
            tbEREjAJournalNumber = new TextBox();
            labelEREjAJournalNumber = new Label();
            tbEREjAAuthors = new TextBox();
            tbEREjAYear = new TextBox();
            tbEREjAAuthorsAdd = new Button();
            labelEREjAYear = new Label();
            lbEREjAAuthors = new ListBox();
            tbEREjAJournalName = new TextBox();
            labelEREjATitle = new Label();
            labelEREjAJournalName = new Label();
            tbEREjATitle = new TextBox();
            gbEREjournalArticleOptional = new GroupBox();
            panelEREjournalArticleOptional = new Panel();
            labelEREjAAccessMode = new Label();
            labelEREjAContentType = new Label();
            tbEREjAAccessMode = new TextBox();
            tbEREjAContentType = new TextBox();
            tpERMultimediaEdition = new TabPage();
            gbERMultimediaEditionRequired = new GroupBox();
            panelERMultimediaEditionRequired = new Panel();
            cbERMEAuthors = new CheckBox();
            lbERMEPublishingLocationSelect = new ListBox();
            cbERMEPublisher = new CheckBox();
            buttonERMEPublisherAdd = new Button();
            lbERMEPublisher = new ListBox();
            buttonERMEPublishingLocationAdd = new Button();
            lbERMEPublishingLocation = new ListBox();
            tbERMEPublisher = new TextBox();
            labelERMEPublisher = new Label();
            tbERMEPublishingLocation = new TextBox();
            labelERMEPublishingLocation = new Label();
            labelERMEAuthors = new Label();
            tbERMEAuthors = new TextBox();
            tbERMEDataCarrier = new TextBox();
            buttonERMEAuthorsAdd = new Button();
            labelERMEDataCarrier = new Label();
            lbERMEAuthors = new ListBox();
            tbERMEPublishYear = new TextBox();
            labelERMETitle = new Label();
            labelERMEPublishYear = new Label();
            tbERMETitle = new TextBox();
            gbERMultimediaEditionOptional = new GroupBox();
            panelERMultimediaEditionOptional = new Panel();
            tbERMESeries = new TextBox();
            labelERMESeries = new Label();
            labelERMEContentType = new Label();
            tbERMEContentType = new TextBox();
            labelERMEDocumentType = new Label();
            labelERMEISBN = new Label();
            tbERMENotation = new TextBox();
            tbERMEOrganization = new TextBox();
            tbERMEDocumentType = new TextBox();
            labelERMENotation = new Label();
            tbERMEISBN = new TextBox();
            labelERMEOrganization = new Label();
            tpERWebsite = new TabPage();
            gbERWebsiteRequired = new GroupBox();
            panelERWebsiteRequired = new Panel();
            labelERWWebsiteName = new Label();
            labelERWURL = new Label();
            tbERWAccessDate = new TextBox();
            tbERWURL = new TextBox();
            labelERWAccessDate = new Label();
            tbERWWebsiteName = new TextBox();
            gbERWebsiteOptional = new GroupBox();
            panelERWebsiteOptional = new Panel();
            lbERWPublishingLocationSelect = new ListBox();
            cbERWPublisher = new CheckBox();
            buttonERWPublisherAdd = new Button();
            lbERWPublisher = new ListBox();
            buttonERWPublishingLocationAdd = new Button();
            lbERWPublishingLocation = new ListBox();
            tbERWPublisher = new TextBox();
            labelERWPublisher = new Label();
            tbERWPublishingLocation = new TextBox();
            labelERWPublishingLocation = new Label();
            labelERWDetails = new Label();
            tbERWDetails = new TextBox();
            labelERWPublicationDate = new Label();
            tbERWPublicationDate = new TextBox();
            labelERWResourceDescription = new Label();
            tbERWResourceDescription = new TextBox();
            labelERWContentType = new Label();
            tbERWContentType = new TextBox();
            labelERWResourceType = new Label();
            labelERWOrganization = new Label();
            tbERWAccessMode = new TextBox();
            tbERWOrganization = new TextBox();
            labelERWAccessMode = new Label();
            tbERWCreationYear = new TextBox();
            tbERWResourceType = new TextBox();
            labelERWCreationYear = new Label();
            tpConstituentParts = new TabPage();
            tcCPTypes = new TabControl();
            tpCPBookArticle = new TabPage();
            gbCPBookArticleRequired = new GroupBox();
            panelCPBookArticleRequired = new Panel();
            cbCPBABookAuthors = new CheckBox();
            labelCPBABookAuthors = new Label();
            tbCPBABookAuthors = new TextBox();
            lbCPBABookAuthors = new ListBox();
            buttonCPBABookAuthorsAdd = new Button();
            lbCPBAPublishingLocationSelect = new ListBox();
            cbCPBAPublisher = new CheckBox();
            buttonCPBAPublisherAdd = new Button();
            lbCPBAPublisher = new ListBox();
            buttonCPBAPublishingLocationAdd = new Button();
            lbCPBAPublishingLocation = new ListBox();
            tbCPBAPublisher = new TextBox();
            labelCPBAPublisher = new Label();
            tbCPBAPublishingLocation = new TextBox();
            labelCPBAPublishingLocation = new Label();
            cbCPBAArticleAuthors = new CheckBox();
            labelCPBAPages = new Label();
            labelCPBAArticleAuthors = new Label();
            tbCPBAPages = new TextBox();
            labelCPBAPublishYear = new Label();
            tbCPBAPublishYear = new TextBox();
            tbCPBABookTitle = new TextBox();
            labelCPBABookTitle = new Label();
            tbCPBAArticleTitle = new TextBox();
            labelCPBAArticleTitle = new Label();
            tbCPBAArticleAuthors = new TextBox();
            lbCPBAArticleAuthors = new ListBox();
            buttonCPBAArticleAuthorsAdd = new Button();
            gbCPBookArticleOptional = new GroupBox();
            panelCPBookArticleOptional = new Panel();
            labelCPBAContentType = new Label();
            tbCPBAContentType = new TextBox();
            labelCPBAOrganization = new Label();
            tbCPBAOrganization = new TextBox();
            labelCPBABookDocumentType = new Label();
            tbCPBABookDocumentType = new TextBox();
            tpCPConferenceArticle = new TabPage();
            gbCPConferenceArticleRequired = new GroupBox();
            panelCPConferenceArticleRequired = new Panel();
            labelCPCAPublicationType = new Label();
            tbCPCAPublicationType = new TextBox();
            lbCPCAPublishingLocationSelect = new ListBox();
            cbCPCAPublisher = new CheckBox();
            buttonCPCAPublisherAdd = new Button();
            lbCPCAPublisher = new ListBox();
            buttonCPCAPublishingLocationAdd = new Button();
            lbCPCAPublishingLocation = new ListBox();
            tbCPCAPublisher = new TextBox();
            labelCPCAPublisher = new Label();
            tbCPCAPublishingLocation = new TextBox();
            labelCPCAPublishingLocation = new Label();
            cbCPCAArticleAuthors = new CheckBox();
            labelCPCAPages = new Label();
            labelCPCAArticleAuthors = new Label();
            tbCPCAPages = new TextBox();
            labelCPCAPublishYear = new Label();
            tbCPCAPublishYear = new TextBox();
            tbCPCAEventTitle = new TextBox();
            labelCPCAEventTitle = new Label();
            tbCPCAArticleTitle = new TextBox();
            labelCPCAArticleTitle = new Label();
            tbCPCAArticleAuthors = new TextBox();
            lbCPCAArticleAuthors = new ListBox();
            buttonCPCAArticleAuthorsAdd = new Button();
            gbCPConferenceArticleOptional = new GroupBox();
            panelCPConferenceArticleOptional = new Panel();
            tbCPCAEventDate = new TextBox();
            labelCPCAEventDate = new Label();
            cbCPCAConferenceAuthors = new CheckBox();
            tbCPCAEventPlace = new TextBox();
            labelCPCAConferenceAuthors = new Label();
            tbCPCAConferenceAuthors = new TextBox();
            labelCPCAEventPlace = new Label();
            lbCPCAConferenceAuthors = new ListBox();
            buttonCPCAConferenceAuthorsAdd = new Button();
            cbCPCAEditorType = new ComboBox();
            lbCPCAEditor = new ListBox();
            buttonCPCAEditorAdd = new Button();
            labelCPCAPartNumberAndTitle = new Label();
            tbCPCAPartNumberAndTitle = new TextBox();
            labelCPCAPartCount = new Label();
            tbCPCAPartCount = new TextBox();
            tbCPCAEditor = new TextBox();
            labelCPCAEditor = new Label();
            labelCPCAContentType = new Label();
            tbCPCAContentType = new TextBox();
            labelCPCAOrganization = new Label();
            tbCPCAOrganization = new TextBox();
            tpCPJournalArticle = new TabPage();
            gbCPJournalArticleRequired = new GroupBox();
            panelCPJournalArticleRequired = new Panel();
            cbCPJAArticleAuthors = new CheckBox();
            labelCPJAArticleAuthors = new Label();
            tbCPJAArticleAuthors = new TextBox();
            lbCPJAArticleAuthors = new ListBox();
            buttonCPJAArticleAuthorsAdd = new Button();
            tbCPJAPages = new TextBox();
            labelCPJAPages = new Label();
            labelCPJAArticleTitle = new Label();
            tbCPJAArticleTitle = new TextBox();
            tbCPJAPublishYear = new TextBox();
            labelCPJAJournalName = new Label();
            labelCPJAPublishYear = new Label();
            tbCPJAJournalName = new TextBox();
            gbCPJournalArticleOptional = new GroupBox();
            panelCPJournalArticleOptional = new Panel();
            labelCPJAContentType = new Label();
            tbCPJAContentType = new TextBox();
            labelCPJAIssue = new Label();
            tbCPJAIssue = new TextBox();
            labelCPJAJournalSeries = new Label();
            tbCPJAJournalSeries = new TextBox();
            rbCPJAVolume = new RadioButton();
            rbCPJANumber = new RadioButton();
            labelCPJAAccessMode = new Label();
            tbCPJAAccessMode = new TextBox();
            labelCPJAAccessDate = new Label();
            tbCPJAAccessDate = new TextBox();
            labelCPJAURL = new Label();
            tbCPJAURL = new TextBox();
            labelCPJADOI = new Label();
            tbCPJADOI = new TextBox();
            labelCPJANumberOrVolume = new Label();
            tbCPJANumberOrVolume = new TextBox();
            tpCPNewspaperArticle = new TabPage();
            gbCPNewspaperArticleReqired = new GroupBox();
            panelCPNewspaperArticleReqired = new Panel();
            tbCPNANumber = new TextBox();
            labelCPNANumber = new Label();
            cbCPNAArticleAuthors = new CheckBox();
            labelCPNAArticleAuthors = new Label();
            tbCPNAArticleAuthors = new TextBox();
            lbCPNAArticleAuthors = new ListBox();
            buttonCPNAArticleAuthorsAdd = new Button();
            tbCPNAPages = new TextBox();
            labelCPNAPages = new Label();
            tbCPNAReleaseDate = new TextBox();
            labelCPNAArticleTitle = new Label();
            labelCPNAReleaseDate = new Label();
            tbCPNAArticleTitle = new TextBox();
            tbCPNAPublishYear = new TextBox();
            labelCPNANewspaperName = new Label();
            labelCPNAPublishYear = new Label();
            tbCPNANewspaperName = new TextBox();
            gbCPNewspaperArticleOptional = new GroupBox();
            panelCPNewspaperArticleOptional = new Panel();
            labelCPNAContentType = new Label();
            tbCPNAContentType = new TextBox();
            labelCPNAArticleNote = new Label();
            tbCPNAInterviewer = new TextBox();
            tbCPNAArticleNote = new TextBox();
            labelCPNAInterviewer = new Label();
            tpCPWebsiteArticle = new TabPage();
            gbCPWebsiteArticleRequired = new GroupBox();
            panelCPWebsiteArticleRequired = new Panel();
            tbCPWAURL = new TextBox();
            labelCPWAArticleTitle = new Label();
            labelCPWAURL = new Label();
            tbCPWAArticleTitle = new TextBox();
            tbCPWAWebsiteName = new TextBox();
            labelCPWAWebsiteName = new Label();
            gbCPWebsiteArticleOptional = new GroupBox();
            panelCPWebsiteArticleOptional = new Panel();
            tbCPWAAccessDate = new TextBox();
            labelCPWAPublicationType = new Label();
            labelCPWAAccessDate = new Label();
            tbCPWAPublicationType = new TextBox();
            labelCPWAMaterialType = new Label();
            tbCPWAMaterialType = new TextBox();
            labelCPWAContentType = new Label();
            tbCPWAContentType = new TextBox();
            tbCPWAEventDate = new TextBox();
            labelCPWAEventDate = new Label();
            tbCPWAEventPlace = new TextBox();
            labelCPWAEventPlace = new Label();
            labelCPWAResourceDescription = new Label();
            tbCPWAResourceDescription = new TextBox();
            labelCPWAResourceType = new Label();
            tbCPWAResourceType = new TextBox();
            cbCPWAArticleAuthors = new CheckBox();
            labelCPWAArticleAuthors = new Label();
            tbCPWAArticleAuthors = new TextBox();
            lbCPWAArticleAuthors = new ListBox();
            buttonCPWAArticleAuthorsAdd = new Button();
            labelCPWAPublishYear = new Label();
            tbCPWAPublishDate = new TextBox();
            tbCPWAPublishYear = new TextBox();
            labelCPWAPublishDate = new Label();
            ttMain = new ToolTip(this.components);
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer3)).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            panelRtbMLA.SuspendLayout();
            cmsRichTextBox_TextBox.SuspendLayout();
            panelRtbGOST.SuspendLayout();
            panelConvertTitle.SuspendLayout();
            cmsListBox.SuspendLayout();
            panelAddRecord.SuspendLayout();
            tcCategories.SuspendLayout();
            cmsMainTabControl.SuspendLayout();
            tpSingleVolume.SuspendLayout();
            tcSVTypes.SuspendLayout();
            tpSVBook.SuspendLayout();
            gpSVBookRequired.SuspendLayout();
            panelSVBookRequired.SuspendLayout();
            gpSVBookOptional.SuspendLayout();
            panelSVBookOptional.SuspendLayout();
            tpSVConferenceMaterials.SuspendLayout();
            gbSVConferenceMaterialsRequired.SuspendLayout();
            panelSVConferenceMaterialsRequired.SuspendLayout();
            gbSVConferenceMaterialsOptional.SuspendLayout();
            panelSVConferenceMaterialsOptional.SuspendLayout();
            tpSVGOST.SuspendLayout();
            gbSVGOSTRequired.SuspendLayout();
            panelSVGOSTRequired.SuspendLayout();
            gbSVGOSTOptional.SuspendLayout();
            panelSVGOSTOptional.SuspendLayout();
            tpSVLegislativeMaterial.SuspendLayout();
            gbSVLegislativeMaterialRequired.SuspendLayout();
            panelSVLegislativeMaterialRequired.SuspendLayout();
            gbSVLegislativeMaterialOptional.SuspendLayout();
            panelSVLegislativeMaterialOptional.SuspendLayout();
            tpSVDissertationAbstract.SuspendLayout();
            gbSVDissertationAbstractRequired.SuspendLayout();
            panelSVDissertationAbstractRequired.SuspendLayout();
            gbSVDissertationAbstractOptional.SuspendLayout();
            panelSVDissertationAbstractOptional.SuspendLayout();
            tpSVDissertation.SuspendLayout();
            gbSVDissertationRequired.SuspendLayout();
            panelSVDissertationRequired.SuspendLayout();
            gbSVDissertationOptional.SuspendLayout();
            panelSVDissertationOptional.SuspendLayout();
            tpMultiVolume.SuspendLayout();
            tcMVTypes.SuspendLayout();
            tpMVWholeMultivolume.SuspendLayout();
            gbMVWholeMultivolumeRequired.SuspendLayout();
            panelMVWholeMultivolumeRequired.SuspendLayout();
            gbMVWholeMultivolumeOptional.SuspendLayout();
            panelMVWholeMultivolumeOptional.SuspendLayout();
            tpMVSeparateVolume.SuspendLayout();
            gbMVSeparateVolumeRequired.SuspendLayout();
            panelMVSeparateVolumeRequired.SuspendLayout();
            gbMVSeparateVolumeOptional.SuspendLayout();
            panelMVSeparateVolumeOptional.SuspendLayout();
            tpElectronicResources.SuspendLayout();
            tcERTypes.SuspendLayout();
            tpEREbook.SuspendLayout();
            gbEREbookRequired.SuspendLayout();
            panelEREbookRequired.SuspendLayout();
            gbEREbookOptional.SuspendLayout();
            panelEREbookOptional.SuspendLayout();
            tpERWholeElectronicEdition.SuspendLayout();
            gbERWholeElectronicEditionRequired.SuspendLayout();
            panelERWholeElectronicEditionRequired.SuspendLayout();
            gbERWholeElectronicEditionOptional.SuspendLayout();
            panelERWholeElectronicEditionOptional.SuspendLayout();
            tpERElectronicEditionSeparateVolume.SuspendLayout();
            gbERElectronicEditionSeparateVolumeRequired.SuspendLayout();
            panelERElectronicEditionSeparateVolumeRequired.SuspendLayout();
            gbERElectronicEditionSeparateVolumeOptional.SuspendLayout();
            panelERElectronicEditionSeparateVolumeOptional.SuspendLayout();
            tpERElectronicConferenceMaterials.SuspendLayout();
            gbERElectronicConferenceMaterialsRequired.SuspendLayout();
            panelERElectronicConferenceMaterialsRequired.SuspendLayout();
            gbERElectronicConferenceMaterialsOptional.SuspendLayout();
            panelERElectronicConferenceMaterialsOptional.SuspendLayout();
            tpERElectronicCollections.SuspendLayout();
            gbERElectronicCollectionsRequired.SuspendLayout();
            panelERElectronicCollectionsRequired.SuspendLayout();
            gbERElectronicCollectionsOptional.SuspendLayout();
            panelERElectronicCollectionsOptional.SuspendLayout();
            tpEREjournalArticle.SuspendLayout();
            gbEREjournalArticleReqired.SuspendLayout();
            panelEREjournalArticleReqired.SuspendLayout();
            gbEREjournalArticleOptional.SuspendLayout();
            panelEREjournalArticleOptional.SuspendLayout();
            tpERMultimediaEdition.SuspendLayout();
            gbERMultimediaEditionRequired.SuspendLayout();
            panelERMultimediaEditionRequired.SuspendLayout();
            gbERMultimediaEditionOptional.SuspendLayout();
            panelERMultimediaEditionOptional.SuspendLayout();
            tpERWebsite.SuspendLayout();
            gbERWebsiteRequired.SuspendLayout();
            panelERWebsiteRequired.SuspendLayout();
            gbERWebsiteOptional.SuspendLayout();
            panelERWebsiteOptional.SuspendLayout();
            tpConstituentParts.SuspendLayout();
            tcCPTypes.SuspendLayout();
            tpCPBookArticle.SuspendLayout();
            gbCPBookArticleRequired.SuspendLayout();
            panelCPBookArticleRequired.SuspendLayout();
            gbCPBookArticleOptional.SuspendLayout();
            panelCPBookArticleOptional.SuspendLayout();
            tpCPConferenceArticle.SuspendLayout();
            gbCPConferenceArticleRequired.SuspendLayout();
            panelCPConferenceArticleRequired.SuspendLayout();
            gbCPConferenceArticleOptional.SuspendLayout();
            panelCPConferenceArticleOptional.SuspendLayout();
            tpCPJournalArticle.SuspendLayout();
            gbCPJournalArticleRequired.SuspendLayout();
            panelCPJournalArticleRequired.SuspendLayout();
            gbCPJournalArticleOptional.SuspendLayout();
            panelCPJournalArticleOptional.SuspendLayout();
            tpCPNewspaperArticle.SuspendLayout();
            gbCPNewspaperArticleReqired.SuspendLayout();
            panelCPNewspaperArticleReqired.SuspendLayout();
            gbCPNewspaperArticleOptional.SuspendLayout();
            panelCPNewspaperArticleOptional.SuspendLayout();
            tpCPWebsiteArticle.SuspendLayout();
            gbCPWebsiteArticleRequired.SuspendLayout();
            panelCPWebsiteArticleRequired.SuspendLayout();
            gbCPWebsiteArticleOptional.SuspendLayout();
            panelCPWebsiteArticleOptional.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelAddRecord);
            splitContainer1.Panel2.Controls.Add(tcCategories);
            splitContainer1.Size = new Size(837, 808);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonPDFExportResult);
            splitContainer2.Panel2.Controls.Add(buttonWordExportResult);
            splitContainer2.Panel2.Controls.Add(buttonCopyResult);
            splitContainer2.Panel2.Controls.Add(labelResult);
            splitContainer2.Panel2.Controls.Add(lbResult);
            splitContainer2.Size = new Size(300, 808);
            splitContainer2.SplitterDistance = 389;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(buttonToGOST2008);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(buttonFillForm);
            splitContainer3.Panel2.Controls.Add(panelRtbMLA);
            splitContainer3.Panel2.Controls.Add(panelRtbGOST);
            splitContainer3.Panel2.Controls.Add(panelConvertTitle);
            splitContainer3.Panel2.Controls.Add(labelGOST);
            splitContainer3.Panel2.Controls.Add(labelMLA);
            splitContainer3.Panel2.Controls.Add(buttonConvert);
            splitContainer3.Size = new Size(300, 389);
            splitContainer3.SplitterDistance = 47;
            splitContainer3.TabIndex = 0;
            // 
            // buttonToGOST2008
            // 
            buttonToGOST2008.BackColor = SystemColors.ActiveBorder;
            buttonToGOST2008.FlatStyle = FlatStyle.Flat;
            buttonToGOST2008.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToGOST2008.Location = new Point(4, 3);
            buttonToGOST2008.Name = "buttonToGOST2008";
            buttonToGOST2008.Size = new Size(291, 39);
            buttonToGOST2008.TabIndex = 0;
            buttonToGOST2008.Text = "ГОСТ Р 7.0.5-2008";
            buttonToGOST2008.UseVisualStyleBackColor = false;
            buttonToGOST2008.Click += this.buttonToGOST2008_Click;
            // 
            // buttonFillForm
            // 
            buttonFillForm.BackColor = SystemColors.Info;
            buttonFillForm.FlatStyle = FlatStyle.Flat;
            buttonFillForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFillForm.Location = new Point(151, 299);
            buttonFillForm.Name = "buttonFillForm";
            buttonFillForm.Size = new Size(144, 34);
            buttonFillForm.TabIndex = 4;
            buttonFillForm.Text = "Заполнить форму";
            buttonFillForm.UseVisualStyleBackColor = false;
            buttonFillForm.Click += this.buttonFillForm_Click;
            // 
            // panelRtbMLA
            // 
            panelRtbMLA.BorderStyle = BorderStyle.FixedSingle;
            panelRtbMLA.Controls.Add(rtbMLA);
            panelRtbMLA.Location = new Point(4, 204);
            panelRtbMLA.Name = "panelRtbMLA";
            panelRtbMLA.Size = new Size(291, 90);
            panelRtbMLA.TabIndex = 4;
            // 
            // rtbMLA
            // 
            rtbMLA.BorderStyle = BorderStyle.None;
            rtbMLA.ContextMenuStrip = cmsRichTextBox_TextBox;
            rtbMLA.Location = new Point(0, 0);
            rtbMLA.Name = "rtbMLA";
            rtbMLA.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbMLA.Size = new Size(290, 90);
            rtbMLA.TabIndex = 2;
            rtbMLA.Text = "";
            // 
            // cmsRichTextBox_TextBox
            // 
            cmsRichTextBox_TextBox.Items.AddRange(new ToolStripItem[] { tsmiClearRichTextBox, toolStripSeparator1, tsmiUndoRichTextBox, toolStripSeparator2, tsmiCutRichTextBox, tsmiCopyRichTextBox, tsmiPasteRichTextBox, tsmiDeleteRichTextBox, toolStripSeparator3, tsmiSelectAllRichTextBox, toolStripSeparator4, tsmiUnableClearingRichTextBox1, tsmiUnableClearingRichTextBox2 });
            cmsRichTextBox_TextBox.Name = "cmsRichTextBox";
            cmsRichTextBox_TextBox.Size = new Size(246, 226);
            cmsRichTextBox_TextBox.Opening += this.cmsRichTextBox_TextBox_Opening;
            // 
            // tsmiClearRichTextBox
            // 
            tsmiClearRichTextBox.Name = "tsmiClearRichTextBox";
            tsmiClearRichTextBox.Size = new Size(245, 22);
            tsmiClearRichTextBox.Text = "Очистить";
            tsmiClearRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(242, 6);
            // 
            // tsmiUndoRichTextBox
            // 
            tsmiUndoRichTextBox.Name = "tsmiUndoRichTextBox";
            tsmiUndoRichTextBox.Size = new Size(245, 22);
            tsmiUndoRichTextBox.Text = "Отменить";
            tsmiUndoRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(242, 6);
            // 
            // tsmiCutRichTextBox
            // 
            tsmiCutRichTextBox.Name = "tsmiCutRichTextBox";
            tsmiCutRichTextBox.Size = new Size(245, 22);
            tsmiCutRichTextBox.Text = "Вырезать";
            tsmiCutRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // tsmiCopyRichTextBox
            // 
            tsmiCopyRichTextBox.Name = "tsmiCopyRichTextBox";
            tsmiCopyRichTextBox.Size = new Size(245, 22);
            tsmiCopyRichTextBox.Text = "Копировать";
            tsmiCopyRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // tsmiPasteRichTextBox
            // 
            tsmiPasteRichTextBox.Name = "tsmiPasteRichTextBox";
            tsmiPasteRichTextBox.Size = new Size(245, 22);
            tsmiPasteRichTextBox.Text = "Вставить";
            tsmiPasteRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // tsmiDeleteRichTextBox
            // 
            tsmiDeleteRichTextBox.Name = "tsmiDeleteRichTextBox";
            tsmiDeleteRichTextBox.Size = new Size(245, 22);
            tsmiDeleteRichTextBox.Text = "Удалить";
            tsmiDeleteRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(242, 6);
            // 
            // tsmiSelectAllRichTextBox
            // 
            tsmiSelectAllRichTextBox.Name = "tsmiSelectAllRichTextBox";
            tsmiSelectAllRichTextBox.Size = new Size(245, 22);
            tsmiSelectAllRichTextBox.Text = "Выделить все";
            tsmiSelectAllRichTextBox.Click += this.UniversalRichTextBox_TextBox_MenuItemClick;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(242, 6);
            // 
            // tsmiUnableClearingRichTextBox1
            // 
            tsmiUnableClearingRichTextBox1.CheckOnClick = true;
            tsmiUnableClearingRichTextBox1.Name = "tsmiUnableClearingRichTextBox1";
            tsmiUnableClearingRichTextBox1.Size = new Size(245, 22);
            tsmiUnableClearingRichTextBox1.Text = "Не очищать после добавления";
            // 
            // tsmiUnableClearingRichTextBox2
            // 
            tsmiUnableClearingRichTextBox2.CheckOnClick = true;
            tsmiUnableClearingRichTextBox2.Name = "tsmiUnableClearingRichTextBox2";
            tsmiUnableClearingRichTextBox2.Size = new Size(245, 22);
            tsmiUnableClearingRichTextBox2.Text = "Не очищать после добавления";
            // 
            // panelRtbGOST
            // 
            panelRtbGOST.BorderStyle = BorderStyle.FixedSingle;
            panelRtbGOST.Controls.Add(rtbGOST);
            panelRtbGOST.Location = new Point(4, 88);
            panelRtbGOST.Name = "panelRtbGOST";
            panelRtbGOST.Size = new Size(291, 90);
            panelRtbGOST.TabIndex = 11;
            // 
            // rtbGOST
            // 
            rtbGOST.BorderStyle = BorderStyle.None;
            rtbGOST.ContextMenuStrip = cmsRichTextBox_TextBox;
            rtbGOST.Location = new Point(0, 0);
            rtbGOST.Name = "rtbGOST";
            rtbGOST.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbGOST.Size = new Size(290, 90);
            rtbGOST.TabIndex = 1;
            rtbGOST.Text = "";
            // 
            // panelConvertTitle
            // 
            panelConvertTitle.BackColor = SystemColors.ControlLight;
            panelConvertTitle.Controls.Add(labelConvert);
            panelConvertTitle.Location = new Point(2, 3);
            panelConvertTitle.Name = "panelConvertTitle";
            panelConvertTitle.Size = new Size(293, 59);
            panelConvertTitle.TabIndex = 10;
            // 
            // labelConvert
            // 
            labelConvert.AutoSize = true;
            labelConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelConvert.Location = new Point(63, 3);
            labelConvert.Name = "labelConvert";
            labelConvert.Size = new Size(175, 50);
            labelConvert.TabIndex = 5;
            labelConvert.Text = "Конвертировать в \r\n нужный формат";
            // 
            // labelGOST
            // 
            labelGOST.AutoSize = true;
            labelGOST.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelGOST.Location = new Point(70, 65);
            labelGOST.Name = "labelGOST";
            labelGOST.Size = new Size(166, 20);
            labelGOST.TabIndex = 9;
            labelGOST.Text = "Киберленинка «ГОСТ»";
            // 
            // labelMLA
            // 
            labelMLA.AutoSize = true;
            labelMLA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMLA.Location = new Point(70, 181);
            labelMLA.Name = "labelMLA";
            labelMLA.Size = new Size(161, 20);
            labelMLA.TabIndex = 7;
            labelMLA.Text = "Киберленинка «MLA»";
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = SystemColors.Info;
            buttonConvert.FlatStyle = FlatStyle.Flat;
            buttonConvert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConvert.Location = new Point(4, 299);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(143, 34);
            buttonConvert.TabIndex = 3;
            buttonConvert.Text = "Конвертировать";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += this.buttonConvert_Click;
            // 
            // buttonPDFExportResult
            // 
            buttonPDFExportResult.BackColor = Color.IndianRed;
            buttonPDFExportResult.FlatStyle = FlatStyle.Flat;
            buttonPDFExportResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPDFExportResult.Location = new Point(151, 370);
            buttonPDFExportResult.Name = "buttonPDFExportResult";
            buttonPDFExportResult.Size = new Size(144, 40);
            buttonPDFExportResult.TabIndex = 7;
            buttonPDFExportResult.Text = "Экспорт в PDF";
            buttonPDFExportResult.UseVisualStyleBackColor = false;
            buttonPDFExportResult.Click += this.buttonPDFExportResult_Click;
            // 
            // buttonWordExportResult
            // 
            buttonWordExportResult.BackColor = SystemColors.ActiveCaption;
            buttonWordExportResult.FlatStyle = FlatStyle.Flat;
            buttonWordExportResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWordExportResult.Location = new Point(3, 370);
            buttonWordExportResult.Name = "buttonWordExportResult";
            buttonWordExportResult.Size = new Size(144, 40);
            buttonWordExportResult.TabIndex = 6;
            buttonWordExportResult.Text = "Экспорт в Word";
            buttonWordExportResult.UseVisualStyleBackColor = false;
            buttonWordExportResult.Click += this.buttonWordExportResult_Click;
            // 
            // buttonCopyResult
            // 
            buttonCopyResult.BackColor = Color.SandyBrown;
            buttonCopyResult.FlatStyle = FlatStyle.Flat;
            buttonCopyResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCopyResult.Location = new Point(3, 327);
            buttonCopyResult.Name = "buttonCopyResult";
            buttonCopyResult.Size = new Size(292, 40);
            buttonCopyResult.TabIndex = 5;
            buttonCopyResult.Text = "Скопировать все";
            buttonCopyResult.UseVisualStyleBackColor = false;
            buttonCopyResult.Click += this.buttonCopyResult_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(103, 10);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(96, 25);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат";
            // 
            // lbResult
            // 
            lbResult.AllowDrop = true;
            lbResult.BackColor = SystemColors.ControlLight;
            lbResult.BorderStyle = BorderStyle.FixedSingle;
            lbResult.ContextMenuStrip = cmsListBox;
            lbResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.FormattingEnabled = true;
            lbResult.HorizontalScrollbar = true;
            lbResult.ItemHeight = 20;
            lbResult.Location = new Point(3, 42);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(292, 282);
            lbResult.TabIndex = 0;
            lbResult.TabStop = false;
            lbResult.DragDrop += this.ListBox_DragDrop;
            lbResult.DragOver += this.ListBox_DragOver;
            lbResult.KeyDown += this.ListBox_KeyDown;
            lbResult.MouseDown += this.ListBox_MouseDown;
            lbResult.MouseMove += this.ListBox_MouseMove;
            // 
            // cmsListBox
            // 
            cmsListBox.Items.AddRange(new ToolStripItem[] { tsmiUndo, toolStripSeparator6, tsmiDeleteAll, toolStripSeparator5, tsmiDeleteSelected, tsmiEdit, tsmiCopy, tsmiRestoreEntry });
            cmsListBox.Name = "contextMenuStrip1";
            cmsListBox.Size = new Size(190, 170);
            cmsListBox.Opening += this.cmsListBox_Opening;
            // 
            // tsmiUndo
            // 
            tsmiUndo.Name = "tsmiUndo";
            tsmiUndo.Size = new Size(189, 22);
            tsmiUndo.Text = "Отменить";
            tsmiUndo.Click += this.tsmiUndo_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(186, 6);
            // 
            // tsmiDeleteAll
            // 
            tsmiDeleteAll.Name = "tsmiDeleteAll";
            tsmiDeleteAll.Size = new Size(189, 22);
            tsmiDeleteAll.Text = "Очистить";
            tsmiDeleteAll.Click += this.tsmiDeleteAll_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(186, 6);
            // 
            // tsmiDeleteSelected
            // 
            tsmiDeleteSelected.Name = "tsmiDeleteSelected";
            tsmiDeleteSelected.Size = new Size(189, 22);
            tsmiDeleteSelected.Text = "Удалить";
            tsmiDeleteSelected.Click += this.tsmiDeleteSelected_Click;
            // 
            // tsmiEdit
            // 
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(189, 22);
            tsmiEdit.Text = "Редактировать";
            tsmiEdit.Click += this.tsmiEdit_Click;
            // 
            // tsmiCopy
            // 
            tsmiCopy.Name = "tsmiCopy";
            tsmiCopy.Size = new Size(189, 22);
            tsmiCopy.Text = "Скопировать";
            tsmiCopy.Click += this.tsmiCopy_Click;
            // 
            // tsmiRestoreEntry
            // 
            tsmiRestoreEntry.Name = "tsmiRestoreEntry";
            tsmiRestoreEntry.Size = new Size(189, 22);
            tsmiRestoreEntry.Text = "Восстановить запись";
            tsmiRestoreEntry.Click += this.tsmiRestoreEntry_Click;
            // 
            // panelAddRecord
            // 
            panelAddRecord.BackColor = SystemColors.ControlLight;
            panelAddRecord.Controls.Add(buttonAddRecord);
            panelAddRecord.Controls.Add(cbWordAbbreviation);
            panelAddRecord.Location = new Point(10, 757);
            panelAddRecord.Name = "panelAddRecord";
            panelAddRecord.Size = new Size(509, 42);
            panelAddRecord.TabIndex = 2;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.BackColor = SystemColors.MenuHighlight;
            buttonAddRecord.FlatStyle = FlatStyle.Flat;
            buttonAddRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddRecord.Location = new Point(304, 4);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(202, 34);
            buttonAddRecord.TabIndex = 9;
            buttonAddRecord.Text = "Добавить";
            buttonAddRecord.UseVisualStyleBackColor = false;
            buttonAddRecord.Click += this.buttonAddRecord_Click;
            // 
            // cbWordAbbreviation
            // 
            cbWordAbbreviation.AutoSize = true;
            cbWordAbbreviation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbWordAbbreviation.Location = new Point(7, 9);
            cbWordAbbreviation.Name = "cbWordAbbreviation";
            cbWordAbbreviation.Size = new Size(282, 24);
            cbWordAbbreviation.TabIndex = 8;
            cbWordAbbreviation.Text = "Включить сокращение слов по ГОСТ\r\n";
            cbWordAbbreviation.UseVisualStyleBackColor = true;
            // 
            // tcCategories
            // 
            tcCategories.ContextMenuStrip = cmsMainTabControl;
            tcCategories.Controls.Add(tpSingleVolume);
            tcCategories.Controls.Add(tpMultiVolume);
            tcCategories.Controls.Add(tpElectronicResources);
            tcCategories.Controls.Add(tpConstituentParts);
            tcCategories.Location = new Point(3, 3);
            tcCategories.Name = "tcCategories";
            tcCategories.RightToLeft = RightToLeft.No;
            tcCategories.SelectedIndex = 0;
            tcCategories.Size = new Size(529, 748);
            tcCategories.TabIndex = 1;
            tcCategories.TabStop = false;
            // 
            // cmsMainTabControl
            // 
            cmsMainTabControl.Items.AddRange(new ToolStripItem[] { tsmiSaveFormData, tsmiRestoreLastEntry, tsmiClearForm });
            cmsMainTabControl.Name = "contextMenuStrip1";
            cmsMainTabControl.Size = new Size(259, 70);
            cmsMainTabControl.Opening += this.cmsMainTabControl_Opening;
            // 
            // tsmiSaveFormData
            // 
            tsmiSaveFormData.CheckOnClick = true;
            tsmiSaveFormData.Name = "tsmiSaveFormData";
            tsmiSaveFormData.Size = new Size(258, 22);
            tsmiSaveFormData.Text = "Сохранять данные в форме";
            // 
            // tsmiRestoreLastEntry
            // 
            tsmiRestoreLastEntry.Name = "tsmiRestoreLastEntry";
            tsmiRestoreLastEntry.Size = new Size(258, 22);
            tsmiRestoreLastEntry.Text = "Восстановить последнюю запись";
            tsmiRestoreLastEntry.Click += this.tsmiRestoreLastEntry_Click;
            // 
            // tsmiClearForm
            // 
            tsmiClearForm.Name = "tsmiClearForm";
            tsmiClearForm.Size = new Size(258, 22);
            tsmiClearForm.Text = "Очистить форму";
            tsmiClearForm.Click += this.tsmiClearForm_Click;
            // 
            // tpSingleVolume
            // 
            tpSingleVolume.BackColor = SystemColors.Control;
            tpSingleVolume.Controls.Add(tcSVTypes);
            tpSingleVolume.Location = new Point(4, 24);
            tpSingleVolume.Name = "tpSingleVolume";
            tpSingleVolume.Padding = new Padding(3);
            tpSingleVolume.Size = new Size(521, 720);
            tpSingleVolume.TabIndex = 0;
            tpSingleVolume.Text = "Одночастные (однотомные) ресурсы";
            // 
            // tcSVTypes
            // 
            tcSVTypes.Controls.Add(tpSVBook);
            tcSVTypes.Controls.Add(tpSVConferenceMaterials);
            tcSVTypes.Controls.Add(tpSVGOST);
            tcSVTypes.Controls.Add(tpSVLegislativeMaterial);
            tcSVTypes.Controls.Add(tpSVDissertationAbstract);
            tcSVTypes.Controls.Add(tpSVDissertation);
            tcSVTypes.ImeMode = ImeMode.NoControl;
            tcSVTypes.Location = new Point(3, 6);
            tcSVTypes.Name = "tcSVTypes";
            tcSVTypes.SelectedIndex = 0;
            tcSVTypes.Size = new Size(513, 709);
            tcSVTypes.TabIndex = 0;
            tcSVTypes.TabStop = false;
            // 
            // tpSVBook
            // 
            tpSVBook.BackColor = SystemColors.Control;
            tpSVBook.Controls.Add(gpSVBookRequired);
            tpSVBook.Controls.Add(gpSVBookOptional);
            tpSVBook.Location = new Point(4, 24);
            tpSVBook.Name = "tpSVBook";
            tpSVBook.Padding = new Padding(3);
            tpSVBook.Size = new Size(505, 681);
            tpSVBook.TabIndex = 0;
            tpSVBook.Text = "Книга";
            // 
            // gpSVBookRequired
            // 
            gpSVBookRequired.Controls.Add(panelSVBookRequired);
            gpSVBookRequired.Location = new Point(10, 10);
            gpSVBookRequired.Name = "gpSVBookRequired";
            gpSVBookRequired.Size = new Size(488, 330);
            gpSVBookRequired.TabIndex = 0;
            gpSVBookRequired.TabStop = false;
            gpSVBookRequired.Text = "Обязательные поля";
            // 
            // panelSVBookRequired
            // 
            panelSVBookRequired.AutoScroll = true;
            panelSVBookRequired.Controls.Add(lbSVBPublishingLocationSelect);
            panelSVBookRequired.Controls.Add(cbSVBPublisher);
            panelSVBookRequired.Controls.Add(cbSVBAuthors);
            panelSVBookRequired.Controls.Add(buttonSVBPublisherAdd);
            panelSVBookRequired.Controls.Add(lbSVBPublisher);
            panelSVBookRequired.Controls.Add(buttonSVBPublishingLocationAdd);
            panelSVBookRequired.Controls.Add(lbSVBPublishingLocation);
            panelSVBookRequired.Controls.Add(labelSVBAuthors);
            panelSVBookRequired.Controls.Add(tbSVBAuthors);
            panelSVBookRequired.Controls.Add(buttonSVBAuthorsAdd);
            panelSVBookRequired.Controls.Add(lbSVBAuthors);
            panelSVBookRequired.Controls.Add(tbSVBPublishYear);
            panelSVBookRequired.Controls.Add(labelSVBTitle);
            panelSVBookRequired.Controls.Add(labelSVBPublishYear);
            panelSVBookRequired.Controls.Add(tbSVBTitle);
            panelSVBookRequired.Controls.Add(tbSVBPublisher);
            panelSVBookRequired.Controls.Add(labelSVBPublishingLocation);
            panelSVBookRequired.Controls.Add(labelSVBPublisher);
            panelSVBookRequired.Controls.Add(tbSVBPublishingLocation);
            panelSVBookRequired.Location = new Point(10, 22);
            panelSVBookRequired.Name = "panelSVBookRequired";
            panelSVBookRequired.Size = new Size(473, 302);
            panelSVBookRequired.TabIndex = 14;
            // 
            // lbSVBPublishingLocationSelect
            // 
            lbSVBPublishingLocationSelect.Enabled = false;
            lbSVBPublishingLocationSelect.FormattingEnabled = true;
            lbSVBPublishingLocationSelect.ItemHeight = 15;
            lbSVBPublishingLocationSelect.Location = new Point(243, 319);
            lbSVBPublishingLocationSelect.Name = "lbSVBPublishingLocationSelect";
            lbSVBPublishingLocationSelect.Size = new Size(207, 64);
            lbSVBPublishingLocationSelect.TabIndex = 49;
            lbSVBPublishingLocationSelect.TabStop = false;
            lbSVBPublishingLocationSelect.SelectedIndexChanged += this.lbSVBPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbSVBPublisher
            // 
            cbSVBPublisher.AutoSize = true;
            cbSVBPublisher.Location = new Point(339, 292);
            cbSVBPublisher.Name = "cbSVBPublisher";
            cbSVBPublisher.Size = new Size(111, 19);
            cbSVBPublisher.TabIndex = 18;
            cbSVBPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbSVBPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbSVBPublisher.UseVisualStyleBackColor = true;
            cbSVBPublisher.CheckedChanged += this.cbSVBPublisher_CheckedChanged;
            // 
            // cbSVBAuthors
            // 
            cbSVBAuthors.AutoSize = true;
            cbSVBAuthors.Location = new Point(371, 20);
            cbSVBAuthors.Name = "cbSVBAuthors";
            cbSVBAuthors.Size = new Size(79, 19);
            cbSVBAuthors.TabIndex = 12;
            cbSVBAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbSVBAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbSVBAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonSVBPublisherAdd
            // 
            buttonSVBPublisherAdd.Location = new Point(243, 290);
            buttonSVBPublisherAdd.Name = "buttonSVBPublisherAdd";
            buttonSVBPublisherAdd.Size = new Size(90, 23);
            buttonSVBPublisherAdd.TabIndex = 17;
            buttonSVBPublisherAdd.Text = "Добавить";
            buttonSVBPublisherAdd.UseVisualStyleBackColor = true;
            buttonSVBPublisherAdd.Click += this.buttonSVBPublisherAdd_Click;
            // 
            // lbSVBPublisher
            // 
            lbSVBPublisher.AllowDrop = true;
            lbSVBPublisher.ContextMenuStrip = cmsListBox;
            lbSVBPublisher.ItemHeight = 15;
            lbSVBPublisher.Location = new Point(0, 319);
            lbSVBPublisher.Name = "lbSVBPublisher";
            lbSVBPublisher.Size = new Size(237, 64);
            lbSVBPublisher.TabIndex = 16;
            lbSVBPublisher.TabStop = false;
            lbSVBPublisher.DragDrop += this.ListBox_DragDrop;
            lbSVBPublisher.DragOver += this.ListBox_DragOver;
            lbSVBPublisher.KeyDown += this.ListBox_KeyDown;
            lbSVBPublisher.MouseDown += this.ListBox_MouseDown;
            lbSVBPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonSVBPublishingLocationAdd
            // 
            buttonSVBPublishingLocationAdd.Location = new Point(360, 176);
            buttonSVBPublishingLocationAdd.Name = "buttonSVBPublishingLocationAdd";
            buttonSVBPublishingLocationAdd.Size = new Size(90, 23);
            buttonSVBPublishingLocationAdd.TabIndex = 15;
            buttonSVBPublishingLocationAdd.Text = "Добавить";
            buttonSVBPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonSVBPublishingLocationAdd.Click += this.buttonSVBPublishingLocationAdd_Click;
            // 
            // lbSVBPublishingLocation
            // 
            lbSVBPublishingLocation.AllowDrop = true;
            lbSVBPublishingLocation.ContextMenuStrip = cmsListBox;
            lbSVBPublishingLocation.ItemHeight = 15;
            lbSVBPublishingLocation.Location = new Point(0, 205);
            lbSVBPublishingLocation.Name = "lbSVBPublishingLocation";
            lbSVBPublishingLocation.Size = new Size(450, 64);
            lbSVBPublishingLocation.TabIndex = 14;
            lbSVBPublishingLocation.TabStop = false;
            lbSVBPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbSVBPublishingLocation.DragOver += this.ListBox_DragOver;
            lbSVBPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbSVBPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbSVBPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // labelSVBAuthors
            // 
            labelSVBAuthors.AutoSize = true;
            labelSVBAuthors.Location = new Point(0, 0);
            labelSVBAuthors.Name = "labelSVBAuthors";
            labelSVBAuthors.Size = new Size(57, 15);
            labelSVBAuthors.TabIndex = 0;
            labelSVBAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelSVBAuthors, resources.GetString("labelSVBAuthors.ToolTip"));
            // 
            // tbSVBAuthors
            // 
            tbSVBAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBAuthors.Location = new Point(0, 18);
            tbSVBAuthors.Name = "tbSVBAuthors";
            tbSVBAuthors.Size = new Size(269, 23);
            tbSVBAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbSVBAuthors, resources.GetString("tbSVBAuthors.ToolTip"));
            tbSVBAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonSVBAuthorsAdd
            // 
            buttonSVBAuthorsAdd.Location = new Point(275, 18);
            buttonSVBAuthorsAdd.Name = "buttonSVBAuthorsAdd";
            buttonSVBAuthorsAdd.Size = new Size(90, 23);
            buttonSVBAuthorsAdd.TabIndex = 11;
            buttonSVBAuthorsAdd.Text = "Добавить";
            buttonSVBAuthorsAdd.UseVisualStyleBackColor = true;
            buttonSVBAuthorsAdd.Click += this.buttonSVBAuthorsAdd_Click;
            // 
            // lbSVBAuthors
            // 
            lbSVBAuthors.AllowDrop = true;
            lbSVBAuthors.ContextMenuStrip = cmsListBox;
            lbSVBAuthors.ItemHeight = 15;
            lbSVBAuthors.Location = new Point(0, 47);
            lbSVBAuthors.Name = "lbSVBAuthors";
            lbSVBAuthors.Size = new Size(450, 64);
            lbSVBAuthors.TabIndex = 3;
            lbSVBAuthors.TabStop = false;
            lbSVBAuthors.Tag = "";
            lbSVBAuthors.DragDrop += this.ListBox_DragDrop;
            lbSVBAuthors.DragOver += this.ListBox_DragOver;
            lbSVBAuthors.KeyDown += this.ListBox_KeyDown;
            lbSVBAuthors.MouseDown += this.ListBox_MouseDown;
            lbSVBAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVBPublishYear
            // 
            tbSVBPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBPublishYear.Location = new Point(0, 404);
            tbSVBPublishYear.Name = "tbSVBPublishYear";
            tbSVBPublishYear.Size = new Size(450, 23);
            tbSVBPublishYear.TabIndex = 19;
            ttMain.SetToolTip(tbSVBPublishYear, "Год публикации книги.\r\nПример: \"2019\"\r\n");
            tbSVBPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBTitle
            // 
            labelSVBTitle.AutoSize = true;
            labelSVBTitle.Location = new Point(0, 114);
            labelSVBTitle.Name = "labelSVBTitle";
            labelSVBTitle.Size = new Size(57, 15);
            labelSVBTitle.TabIndex = 4;
            labelSVBTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVBTitle, "Полное название книги, как указано в источнике, без сокращений.\r\nПример: \"Экономика организации. Ресурсы коммерческой организации\".");
            // 
            // labelSVBPublishYear
            // 
            labelSVBPublishYear.AutoSize = true;
            labelSVBPublishYear.Location = new Point(1, 386);
            labelSVBPublishYear.Name = "labelSVBPublishYear";
            labelSVBPublishYear.Size = new Size(73, 15);
            labelSVBPublishYear.TabIndex = 10;
            labelSVBPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVBPublishYear, "Год публикации книги.\r\nПример: \"2019\"");
            // 
            // tbSVBTitle
            // 
            tbSVBTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBTitle.Location = new Point(0, 132);
            tbSVBTitle.Name = "tbSVBTitle";
            tbSVBTitle.Size = new Size(450, 23);
            tbSVBTitle.TabIndex = 13;
            ttMain.SetToolTip(tbSVBTitle, "Полное название книги, как указано в источнике, без сокращений.\r\nПример: \"Экономика организации. Ресурсы коммерческой организации\".");
            tbSVBTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVBPublisher
            // 
            tbSVBPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBPublisher.Location = new Point(0, 290);
            tbSVBPublisher.Name = "tbSVBPublisher";
            tbSVBPublisher.Size = new Size(237, 23);
            tbSVBPublisher.TabIndex = 16;
            ttMain.SetToolTip(tbSVBPublisher, resources.GetString("tbSVBPublisher.ToolTip"));
            tbSVBPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBPublishingLocation
            // 
            labelSVBPublishingLocation.AutoSize = true;
            labelSVBPublishingLocation.Location = new Point(0, 158);
            labelSVBPublishingLocation.Name = "labelSVBPublishingLocation";
            labelSVBPublishingLocation.Size = new Size(89, 15);
            labelSVBPublishingLocation.TabIndex = 6;
            labelSVBPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVBPublishingLocation, "Город, где книга была издана.\r\nПример: \"Москва\".");
            // 
            // labelSVBPublisher
            // 
            labelSVBPublisher.AutoSize = true;
            labelSVBPublisher.Location = new Point(0, 272);
            labelSVBPublisher.Name = "labelSVBPublisher";
            labelSVBPublisher.Size = new Size(81, 15);
            labelSVBPublisher.TabIndex = 8;
            labelSVBPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelSVBPublisher, resources.GetString("labelSVBPublisher.ToolTip"));
            // 
            // tbSVBPublishingLocation
            // 
            tbSVBPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBPublishingLocation.Location = new Point(0, 176);
            tbSVBPublishingLocation.Name = "tbSVBPublishingLocation";
            tbSVBPublishingLocation.Size = new Size(354, 23);
            tbSVBPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbSVBPublishingLocation, "Город, где книга была издана.\r\nПример: \"Москва\".\r\n");
            tbSVBPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // gpSVBookOptional
            // 
            gpSVBookOptional.Controls.Add(panelSVBookOptional);
            gpSVBookOptional.Location = new Point(10, 346);
            gpSVBookOptional.Name = "gpSVBookOptional";
            gpSVBookOptional.Size = new Size(488, 330);
            gpSVBookOptional.TabIndex = 1;
            gpSVBookOptional.TabStop = false;
            gpSVBookOptional.Text = "Необязательные поля";
            // 
            // panelSVBookOptional
            // 
            panelSVBookOptional.AutoScroll = true;
            panelSVBookOptional.Controls.Add(cbSVBEditorType);
            panelSVBookOptional.Controls.Add(labelSVBOrganization);
            panelSVBookOptional.Controls.Add(tbSVBOrganization);
            panelSVBookOptional.Controls.Add(lbSVBEditor);
            panelSVBookOptional.Controls.Add(buttonSVBEditorAdd);
            panelSVBookOptional.Controls.Add(labelSVBParallelTitle);
            panelSVBookOptional.Controls.Add(tbSVBParallelTitle);
            panelSVBookOptional.Controls.Add(tbSVBPagesCount);
            panelSVBookOptional.Controls.Add(labelSVBContentType);
            panelSVBookOptional.Controls.Add(labelSVBPagesCount);
            panelSVBookOptional.Controls.Add(tbSVBContentType);
            panelSVBookOptional.Controls.Add(labelSVBDocumentType);
            panelSVBookOptional.Controls.Add(tbSVBDocumentType);
            panelSVBookOptional.Controls.Add(labelSVBEditor);
            panelSVBookOptional.Controls.Add(tbSVBTranslator);
            panelSVBookOptional.Controls.Add(tbSVBEditor);
            panelSVBookOptional.Controls.Add(labelSVBTranslator);
            panelSVBookOptional.Controls.Add(labelSVBEditionNumber);
            panelSVBookOptional.Controls.Add(tbSVBISBN);
            panelSVBookOptional.Controls.Add(tbSVBEditionNumber);
            panelSVBookOptional.Controls.Add(labelSVBISBN);
            panelSVBookOptional.Controls.Add(labelSVBSeries);
            panelSVBookOptional.Controls.Add(tbSVBSeries);
            panelSVBookOptional.Location = new Point(10, 22);
            panelSVBookOptional.Name = "panelSVBookOptional";
            panelSVBookOptional.Size = new Size(473, 302);
            panelSVBookOptional.TabIndex = 14;
            // 
            // cbSVBEditorType
            // 
            cbSVBEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSVBEditorType.FormattingEnabled = true;
            cbSVBEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbSVBEditorType.Location = new Point(194, 106);
            cbSVBEditorType.Name = "cbSVBEditorType";
            cbSVBEditorType.Size = new Size(160, 23);
            cbSVBEditorType.TabIndex = 23;
            // 
            // labelSVBOrganization
            // 
            labelSVBOrganization.AutoSize = true;
            labelSVBOrganization.Location = new Point(0, 202);
            labelSVBOrganization.Name = "labelSVBOrganization";
            labelSVBOrganization.Size = new Size(79, 15);
            labelSVBOrganization.TabIndex = 12;
            labelSVBOrganization.Text = "Организация";
            ttMain.SetToolTip(labelSVBOrganization, resources.GetString("labelSVBOrganization.ToolTip"));
            // 
            // tbSVBOrganization
            // 
            tbSVBOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBOrganization.Location = new Point(0, 220);
            tbSVBOrganization.Name = "tbSVBOrganization";
            tbSVBOrganization.Size = new Size(450, 23);
            tbSVBOrganization.TabIndex = 25;
            ttMain.SetToolTip(tbSVBOrganization, resources.GetString("tbSVBOrganization.ToolTip"));
            tbSVBOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // lbSVBEditor
            // 
            lbSVBEditor.AllowDrop = true;
            lbSVBEditor.ContextMenuStrip = cmsListBox;
            lbSVBEditor.ItemHeight = 15;
            lbSVBEditor.Location = new Point(0, 135);
            lbSVBEditor.Name = "lbSVBEditor";
            lbSVBEditor.Size = new Size(450, 64);
            lbSVBEditor.TabIndex = 19;
            lbSVBEditor.TabStop = false;
            lbSVBEditor.DragDrop += this.ListBox_DragDrop;
            lbSVBEditor.DragOver += this.ListBox_DragOver;
            lbSVBEditor.KeyDown += this.ListBox_KeyDown;
            lbSVBEditor.MouseDown += this.ListBox_MouseDown;
            lbSVBEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonSVBEditorAdd
            // 
            buttonSVBEditorAdd.Location = new Point(360, 106);
            buttonSVBEditorAdd.Name = "buttonSVBEditorAdd";
            buttonSVBEditorAdd.Size = new Size(90, 23);
            buttonSVBEditorAdd.TabIndex = 24;
            buttonSVBEditorAdd.Text = "Добавить";
            buttonSVBEditorAdd.UseVisualStyleBackColor = true;
            buttonSVBEditorAdd.Click += this.buttonSVBEditorAdd_Click;
            // 
            // labelSVBParallelTitle
            // 
            labelSVBParallelTitle.AutoSize = true;
            labelSVBParallelTitle.Location = new Point(0, 0);
            labelSVBParallelTitle.Name = "labelSVBParallelTitle";
            labelSVBParallelTitle.Size = new Size(139, 15);
            labelSVBParallelTitle.TabIndex = 16;
            labelSVBParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelSVBParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbSVBParallelTitle
            // 
            tbSVBParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBParallelTitle.Location = new Point(0, 18);
            tbSVBParallelTitle.Name = "tbSVBParallelTitle";
            tbSVBParallelTitle.Size = new Size(450, 23);
            tbSVBParallelTitle.TabIndex = 20;
            ttMain.SetToolTip(tbSVBParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbSVBParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVBPagesCount
            // 
            tbSVBPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBPagesCount.Location = new Point(0, 352);
            tbSVBPagesCount.Name = "tbSVBPagesCount";
            tbSVBPagesCount.Size = new Size(450, 23);
            tbSVBPagesCount.TabIndex = 28;
            ttMain.SetToolTip(tbSVBPagesCount, "Общий объем книги в страницах.\r\nПример: \"134\".\r\n");
            tbSVBPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBContentType
            // 
            labelSVBContentType.AutoSize = true;
            labelSVBContentType.Location = new Point(0, 466);
            labelSVBContentType.Name = "labelSVBContentType";
            labelSVBContentType.Size = new Size(97, 15);
            labelSVBContentType.TabIndex = 14;
            labelSVBContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVBContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // labelSVBPagesCount
            // 
            labelSVBPagesCount.AutoSize = true;
            labelSVBPagesCount.Location = new Point(0, 334);
            labelSVBPagesCount.Name = "labelSVBPagesCount";
            labelSVBPagesCount.Size = new Size(120, 15);
            labelSVBPagesCount.TabIndex = 12;
            labelSVBPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVBPagesCount, "Общий объем книги в страницах.\r\nПример: \"134\".");
            // 
            // tbSVBContentType
            // 
            tbSVBContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBContentType.Location = new Point(0, 484);
            tbSVBContentType.Name = "tbSVBContentType";
            tbSVBContentType.Size = new Size(450, 23);
            tbSVBContentType.TabIndex = 31;
            ttMain.SetToolTip(tbSVBContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbSVBContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBDocumentType
            // 
            labelSVBDocumentType.AutoSize = true;
            labelSVBDocumentType.Location = new Point(0, 44);
            labelSVBDocumentType.Name = "labelSVBDocumentType";
            labelSVBDocumentType.Size = new Size(88, 15);
            labelSVBDocumentType.TabIndex = 0;
            labelSVBDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelSVBDocumentType, "Уточняет тип издания (учебник, монография и т.д.).\r\nПример: \"учебное пособие\" или \"[монография]\"");
            // 
            // tbSVBDocumentType
            // 
            tbSVBDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBDocumentType.Location = new Point(0, 62);
            tbSVBDocumentType.Name = "tbSVBDocumentType";
            tbSVBDocumentType.Size = new Size(450, 23);
            tbSVBDocumentType.TabIndex = 21;
            ttMain.SetToolTip(tbSVBDocumentType, "Уточняет тип издания (учебник, монография и т.д.).\r\nПример: \"учебное пособие\" или \"[монография]\"\r\n");
            tbSVBDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBEditor
            // 
            labelSVBEditor.AutoSize = true;
            labelSVBEditor.Location = new Point(0, 88);
            labelSVBEditor.Name = "labelSVBEditor";
            labelSVBEditor.Size = new Size(74, 15);
            labelSVBEditor.TabIndex = 2;
            labelSVBEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelSVBEditor, resources.GetString("labelSVBEditor.ToolTip"));
            // 
            // tbSVBTranslator
            // 
            tbSVBTranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBTranslator.Location = new Point(0, 308);
            tbSVBTranslator.Name = "tbSVBTranslator";
            tbSVBTranslator.Size = new Size(450, 23);
            tbSVBTranslator.TabIndex = 27;
            ttMain.SetToolTip(tbSVBTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            tbSVBTranslator.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVBEditor
            // 
            tbSVBEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBEditor.Location = new Point(0, 106);
            tbSVBEditor.Name = "tbSVBEditor";
            tbSVBEditor.Size = new Size(188, 23);
            tbSVBEditor.TabIndex = 22;
            ttMain.SetToolTip(tbSVBEditor, resources.GetString("tbSVBEditor.ToolTip"));
            tbSVBEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBTranslator
            // 
            labelSVBTranslator.AutoSize = true;
            labelSVBTranslator.Location = new Point(0, 290);
            labelSVBTranslator.Name = "labelSVBTranslator";
            labelSVBTranslator.Size = new Size(74, 15);
            labelSVBTranslator.TabIndex = 10;
            labelSVBTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelSVBTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".");
            // 
            // labelSVBEditionNumber
            // 
            labelSVBEditionNumber.AutoSize = true;
            labelSVBEditionNumber.Location = new Point(0, 246);
            labelSVBEditionNumber.Name = "labelSVBEditionNumber";
            labelSVBEditionNumber.Size = new Size(92, 15);
            labelSVBEditionNumber.TabIndex = 4;
            labelSVBEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelSVBEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".");
            // 
            // tbSVBISBN
            // 
            tbSVBISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBISBN.Location = new Point(0, 440);
            tbSVBISBN.Name = "tbSVBISBN";
            tbSVBISBN.Size = new Size(450, 23);
            tbSVBISBN.TabIndex = 30;
            ttMain.SetToolTip(tbSVBISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".");
            tbSVBISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVBEditionNumber
            // 
            tbSVBEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBEditionNumber.Location = new Point(0, 264);
            tbSVBEditionNumber.Name = "tbSVBEditionNumber";
            tbSVBEditionNumber.Size = new Size(450, 23);
            tbSVBEditionNumber.TabIndex = 26;
            ttMain.SetToolTip(tbSVBEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, перераб. и доп.\".");
            tbSVBEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVBISBN
            // 
            labelSVBISBN.AutoSize = true;
            labelSVBISBN.Location = new Point(0, 422);
            labelSVBISBN.Name = "labelSVBISBN";
            labelSVBISBN.Size = new Size(32, 15);
            labelSVBISBN.TabIndex = 8;
            labelSVBISBN.Text = "ISBN";
            ttMain.SetToolTip(labelSVBISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".");
            // 
            // labelSVBSeries
            // 
            labelSVBSeries.AutoSize = true;
            labelSVBSeries.Location = new Point(0, 378);
            labelSVBSeries.Name = "labelSVBSeries";
            labelSVBSeries.Size = new Size(41, 15);
            labelSVBSeries.TabIndex = 6;
            labelSVBSeries.Text = "Серия";
            ttMain.SetToolTip(labelSVBSeries, "Название серии, в которой издана книга.\r\nПример: \"Профессиональное образование\".");
            // 
            // tbSVBSeries
            // 
            tbSVBSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVBSeries.Location = new Point(0, 396);
            tbSVBSeries.Name = "tbSVBSeries";
            tbSVBSeries.Size = new Size(450, 23);
            tbSVBSeries.TabIndex = 29;
            ttMain.SetToolTip(tbSVBSeries, "Название серии, в которой издана книга.\r\nПример: \"Профессиональное образование\".\r\n");
            tbSVBSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tpSVConferenceMaterials
            // 
            tpSVConferenceMaterials.BackColor = SystemColors.Control;
            tpSVConferenceMaterials.Controls.Add(gbSVConferenceMaterialsRequired);
            tpSVConferenceMaterials.Controls.Add(gbSVConferenceMaterialsOptional);
            tpSVConferenceMaterials.Location = new Point(4, 24);
            tpSVConferenceMaterials.Name = "tpSVConferenceMaterials";
            tpSVConferenceMaterials.Padding = new Padding(3);
            tpSVConferenceMaterials.Size = new Size(505, 681);
            tpSVConferenceMaterials.TabIndex = 4;
            tpSVConferenceMaterials.Text = "Материалы конференции";
            // 
            // gbSVConferenceMaterialsRequired
            // 
            gbSVConferenceMaterialsRequired.Controls.Add(panelSVConferenceMaterialsRequired);
            gbSVConferenceMaterialsRequired.Location = new Point(10, 10);
            gbSVConferenceMaterialsRequired.Name = "gbSVConferenceMaterialsRequired";
            gbSVConferenceMaterialsRequired.Size = new Size(488, 330);
            gbSVConferenceMaterialsRequired.TabIndex = 2;
            gbSVConferenceMaterialsRequired.TabStop = false;
            gbSVConferenceMaterialsRequired.Text = "Обязательные поля";
            // 
            // panelSVConferenceMaterialsRequired
            // 
            panelSVConferenceMaterialsRequired.AutoScroll = true;
            panelSVConferenceMaterialsRequired.Controls.Add(lbSVCMPublishingLocationSelect);
            panelSVConferenceMaterialsRequired.Controls.Add(cbSVCMPublisher);
            panelSVConferenceMaterialsRequired.Controls.Add(buttonSVCMPublisherAdd);
            panelSVConferenceMaterialsRequired.Controls.Add(lbSVCMPublisher);
            panelSVConferenceMaterialsRequired.Controls.Add(buttonSVCMPublishingLocationAdd);
            panelSVConferenceMaterialsRequired.Controls.Add(lbSVCMPublishingLocation);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMPublisher);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMPublisher);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMPublishingLocation);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMPublishingLocation);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMEventDate);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMEventDate);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMEventTitle);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMEventTitle);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMPublishYear);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMPublishYear);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMEventPlace);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMPublicationType);
            panelSVConferenceMaterialsRequired.Controls.Add(labelSVCMEventPlace);
            panelSVConferenceMaterialsRequired.Controls.Add(tbSVCMPublicationType);
            panelSVConferenceMaterialsRequired.Location = new Point(10, 22);
            panelSVConferenceMaterialsRequired.Name = "panelSVConferenceMaterialsRequired";
            panelSVConferenceMaterialsRequired.Size = new Size(473, 302);
            panelSVConferenceMaterialsRequired.TabIndex = 14;
            // 
            // lbSVCMPublishingLocationSelect
            // 
            lbSVCMPublishingLocationSelect.Enabled = false;
            lbSVCMPublishingLocationSelect.FormattingEnabled = true;
            lbSVCMPublishingLocationSelect.ItemHeight = 15;
            lbSVCMPublishingLocationSelect.Location = new Point(243, 337);
            lbSVCMPublishingLocationSelect.Name = "lbSVCMPublishingLocationSelect";
            lbSVCMPublishingLocationSelect.Size = new Size(207, 64);
            lbSVCMPublishingLocationSelect.TabIndex = 51;
            lbSVCMPublishingLocationSelect.TabStop = false;
            // 
            // cbSVCMPublisher
            // 
            cbSVCMPublisher.AutoSize = true;
            cbSVCMPublisher.Location = new Point(339, 310);
            cbSVCMPublisher.Name = "cbSVCMPublisher";
            cbSVCMPublisher.Size = new Size(111, 19);
            cbSVCMPublisher.TabIndex = 18;
            cbSVCMPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbSVCMPublisher, "Включение «умного режима» добавления издательств");
            cbSVCMPublisher.UseVisualStyleBackColor = true;
            // 
            // buttonSVCMPublisherAdd
            // 
            buttonSVCMPublisherAdd.Location = new Point(243, 308);
            buttonSVCMPublisherAdd.Name = "buttonSVCMPublisherAdd";
            buttonSVCMPublisherAdd.Size = new Size(90, 23);
            buttonSVCMPublisherAdd.TabIndex = 17;
            buttonSVCMPublisherAdd.Text = "Добавить";
            buttonSVCMPublisherAdd.UseVisualStyleBackColor = true;
            buttonSVCMPublisherAdd.Click += this.buttonSVCPublisherAdd_Click;
            // 
            // lbSVCMPublisher
            // 
            lbSVCMPublisher.AllowDrop = true;
            lbSVCMPublisher.ContextMenuStrip = cmsListBox;
            lbSVCMPublisher.ItemHeight = 15;
            lbSVCMPublisher.Location = new Point(0, 337);
            lbSVCMPublisher.Name = "lbSVCMPublisher";
            lbSVCMPublisher.Size = new Size(237, 64);
            lbSVCMPublisher.TabIndex = 22;
            lbSVCMPublisher.TabStop = false;
            lbSVCMPublisher.DragDrop += this.ListBox_DragDrop;
            lbSVCMPublisher.DragOver += this.ListBox_DragOver;
            lbSVCMPublisher.KeyDown += this.ListBox_KeyDown;
            lbSVCMPublisher.MouseDown += this.ListBox_MouseDown;
            lbSVCMPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonSVCMPublishingLocationAdd
            // 
            buttonSVCMPublishingLocationAdd.Location = new Point(360, 194);
            buttonSVCMPublishingLocationAdd.Name = "buttonSVCMPublishingLocationAdd";
            buttonSVCMPublishingLocationAdd.Size = new Size(90, 23);
            buttonSVCMPublishingLocationAdd.TabIndex = 15;
            buttonSVCMPublishingLocationAdd.Text = "Добавить";
            buttonSVCMPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonSVCMPublishingLocationAdd.Click += this.buttonSVCPublishingLocationAdd_Click;
            // 
            // lbSVCMPublishingLocation
            // 
            lbSVCMPublishingLocation.AllowDrop = true;
            lbSVCMPublishingLocation.ContextMenuStrip = cmsListBox;
            lbSVCMPublishingLocation.ItemHeight = 15;
            lbSVCMPublishingLocation.Location = new Point(0, 223);
            lbSVCMPublishingLocation.Name = "lbSVCMPublishingLocation";
            lbSVCMPublishingLocation.Size = new Size(450, 64);
            lbSVCMPublishingLocation.TabIndex = 20;
            lbSVCMPublishingLocation.TabStop = false;
            lbSVCMPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbSVCMPublishingLocation.DragOver += this.ListBox_DragOver;
            lbSVCMPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbSVCMPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbSVCMPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVCMPublisher
            // 
            tbSVCMPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPublisher.Location = new Point(0, 308);
            tbSVCMPublisher.Name = "tbSVCMPublisher";
            tbSVCMPublisher.Size = new Size(237, 23);
            tbSVCMPublisher.TabIndex = 16;
            ttMain.SetToolTip(tbSVCMPublisher, resources.GetString("tbSVCMPublisher.ToolTip"));
            tbSVCMPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMPublisher
            // 
            labelSVCMPublisher.AutoSize = true;
            labelSVCMPublisher.Location = new Point(0, 290);
            labelSVCMPublisher.Name = "labelSVCMPublisher";
            labelSVCMPublisher.Size = new Size(81, 15);
            labelSVCMPublisher.TabIndex = 18;
            labelSVCMPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelSVCMPublisher, resources.GetString("labelSVCMPublisher.ToolTip"));
            // 
            // tbSVCMPublishingLocation
            // 
            tbSVCMPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPublishingLocation.Location = new Point(0, 194);
            tbSVCMPublishingLocation.Name = "tbSVCMPublishingLocation";
            tbSVCMPublishingLocation.Size = new Size(354, 23);
            tbSVCMPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbSVCMPublishingLocation, "Город, в котором было издано издание.\r\nПример: «Москва»\r\n");
            tbSVCMPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMPublishingLocation
            // 
            labelSVCMPublishingLocation.AutoSize = true;
            labelSVCMPublishingLocation.Location = new Point(0, 176);
            labelSVCMPublishingLocation.Name = "labelSVCMPublishingLocation";
            labelSVCMPublishingLocation.Size = new Size(89, 15);
            labelSVCMPublishingLocation.TabIndex = 16;
            labelSVCMPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVCMPublishingLocation, "Город, в котором было издано издание.\r\nПример: «Москва»");
            // 
            // tbSVCMEventDate
            // 
            tbSVCMEventDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMEventDate.Location = new Point(0, 150);
            tbSVCMEventDate.Name = "tbSVCMEventDate";
            tbSVCMEventDate.Size = new Size(450, 23);
            tbSVCMEventDate.TabIndex = 13;
            ttMain.SetToolTip(tbSVCMEventDate, "Дата, когда проходило мероприятие.\r\nПример: «15 ноября 2017 г.»\r\n");
            tbSVCMEventDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMEventDate
            // 
            labelSVCMEventDate.AutoSize = true;
            labelSVCMEventDate.Location = new Point(0, 132);
            labelSVCMEventDate.Name = "labelSVCMEventDate";
            labelSVCMEventDate.Size = new Size(100, 15);
            labelSVCMEventDate.TabIndex = 14;
            labelSVCMEventDate.Text = "Дата проведения";
            ttMain.SetToolTip(labelSVCMEventDate, "Дата, когда проходило мероприятие.\r\nПример: «15 ноября 2017 г.»");
            // 
            // labelSVCMEventTitle
            // 
            labelSVCMEventTitle.AutoSize = true;
            labelSVCMEventTitle.Location = new Point(0, 0);
            labelSVCMEventTitle.Name = "labelSVCMEventTitle";
            labelSVCMEventTitle.Size = new Size(136, 15);
            labelSVCMEventTitle.TabIndex = 0;
            labelSVCMEventTitle.Text = "Название мероприятия";
            ttMain.SetToolTip(labelSVCMEventTitle, "Полное название конференции или научного мероприятия.\r\nПример: «Институциональная экономика: развитие, преподавание, приложения»");
            // 
            // tbSVCMEventTitle
            // 
            tbSVCMEventTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMEventTitle.Location = new Point(0, 18);
            tbSVCMEventTitle.Name = "tbSVCMEventTitle";
            tbSVCMEventTitle.Size = new Size(450, 23);
            tbSVCMEventTitle.TabIndex = 10;
            ttMain.SetToolTip(tbSVCMEventTitle, "Полное название конференции или научного мероприятия.\r\nПример: «Институциональная экономика: развитие, преподавание, приложения»");
            tbSVCMEventTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVCMPublishYear
            // 
            tbSVCMPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPublishYear.Location = new Point(0, 422);
            tbSVCMPublishYear.Name = "tbSVCMPublishYear";
            tbSVCMPublishYear.Size = new Size(450, 23);
            tbSVCMPublishYear.TabIndex = 19;
            ttMain.SetToolTip(tbSVCMPublishYear, "Год публикации материалов.\r\nПример: \"2019\".\r\n\r\n");
            tbSVCMPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMPublishYear
            // 
            labelSVCMPublishYear.AutoSize = true;
            labelSVCMPublishYear.Location = new Point(0, 404);
            labelSVCMPublishYear.Name = "labelSVCMPublishYear";
            labelSVCMPublishYear.Size = new Size(73, 15);
            labelSVCMPublishYear.TabIndex = 10;
            labelSVCMPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVCMPublishYear, "Год публикации материалов.\r\nПример: \"2019\".\r\n");
            // 
            // tbSVCMEventPlace
            // 
            tbSVCMEventPlace.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMEventPlace.Location = new Point(0, 106);
            tbSVCMEventPlace.Name = "tbSVCMEventPlace";
            tbSVCMEventPlace.Size = new Size(450, 23);
            tbSVCMEventPlace.TabIndex = 12;
            ttMain.SetToolTip(tbSVCMEventPlace, "Город, в котором проходило мероприятие.\r\nПример: «Москва»\r\n");
            tbSVCMEventPlace.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMPublicationType
            // 
            labelSVCMPublicationType.AutoSize = true;
            labelSVCMPublicationType.Location = new Point(0, 44);
            labelSVCMPublicationType.Name = "labelSVCMPublicationType";
            labelSVCMPublicationType.Size = new Size(74, 15);
            labelSVCMPublicationType.TabIndex = 6;
            labelSVCMPublicationType.Text = "Вид издания";
            ttMain.SetToolTip(labelSVCMPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»");
            // 
            // labelSVCMEventPlace
            // 
            labelSVCMEventPlace.AutoSize = true;
            labelSVCMEventPlace.Location = new Point(0, 88);
            labelSVCMEventPlace.Name = "labelSVCMEventPlace";
            labelSVCMEventPlace.Size = new Size(108, 15);
            labelSVCMEventPlace.TabIndex = 8;
            labelSVCMEventPlace.Text = "Город проведения";
            ttMain.SetToolTip(labelSVCMEventPlace, "Город, в котором проходило мероприятие.\r\nПример: «Москва»");
            // 
            // tbSVCMPublicationType
            // 
            tbSVCMPublicationType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPublicationType.Location = new Point(0, 62);
            tbSVCMPublicationType.Name = "tbSVCMPublicationType";
            tbSVCMPublicationType.Size = new Size(450, 23);
            tbSVCMPublicationType.TabIndex = 11;
            ttMain.SetToolTip(tbSVCMPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»\r\n");
            tbSVCMPublicationType.KeyDown += this.TextBox_KeyDown;
            // 
            // gbSVConferenceMaterialsOptional
            // 
            gbSVConferenceMaterialsOptional.Controls.Add(panelSVConferenceMaterialsOptional);
            gbSVConferenceMaterialsOptional.Location = new Point(10, 346);
            gbSVConferenceMaterialsOptional.Name = "gbSVConferenceMaterialsOptional";
            gbSVConferenceMaterialsOptional.Size = new Size(488, 330);
            gbSVConferenceMaterialsOptional.TabIndex = 3;
            gbSVConferenceMaterialsOptional.TabStop = false;
            gbSVConferenceMaterialsOptional.Text = "Необязательные поля";
            // 
            // panelSVConferenceMaterialsOptional
            // 
            panelSVConferenceMaterialsOptional.AutoScroll = true;
            panelSVConferenceMaterialsOptional.Controls.Add(cbSVCMEditorType);
            panelSVConferenceMaterialsOptional.Controls.Add(lbSVCMEditor);
            panelSVConferenceMaterialsOptional.Controls.Add(buttonSVCMEditorAdd);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMPartNumberAndTitle);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMPartNumberAndTitle);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMContentType);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMContentType);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMPartCount);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMPartCount);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMPagesCount);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMISBN);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMPagesCount);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMEditor);
            panelSVConferenceMaterialsOptional.Controls.Add(tbSVCMISBN);
            panelSVConferenceMaterialsOptional.Controls.Add(labelSVCMEditor);
            panelSVConferenceMaterialsOptional.Location = new Point(10, 22);
            panelSVConferenceMaterialsOptional.Name = "panelSVConferenceMaterialsOptional";
            panelSVConferenceMaterialsOptional.Size = new Size(473, 302);
            panelSVConferenceMaterialsOptional.TabIndex = 14;
            // 
            // cbSVCMEditorType
            // 
            cbSVCMEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSVCMEditorType.FormattingEnabled = true;
            cbSVCMEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbSVCMEditorType.Location = new Point(194, 106);
            cbSVCMEditorType.Name = "cbSVCMEditorType";
            cbSVCMEditorType.Size = new Size(160, 23);
            cbSVCMEditorType.TabIndex = 23;
            // 
            // lbSVCMEditor
            // 
            lbSVCMEditor.AllowDrop = true;
            lbSVCMEditor.ContextMenuStrip = cmsListBox;
            lbSVCMEditor.ItemHeight = 15;
            lbSVCMEditor.Location = new Point(0, 135);
            lbSVCMEditor.Name = "lbSVCMEditor";
            lbSVCMEditor.Size = new Size(450, 64);
            lbSVCMEditor.TabIndex = 22;
            lbSVCMEditor.TabStop = false;
            lbSVCMEditor.DragDrop += this.ListBox_DragDrop;
            lbSVCMEditor.DragOver += this.ListBox_DragOver;
            lbSVCMEditor.KeyDown += this.ListBox_KeyDown;
            lbSVCMEditor.MouseDown += this.ListBox_MouseDown;
            lbSVCMEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonSVCMEditorAdd
            // 
            buttonSVCMEditorAdd.Location = new Point(360, 106);
            buttonSVCMEditorAdd.Name = "buttonSVCMEditorAdd";
            buttonSVCMEditorAdd.Size = new Size(90, 23);
            buttonSVCMEditorAdd.TabIndex = 24;
            buttonSVCMEditorAdd.Text = "Добавить";
            buttonSVCMEditorAdd.UseVisualStyleBackColor = true;
            buttonSVCMEditorAdd.Click += this.buttonSVCEditorAdd_Click;
            // 
            // labelSVCMPartNumberAndTitle
            // 
            labelSVCMPartNumberAndTitle.AutoSize = true;
            labelSVCMPartNumberAndTitle.Location = new Point(0, 44);
            labelSVCMPartNumberAndTitle.Name = "labelSVCMPartNumberAndTitle";
            labelSVCMPartNumberAndTitle.Size = new Size(180, 15);
            labelSVCMPartNumberAndTitle.TabIndex = 12;
            labelSVCMPartNumberAndTitle.Text = "Номер и название части (тома)";
            ttMain.SetToolTip(labelSVCMPartNumberAndTitle, resources.GetString("labelSVCMPartNumberAndTitle.ToolTip"));
            // 
            // tbSVCMPartNumberAndTitle
            // 
            tbSVCMPartNumberAndTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPartNumberAndTitle.Location = new Point(0, 62);
            tbSVCMPartNumberAndTitle.Name = "tbSVCMPartNumberAndTitle";
            tbSVCMPartNumberAndTitle.Size = new Size(450, 23);
            tbSVCMPartNumberAndTitle.TabIndex = 21;
            ttMain.SetToolTip(tbSVCMPartNumberAndTitle, resources.GetString("tbSVCMPartNumberAndTitle.ToolTip"));
            tbSVCMPartNumberAndTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMContentType
            // 
            labelSVCMContentType.AutoSize = true;
            labelSVCMContentType.Location = new Point(0, 290);
            labelSVCMContentType.Name = "labelSVCMContentType";
            labelSVCMContentType.Size = new Size(97, 15);
            labelSVCMContentType.TabIndex = 14;
            labelSVCMContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVCMContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbSVCMContentType
            // 
            tbSVCMContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMContentType.Location = new Point(0, 308);
            tbSVCMContentType.Name = "tbSVCMContentType";
            tbSVCMContentType.Size = new Size(450, 23);
            tbSVCMContentType.TabIndex = 27;
            ttMain.SetToolTip(tbSVCMContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbSVCMContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMPartCount
            // 
            labelSVCMPartCount.AutoSize = true;
            labelSVCMPartCount.Location = new Point(0, 0);
            labelSVCMPartCount.Name = "labelSVCMPartCount";
            labelSVCMPartCount.Size = new Size(157, 15);
            labelSVCMPartCount.TabIndex = 0;
            labelSVCMPartCount.Text = "Количество частей (томов)";
            ttMain.SetToolTip(labelSVCMPartCount, "Количество частей, если издание состоит из нескольких частей или томов.\r\nПример: «3»");
            // 
            // tbSVCMPartCount
            // 
            tbSVCMPartCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPartCount.Location = new Point(0, 18);
            tbSVCMPartCount.Name = "tbSVCMPartCount";
            tbSVCMPartCount.Size = new Size(450, 23);
            tbSVCMPartCount.TabIndex = 20;
            ttMain.SetToolTip(tbSVCMPartCount, "Количество частей, если издание состоит из нескольких частей или томов.\r\nПример: «3»\r\n");
            tbSVCMPartCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVCMPagesCount
            // 
            tbSVCMPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMPagesCount.Location = new Point(0, 220);
            tbSVCMPagesCount.Name = "tbSVCMPagesCount";
            tbSVCMPagesCount.Size = new Size(450, 23);
            tbSVCMPagesCount.TabIndex = 25;
            ttMain.SetToolTip(tbSVCMPagesCount, "Общее объем материалов в страницах.\r\nПример: «382»\r\n");
            tbSVCMPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMISBN
            // 
            labelSVCMISBN.AutoSize = true;
            labelSVCMISBN.Location = new Point(0, 246);
            labelSVCMISBN.Name = "labelSVCMISBN";
            labelSVCMISBN.Size = new Size(32, 15);
            labelSVCMISBN.TabIndex = 2;
            labelSVCMISBN.Text = "ISBN";
            ttMain.SetToolTip(labelSVCMISBN, "Международный стандартный номер книги.\r\nПример: «978-5-215-03012-7»");
            // 
            // labelSVCMPagesCount
            // 
            labelSVCMPagesCount.AutoSize = true;
            labelSVCMPagesCount.Location = new Point(0, 202);
            labelSVCMPagesCount.Name = "labelSVCMPagesCount";
            labelSVCMPagesCount.Size = new Size(120, 15);
            labelSVCMPagesCount.TabIndex = 12;
            labelSVCMPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVCMPagesCount, "Общее объем материалов в страницах.\r\nПример: «382»");
            // 
            // tbSVCMEditor
            // 
            tbSVCMEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMEditor.Location = new Point(0, 106);
            tbSVCMEditor.Name = "tbSVCMEditor";
            tbSVCMEditor.Size = new Size(188, 23);
            tbSVCMEditor.TabIndex = 22;
            ttMain.SetToolTip(tbSVCMEditor, resources.GetString("tbSVCMEditor.ToolTip"));
            tbSVCMEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVCMISBN
            // 
            tbSVCMISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVCMISBN.Location = new Point(0, 264);
            tbSVCMISBN.Name = "tbSVCMISBN";
            tbSVCMISBN.Size = new Size(450, 23);
            tbSVCMISBN.TabIndex = 26;
            ttMain.SetToolTip(tbSVCMISBN, "Международный стандартный номер книги.\r\nПример: «978-5-215-03012-7»\r\n");
            tbSVCMISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVCMEditor
            // 
            labelSVCMEditor.AutoSize = true;
            labelSVCMEditor.Location = new Point(0, 88);
            labelSVCMEditor.Name = "labelSVCMEditor";
            labelSVCMEditor.Size = new Size(74, 15);
            labelSVCMEditor.TabIndex = 10;
            labelSVCMEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelSVCMEditor, resources.GetString("labelSVCMEditor.ToolTip"));
            // 
            // tpSVGOST
            // 
            tpSVGOST.BackColor = SystemColors.Control;
            tpSVGOST.Controls.Add(gbSVGOSTRequired);
            tpSVGOST.Controls.Add(gbSVGOSTOptional);
            tpSVGOST.Location = new Point(4, 24);
            tpSVGOST.Name = "tpSVGOST";
            tpSVGOST.Padding = new Padding(3);
            tpSVGOST.Size = new Size(505, 681);
            tpSVGOST.TabIndex = 1;
            tpSVGOST.Text = "ГОСТ";
            // 
            // gbSVGOSTRequired
            // 
            gbSVGOSTRequired.Controls.Add(panelSVGOSTRequired);
            gbSVGOSTRequired.Location = new Point(10, 10);
            gbSVGOSTRequired.Name = "gbSVGOSTRequired";
            gbSVGOSTRequired.Size = new Size(488, 330);
            gbSVGOSTRequired.TabIndex = 2;
            gbSVGOSTRequired.TabStop = false;
            gbSVGOSTRequired.Text = "Обязательные поля";
            // 
            // panelSVGOSTRequired
            // 
            panelSVGOSTRequired.AutoScroll = true;
            panelSVGOSTRequired.Controls.Add(lbSVGOSTPublishingLocationSelect);
            panelSVGOSTRequired.Controls.Add(cbSVGOSTPublisher);
            panelSVGOSTRequired.Controls.Add(buttonSVGOSTPublisher);
            panelSVGOSTRequired.Controls.Add(lbSVGOSTPublisher);
            panelSVGOSTRequired.Controls.Add(tbSVGOSTPublisher);
            panelSVGOSTRequired.Controls.Add(buttonSVGOSTPublishingLocationAdd);
            panelSVGOSTRequired.Controls.Add(lbSVGOSTPublishingLocation);
            panelSVGOSTRequired.Controls.Add(tbSVGOSTPublishingLocation);
            panelSVGOSTRequired.Controls.Add(labelSVGOSTTitle);
            panelSVGOSTRequired.Controls.Add(labelSVGOSTDocumentNumber);
            panelSVGOSTRequired.Controls.Add(tbSVGOSTPublishYear);
            panelSVGOSTRequired.Controls.Add(tbSVGOSTDocumentNumber);
            panelSVGOSTRequired.Controls.Add(labelSVGOSTPublishYear);
            panelSVGOSTRequired.Controls.Add(tbSVGOSTTitle);
            panelSVGOSTRequired.Controls.Add(labelSVGOSTPublisher);
            panelSVGOSTRequired.Controls.Add(labelSVGOSTPublishingLocation);
            panelSVGOSTRequired.Location = new Point(10, 22);
            panelSVGOSTRequired.Name = "panelSVGOSTRequired";
            panelSVGOSTRequired.Size = new Size(473, 302);
            panelSVGOSTRequired.TabIndex = 16;
            // 
            // lbSVGOSTPublishingLocationSelect
            // 
            lbSVGOSTPublishingLocationSelect.Enabled = false;
            lbSVGOSTPublishingLocationSelect.FormattingEnabled = true;
            lbSVGOSTPublishingLocationSelect.ItemHeight = 15;
            lbSVGOSTPublishingLocationSelect.Location = new Point(243, 249);
            lbSVGOSTPublishingLocationSelect.Name = "lbSVGOSTPublishingLocationSelect";
            lbSVGOSTPublishingLocationSelect.Size = new Size(207, 64);
            lbSVGOSTPublishingLocationSelect.TabIndex = 53;
            lbSVGOSTPublishingLocationSelect.TabStop = false;
            lbSVGOSTPublishingLocationSelect.SelectedIndexChanged += this.lbSVGOSTPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbSVGOSTPublisher
            // 
            cbSVGOSTPublisher.AutoSize = true;
            cbSVGOSTPublisher.Location = new Point(339, 222);
            cbSVGOSTPublisher.Name = "cbSVGOSTPublisher";
            cbSVGOSTPublisher.Size = new Size(111, 19);
            cbSVGOSTPublisher.TabIndex = 16;
            cbSVGOSTPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbSVGOSTPublisher, "Включение «умного режима» добавления издательств\r\n\r\n");
            cbSVGOSTPublisher.UseVisualStyleBackColor = true;
            cbSVGOSTPublisher.CheckedChanged += this.cbSVGOSTPublisher_CheckedChanged;
            // 
            // buttonSVGOSTPublisher
            // 
            buttonSVGOSTPublisher.Location = new Point(243, 220);
            buttonSVGOSTPublisher.Name = "buttonSVGOSTPublisher";
            buttonSVGOSTPublisher.Size = new Size(90, 23);
            buttonSVGOSTPublisher.TabIndex = 15;
            buttonSVGOSTPublisher.Text = "Добавить";
            buttonSVGOSTPublisher.UseVisualStyleBackColor = true;
            buttonSVGOSTPublisher.Click += this.buttonSVGOSTPublisher_Click;
            // 
            // lbSVGOSTPublisher
            // 
            lbSVGOSTPublisher.AllowDrop = true;
            lbSVGOSTPublisher.ContextMenuStrip = cmsListBox;
            lbSVGOSTPublisher.ItemHeight = 15;
            lbSVGOSTPublisher.Location = new Point(0, 249);
            lbSVGOSTPublisher.Name = "lbSVGOSTPublisher";
            lbSVGOSTPublisher.Size = new Size(237, 64);
            lbSVGOSTPublisher.TabIndex = 26;
            lbSVGOSTPublisher.TabStop = false;
            lbSVGOSTPublisher.DragDrop += this.ListBox_DragDrop;
            lbSVGOSTPublisher.DragOver += this.ListBox_DragOver;
            lbSVGOSTPublisher.KeyDown += this.ListBox_KeyDown;
            lbSVGOSTPublisher.MouseDown += this.ListBox_MouseDown;
            lbSVGOSTPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVGOSTPublisher
            // 
            tbSVGOSTPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTPublisher.Location = new Point(0, 220);
            tbSVGOSTPublisher.Name = "tbSVGOSTPublisher";
            tbSVGOSTPublisher.Size = new Size(237, 23);
            tbSVGOSTPublisher.TabIndex = 14;
            ttMain.SetToolTip(tbSVGOSTPublisher, resources.GetString("tbSVGOSTPublisher.ToolTip"));
            tbSVGOSTPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonSVGOSTPublishingLocationAdd
            // 
            buttonSVGOSTPublishingLocationAdd.Location = new Point(360, 106);
            buttonSVGOSTPublishingLocationAdd.Name = "buttonSVGOSTPublishingLocationAdd";
            buttonSVGOSTPublishingLocationAdd.Size = new Size(90, 23);
            buttonSVGOSTPublishingLocationAdd.TabIndex = 13;
            buttonSVGOSTPublishingLocationAdd.Text = "Добавить";
            buttonSVGOSTPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonSVGOSTPublishingLocationAdd.Click += this.buttonSVGOSTPublishingLocationAdd_Click;
            // 
            // lbSVGOSTPublishingLocation
            // 
            lbSVGOSTPublishingLocation.AllowDrop = true;
            lbSVGOSTPublishingLocation.ContextMenuStrip = cmsListBox;
            lbSVGOSTPublishingLocation.ItemHeight = 15;
            lbSVGOSTPublishingLocation.Location = new Point(0, 135);
            lbSVGOSTPublishingLocation.Name = "lbSVGOSTPublishingLocation";
            lbSVGOSTPublishingLocation.Size = new Size(450, 64);
            lbSVGOSTPublishingLocation.TabIndex = 23;
            lbSVGOSTPublishingLocation.TabStop = false;
            lbSVGOSTPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbSVGOSTPublishingLocation.DragOver += this.ListBox_DragOver;
            lbSVGOSTPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbSVGOSTPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbSVGOSTPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVGOSTPublishingLocation
            // 
            tbSVGOSTPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTPublishingLocation.Location = new Point(0, 106);
            tbSVGOSTPublishingLocation.Name = "tbSVGOSTPublishingLocation";
            tbSVGOSTPublishingLocation.Size = new Size(354, 23);
            tbSVGOSTPublishingLocation.TabIndex = 12;
            ttMain.SetToolTip(tbSVGOSTPublishingLocation, "Город, в котором было издан документ.\r\nПример: «Москва»\r\n");
            tbSVGOSTPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTTitle
            // 
            labelSVGOSTTitle.AutoSize = true;
            labelSVGOSTTitle.Location = new Point(0, 44);
            labelSVGOSTTitle.Name = "labelSVGOSTTitle";
            labelSVGOSTTitle.Size = new Size(57, 15);
            labelSVGOSTTitle.TabIndex = 4;
            labelSVGOSTTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVGOSTTitle, "Полное название документа, как указано в источнике.\r\nПример: \"Организация и проведение работ по международной стандартизации в Российской Федерации\"");
            // 
            // labelSVGOSTDocumentNumber
            // 
            labelSVGOSTDocumentNumber.AutoSize = true;
            labelSVGOSTDocumentNumber.Location = new Point(0, 0);
            labelSVGOSTDocumentNumber.Name = "labelSVGOSTDocumentNumber";
            labelSVGOSTDocumentNumber.Size = new Size(106, 15);
            labelSVGOSTDocumentNumber.TabIndex = 14;
            labelSVGOSTDocumentNumber.Text = "Номер документа";
            ttMain.SetToolTip(labelSVGOSTDocumentNumber, "Уникальный номер документа.\r\nПример: \"ГОСТ Р 57564–2017\"");
            // 
            // tbSVGOSTPublishYear
            // 
            tbSVGOSTPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTPublishYear.Location = new Point(0, 334);
            tbSVGOSTPublishYear.Name = "tbSVGOSTPublishYear";
            tbSVGOSTPublishYear.Size = new Size(450, 23);
            tbSVGOSTPublishYear.TabIndex = 17;
            ttMain.SetToolTip(tbSVGOSTPublishYear, "Год публикации документа.\r\nПример: \"2019\".\r\n\r\n\r\n");
            tbSVGOSTPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVGOSTDocumentNumber
            // 
            tbSVGOSTDocumentNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTDocumentNumber.Location = new Point(0, 18);
            tbSVGOSTDocumentNumber.Name = "tbSVGOSTDocumentNumber";
            tbSVGOSTDocumentNumber.Size = new Size(450, 23);
            tbSVGOSTDocumentNumber.TabIndex = 10;
            ttMain.SetToolTip(tbSVGOSTDocumentNumber, "Уникальный номер документа.\r\nПример: \"ГОСТ Р 57564–2017\"\r\n");
            tbSVGOSTDocumentNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTPublishYear
            // 
            labelSVGOSTPublishYear.AutoSize = true;
            labelSVGOSTPublishYear.Location = new Point(0, 316);
            labelSVGOSTPublishYear.Name = "labelSVGOSTPublishYear";
            labelSVGOSTPublishYear.Size = new Size(73, 15);
            labelSVGOSTPublishYear.TabIndex = 10;
            labelSVGOSTPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVGOSTPublishYear, "Год публикации документа.\r\nПример: \"2019\".\r\n\r\n");
            // 
            // tbSVGOSTTitle
            // 
            tbSVGOSTTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTTitle.Location = new Point(0, 62);
            tbSVGOSTTitle.Name = "tbSVGOSTTitle";
            tbSVGOSTTitle.Size = new Size(450, 23);
            tbSVGOSTTitle.TabIndex = 11;
            ttMain.SetToolTip(tbSVGOSTTitle, "Полное название документа, как указано в источнике.\r\nПример: \"Организация и проведение работ по международной стандартизации в Российской Федерации\"\r\n");
            tbSVGOSTTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTPublisher
            // 
            labelSVGOSTPublisher.AutoSize = true;
            labelSVGOSTPublisher.Location = new Point(0, 202);
            labelSVGOSTPublisher.Name = "labelSVGOSTPublisher";
            labelSVGOSTPublisher.Size = new Size(81, 15);
            labelSVGOSTPublisher.TabIndex = 8;
            labelSVGOSTPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelSVGOSTPublisher, resources.GetString("labelSVGOSTPublisher.ToolTip"));
            // 
            // labelSVGOSTPublishingLocation
            // 
            labelSVGOSTPublishingLocation.AutoSize = true;
            labelSVGOSTPublishingLocation.Location = new Point(0, 88);
            labelSVGOSTPublishingLocation.Name = "labelSVGOSTPublishingLocation";
            labelSVGOSTPublishingLocation.Size = new Size(89, 15);
            labelSVGOSTPublishingLocation.TabIndex = 6;
            labelSVGOSTPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVGOSTPublishingLocation, "Город, в котором было издан документ.\r\nПример: «Москва»");
            // 
            // gbSVGOSTOptional
            // 
            gbSVGOSTOptional.Controls.Add(panelSVGOSTOptional);
            gbSVGOSTOptional.Location = new Point(10, 346);
            gbSVGOSTOptional.Name = "gbSVGOSTOptional";
            gbSVGOSTOptional.Size = new Size(488, 330);
            gbSVGOSTOptional.TabIndex = 3;
            gbSVGOSTOptional.TabStop = false;
            gbSVGOSTOptional.Text = "Необязательные поля";
            // 
            // panelSVGOSTOptional
            // 
            panelSVGOSTOptional.AutoScroll = true;
            panelSVGOSTOptional.Controls.Add(cbGOSTFirstTime);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTAdditions);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTAdditions);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTParallelTitle);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTParallelTitle);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTDocumentType);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTContentType);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTPagesCount);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTContentType);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTPagesCount);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTDeveloper);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTDeveloper);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTDocumentType);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTImplementDate);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTApprovalDate);
            panelSVGOSTOptional.Controls.Add(labelSVGOSTImplementDate);
            panelSVGOSTOptional.Controls.Add(tbSVGOSTApprovalDate);
            panelSVGOSTOptional.Location = new Point(10, 22);
            panelSVGOSTOptional.Name = "panelSVGOSTOptional";
            panelSVGOSTOptional.Size = new Size(473, 302);
            panelSVGOSTOptional.TabIndex = 22;
            // 
            // cbGOSTFirstTime
            // 
            cbGOSTFirstTime.AutoSize = true;
            cbGOSTFirstTime.Location = new Point(336, 196);
            cbGOSTFirstTime.Name = "cbGOSTFirstTime";
            cbGOSTFirstTime.Size = new Size(114, 19);
            cbGOSTFirstTime.TabIndex = 22;
            cbGOSTFirstTime.Text = "Введен впервые";
            ttMain.SetToolTip(cbGOSTFirstTime, "Включить добавление \"введен впервые\" перед датой введения.");
            cbGOSTFirstTime.UseVisualStyleBackColor = true;
            // 
            // labelSVGOSTAdditions
            // 
            labelSVGOSTAdditions.AutoSize = true;
            labelSVGOSTAdditions.Location = new Point(0, 88);
            labelSVGOSTAdditions.Name = "labelSVGOSTAdditions";
            labelSVGOSTAdditions.Size = new Size(156, 15);
            labelSVGOSTAdditions.TabIndex = 24;
            labelSVGOSTAdditions.Text = "Дополнительные сведения";
            ttMain.SetToolTip(labelSVGOSTAdditions, "Любые уточнения об издании. \r\nПример: \"издание официальное\".");
            // 
            // tbSVGOSTAdditions
            // 
            tbSVGOSTAdditions.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTAdditions.Location = new Point(0, 106);
            tbSVGOSTAdditions.Name = "tbSVGOSTAdditions";
            tbSVGOSTAdditions.Size = new Size(450, 23);
            tbSVGOSTAdditions.TabIndex = 19;
            ttMain.SetToolTip(tbSVGOSTAdditions, "Любые уточнения об издании. \r\nПример: \"издание официальное\".\r\n");
            tbSVGOSTAdditions.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTParallelTitle
            // 
            labelSVGOSTParallelTitle.AutoSize = true;
            labelSVGOSTParallelTitle.Location = new Point(0, 0);
            labelSVGOSTParallelTitle.Name = "labelSVGOSTParallelTitle";
            labelSVGOSTParallelTitle.Size = new Size(139, 15);
            labelSVGOSTParallelTitle.TabIndex = 22;
            labelSVGOSTParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelSVGOSTParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Small craft infrastructure. General provisions\"\r\n");
            // 
            // tbSVGOSTParallelTitle
            // 
            tbSVGOSTParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTParallelTitle.Location = new Point(0, 18);
            tbSVGOSTParallelTitle.Name = "tbSVGOSTParallelTitle";
            tbSVGOSTParallelTitle.Size = new Size(450, 23);
            tbSVGOSTParallelTitle.TabIndex = 23;
            ttMain.SetToolTip(tbSVGOSTParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Small craft infrastructure. General provisions\"\r\n\r\n");
            tbSVGOSTParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTDocumentType
            // 
            labelSVGOSTDocumentType.AutoSize = true;
            labelSVGOSTDocumentType.Location = new Point(0, 44);
            labelSVGOSTDocumentType.Name = "labelSVGOSTDocumentType";
            labelSVGOSTDocumentType.Size = new Size(88, 15);
            labelSVGOSTDocumentType.TabIndex = 0;
            labelSVGOSTDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelSVGOSTDocumentType, "Уточняет вид документа.\r\nПример: \"национальный стандарт Российской Федерации\".");
            // 
            // tbSVGOSTContentType
            // 
            tbSVGOSTContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTContentType.Location = new Point(0, 326);
            tbSVGOSTContentType.Name = "tbSVGOSTContentType";
            tbSVGOSTContentType.Size = new Size(450, 23);
            tbSVGOSTContentType.TabIndex = 25;
            ttMain.SetToolTip(tbSVGOSTContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbSVGOSTContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTPagesCount
            // 
            labelSVGOSTPagesCount.AutoSize = true;
            labelSVGOSTPagesCount.Location = new Point(0, 264);
            labelSVGOSTPagesCount.Name = "labelSVGOSTPagesCount";
            labelSVGOSTPagesCount.Size = new Size(120, 15);
            labelSVGOSTPagesCount.TabIndex = 14;
            labelSVGOSTPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVGOSTPagesCount, "Объем документа в страницах.\r\nПример: \"43\" или \"350\".");
            // 
            // labelSVGOSTContentType
            // 
            labelSVGOSTContentType.AutoSize = true;
            labelSVGOSTContentType.Location = new Point(0, 308);
            labelSVGOSTContentType.Name = "labelSVGOSTContentType";
            labelSVGOSTContentType.Size = new Size(97, 15);
            labelSVGOSTContentType.TabIndex = 8;
            labelSVGOSTContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVGOSTContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbSVGOSTPagesCount
            // 
            tbSVGOSTPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTPagesCount.Location = new Point(0, 282);
            tbSVGOSTPagesCount.Name = "tbSVGOSTPagesCount";
            tbSVGOSTPagesCount.Size = new Size(450, 23);
            tbSVGOSTPagesCount.TabIndex = 24;
            ttMain.SetToolTip(tbSVGOSTPagesCount, "Объем документа в страницах.\r\nПример: \"43\" или \"350\".\r\n");
            tbSVGOSTPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVGOSTDeveloper
            // 
            tbSVGOSTDeveloper.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTDeveloper.Location = new Point(0, 238);
            tbSVGOSTDeveloper.Name = "tbSVGOSTDeveloper";
            tbSVGOSTDeveloper.Size = new Size(450, 23);
            tbSVGOSTDeveloper.TabIndex = 23;
            ttMain.SetToolTip(tbSVGOSTDeveloper, "Организация, разработавшая документ.\r\nПример: \"разработан Всероссийским научно-исследовательским институтом стандартизации и сертификации в машиностроении (ВНИИНМАШ)\".\r\n");
            tbSVGOSTDeveloper.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTDeveloper
            // 
            labelSVGOSTDeveloper.AutoSize = true;
            labelSVGOSTDeveloper.Location = new Point(0, 220);
            labelSVGOSTDeveloper.Name = "labelSVGOSTDeveloper";
            labelSVGOSTDeveloper.Size = new Size(77, 15);
            labelSVGOSTDeveloper.TabIndex = 6;
            labelSVGOSTDeveloper.Text = "Разработчик";
            ttMain.SetToolTip(labelSVGOSTDeveloper, "Организация, разработавшая документ.\r\nПример: \"разработан Всероссийским научно-исследовательским институтом стандартизации и сертификации в машиностроении (ВНИИНМАШ)\".");
            // 
            // tbSVGOSTDocumentType
            // 
            tbSVGOSTDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTDocumentType.Location = new Point(0, 62);
            tbSVGOSTDocumentType.Name = "tbSVGOSTDocumentType";
            tbSVGOSTDocumentType.Size = new Size(450, 23);
            tbSVGOSTDocumentType.TabIndex = 18;
            ttMain.SetToolTip(tbSVGOSTDocumentType, "Уточняет вид документа.\r\nПример: \"национальный стандарт Российской Федерации\".\r\n");
            tbSVGOSTDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVGOSTImplementDate
            // 
            tbSVGOSTImplementDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTImplementDate.Location = new Point(0, 194);
            tbSVGOSTImplementDate.Name = "tbSVGOSTImplementDate";
            tbSVGOSTImplementDate.Size = new Size(330, 23);
            tbSVGOSTImplementDate.TabIndex = 21;
            ttMain.SetToolTip(tbSVGOSTImplementDate, "Дата начала действия или одобрения документа.\r\nПример: \"дата введения 2017-12-01\".\r\n");
            tbSVGOSTImplementDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVGOSTApprovalDate
            // 
            labelSVGOSTApprovalDate.AutoSize = true;
            labelSVGOSTApprovalDate.Location = new Point(0, 132);
            labelSVGOSTApprovalDate.Name = "labelSVGOSTApprovalDate";
            labelSVGOSTApprovalDate.Size = new Size(163, 15);
            labelSVGOSTApprovalDate.TabIndex = 2;
            labelSVGOSTApprovalDate.Text = "Дата утверждения/принятия";
            ttMain.SetToolTip(labelSVGOSTApprovalDate, resources.GetString("labelSVGOSTApprovalDate.ToolTip"));
            // 
            // labelSVGOSTImplementDate
            // 
            labelSVGOSTImplementDate.AutoSize = true;
            labelSVGOSTImplementDate.Location = new Point(0, 176);
            labelSVGOSTImplementDate.Name = "labelSVGOSTImplementDate";
            labelSVGOSTImplementDate.Size = new Size(150, 15);
            labelSVGOSTImplementDate.TabIndex = 4;
            labelSVGOSTImplementDate.Text = "Дата введения/одобрения";
            ttMain.SetToolTip(labelSVGOSTImplementDate, "Дата начала действия или одобрения документа.\r\nПример: \"дата введения 2017-12-01\".");
            // 
            // tbSVGOSTApprovalDate
            // 
            tbSVGOSTApprovalDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVGOSTApprovalDate.Location = new Point(0, 150);
            tbSVGOSTApprovalDate.Name = "tbSVGOSTApprovalDate";
            tbSVGOSTApprovalDate.Size = new Size(450, 23);
            tbSVGOSTApprovalDate.TabIndex = 20;
            ttMain.SetToolTip(tbSVGOSTApprovalDate, resources.GetString("tbSVGOSTApprovalDate.ToolTip"));
            tbSVGOSTApprovalDate.KeyDown += this.TextBox_KeyDown;
            // 
            // tpSVLegislativeMaterial
            // 
            tpSVLegislativeMaterial.BackColor = SystemColors.Control;
            tpSVLegislativeMaterial.Controls.Add(gbSVLegislativeMaterialRequired);
            tpSVLegislativeMaterial.Controls.Add(gbSVLegislativeMaterialOptional);
            tpSVLegislativeMaterial.Location = new Point(4, 24);
            tpSVLegislativeMaterial.Name = "tpSVLegislativeMaterial";
            tpSVLegislativeMaterial.Padding = new Padding(3);
            tpSVLegislativeMaterial.Size = new Size(505, 681);
            tpSVLegislativeMaterial.TabIndex = 5;
            tpSVLegislativeMaterial.Text = "Законодательный материал";
            // 
            // gbSVLegislativeMaterialRequired
            // 
            gbSVLegislativeMaterialRequired.Controls.Add(panelSVLegislativeMaterialRequired);
            gbSVLegislativeMaterialRequired.Location = new Point(10, 10);
            gbSVLegislativeMaterialRequired.Name = "gbSVLegislativeMaterialRequired";
            gbSVLegislativeMaterialRequired.Size = new Size(488, 330);
            gbSVLegislativeMaterialRequired.TabIndex = 4;
            gbSVLegislativeMaterialRequired.TabStop = false;
            gbSVLegislativeMaterialRequired.Text = "Обязательные поля";
            // 
            // panelSVLegislativeMaterialRequired
            // 
            panelSVLegislativeMaterialRequired.AutoScroll = true;
            panelSVLegislativeMaterialRequired.Controls.Add(lbSVLMPublishingLocationSelect);
            panelSVLegislativeMaterialRequired.Controls.Add(cbSVLMPublisher);
            panelSVLegislativeMaterialRequired.Controls.Add(buttonSVLMPublisher);
            panelSVLegislativeMaterialRequired.Controls.Add(lbSVLMPublisher);
            panelSVLegislativeMaterialRequired.Controls.Add(tbSVLMPublisher);
            panelSVLegislativeMaterialRequired.Controls.Add(buttonSVLMPublishingLocationAdd);
            panelSVLegislativeMaterialRequired.Controls.Add(lbSVLMPublishingLocation);
            panelSVLegislativeMaterialRequired.Controls.Add(tbSVLMPublishingLocation);
            panelSVLegislativeMaterialRequired.Controls.Add(labelSVLMTitle);
            panelSVLegislativeMaterialRequired.Controls.Add(tbSVLMPublishYear);
            panelSVLegislativeMaterialRequired.Controls.Add(labelSVLMPublishYear);
            panelSVLegislativeMaterialRequired.Controls.Add(tbSVLMTitle);
            panelSVLegislativeMaterialRequired.Controls.Add(labelSVLMPublisher);
            panelSVLegislativeMaterialRequired.Controls.Add(labelSVLMPublishingLocation);
            panelSVLegislativeMaterialRequired.Location = new Point(10, 22);
            panelSVLegislativeMaterialRequired.Name = "panelSVLegislativeMaterialRequired";
            panelSVLegislativeMaterialRequired.Size = new Size(473, 302);
            panelSVLegislativeMaterialRequired.TabIndex = 16;
            // 
            // lbSVLMPublishingLocationSelect
            // 
            lbSVLMPublishingLocationSelect.Enabled = false;
            lbSVLMPublishingLocationSelect.FormattingEnabled = true;
            lbSVLMPublishingLocationSelect.ItemHeight = 15;
            lbSVLMPublishingLocationSelect.Location = new Point(243, 205);
            lbSVLMPublishingLocationSelect.Name = "lbSVLMPublishingLocationSelect";
            lbSVLMPublishingLocationSelect.Size = new Size(207, 64);
            lbSVLMPublishingLocationSelect.TabIndex = 55;
            lbSVLMPublishingLocationSelect.TabStop = false;
            lbSVLMPublishingLocationSelect.SelectedIndexChanged += this.lbSVLMPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbSVLMPublisher
            // 
            cbSVLMPublisher.AutoSize = true;
            cbSVLMPublisher.Location = new Point(339, 178);
            cbSVLMPublisher.Name = "cbSVLMPublisher";
            cbSVLMPublisher.Size = new Size(111, 19);
            cbSVLMPublisher.TabIndex = 15;
            cbSVLMPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbSVLMPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbSVLMPublisher.UseVisualStyleBackColor = true;
            cbSVLMPublisher.CheckedChanged += this.cbSVLMPublisher_CheckedChanged;
            // 
            // buttonSVLMPublisher
            // 
            buttonSVLMPublisher.Location = new Point(243, 176);
            buttonSVLMPublisher.Name = "buttonSVLMPublisher";
            buttonSVLMPublisher.Size = new Size(90, 23);
            buttonSVLMPublisher.TabIndex = 14;
            buttonSVLMPublisher.Text = "Добавить";
            buttonSVLMPublisher.UseVisualStyleBackColor = true;
            buttonSVLMPublisher.Click += this.buttonSVLMPublisher_Click;
            // 
            // lbSVLMPublisher
            // 
            lbSVLMPublisher.AllowDrop = true;
            lbSVLMPublisher.ContextMenuStrip = cmsListBox;
            lbSVLMPublisher.ItemHeight = 15;
            lbSVLMPublisher.Location = new Point(0, 205);
            lbSVLMPublisher.Name = "lbSVLMPublisher";
            lbSVLMPublisher.Size = new Size(237, 64);
            lbSVLMPublisher.TabIndex = 26;
            lbSVLMPublisher.TabStop = false;
            lbSVLMPublisher.DragDrop += this.ListBox_DragDrop;
            lbSVLMPublisher.DragOver += this.ListBox_DragOver;
            lbSVLMPublisher.KeyDown += this.ListBox_KeyDown;
            lbSVLMPublisher.MouseDown += this.ListBox_MouseDown;
            lbSVLMPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVLMPublisher
            // 
            tbSVLMPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMPublisher.Location = new Point(0, 176);
            tbSVLMPublisher.Name = "tbSVLMPublisher";
            tbSVLMPublisher.Size = new Size(237, 23);
            tbSVLMPublisher.TabIndex = 13;
            ttMain.SetToolTip(tbSVLMPublisher, resources.GetString("tbSVLMPublisher.ToolTip"));
            tbSVLMPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonSVLMPublishingLocationAdd
            // 
            buttonSVLMPublishingLocationAdd.Location = new Point(360, 62);
            buttonSVLMPublishingLocationAdd.Name = "buttonSVLMPublishingLocationAdd";
            buttonSVLMPublishingLocationAdd.Size = new Size(90, 23);
            buttonSVLMPublishingLocationAdd.TabIndex = 12;
            buttonSVLMPublishingLocationAdd.Text = "Добавить";
            buttonSVLMPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonSVLMPublishingLocationAdd.Click += this.buttonSVLMPublishingLocationAdd_Click;
            // 
            // lbSVLMPublishingLocation
            // 
            lbSVLMPublishingLocation.AllowDrop = true;
            lbSVLMPublishingLocation.ContextMenuStrip = cmsListBox;
            lbSVLMPublishingLocation.ItemHeight = 15;
            lbSVLMPublishingLocation.Location = new Point(0, 91);
            lbSVLMPublishingLocation.Name = "lbSVLMPublishingLocation";
            lbSVLMPublishingLocation.Size = new Size(450, 64);
            lbSVLMPublishingLocation.TabIndex = 23;
            lbSVLMPublishingLocation.TabStop = false;
            lbSVLMPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbSVLMPublishingLocation.DragOver += this.ListBox_DragOver;
            lbSVLMPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbSVLMPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbSVLMPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbSVLMPublishingLocation
            // 
            tbSVLMPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMPublishingLocation.Location = new Point(0, 62);
            tbSVLMPublishingLocation.Name = "tbSVLMPublishingLocation";
            tbSVLMPublishingLocation.Size = new Size(354, 23);
            tbSVLMPublishingLocation.TabIndex = 11;
            ttMain.SetToolTip(tbSVLMPublishingLocation, "Населённый пункт, где опубликован документ.\r\nПример: «Москва»");
            tbSVLMPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMTitle
            // 
            labelSVLMTitle.AutoSize = true;
            labelSVLMTitle.Location = new Point(0, 0);
            labelSVLMTitle.Name = "labelSVLMTitle";
            labelSVLMTitle.Size = new Size(57, 15);
            labelSVLMTitle.TabIndex = 4;
            labelSVLMTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVLMTitle, "Полное название документа, как указано в источнике.\r\nПример: \"Уголовный кодекс Российской Федерации\".");
            // 
            // tbSVLMPublishYear
            // 
            tbSVLMPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMPublishYear.Location = new Point(0, 292);
            tbSVLMPublishYear.Name = "tbSVLMPublishYear";
            tbSVLMPublishYear.Size = new Size(450, 23);
            tbSVLMPublishYear.TabIndex = 16;
            ttMain.SetToolTip(tbSVLMPublishYear, "Год публикации законодательного материала.\r\nПример: «2023»");
            tbSVLMPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMPublishYear
            // 
            labelSVLMPublishYear.AutoSize = true;
            labelSVLMPublishYear.Location = new Point(0, 272);
            labelSVLMPublishYear.Name = "labelSVLMPublishYear";
            labelSVLMPublishYear.Size = new Size(73, 15);
            labelSVLMPublishYear.TabIndex = 10;
            labelSVLMPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVLMPublishYear, "Год публикации законодательного материала.\r\nПример: «2023»");
            // 
            // tbSVLMTitle
            // 
            tbSVLMTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMTitle.Location = new Point(0, 18);
            tbSVLMTitle.Name = "tbSVLMTitle";
            tbSVLMTitle.Size = new Size(450, 23);
            tbSVLMTitle.TabIndex = 10;
            ttMain.SetToolTip(tbSVLMTitle, "Полное название документа, как указано в источнике.\r\nПример: \"Уголовный кодекс Российской Федерации\".\r\n");
            tbSVLMTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMPublisher
            // 
            labelSVLMPublisher.AutoSize = true;
            labelSVLMPublisher.Location = new Point(0, 158);
            labelSVLMPublisher.Name = "labelSVLMPublisher";
            labelSVLMPublisher.Size = new Size(81, 15);
            labelSVLMPublisher.TabIndex = 8;
            labelSVLMPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelSVLMPublisher, resources.GetString("labelSVLMPublisher.ToolTip"));
            // 
            // labelSVLMPublishingLocation
            // 
            labelSVLMPublishingLocation.AutoSize = true;
            labelSVLMPublishingLocation.Location = new Point(0, 44);
            labelSVLMPublishingLocation.Name = "labelSVLMPublishingLocation";
            labelSVLMPublishingLocation.Size = new Size(89, 15);
            labelSVLMPublishingLocation.TabIndex = 6;
            labelSVLMPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVLMPublishingLocation, "Населённый пункт, где опубликован документ.\r\nПример: «Москва»");
            // 
            // gbSVLegislativeMaterialOptional
            // 
            gbSVLegislativeMaterialOptional.Controls.Add(panelSVLegislativeMaterialOptional);
            gbSVLegislativeMaterialOptional.Location = new Point(10, 346);
            gbSVLegislativeMaterialOptional.Name = "gbSVLegislativeMaterialOptional";
            gbSVLegislativeMaterialOptional.Size = new Size(488, 330);
            gbSVLegislativeMaterialOptional.TabIndex = 5;
            gbSVLegislativeMaterialOptional.TabStop = false;
            gbSVLegislativeMaterialOptional.Text = "Необязательные поля";
            // 
            // panelSVLegislativeMaterialOptional
            // 
            panelSVLegislativeMaterialOptional.AutoScroll = true;
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMImplementDate);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMImplementDate);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMDocumentType);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMDocumentType);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMApprovalDate);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMApprovalDate);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMISBN);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMISBN);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMAbbreviation);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMAbbreviation);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMAdditions);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMContentType);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMPagesCount);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMContentType);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMPagesCount);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMSeries);
            panelSVLegislativeMaterialOptional.Controls.Add(labelSVLMSeries);
            panelSVLegislativeMaterialOptional.Controls.Add(tbSVLMAdditions);
            panelSVLegislativeMaterialOptional.Location = new Point(10, 22);
            panelSVLegislativeMaterialOptional.Name = "panelSVLegislativeMaterialOptional";
            panelSVLegislativeMaterialOptional.Size = new Size(473, 302);
            panelSVLegislativeMaterialOptional.TabIndex = 22;
            // 
            // tbSVLMImplementDate
            // 
            tbSVLMImplementDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMImplementDate.Location = new Point(0, 194);
            tbSVLMImplementDate.Name = "tbSVLMImplementDate";
            tbSVLMImplementDate.Size = new Size(450, 23);
            tbSVLMImplementDate.TabIndex = 21;
            ttMain.SetToolTip(tbSVLMImplementDate, "Когда и кем одобрен закон. \r\nПример: \"Советом Федерации 5 июня 1996 года\".\r\n");
            tbSVLMImplementDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMImplementDate
            // 
            labelSVLMImplementDate.AutoSize = true;
            labelSVLMImplementDate.Location = new Point(0, 176);
            labelSVLMImplementDate.Name = "labelSVLMImplementDate";
            labelSVLMImplementDate.Size = new Size(150, 15);
            labelSVLMImplementDate.TabIndex = 30;
            labelSVLMImplementDate.Text = "Дата введения/одобрения";
            ttMain.SetToolTip(labelSVLMImplementDate, "Когда и кем одобрен закон. \r\nПример: \"Советом Федерации 5 июня 1996 года\".");
            // 
            // labelSVLMDocumentType
            // 
            labelSVLMDocumentType.AutoSize = true;
            labelSVLMDocumentType.Location = new Point(0, 0);
            labelSVLMDocumentType.Name = "labelSVLMDocumentType";
            labelSVLMDocumentType.Size = new Size(88, 15);
            labelSVLMDocumentType.TabIndex = 28;
            labelSVLMDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelSVLMDocumentType, "Уточняет вид документа.\r\nПример: \"федеральный закон\".");
            // 
            // tbSVLMDocumentType
            // 
            tbSVLMDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMDocumentType.Location = new Point(0, 18);
            tbSVLMDocumentType.Name = "tbSVLMDocumentType";
            tbSVLMDocumentType.Size = new Size(450, 23);
            tbSVLMDocumentType.TabIndex = 17;
            ttMain.SetToolTip(tbSVLMDocumentType, "Уточняет вид документа.\r\nПример: \"федеральный закон\".\r\n");
            tbSVLMDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVLMApprovalDate
            // 
            tbSVLMApprovalDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMApprovalDate.Location = new Point(0, 150);
            tbSVLMApprovalDate.Name = "tbSVLMApprovalDate";
            tbSVLMApprovalDate.Size = new Size(450, 23);
            tbSVLMApprovalDate.TabIndex = 20;
            ttMain.SetToolTip(tbSVLMApprovalDate, "Когда и кем был принят закон.\r\nПример: \"Государственной думой 24 мая 1996 года\".\r\n\r\n");
            tbSVLMApprovalDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMApprovalDate
            // 
            labelSVLMApprovalDate.AutoSize = true;
            labelSVLMApprovalDate.Location = new Point(0, 132);
            labelSVLMApprovalDate.Name = "labelSVLMApprovalDate";
            labelSVLMApprovalDate.Size = new Size(163, 15);
            labelSVLMApprovalDate.TabIndex = 26;
            labelSVLMApprovalDate.Text = "Дата утверждения/принятия";
            ttMain.SetToolTip(labelSVLMApprovalDate, "Когда и кем был принят закон.\r\nПример: \"Государственной думой 24 мая 1996 года\".\r\n");
            // 
            // tbSVLMISBN
            // 
            tbSVLMISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMISBN.Location = new Point(0, 326);
            tbSVLMISBN.Name = "tbSVLMISBN";
            tbSVLMISBN.Size = new Size(450, 23);
            tbSVLMISBN.TabIndex = 24;
            ttMain.SetToolTip(tbSVLMISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".\r\n");
            tbSVLMISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMISBN
            // 
            labelSVLMISBN.AutoSize = true;
            labelSVLMISBN.Location = new Point(0, 308);
            labelSVLMISBN.Name = "labelSVLMISBN";
            labelSVLMISBN.Size = new Size(32, 15);
            labelSVLMISBN.TabIndex = 24;
            labelSVLMISBN.Text = "ISBN";
            ttMain.SetToolTip(labelSVLMISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".\r\n");
            // 
            // labelSVLMAbbreviation
            // 
            labelSVLMAbbreviation.AutoSize = true;
            labelSVLMAbbreviation.Location = new Point(0, 44);
            labelSVLMAbbreviation.Name = "labelSVLMAbbreviation";
            labelSVLMAbbreviation.Size = new Size(78, 15);
            labelSVLMAbbreviation.TabIndex = 22;
            labelSVLMAbbreviation.Text = "Сокращение";
            ttMain.SetToolTip(labelSVLMAbbreviation, "Аббревиатура документа.\r\nПример: \"УК\".");
            // 
            // tbSVLMAbbreviation
            // 
            tbSVLMAbbreviation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMAbbreviation.Location = new Point(0, 62);
            tbSVLMAbbreviation.Name = "tbSVLMAbbreviation";
            tbSVLMAbbreviation.Size = new Size(450, 23);
            tbSVLMAbbreviation.TabIndex = 18;
            ttMain.SetToolTip(tbSVLMAbbreviation, "Аббревиатура документа.\r\nПример: \"УК\".\r\n");
            tbSVLMAbbreviation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMAdditions
            // 
            labelSVLMAdditions.AutoSize = true;
            labelSVLMAdditions.Location = new Point(0, 88);
            labelSVLMAdditions.Name = "labelSVLMAdditions";
            labelSVLMAdditions.Size = new Size(140, 15);
            labelSVLMAdditions.TabIndex = 0;
            labelSVLMAdditions.Text = "Дополнения к заглавию";
            ttMain.SetToolTip(labelSVLMAdditions, "Любые дополнительные сведения о законе. \r\nПример: \"с изменениями на 2023 год\".");
            // 
            // tbSVLMContentType
            // 
            tbSVLMContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMContentType.Location = new Point(0, 370);
            tbSVLMContentType.Name = "tbSVLMContentType";
            tbSVLMContentType.Size = new Size(450, 23);
            tbSVLMContentType.TabIndex = 25;
            ttMain.SetToolTip(tbSVLMContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n\r\n");
            tbSVLMContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMPagesCount
            // 
            labelSVLMPagesCount.AutoSize = true;
            labelSVLMPagesCount.Location = new Point(0, 220);
            labelSVLMPagesCount.Name = "labelSVLMPagesCount";
            labelSVLMPagesCount.Size = new Size(120, 15);
            labelSVLMPagesCount.TabIndex = 14;
            labelSVLMPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVLMPagesCount, "Объем документа в страницах.\r\nПример: \"43\" или \"350\".\r\n");
            // 
            // labelSVLMContentType
            // 
            labelSVLMContentType.AutoSize = true;
            labelSVLMContentType.Location = new Point(0, 352);
            labelSVLMContentType.Name = "labelSVLMContentType";
            labelSVLMContentType.Size = new Size(97, 15);
            labelSVLMContentType.TabIndex = 8;
            labelSVLMContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVLMContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            // 
            // tbSVLMPagesCount
            // 
            tbSVLMPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMPagesCount.Location = new Point(0, 238);
            tbSVLMPagesCount.Name = "tbSVLMPagesCount";
            tbSVLMPagesCount.Size = new Size(450, 23);
            tbSVLMPagesCount.TabIndex = 22;
            ttMain.SetToolTip(tbSVLMPagesCount, "Объем документа в страницах.\r\nПример: \"43\" или \"350\".\r\n");
            tbSVLMPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVLMSeries
            // 
            tbSVLMSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMSeries.Location = new Point(0, 282);
            tbSVLMSeries.Name = "tbSVLMSeries";
            tbSVLMSeries.Size = new Size(450, 23);
            tbSVLMSeries.TabIndex = 23;
            ttMain.SetToolTip(tbSVLMSeries, "Название серии, в которой издан документ.\r\nПример: \"Профессиональное образование\".\r\n\r\n");
            tbSVLMSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVLMSeries
            // 
            labelSVLMSeries.AutoSize = true;
            labelSVLMSeries.Location = new Point(0, 264);
            labelSVLMSeries.Name = "labelSVLMSeries";
            labelSVLMSeries.Size = new Size(41, 15);
            labelSVLMSeries.TabIndex = 6;
            labelSVLMSeries.Text = "Серия";
            ttMain.SetToolTip(labelSVLMSeries, "Название серии, в которой издан документ.\r\nПример: \"Профессиональное образование\".\r\n");
            // 
            // tbSVLMAdditions
            // 
            tbSVLMAdditions.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVLMAdditions.Location = new Point(0, 106);
            tbSVLMAdditions.Name = "tbSVLMAdditions";
            tbSVLMAdditions.Size = new Size(450, 23);
            tbSVLMAdditions.TabIndex = 19;
            ttMain.SetToolTip(tbSVLMAdditions, "Любые дополнительные сведения о законе. \r\nПример: \"с изменениями на 2023 год\".\r\n");
            tbSVLMAdditions.KeyDown += this.TextBox_KeyDown;
            // 
            // tpSVDissertationAbstract
            // 
            tpSVDissertationAbstract.BackColor = SystemColors.Control;
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractRequired);
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractOptional);
            tpSVDissertationAbstract.Location = new Point(4, 24);
            tpSVDissertationAbstract.Name = "tpSVDissertationAbstract";
            tpSVDissertationAbstract.Padding = new Padding(3);
            tpSVDissertationAbstract.Size = new Size(505, 681);
            tpSVDissertationAbstract.TabIndex = 2;
            tpSVDissertationAbstract.Text = "Автореферат диссертации";
            // 
            // gbSVDissertationAbstractRequired
            // 
            gbSVDissertationAbstractRequired.Controls.Add(panelSVDissertationAbstractRequired);
            gbSVDissertationAbstractRequired.Location = new Point(10, 10);
            gbSVDissertationAbstractRequired.Name = "gbSVDissertationAbstractRequired";
            gbSVDissertationAbstractRequired.Size = new Size(488, 330);
            gbSVDissertationAbstractRequired.TabIndex = 4;
            gbSVDissertationAbstractRequired.TabStop = false;
            gbSVDissertationAbstractRequired.Text = "Обязательные поля";
            // 
            // panelSVDissertationAbstractRequired
            // 
            panelSVDissertationAbstractRequired.AutoScroll = true;
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDADefenseLocation);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAAuthor);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDADefenseLocation);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAPublishingLocation);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAPublishingLocation);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDADegree);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAPublishYear);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDADegree);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAPublishYear);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDASpecialty);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDATitle);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDASpecialty);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDATitle);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAAuthor);
            panelSVDissertationAbstractRequired.Location = new Point(10, 22);
            panelSVDissertationAbstractRequired.Name = "panelSVDissertationAbstractRequired";
            panelSVDissertationAbstractRequired.Size = new Size(472, 302);
            panelSVDissertationAbstractRequired.TabIndex = 8;
            // 
            // labelSVDADefenseLocation
            // 
            labelSVDADefenseLocation.AutoSize = true;
            labelSVDADefenseLocation.Location = new Point(0, 264);
            labelSVDADefenseLocation.Name = "labelSVDADefenseLocation";
            labelSVDADefenseLocation.Size = new Size(88, 15);
            labelSVDADefenseLocation.TabIndex = 20;
            labelSVDADefenseLocation.Text = "Место защиты";
            ttMain.SetToolTip(labelSVDADefenseLocation, "Название организации или института, где проходила защита диссертационного исследования.\r\nПример: \"Место защиты: Ин-т психологии РАН\".\r\n");
            // 
            // labelSVDAAuthor
            // 
            labelSVDAAuthor.AutoSize = true;
            labelSVDAAuthor.Location = new Point(0, 0);
            labelSVDAAuthor.Name = "labelSVDAAuthor";
            labelSVDAAuthor.Size = new Size(117, 15);
            labelSVDAAuthor.TabIndex = 4;
            labelSVDAAuthor.Text = "Автор (полное имя)";
            ttMain.SetToolTip(labelSVDAAuthor, "Фамилия, имя и отчество автора.\r\nПример: «Иванов Петр Сергеевич»\r\n");
            // 
            // tbSVDADefenseLocation
            // 
            tbSVDADefenseLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDADefenseLocation.Location = new Point(0, 282);
            tbSVDADefenseLocation.Name = "tbSVDADefenseLocation";
            tbSVDADefenseLocation.Size = new Size(450, 23);
            tbSVDADefenseLocation.TabIndex = 16;
            ttMain.SetToolTip(tbSVDADefenseLocation, "Название организации или института, где проходила защита диссертационного исследования.\r\nПример: \"Место защиты: Ин-т психологии РАН\".\r\n\r\n");
            tbSVDADefenseLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDAPublishingLocation
            // 
            tbSVDAPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAPublishingLocation.Location = new Point(0, 194);
            tbSVDAPublishingLocation.Name = "tbSVDAPublishingLocation";
            tbSVDAPublishingLocation.Size = new Size(450, 23);
            tbSVDAPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbSVDAPublishingLocation, "Город, где был издан автореферат.\r\nПример: «Москва»");
            tbSVDAPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDAPublishingLocation
            // 
            labelSVDAPublishingLocation.AutoSize = true;
            labelSVDAPublishingLocation.Location = new Point(0, 176);
            labelSVDAPublishingLocation.Name = "labelSVDAPublishingLocation";
            labelSVDAPublishingLocation.Size = new Size(89, 15);
            labelSVDAPublishingLocation.TabIndex = 10;
            labelSVDAPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVDAPublishingLocation, "Город, где был издан автореферат.\r\nПример: «Москва»");
            // 
            // tbSVDADegree
            // 
            tbSVDADegree.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDADegree.Location = new Point(0, 150);
            tbSVDADegree.Name = "tbSVDADegree";
            tbSVDADegree.Size = new Size(450, 23);
            tbSVDADegree.TabIndex = 13;
            ttMain.SetToolTip(tbSVDADegree, "Степень, на которую претендует соискатель (доктора или кандидата определенных наук).\r\nПример: \"доктора психологических наук\".\r\n\r\n");
            tbSVDADegree.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDAPublishYear
            // 
            labelSVDAPublishYear.AutoSize = true;
            labelSVDAPublishYear.Location = new Point(0, 220);
            labelSVDAPublishYear.Name = "labelSVDAPublishYear";
            labelSVDAPublishYear.Size = new Size(73, 15);
            labelSVDAPublishYear.TabIndex = 16;
            labelSVDAPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVDAPublishYear, "Год выпуска печатного автореферата.\r\nПример: «2022»");
            // 
            // labelSVDADegree
            // 
            labelSVDADegree.AutoSize = true;
            labelSVDADegree.Location = new Point(0, 132);
            labelSVDADegree.Name = "labelSVDADegree";
            labelSVDADegree.Size = new Size(92, 15);
            labelSVDADegree.TabIndex = 8;
            labelSVDADegree.Text = "Ученая степень";
            ttMain.SetToolTip(labelSVDADegree, "Степень, на которую претендует соискатель (доктора или кандидата определенных наук).\r\nПример: \"доктора психологических наук\".\r\n");
            // 
            // tbSVDAPublishYear
            // 
            tbSVDAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAPublishYear.Location = new Point(0, 238);
            tbSVDAPublishYear.Name = "tbSVDAPublishYear";
            tbSVDAPublishYear.Size = new Size(450, 23);
            tbSVDAPublishYear.TabIndex = 15;
            ttMain.SetToolTip(tbSVDAPublishYear, "Год выпуска печатного автореферата.\r\nПример: «2022»");
            tbSVDAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDASpecialty
            // 
            tbSVDASpecialty.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDASpecialty.Location = new Point(0, 106);
            tbSVDASpecialty.Name = "tbSVDASpecialty";
            tbSVDASpecialty.Size = new Size(450, 23);
            tbSVDASpecialty.TabIndex = 12;
            ttMain.SetToolTip(tbSVDASpecialty, "Код и полное название специальности, по которой выполнена диссертация.\r\nПример: \"специальность 19.00.01 «Общая психология, психология личности, история психологии»\".");
            tbSVDASpecialty.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDATitle
            // 
            labelSVDATitle.AutoSize = true;
            labelSVDATitle.Location = new Point(0, 44);
            labelSVDATitle.Name = "labelSVDATitle";
            labelSVDATitle.Size = new Size(57, 15);
            labelSVDATitle.TabIndex = 14;
            labelSVDATitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVDATitle, "Название автореферата (часто совпадает с названием диссертации). \r\nПример: \"Функциональная организация рабочей памяти\".");
            // 
            // labelSVDASpecialty
            // 
            labelSVDASpecialty.AutoSize = true;
            labelSVDASpecialty.Location = new Point(0, 88);
            labelSVDASpecialty.Name = "labelSVDASpecialty";
            labelSVDASpecialty.Size = new Size(185, 15);
            labelSVDASpecialty.TabIndex = 6;
            labelSVDASpecialty.Text = "Специальность (код и название)";
            ttMain.SetToolTip(labelSVDASpecialty, "Код и полное название специальности, по которой выполнена диссертация.\r\nПример: \"специальность 19.00.01 «Общая психология, психология личности, история психологии»\".\r\n");
            // 
            // tbSVDATitle
            // 
            tbSVDATitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDATitle.Location = new Point(0, 62);
            tbSVDATitle.Name = "tbSVDATitle";
            tbSVDATitle.Size = new Size(450, 23);
            tbSVDATitle.TabIndex = 11;
            ttMain.SetToolTip(tbSVDATitle, "Название автореферата (часто совпадает с названием диссертации). \r\nПример: \"Функциональная организация рабочей памяти\".\r\n");
            tbSVDATitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDAAuthor
            // 
            tbSVDAAuthor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAAuthor.Location = new Point(0, 18);
            tbSVDAAuthor.Name = "tbSVDAAuthor";
            tbSVDAAuthor.Size = new Size(450, 23);
            tbSVDAAuthor.TabIndex = 10;
            ttMain.SetToolTip(tbSVDAAuthor, "Фамилия, имя и отчество автора.\r\nПример: «Иванов Петр Сергеевич»\r\n");
            tbSVDAAuthor.KeyDown += this.TextBox_KeyDown;
            // 
            // gbSVDissertationAbstractOptional
            // 
            gbSVDissertationAbstractOptional.Controls.Add(panelSVDissertationAbstractOptional);
            gbSVDissertationAbstractOptional.Location = new Point(10, 346);
            gbSVDissertationAbstractOptional.Name = "gbSVDissertationAbstractOptional";
            gbSVDissertationAbstractOptional.Size = new Size(488, 330);
            gbSVDissertationAbstractOptional.TabIndex = 5;
            gbSVDissertationAbstractOptional.TabStop = false;
            gbSVDissertationAbstractOptional.Text = "Необязательные поля";
            // 
            // panelSVDissertationAbstractOptional
            // 
            panelSVDissertationAbstractOptional.Controls.Add(labelSVDAContentType);
            panelSVDissertationAbstractOptional.Controls.Add(tbSVDABibliography);
            panelSVDissertationAbstractOptional.Controls.Add(tbSVDAContentType);
            panelSVDissertationAbstractOptional.Controls.Add(labelSVDABibliography);
            panelSVDissertationAbstractOptional.Controls.Add(labelSVDAPagesCount);
            panelSVDissertationAbstractOptional.Controls.Add(tbSVDAOrganization);
            panelSVDissertationAbstractOptional.Controls.Add(tbSVDAPagesCount);
            panelSVDissertationAbstractOptional.Controls.Add(labelSVDAOrganization);
            panelSVDissertationAbstractOptional.Location = new Point(10, 22);
            panelSVDissertationAbstractOptional.Name = "panelSVDissertationAbstractOptional";
            panelSVDissertationAbstractOptional.Size = new Size(473, 302);
            panelSVDissertationAbstractOptional.TabIndex = 18;
            // 
            // labelSVDAContentType
            // 
            labelSVDAContentType.AutoSize = true;
            labelSVDAContentType.Location = new Point(0, 132);
            labelSVDAContentType.Name = "labelSVDAContentType";
            labelSVDAContentType.Size = new Size(97, 15);
            labelSVDAContentType.TabIndex = 16;
            labelSVDAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVDAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbSVDABibliography
            // 
            tbSVDABibliography.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDABibliography.Location = new Point(0, 106);
            tbSVDABibliography.Name = "tbSVDABibliography";
            tbSVDABibliography.Size = new Size(450, 23);
            tbSVDABibliography.TabIndex = 19;
            ttMain.SetToolTip(tbSVDABibliography, "Информация о наличии списка литературы в конце автореферата в формате диапазона страниц.\r\nПример: \"37-44\".\r\n\r\n");
            tbSVDABibliography.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDAContentType
            // 
            tbSVDAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAContentType.Location = new Point(0, 150);
            tbSVDAContentType.Name = "tbSVDAContentType";
            tbSVDAContentType.Size = new Size(450, 23);
            tbSVDAContentType.TabIndex = 20;
            ttMain.SetToolTip(tbSVDAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbSVDAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDABibliography
            // 
            labelSVDABibliography.AutoSize = true;
            labelSVDABibliography.Location = new Point(0, 88);
            labelSVDABibliography.Name = "labelSVDABibliography";
            labelSVDABibliography.Size = new Size(199, 15);
            labelSVDABibliography.TabIndex = 6;
            labelSVDABibliography.Text = "Библиография (диапазон страниц)";
            ttMain.SetToolTip(labelSVDABibliography, "Информация о наличии списка литературы в конце автореферата в формате диапазона страниц.\r\nПример: \"37-44\".\r\n");
            // 
            // labelSVDAPagesCount
            // 
            labelSVDAPagesCount.AutoSize = true;
            labelSVDAPagesCount.Location = new Point(0, 44);
            labelSVDAPagesCount.Name = "labelSVDAPagesCount";
            labelSVDAPagesCount.Size = new Size(120, 15);
            labelSVDAPagesCount.TabIndex = 18;
            labelSVDAPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVDAPagesCount, "Объем автореферата в страницах.\r\nПример: \"43\" или \"350\".\r\n\r\n");
            // 
            // tbSVDAOrganization
            // 
            tbSVDAOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAOrganization.Location = new Point(0, 18);
            tbSVDAOrganization.Name = "tbSVDAOrganization";
            tbSVDAOrganization.Size = new Size(450, 23);
            tbSVDAOrganization.TabIndex = 17;
            ttMain.SetToolTip(tbSVDAOrganization, "Научная или образовательная организация, где защищалась работа.\r\nПример: «НИУ ИТМО»");
            tbSVDAOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDAPagesCount
            // 
            tbSVDAPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAPagesCount.Location = new Point(0, 62);
            tbSVDAPagesCount.Name = "tbSVDAPagesCount";
            tbSVDAPagesCount.Size = new Size(450, 23);
            tbSVDAPagesCount.TabIndex = 18;
            ttMain.SetToolTip(tbSVDAPagesCount, "Объем автореферата в страницах.\r\nПример: \"43\" или \"350\".\r\n\r\n\r\n");
            tbSVDAPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDAOrganization
            // 
            labelSVDAOrganization.AutoSize = true;
            labelSVDAOrganization.Location = new Point(0, 0);
            labelSVDAOrganization.Name = "labelSVDAOrganization";
            labelSVDAOrganization.Size = new Size(79, 15);
            labelSVDAOrganization.TabIndex = 4;
            labelSVDAOrganization.Text = "Организация";
            ttMain.SetToolTip(labelSVDAOrganization, "Научная или образовательная организация, где защищалась работа.\r\nПример: «НИУ ИТМО»");
            // 
            // tpSVDissertation
            // 
            tpSVDissertation.BackColor = SystemColors.Control;
            tpSVDissertation.Controls.Add(gbSVDissertationRequired);
            tpSVDissertation.Controls.Add(gbSVDissertationOptional);
            tpSVDissertation.Location = new Point(4, 24);
            tpSVDissertation.Name = "tpSVDissertation";
            tpSVDissertation.Padding = new Padding(3);
            tpSVDissertation.Size = new Size(505, 681);
            tpSVDissertation.TabIndex = 3;
            tpSVDissertation.Text = "Диссертация";
            // 
            // gbSVDissertationRequired
            // 
            gbSVDissertationRequired.Controls.Add(panelSVDissertationRequired);
            gbSVDissertationRequired.Location = new Point(10, 10);
            gbSVDissertationRequired.Name = "gbSVDissertationRequired";
            gbSVDissertationRequired.Size = new Size(488, 330);
            gbSVDissertationRequired.TabIndex = 6;
            gbSVDissertationRequired.TabStop = false;
            gbSVDissertationRequired.Text = "Обязательные поля";
            // 
            // panelSVDissertationRequired
            // 
            panelSVDissertationRequired.AutoScroll = true;
            panelSVDissertationRequired.Controls.Add(labelSVDAuthor);
            panelSVDissertationRequired.Controls.Add(tbSVDPublishingLocation);
            panelSVDissertationRequired.Controls.Add(labelSVDPublishingLocation);
            panelSVDissertationRequired.Controls.Add(tbSVDDegree);
            panelSVDissertationRequired.Controls.Add(labelSVDPublishYear);
            panelSVDissertationRequired.Controls.Add(labelSVDDegree);
            panelSVDissertationRequired.Controls.Add(tbSVDPublishYear);
            panelSVDissertationRequired.Controls.Add(tbSVDSpecialty);
            panelSVDissertationRequired.Controls.Add(labelSVDTitle);
            panelSVDissertationRequired.Controls.Add(labelSVDSpecialty);
            panelSVDissertationRequired.Controls.Add(tbSVDTitle);
            panelSVDissertationRequired.Controls.Add(tbSVDAuthor);
            panelSVDissertationRequired.Location = new Point(10, 22);
            panelSVDissertationRequired.Name = "panelSVDissertationRequired";
            panelSVDissertationRequired.Size = new Size(472, 302);
            panelSVDissertationRequired.TabIndex = 8;
            // 
            // labelSVDAuthor
            // 
            labelSVDAuthor.AutoSize = true;
            labelSVDAuthor.Location = new Point(0, 0);
            labelSVDAuthor.Name = "labelSVDAuthor";
            labelSVDAuthor.Size = new Size(117, 15);
            labelSVDAuthor.TabIndex = 4;
            labelSVDAuthor.Text = "Автор (полное имя)";
            ttMain.SetToolTip(labelSVDAuthor, "Фамилия, имя и отчество автора.\r\nПример: «Иванов Петр Сергеевич»");
            // 
            // tbSVDPublishingLocation
            // 
            tbSVDPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDPublishingLocation.Location = new Point(0, 194);
            tbSVDPublishingLocation.Name = "tbSVDPublishingLocation";
            tbSVDPublishingLocation.Size = new Size(450, 23);
            tbSVDPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbSVDPublishingLocation, "Город, в котором была защищена или опубликована диссертация.\r\nПример: «Санкт-Петербург»");
            tbSVDPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDPublishingLocation
            // 
            labelSVDPublishingLocation.AutoSize = true;
            labelSVDPublishingLocation.Location = new Point(0, 176);
            labelSVDPublishingLocation.Name = "labelSVDPublishingLocation";
            labelSVDPublishingLocation.Size = new Size(89, 15);
            labelSVDPublishingLocation.TabIndex = 10;
            labelSVDPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVDPublishingLocation, "Город, в котором была защищена или опубликована диссертация.\r\nПример: «Санкт-Петербург»");
            // 
            // tbSVDDegree
            // 
            tbSVDDegree.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDDegree.Location = new Point(0, 150);
            tbSVDDegree.Name = "tbSVDDegree";
            tbSVDDegree.Size = new Size(450, 23);
            tbSVDDegree.TabIndex = 13;
            ttMain.SetToolTip(tbSVDDegree, "Степень, на которую претендует соискатель (доктора или кандидата определенных наук).\r\nПример: \"доктора психологических наук\".\r\n\r\n");
            tbSVDDegree.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDPublishYear
            // 
            labelSVDPublishYear.AutoSize = true;
            labelSVDPublishYear.Location = new Point(0, 220);
            labelSVDPublishYear.Name = "labelSVDPublishYear";
            labelSVDPublishYear.Size = new Size(73, 15);
            labelSVDPublishYear.TabIndex = 16;
            labelSVDPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVDPublishYear, "Год защиты или выхода печатной версии.\r\nПример: «2023»");
            // 
            // labelSVDDegree
            // 
            labelSVDDegree.AutoSize = true;
            labelSVDDegree.Location = new Point(0, 132);
            labelSVDDegree.Name = "labelSVDDegree";
            labelSVDDegree.Size = new Size(92, 15);
            labelSVDDegree.TabIndex = 8;
            labelSVDDegree.Text = "Ученая степень";
            ttMain.SetToolTip(labelSVDDegree, "Степень, на которую претендует соискатель (доктора или кандидата определенных наук).\r\nПример: \"доктора психологических наук\".\r\n\r\n");
            // 
            // tbSVDPublishYear
            // 
            tbSVDPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDPublishYear.Location = new Point(0, 238);
            tbSVDPublishYear.Name = "tbSVDPublishYear";
            tbSVDPublishYear.Size = new Size(450, 23);
            tbSVDPublishYear.TabIndex = 15;
            ttMain.SetToolTip(tbSVDPublishYear, "Год защиты или выхода печатной версии.\r\nПример: «2023»");
            tbSVDPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDSpecialty
            // 
            tbSVDSpecialty.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDSpecialty.Location = new Point(0, 106);
            tbSVDSpecialty.Name = "tbSVDSpecialty";
            tbSVDSpecialty.Size = new Size(450, 23);
            tbSVDSpecialty.TabIndex = 12;
            ttMain.SetToolTip(tbSVDSpecialty, "Код и полное название специальности, по которой выполнена диссертация.\r\nПример: \"специальность 19.00.01 «Общая психология, психология личности, история психологии»\".\r\n\r\n");
            tbSVDSpecialty.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDTitle
            // 
            labelSVDTitle.AutoSize = true;
            labelSVDTitle.Location = new Point(0, 44);
            labelSVDTitle.Name = "labelSVDTitle";
            labelSVDTitle.Size = new Size(57, 15);
            labelSVDTitle.TabIndex = 14;
            labelSVDTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVDTitle, "Полное название диссертационной работы.\r\nПример: «Методы анализа эмоциональной окраски текста в социальных сетях»");
            // 
            // labelSVDSpecialty
            // 
            labelSVDSpecialty.AutoSize = true;
            labelSVDSpecialty.Location = new Point(0, 88);
            labelSVDSpecialty.Name = "labelSVDSpecialty";
            labelSVDSpecialty.Size = new Size(185, 15);
            labelSVDSpecialty.TabIndex = 6;
            labelSVDSpecialty.Text = "Специальность (код и название)";
            ttMain.SetToolTip(labelSVDSpecialty, "Код и полное название специальности, по которой выполнена диссертация.\r\nПример: \"специальность 19.00.01 «Общая психология, психология личности, история психологии»\".\r\n\r\n");
            // 
            // tbSVDTitle
            // 
            tbSVDTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDTitle.Location = new Point(0, 62);
            tbSVDTitle.Name = "tbSVDTitle";
            tbSVDTitle.Size = new Size(450, 23);
            tbSVDTitle.TabIndex = 11;
            ttMain.SetToolTip(tbSVDTitle, "Полное название диссертационной работы.\r\nПример: «Методы анализа эмоциональной окраски текста в социальных сетях»\r\n");
            tbSVDTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDAuthor
            // 
            tbSVDAuthor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDAuthor.Location = new Point(0, 18);
            tbSVDAuthor.Name = "tbSVDAuthor";
            tbSVDAuthor.Size = new Size(450, 23);
            tbSVDAuthor.TabIndex = 10;
            ttMain.SetToolTip(tbSVDAuthor, "Фамилия, имя и отчество автора.\r\nПример: «Иванов Петр Сергеевич»");
            tbSVDAuthor.KeyDown += this.TextBox_KeyDown;
            // 
            // gbSVDissertationOptional
            // 
            gbSVDissertationOptional.Controls.Add(panelSVDissertationOptional);
            gbSVDissertationOptional.Location = new Point(10, 346);
            gbSVDissertationOptional.Name = "gbSVDissertationOptional";
            gbSVDissertationOptional.Size = new Size(488, 330);
            gbSVDissertationOptional.TabIndex = 7;
            gbSVDissertationOptional.TabStop = false;
            gbSVDissertationOptional.Text = "Необязательные поля";
            // 
            // panelSVDissertationOptional
            // 
            panelSVDissertationOptional.Controls.Add(labelSVDContentType);
            panelSVDissertationOptional.Controls.Add(tbSVDBibliography);
            panelSVDissertationOptional.Controls.Add(tbSVDContentType);
            panelSVDissertationOptional.Controls.Add(labelSVDBibliography);
            panelSVDissertationOptional.Controls.Add(labelSVDPagesCount);
            panelSVDissertationOptional.Controls.Add(tbSVDOrganization);
            panelSVDissertationOptional.Controls.Add(tbSVDPagesCount);
            panelSVDissertationOptional.Controls.Add(labelSVDOrganization);
            panelSVDissertationOptional.Location = new Point(10, 22);
            panelSVDissertationOptional.Name = "panelSVDissertationOptional";
            panelSVDissertationOptional.Size = new Size(473, 302);
            panelSVDissertationOptional.TabIndex = 18;
            // 
            // labelSVDContentType
            // 
            labelSVDContentType.AutoSize = true;
            labelSVDContentType.Location = new Point(0, 132);
            labelSVDContentType.Name = "labelSVDContentType";
            labelSVDContentType.Size = new Size(97, 15);
            labelSVDContentType.TabIndex = 16;
            labelSVDContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVDContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbSVDBibliography
            // 
            tbSVDBibliography.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDBibliography.Location = new Point(0, 106);
            tbSVDBibliography.Name = "tbSVDBibliography";
            tbSVDBibliography.Size = new Size(450, 23);
            tbSVDBibliography.TabIndex = 18;
            ttMain.SetToolTip(tbSVDBibliography, "Информация о наличии списка литературы в конце диссертации в формате диапазона страниц.\r\nПример: \"37-44\".\r\n\r\n\r\n");
            tbSVDBibliography.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDContentType
            // 
            tbSVDContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDContentType.Location = new Point(0, 150);
            tbSVDContentType.Name = "tbSVDContentType";
            tbSVDContentType.Size = new Size(450, 23);
            tbSVDContentType.TabIndex = 19;
            ttMain.SetToolTip(tbSVDContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbSVDContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDBibliography
            // 
            labelSVDBibliography.AutoSize = true;
            labelSVDBibliography.Location = new Point(0, 88);
            labelSVDBibliography.Name = "labelSVDBibliography";
            labelSVDBibliography.Size = new Size(199, 15);
            labelSVDBibliography.TabIndex = 6;
            labelSVDBibliography.Text = "Библиография (диапазон страниц)";
            ttMain.SetToolTip(labelSVDBibliography, "Информация о наличии списка литературы в конце диссертации в формате диапазона страниц.\r\nПример: \"37-44\".\r\n\r\n");
            // 
            // labelSVDPagesCount
            // 
            labelSVDPagesCount.AutoSize = true;
            labelSVDPagesCount.Location = new Point(0, 44);
            labelSVDPagesCount.Name = "labelSVDPagesCount";
            labelSVDPagesCount.Size = new Size(120, 15);
            labelSVDPagesCount.TabIndex = 18;
            labelSVDPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVDPagesCount, "Объем диссертации в страницах.\r\nПример: \"43\" или \"350\".\r\n\r\n\r\n");
            // 
            // tbSVDOrganization
            // 
            tbSVDOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDOrganization.Location = new Point(0, 18);
            tbSVDOrganization.Name = "tbSVDOrganization";
            tbSVDOrganization.Size = new Size(450, 23);
            tbSVDOrganization.TabIndex = 16;
            ttMain.SetToolTip(tbSVDOrganization, "Учреждение, в котором защищалась работа.\r\nПример: «Санкт-Петербургский политехнический университет Петра Великого»");
            tbSVDOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // tbSVDPagesCount
            // 
            tbSVDPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbSVDPagesCount.Location = new Point(0, 62);
            tbSVDPagesCount.Name = "tbSVDPagesCount";
            tbSVDPagesCount.Size = new Size(450, 23);
            tbSVDPagesCount.TabIndex = 17;
            ttMain.SetToolTip(tbSVDPagesCount, "Объем диссертации в страницах.\r\nПример: \"43\" или \"350\".\r\n\r\n\r\n\r\n");
            tbSVDPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelSVDOrganization
            // 
            labelSVDOrganization.AutoSize = true;
            labelSVDOrganization.Location = new Point(0, 0);
            labelSVDOrganization.Name = "labelSVDOrganization";
            labelSVDOrganization.Size = new Size(79, 15);
            labelSVDOrganization.TabIndex = 4;
            labelSVDOrganization.Text = "Организация";
            ttMain.SetToolTip(labelSVDOrganization, "Учреждение, в котором защищалась работа.\r\nПример: «Санкт-Петербургский политехнический университет Петра Великого»");
            // 
            // tpMultiVolume
            // 
            tpMultiVolume.BackColor = SystemColors.Control;
            tpMultiVolume.Controls.Add(tcMVTypes);
            tpMultiVolume.Location = new Point(4, 24);
            tpMultiVolume.Name = "tpMultiVolume";
            tpMultiVolume.Padding = new Padding(3);
            tpMultiVolume.Size = new Size(521, 720);
            tpMultiVolume.TabIndex = 1;
            tpMultiVolume.Text = "Многочастные (многотомные) ресурсы";
            // 
            // tcMVTypes
            // 
            tcMVTypes.Controls.Add(tpMVWholeMultivolume);
            tcMVTypes.Controls.Add(tpMVSeparateVolume);
            tcMVTypes.ImeMode = ImeMode.NoControl;
            tcMVTypes.Location = new Point(3, 6);
            tcMVTypes.Name = "tcMVTypes";
            tcMVTypes.SelectedIndex = 0;
            tcMVTypes.Size = new Size(513, 709);
            tcMVTypes.TabIndex = 1;
            tcMVTypes.TabStop = false;
            // 
            // tpMVWholeMultivolume
            // 
            tpMVWholeMultivolume.BackColor = SystemColors.Control;
            tpMVWholeMultivolume.Controls.Add(gbMVWholeMultivolumeRequired);
            tpMVWholeMultivolume.Controls.Add(gbMVWholeMultivolumeOptional);
            tpMVWholeMultivolume.Location = new Point(4, 24);
            tpMVWholeMultivolume.Name = "tpMVWholeMultivolume";
            tpMVWholeMultivolume.Padding = new Padding(3);
            tpMVWholeMultivolume.Size = new Size(505, 681);
            tpMVWholeMultivolume.TabIndex = 0;
            tpMVWholeMultivolume.Text = "Многотомное издание в целом";
            // 
            // gbMVWholeMultivolumeRequired
            // 
            gbMVWholeMultivolumeRequired.Controls.Add(panelMVWholeMultivolumeRequired);
            gbMVWholeMultivolumeRequired.Location = new Point(10, 10);
            gbMVWholeMultivolumeRequired.Name = "gbMVWholeMultivolumeRequired";
            gbMVWholeMultivolumeRequired.Size = new Size(488, 330);
            gbMVWholeMultivolumeRequired.TabIndex = 0;
            gbMVWholeMultivolumeRequired.TabStop = false;
            gbMVWholeMultivolumeRequired.Text = "Обязательные поля";
            // 
            // panelMVWholeMultivolumeRequired
            // 
            panelMVWholeMultivolumeRequired.AutoScroll = true;
            panelMVWholeMultivolumeRequired.Controls.Add(lbMVWMPublishingLocationSelect);
            panelMVWholeMultivolumeRequired.Controls.Add(cbMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(cbMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(buttonMVWMPublisherAdd);
            panelMVWholeMultivolumeRequired.Controls.Add(lbMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(buttonMVWMPublishingLocationAdd);
            panelMVWholeMultivolumeRequired.Controls.Add(lbMVWMPublishingLocation);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublishYear);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublishYear);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(buttonMVWMAuthorsAdd);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(lbMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublishingLocation);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMTitle);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublishingLocation);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMTitle);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMVolumesCount);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMVolumesCount);
            panelMVWholeMultivolumeRequired.Location = new Point(10, 22);
            panelMVWholeMultivolumeRequired.Name = "panelMVWholeMultivolumeRequired";
            panelMVWholeMultivolumeRequired.Size = new Size(473, 302);
            panelMVWholeMultivolumeRequired.TabIndex = 0;
            // 
            // lbMVWMPublishingLocationSelect
            // 
            lbMVWMPublishingLocationSelect.Enabled = false;
            lbMVWMPublishingLocationSelect.FormattingEnabled = true;
            lbMVWMPublishingLocationSelect.ItemHeight = 15;
            lbMVWMPublishingLocationSelect.Location = new Point(243, 363);
            lbMVWMPublishingLocationSelect.Name = "lbMVWMPublishingLocationSelect";
            lbMVWMPublishingLocationSelect.Size = new Size(207, 64);
            lbMVWMPublishingLocationSelect.TabIndex = 45;
            lbMVWMPublishingLocationSelect.TabStop = false;
            lbMVWMPublishingLocationSelect.SelectedIndexChanged += this.lbMVWMPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbMVWMPublisher
            // 
            cbMVWMPublisher.AutoSize = true;
            cbMVWMPublisher.Location = new Point(339, 336);
            cbMVWMPublisher.Name = "cbMVWMPublisher";
            cbMVWMPublisher.Size = new Size(111, 19);
            cbMVWMPublisher.TabIndex = 19;
            cbMVWMPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbMVWMPublisher, "Включение «умного режима» добавления издательств");
            cbMVWMPublisher.UseVisualStyleBackColor = true;
            cbMVWMPublisher.CheckedChanged += this.cbMVWMPublisher_CheckedChanged;
            // 
            // cbMVWMAuthors
            // 
            cbMVWMAuthors.AutoSize = true;
            cbMVWMAuthors.Location = new Point(371, 20);
            cbMVWMAuthors.Name = "cbMVWMAuthors";
            cbMVWMAuthors.Size = new Size(79, 19);
            cbMVWMAuthors.TabIndex = 12;
            cbMVWMAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbMVWMAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbMVWMAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonMVWMPublisherAdd
            // 
            buttonMVWMPublisherAdd.Location = new Point(243, 334);
            buttonMVWMPublisherAdd.Name = "buttonMVWMPublisherAdd";
            buttonMVWMPublisherAdd.Size = new Size(90, 23);
            buttonMVWMPublisherAdd.TabIndex = 18;
            buttonMVWMPublisherAdd.Text = "Добавить";
            buttonMVWMPublisherAdd.UseVisualStyleBackColor = true;
            buttonMVWMPublisherAdd.Click += this.buttonMVWMPublisherAdd_Click;
            // 
            // lbMVWMPublisher
            // 
            lbMVWMPublisher.AllowDrop = true;
            lbMVWMPublisher.ContextMenuStrip = cmsListBox;
            lbMVWMPublisher.ItemHeight = 15;
            lbMVWMPublisher.Location = new Point(0, 363);
            lbMVWMPublisher.Name = "lbMVWMPublisher";
            lbMVWMPublisher.Size = new Size(237, 64);
            lbMVWMPublisher.TabIndex = 19;
            lbMVWMPublisher.TabStop = false;
            lbMVWMPublisher.DragDrop += this.ListBox_DragDrop;
            lbMVWMPublisher.DragOver += this.ListBox_DragOver;
            lbMVWMPublisher.KeyDown += this.ListBox_KeyDown;
            lbMVWMPublisher.MouseDown += this.ListBox_MouseDown;
            lbMVWMPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonMVWMPublishingLocationAdd
            // 
            buttonMVWMPublishingLocationAdd.Location = new Point(360, 220);
            buttonMVWMPublishingLocationAdd.Name = "buttonMVWMPublishingLocationAdd";
            buttonMVWMPublishingLocationAdd.Size = new Size(90, 23);
            buttonMVWMPublishingLocationAdd.TabIndex = 16;
            buttonMVWMPublishingLocationAdd.Text = "Добавить";
            buttonMVWMPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonMVWMPublishingLocationAdd.Click += this.buttonMVWMPublishingLocationAdd_Click;
            // 
            // lbMVWMPublishingLocation
            // 
            lbMVWMPublishingLocation.AllowDrop = true;
            lbMVWMPublishingLocation.ContextMenuStrip = cmsListBox;
            lbMVWMPublishingLocation.ItemHeight = 15;
            lbMVWMPublishingLocation.Location = new Point(0, 249);
            lbMVWMPublishingLocation.Name = "lbMVWMPublishingLocation";
            lbMVWMPublishingLocation.Size = new Size(450, 64);
            lbMVWMPublishingLocation.TabIndex = 17;
            lbMVWMPublishingLocation.TabStop = false;
            lbMVWMPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbMVWMPublishingLocation.DragOver += this.ListBox_DragOver;
            lbMVWMPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbMVWMPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbMVWMPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // labelMVWMAuthors
            // 
            labelMVWMAuthors.AutoSize = true;
            labelMVWMAuthors.Location = new Point(0, 0);
            labelMVWMAuthors.Name = "labelMVWMAuthors";
            labelMVWMAuthors.Size = new Size(57, 15);
            labelMVWMAuthors.TabIndex = 0;
            labelMVWMAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelMVWMAuthors, resources.GetString("labelMVWMAuthors.ToolTip"));
            // 
            // tbMVWMPublishYear
            // 
            tbMVWMPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMPublishYear.Location = new Point(0, 448);
            tbMVWMPublishYear.Name = "tbMVWMPublishYear";
            tbMVWMPublishYear.Size = new Size(450, 23);
            tbMVWMPublishYear.TabIndex = 20;
            ttMain.SetToolTip(tbMVWMPublishYear, "Год выхода многотомного издания.\r\nПример: «1998»");
            tbMVWMPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMPublishYear
            // 
            labelMVWMPublishYear.AutoSize = true;
            labelMVWMPublishYear.Location = new Point(0, 430);
            labelMVWMPublishYear.Name = "labelMVWMPublishYear";
            labelMVWMPublishYear.Size = new Size(73, 15);
            labelMVWMPublishYear.TabIndex = 12;
            labelMVWMPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelMVWMPublishYear, "Год выхода многотомного издания.\r\nПример: «1998»");
            // 
            // tbMVWMAuthors
            // 
            tbMVWMAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMAuthors.Location = new Point(0, 18);
            tbMVWMAuthors.Name = "tbMVWMAuthors";
            tbMVWMAuthors.Size = new Size(269, 23);
            tbMVWMAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbMVWMAuthors, resources.GetString("tbMVWMAuthors.ToolTip"));
            tbMVWMAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVWMPublisher
            // 
            tbMVWMPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMPublisher.Location = new Point(0, 334);
            tbMVWMPublisher.Name = "tbMVWMPublisher";
            tbMVWMPublisher.Size = new Size(237, 23);
            tbMVWMPublisher.TabIndex = 17;
            ttMain.SetToolTip(tbMVWMPublisher, resources.GetString("tbMVWMPublisher.ToolTip"));
            tbMVWMPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonMVWMAuthorsAdd
            // 
            buttonMVWMAuthorsAdd.Location = new Point(275, 18);
            buttonMVWMAuthorsAdd.Name = "buttonMVWMAuthorsAdd";
            buttonMVWMAuthorsAdd.Size = new Size(90, 23);
            buttonMVWMAuthorsAdd.TabIndex = 11;
            buttonMVWMAuthorsAdd.Text = "Добавить";
            buttonMVWMAuthorsAdd.UseVisualStyleBackColor = true;
            buttonMVWMAuthorsAdd.Click += this.buttonMVWMAuthorsAdd_Click;
            // 
            // labelMVWMPublisher
            // 
            labelMVWMPublisher.AutoSize = true;
            labelMVWMPublisher.Location = new Point(0, 316);
            labelMVWMPublisher.Name = "labelMVWMPublisher";
            labelMVWMPublisher.Size = new Size(81, 15);
            labelMVWMPublisher.TabIndex = 10;
            labelMVWMPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelMVWMPublisher, resources.GetString("labelMVWMPublisher.ToolTip"));
            // 
            // lbMVWMAuthors
            // 
            lbMVWMAuthors.AllowDrop = true;
            lbMVWMAuthors.ContextMenuStrip = cmsListBox;
            lbMVWMAuthors.ItemHeight = 15;
            lbMVWMAuthors.Location = new Point(0, 47);
            lbMVWMAuthors.Name = "lbMVWMAuthors";
            lbMVWMAuthors.Size = new Size(450, 64);
            lbMVWMAuthors.TabIndex = 3;
            lbMVWMAuthors.TabStop = false;
            lbMVWMAuthors.Tag = "";
            lbMVWMAuthors.DragDrop += this.ListBox_DragDrop;
            lbMVWMAuthors.DragOver += this.ListBox_DragOver;
            lbMVWMAuthors.KeyDown += this.ListBox_KeyDown;
            lbMVWMAuthors.MouseDown += this.ListBox_MouseDown;
            lbMVWMAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbMVWMPublishingLocation
            // 
            tbMVWMPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMPublishingLocation.Location = new Point(0, 220);
            tbMVWMPublishingLocation.Name = "tbMVWMPublishingLocation";
            tbMVWMPublishingLocation.Size = new Size(354, 23);
            tbMVWMPublishingLocation.TabIndex = 15;
            ttMain.SetToolTip(tbMVWMPublishingLocation, "Город (или города), в котором было выпущено издание.\r\nПример: «Москва»");
            tbMVWMPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMTitle
            // 
            labelMVWMTitle.AutoSize = true;
            labelMVWMTitle.Location = new Point(0, 114);
            labelMVWMTitle.Name = "labelMVWMTitle";
            labelMVWMTitle.Size = new Size(57, 15);
            labelMVWMTitle.TabIndex = 4;
            labelMVWMTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelMVWMTitle, "Общее название многотомного издания.\r\nПример: «История государства Российского»");
            // 
            // labelMVWMPublishingLocation
            // 
            labelMVWMPublishingLocation.AutoSize = true;
            labelMVWMPublishingLocation.Location = new Point(0, 202);
            labelMVWMPublishingLocation.Name = "labelMVWMPublishingLocation";
            labelMVWMPublishingLocation.Size = new Size(89, 15);
            labelMVWMPublishingLocation.TabIndex = 8;
            labelMVWMPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelMVWMPublishingLocation, "Город (или города), в котором было выпущено издание.\r\nПример: «Москва»");
            // 
            // tbMVWMTitle
            // 
            tbMVWMTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMTitle.Location = new Point(0, 132);
            tbMVWMTitle.Name = "tbMVWMTitle";
            tbMVWMTitle.Size = new Size(450, 23);
            tbMVWMTitle.TabIndex = 13;
            ttMain.SetToolTip(tbMVWMTitle, "Общее название многотомного издания.\r\nПример: «История государства Российского»");
            tbMVWMTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVWMVolumesCount
            // 
            tbMVWMVolumesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMVolumesCount.Location = new Point(0, 176);
            tbMVWMVolumesCount.Name = "tbMVWMVolumesCount";
            tbMVWMVolumesCount.Size = new Size(450, 23);
            tbMVWMVolumesCount.TabIndex = 14;
            ttMain.SetToolTip(tbMVWMVolumesCount, "Общее число томов, входящих в издание.\r\nПример: «12»");
            tbMVWMVolumesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMVolumesCount
            // 
            labelMVWMVolumesCount.AutoSize = true;
            labelMVWMVolumesCount.Location = new Point(0, 158);
            labelMVWMVolumesCount.Name = "labelMVWMVolumesCount";
            labelMVWMVolumesCount.Size = new Size(109, 15);
            labelMVWMVolumesCount.TabIndex = 6;
            labelMVWMVolumesCount.Text = "Количество томов";
            ttMain.SetToolTip(labelMVWMVolumesCount, "Общее число томов, входящих в издание.\r\nПример: «12»");
            // 
            // gbMVWholeMultivolumeOptional
            // 
            gbMVWholeMultivolumeOptional.Controls.Add(panelMVWholeMultivolumeOptional);
            gbMVWholeMultivolumeOptional.Location = new Point(10, 346);
            gbMVWholeMultivolumeOptional.Name = "gbMVWholeMultivolumeOptional";
            gbMVWholeMultivolumeOptional.Size = new Size(488, 330);
            gbMVWholeMultivolumeOptional.TabIndex = 1;
            gbMVWholeMultivolumeOptional.TabStop = false;
            gbMVWholeMultivolumeOptional.Text = "Необязательные поля";
            // 
            // panelMVWholeMultivolumeOptional
            // 
            panelMVWholeMultivolumeOptional.AutoScroll = true;
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMTranslator);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMTranslator);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMOrganization);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMOrganization);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMParallelTitle);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMParallelTitle);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMContentType);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMContentType);
            panelMVWholeMultivolumeOptional.Controls.Add(cbMVWMEditorType);
            panelMVWholeMultivolumeOptional.Controls.Add(lbMVWMEditor);
            panelMVWholeMultivolumeOptional.Controls.Add(buttonMVWMEditorAdd);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMDocumentType);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMISBN);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMSeries);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMEditor);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMPagesCount);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMSeries);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMPagesCount);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMEditionNumber);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMISBN);
            panelMVWholeMultivolumeOptional.Controls.Add(tbMVWMDocumentType);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMEditionNumber);
            panelMVWholeMultivolumeOptional.Controls.Add(labelMVWMEditor);
            panelMVWholeMultivolumeOptional.Location = new Point(10, 22);
            panelMVWholeMultivolumeOptional.Name = "panelMVWholeMultivolumeOptional";
            panelMVWholeMultivolumeOptional.Size = new Size(473, 302);
            panelMVWholeMultivolumeOptional.TabIndex = 12;
            // 
            // labelMVWMTranslator
            // 
            labelMVWMTranslator.AutoSize = true;
            labelMVWMTranslator.Location = new Point(0, 290);
            labelMVWMTranslator.Name = "labelMVWMTranslator";
            labelMVWMTranslator.Size = new Size(74, 15);
            labelMVWMTranslator.TabIndex = 35;
            labelMVWMTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelMVWMTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // tbMVWMTranslator
            // 
            tbMVWMTranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMTranslator.Location = new Point(0, 308);
            tbMVWMTranslator.Name = "tbMVWMTranslator";
            tbMVWMTranslator.Size = new Size(450, 23);
            tbMVWMTranslator.TabIndex = 28;
            ttMain.SetToolTip(tbMVWMTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            tbMVWMTranslator.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMOrganization
            // 
            labelMVWMOrganization.AutoSize = true;
            labelMVWMOrganization.Location = new Point(0, 202);
            labelMVWMOrganization.Name = "labelMVWMOrganization";
            labelMVWMOrganization.Size = new Size(79, 15);
            labelMVWMOrganization.TabIndex = 33;
            labelMVWMOrganization.Text = "Организация";
            ttMain.SetToolTip(labelMVWMOrganization, "Организация, ответственная за публикацию.\r\nПример: «Российская академия наук»");
            // 
            // tbMVWMOrganization
            // 
            tbMVWMOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMOrganization.Location = new Point(0, 220);
            tbMVWMOrganization.Name = "tbMVWMOrganization";
            tbMVWMOrganization.Size = new Size(450, 23);
            tbMVWMOrganization.TabIndex = 26;
            ttMain.SetToolTip(tbMVWMOrganization, "Организация, ответственная за публикацию.\r\nПример: «Российская академия наук»");
            tbMVWMOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMParallelTitle
            // 
            labelMVWMParallelTitle.AutoSize = true;
            labelMVWMParallelTitle.Location = new Point(0, 0);
            labelMVWMParallelTitle.Name = "labelMVWMParallelTitle";
            labelMVWMParallelTitle.Size = new Size(139, 15);
            labelMVWMParallelTitle.TabIndex = 31;
            labelMVWMParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelMVWMParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbMVWMParallelTitle
            // 
            tbMVWMParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMParallelTitle.Location = new Point(0, 18);
            tbMVWMParallelTitle.Name = "tbMVWMParallelTitle";
            tbMVWMParallelTitle.Size = new Size(450, 23);
            tbMVWMParallelTitle.TabIndex = 21;
            ttMain.SetToolTip(tbMVWMParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbMVWMParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMContentType
            // 
            labelMVWMContentType.AutoSize = true;
            labelMVWMContentType.Location = new Point(0, 466);
            labelMVWMContentType.Name = "labelMVWMContentType";
            labelMVWMContentType.Size = new Size(97, 15);
            labelMVWMContentType.TabIndex = 24;
            labelMVWMContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelMVWMContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            // 
            // tbMVWMContentType
            // 
            tbMVWMContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMContentType.Location = new Point(0, 484);
            tbMVWMContentType.Name = "tbMVWMContentType";
            tbMVWMContentType.Size = new Size(450, 23);
            tbMVWMContentType.TabIndex = 32;
            ttMain.SetToolTip(tbMVWMContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbMVWMContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // cbMVWMEditorType
            // 
            cbMVWMEditorType.BackColor = SystemColors.Window;
            cbMVWMEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMVWMEditorType.FormattingEnabled = true;
            cbMVWMEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbMVWMEditorType.Location = new Point(194, 106);
            cbMVWMEditorType.Name = "cbMVWMEditorType";
            cbMVWMEditorType.Size = new Size(160, 23);
            cbMVWMEditorType.TabIndex = 24;
            // 
            // lbMVWMEditor
            // 
            lbMVWMEditor.AllowDrop = true;
            lbMVWMEditor.ContextMenuStrip = cmsListBox;
            lbMVWMEditor.ItemHeight = 15;
            lbMVWMEditor.Location = new Point(0, 135);
            lbMVWMEditor.Name = "lbMVWMEditor";
            lbMVWMEditor.Size = new Size(450, 64);
            lbMVWMEditor.TabIndex = 22;
            lbMVWMEditor.TabStop = false;
            lbMVWMEditor.DragDrop += this.ListBox_DragDrop;
            lbMVWMEditor.DragOver += this.ListBox_DragOver;
            lbMVWMEditor.KeyDown += this.ListBox_KeyDown;
            lbMVWMEditor.MouseDown += this.ListBox_MouseDown;
            lbMVWMEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonMVWMEditorAdd
            // 
            buttonMVWMEditorAdd.Location = new Point(360, 106);
            buttonMVWMEditorAdd.Name = "buttonMVWMEditorAdd";
            buttonMVWMEditorAdd.Size = new Size(90, 23);
            buttonMVWMEditorAdd.TabIndex = 25;
            buttonMVWMEditorAdd.Text = "Добавить";
            buttonMVWMEditorAdd.UseVisualStyleBackColor = true;
            buttonMVWMEditorAdd.Click += this.buttonMVWMEditorAdd_Click;
            // 
            // labelMVWMDocumentType
            // 
            labelMVWMDocumentType.AutoSize = true;
            labelMVWMDocumentType.Location = new Point(0, 44);
            labelMVWMDocumentType.Name = "labelMVWMDocumentType";
            labelMVWMDocumentType.Size = new Size(88, 15);
            labelMVWMDocumentType.TabIndex = 0;
            labelMVWMDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelMVWMDocumentType, "Уточнение типа издания: монография, сборник и т. д.\r\nПример: «монография»");
            // 
            // tbMVWMISBN
            // 
            tbMVWMISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMISBN.Location = new Point(0, 440);
            tbMVWMISBN.Name = "tbMVWMISBN";
            tbMVWMISBN.Size = new Size(450, 23);
            tbMVWMISBN.TabIndex = 31;
            ttMain.SetToolTip(tbMVWMISBN, "Международный стандартный номер книги.\r\nПример: «978-5-17-123456-0»");
            tbMVWMISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMSeries
            // 
            labelMVWMSeries.AutoSize = true;
            labelMVWMSeries.Location = new Point(0, 378);
            labelMVWMSeries.Name = "labelMVWMSeries";
            labelMVWMSeries.Size = new Size(41, 15);
            labelMVWMSeries.TabIndex = 8;
            labelMVWMSeries.Text = "Серия";
            ttMain.SetToolTip(labelMVWMSeries, "Название серии, в которой выпущено издание.\r\nПример: «Университетская библиотека»");
            // 
            // tbMVWMEditor
            // 
            tbMVWMEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMEditor.Location = new Point(0, 106);
            tbMVWMEditor.Name = "tbMVWMEditor";
            tbMVWMEditor.Size = new Size(188, 23);
            tbMVWMEditor.TabIndex = 23;
            ttMain.SetToolTip(tbMVWMEditor, resources.GetString("tbMVWMEditor.ToolTip"));
            tbMVWMEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMPagesCount
            // 
            labelMVWMPagesCount.AutoSize = true;
            labelMVWMPagesCount.Location = new Point(0, 334);
            labelMVWMPagesCount.Name = "labelMVWMPagesCount";
            labelMVWMPagesCount.Size = new Size(120, 15);
            labelMVWMPagesCount.TabIndex = 14;
            labelMVWMPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelMVWMPagesCount, "Общее количество страниц в издании.\r\nПример: «1234»");
            // 
            // tbMVWMSeries
            // 
            tbMVWMSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMSeries.Location = new Point(0, 396);
            tbMVWMSeries.Name = "tbMVWMSeries";
            tbMVWMSeries.Size = new Size(450, 23);
            tbMVWMSeries.TabIndex = 30;
            ttMain.SetToolTip(tbMVWMSeries, "Название серии, в которой выпущено издание.\r\nПример: «Университетская библиотека»");
            tbMVWMSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVWMPagesCount
            // 
            tbMVWMPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMPagesCount.Location = new Point(0, 352);
            tbMVWMPagesCount.Name = "tbMVWMPagesCount";
            tbMVWMPagesCount.Size = new Size(450, 23);
            tbMVWMPagesCount.TabIndex = 29;
            ttMain.SetToolTip(tbMVWMPagesCount, "Общее количество страниц в издании.\r\nПример: «1234»\r\n");
            tbMVWMPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVWMEditionNumber
            // 
            tbMVWMEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMEditionNumber.Location = new Point(0, 264);
            tbMVWMEditionNumber.Name = "tbMVWMEditionNumber";
            tbMVWMEditionNumber.Size = new Size(450, 23);
            tbMVWMEditionNumber.TabIndex = 27;
            ttMain.SetToolTip(tbMVWMEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            tbMVWMEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMISBN
            // 
            labelMVWMISBN.AutoSize = true;
            labelMVWMISBN.Location = new Point(0, 422);
            labelMVWMISBN.Name = "labelMVWMISBN";
            labelMVWMISBN.Size = new Size(32, 15);
            labelMVWMISBN.TabIndex = 10;
            labelMVWMISBN.Text = "ISBN";
            ttMain.SetToolTip(labelMVWMISBN, "Международный стандартный номер книги.\r\nПример: «978-5-17-123456-0»");
            // 
            // tbMVWMDocumentType
            // 
            tbMVWMDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVWMDocumentType.Location = new Point(0, 62);
            tbMVWMDocumentType.Name = "tbMVWMDocumentType";
            tbMVWMDocumentType.Size = new Size(450, 23);
            tbMVWMDocumentType.TabIndex = 22;
            ttMain.SetToolTip(tbMVWMDocumentType, "Уточнение типа издания: монография, сборник и т. д.\r\nПример: «монография»");
            tbMVWMDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVWMEditionNumber
            // 
            labelMVWMEditionNumber.AutoSize = true;
            labelMVWMEditionNumber.Location = new Point(0, 246);
            labelMVWMEditionNumber.Name = "labelMVWMEditionNumber";
            labelMVWMEditionNumber.Size = new Size(92, 15);
            labelMVWMEditionNumber.TabIndex = 6;
            labelMVWMEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelMVWMEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            // 
            // labelMVWMEditor
            // 
            labelMVWMEditor.AutoSize = true;
            labelMVWMEditor.Location = new Point(0, 88);
            labelMVWMEditor.Name = "labelMVWMEditor";
            labelMVWMEditor.Size = new Size(74, 15);
            labelMVWMEditor.TabIndex = 4;
            labelMVWMEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelMVWMEditor, resources.GetString("labelMVWMEditor.ToolTip"));
            // 
            // tpMVSeparateVolume
            // 
            tpMVSeparateVolume.BackColor = SystemColors.Control;
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeRequired);
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeOptional);
            tpMVSeparateVolume.Location = new Point(4, 24);
            tpMVSeparateVolume.Name = "tpMVSeparateVolume";
            tpMVSeparateVolume.Padding = new Padding(3);
            tpMVSeparateVolume.Size = new Size(505, 681);
            tpMVSeparateVolume.TabIndex = 1;
            tpMVSeparateVolume.Text = "Отдельный том";
            // 
            // gbMVSeparateVolumeRequired
            // 
            gbMVSeparateVolumeRequired.Controls.Add(panelMVSeparateVolumeRequired);
            gbMVSeparateVolumeRequired.Location = new Point(10, 10);
            gbMVSeparateVolumeRequired.Name = "gbMVSeparateVolumeRequired";
            gbMVSeparateVolumeRequired.Size = new Size(488, 330);
            gbMVSeparateVolumeRequired.TabIndex = 2;
            gbMVSeparateVolumeRequired.TabStop = false;
            gbMVSeparateVolumeRequired.Text = "Обязательные поля";
            // 
            // panelMVSeparateVolumeRequired
            // 
            panelMVSeparateVolumeRequired.AutoScroll = true;
            panelMVSeparateVolumeRequired.Controls.Add(lbMVSVPublishingLocationSelect);
            panelMVSeparateVolumeRequired.Controls.Add(cbMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(cbMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(buttonMVSVPublisherAdd);
            panelMVSeparateVolumeRequired.Controls.Add(lbMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(buttonMVSVPublishingLocationAdd);
            panelMVSeparateVolumeRequired.Controls.Add(lbMVSVPublishingLocation);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublishingLocation);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublishYear);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublishingLocation);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublishYear);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVVolumeNumber);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVVolumeNumber);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVVolumesCount);
            panelMVSeparateVolumeRequired.Controls.Add(buttonMVSVAuthorsAdd);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVVolumesCount);
            panelMVSeparateVolumeRequired.Controls.Add(lbMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVTitle);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVTitle);
            panelMVSeparateVolumeRequired.Location = new Point(10, 22);
            panelMVSeparateVolumeRequired.Name = "panelMVSeparateVolumeRequired";
            panelMVSeparateVolumeRequired.Size = new Size(473, 302);
            panelMVSeparateVolumeRequired.TabIndex = 0;
            // 
            // lbMVSVPublishingLocationSelect
            // 
            lbMVSVPublishingLocationSelect.Enabled = false;
            lbMVSVPublishingLocationSelect.FormattingEnabled = true;
            lbMVSVPublishingLocationSelect.ItemHeight = 15;
            lbMVSVPublishingLocationSelect.Location = new Point(243, 407);
            lbMVSVPublishingLocationSelect.Name = "lbMVSVPublishingLocationSelect";
            lbMVSVPublishingLocationSelect.Size = new Size(207, 64);
            lbMVSVPublishingLocationSelect.TabIndex = 47;
            lbMVSVPublishingLocationSelect.TabStop = false;
            lbMVSVPublishingLocationSelect.SelectedIndexChanged += this.lbMVSVPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbMVSVPublisher
            // 
            cbMVSVPublisher.AutoSize = true;
            cbMVSVPublisher.Location = new Point(339, 380);
            cbMVSVPublisher.Name = "cbMVSVPublisher";
            cbMVSVPublisher.Size = new Size(111, 19);
            cbMVSVPublisher.TabIndex = 20;
            cbMVSVPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbMVSVPublisher, "Включение «умного режима» добавления издательств\r\n\r\n");
            cbMVSVPublisher.UseVisualStyleBackColor = true;
            cbMVSVPublisher.CheckedChanged += this.cbMVSVPublisher_CheckedChanged;
            // 
            // cbMVSVAuthors
            // 
            cbMVSVAuthors.AutoSize = true;
            cbMVSVAuthors.Location = new Point(371, 20);
            cbMVSVAuthors.Name = "cbMVSVAuthors";
            cbMVSVAuthors.Size = new Size(79, 19);
            cbMVSVAuthors.TabIndex = 12;
            cbMVSVAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbMVSVAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbMVSVAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonMVSVPublisherAdd
            // 
            buttonMVSVPublisherAdd.Location = new Point(243, 378);
            buttonMVSVPublisherAdd.Name = "buttonMVSVPublisherAdd";
            buttonMVSVPublisherAdd.Size = new Size(90, 23);
            buttonMVSVPublisherAdd.TabIndex = 19;
            buttonMVSVPublisherAdd.Text = "Добавить";
            buttonMVSVPublisherAdd.UseVisualStyleBackColor = true;
            buttonMVSVPublisherAdd.Click += this.buttonMVSVPublisherAdd_Click;
            // 
            // lbMVSVPublisher
            // 
            lbMVSVPublisher.AllowDrop = true;
            lbMVSVPublisher.ContextMenuStrip = cmsListBox;
            lbMVSVPublisher.ItemHeight = 15;
            lbMVSVPublisher.Location = new Point(0, 407);
            lbMVSVPublisher.Name = "lbMVSVPublisher";
            lbMVSVPublisher.Size = new Size(237, 64);
            lbMVSVPublisher.TabIndex = 23;
            lbMVSVPublisher.TabStop = false;
            lbMVSVPublisher.DragDrop += this.ListBox_DragDrop;
            lbMVSVPublisher.DragOver += this.ListBox_DragOver;
            lbMVSVPublisher.KeyDown += this.ListBox_KeyDown;
            lbMVSVPublisher.MouseDown += this.ListBox_MouseDown;
            lbMVSVPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonMVSVPublishingLocationAdd
            // 
            buttonMVSVPublishingLocationAdd.Location = new Point(360, 264);
            buttonMVSVPublishingLocationAdd.Name = "buttonMVSVPublishingLocationAdd";
            buttonMVSVPublishingLocationAdd.Size = new Size(90, 23);
            buttonMVSVPublishingLocationAdd.TabIndex = 17;
            buttonMVSVPublishingLocationAdd.Text = "Добавить";
            buttonMVSVPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonMVSVPublishingLocationAdd.Click += this.buttonMVSVPublishingLocationAdd_Click;
            // 
            // lbMVSVPublishingLocation
            // 
            lbMVSVPublishingLocation.AllowDrop = true;
            lbMVSVPublishingLocation.ContextMenuStrip = cmsListBox;
            lbMVSVPublishingLocation.ItemHeight = 15;
            lbMVSVPublishingLocation.Location = new Point(0, 293);
            lbMVSVPublishingLocation.Name = "lbMVSVPublishingLocation";
            lbMVSVPublishingLocation.Size = new Size(450, 64);
            lbMVSVPublishingLocation.TabIndex = 21;
            lbMVSVPublishingLocation.TabStop = false;
            lbMVSVPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbMVSVPublishingLocation.DragOver += this.ListBox_DragOver;
            lbMVSVPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbMVSVPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbMVSVPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // labelMVSVAuthors
            // 
            labelMVSVAuthors.AutoSize = true;
            labelMVSVAuthors.Location = new Point(0, 0);
            labelMVSVAuthors.Name = "labelMVSVAuthors";
            labelMVSVAuthors.Size = new Size(57, 15);
            labelMVSVAuthors.TabIndex = 0;
            labelMVSVAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelMVSVAuthors, resources.GetString("labelMVSVAuthors.ToolTip"));
            // 
            // tbMVSVPublishingLocation
            // 
            tbMVSVPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVPublishingLocation.Location = new Point(0, 264);
            tbMVSVPublishingLocation.Name = "tbMVSVPublishingLocation";
            tbMVSVPublishingLocation.Size = new Size(354, 23);
            tbMVSVPublishingLocation.TabIndex = 16;
            ttMain.SetToolTip(tbMVSVPublishingLocation, "Город или города, где был издан том.\r\nПример: «Санкт-Петербург»");
            tbMVSVPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVPublishYear
            // 
            labelMVSVPublishYear.AutoSize = true;
            labelMVSVPublishYear.Location = new Point(0, 474);
            labelMVSVPublishYear.Name = "labelMVSVPublishYear";
            labelMVSVPublishYear.Size = new Size(73, 15);
            labelMVSVPublishYear.TabIndex = 16;
            labelMVSVPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelMVSVPublishYear, "Год публикации тома.\r\nПример: «2020»");
            // 
            // labelMVSVPublishingLocation
            // 
            labelMVSVPublishingLocation.AutoSize = true;
            labelMVSVPublishingLocation.Location = new Point(0, 246);
            labelMVSVPublishingLocation.Name = "labelMVSVPublishingLocation";
            labelMVSVPublishingLocation.Size = new Size(89, 15);
            labelMVSVPublishingLocation.TabIndex = 12;
            labelMVSVPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelMVSVPublishingLocation, "Город или города, где был издан том.\r\nПример: «Санкт-Петербург»");
            // 
            // tbMVSVPublishYear
            // 
            tbMVSVPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVPublishYear.Location = new Point(0, 492);
            tbMVSVPublishYear.Name = "tbMVSVPublishYear";
            tbMVSVPublishYear.Size = new Size(450, 23);
            tbMVSVPublishYear.TabIndex = 21;
            ttMain.SetToolTip(tbMVSVPublishYear, "Год публикации тома.\r\nПример: «2020»");
            tbMVSVPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVPublisher
            // 
            labelMVSVPublisher.AutoSize = true;
            labelMVSVPublisher.Location = new Point(0, 360);
            labelMVSVPublisher.Name = "labelMVSVPublisher";
            labelMVSVPublisher.Size = new Size(81, 15);
            labelMVSVPublisher.TabIndex = 14;
            labelMVSVPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelMVSVPublisher, resources.GetString("labelMVSVPublisher.ToolTip"));
            // 
            // tbMVSVPublisher
            // 
            tbMVSVPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVPublisher.Location = new Point(0, 378);
            tbMVSVPublisher.Name = "tbMVSVPublisher";
            tbMVSVPublisher.Size = new Size(237, 23);
            tbMVSVPublisher.TabIndex = 18;
            ttMain.SetToolTip(tbMVSVPublisher, resources.GetString("tbMVSVPublisher.ToolTip"));
            tbMVSVPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVVolumeNumber
            // 
            tbMVSVVolumeNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVVolumeNumber.Location = new Point(0, 220);
            tbMVSVVolumeNumber.Name = "tbMVSVVolumeNumber";
            tbMVSVVolumeNumber.Size = new Size(450, 23);
            tbMVSVVolumeNumber.TabIndex = 15;
            ttMain.SetToolTip(tbMVSVVolumeNumber, "Порядковый номер данного тома.\r\nПример: «3»");
            tbMVSVVolumeNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVVolumeNumber
            // 
            labelMVSVVolumeNumber.AutoSize = true;
            labelMVSVVolumeNumber.Location = new Point(0, 202);
            labelMVSVVolumeNumber.Name = "labelMVSVVolumeNumber";
            labelMVSVVolumeNumber.Size = new Size(75, 15);
            labelMVSVVolumeNumber.TabIndex = 8;
            labelMVSVVolumeNumber.Text = "Номер тома";
            ttMain.SetToolTip(labelMVSVVolumeNumber, "Порядковый номер данного тома.\r\nПример: «3»");
            // 
            // tbMVSVAuthors
            // 
            tbMVSVAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVAuthors.Location = new Point(0, 18);
            tbMVSVAuthors.Name = "tbMVSVAuthors";
            tbMVSVAuthors.Size = new Size(269, 23);
            tbMVSVAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbMVSVAuthors, resources.GetString("tbMVSVAuthors.ToolTip"));
            tbMVSVAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVVolumesCount
            // 
            tbMVSVVolumesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVVolumesCount.Location = new Point(0, 176);
            tbMVSVVolumesCount.Name = "tbMVSVVolumesCount";
            tbMVSVVolumesCount.Size = new Size(450, 23);
            tbMVSVVolumesCount.TabIndex = 14;
            ttMain.SetToolTip(tbMVSVVolumesCount, "Общее количество томов в издании.\r\nПример: «5»\r\n");
            tbMVSVVolumesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonMVSVAuthorsAdd
            // 
            buttonMVSVAuthorsAdd.Location = new Point(275, 18);
            buttonMVSVAuthorsAdd.Name = "buttonMVSVAuthorsAdd";
            buttonMVSVAuthorsAdd.Size = new Size(90, 23);
            buttonMVSVAuthorsAdd.TabIndex = 11;
            buttonMVSVAuthorsAdd.Text = "Добавить";
            buttonMVSVAuthorsAdd.UseVisualStyleBackColor = true;
            buttonMVSVAuthorsAdd.Click += this.buttonMVSVAuthorsAdd_Click;
            // 
            // labelMVSVVolumesCount
            // 
            labelMVSVVolumesCount.AutoSize = true;
            labelMVSVVolumesCount.Location = new Point(0, 158);
            labelMVSVVolumesCount.Name = "labelMVSVVolumesCount";
            labelMVSVVolumesCount.Size = new Size(109, 15);
            labelMVSVVolumesCount.TabIndex = 6;
            labelMVSVVolumesCount.Text = "Количество томов";
            ttMain.SetToolTip(labelMVSVVolumesCount, "Общее количество томов в издании.\r\nПример: «5»");
            // 
            // lbMVSVAuthors
            // 
            lbMVSVAuthors.AllowDrop = true;
            lbMVSVAuthors.ContextMenuStrip = cmsListBox;
            lbMVSVAuthors.ItemHeight = 15;
            lbMVSVAuthors.Location = new Point(0, 47);
            lbMVSVAuthors.Name = "lbMVSVAuthors";
            lbMVSVAuthors.Size = new Size(450, 64);
            lbMVSVAuthors.TabIndex = 3;
            lbMVSVAuthors.TabStop = false;
            lbMVSVAuthors.Tag = "";
            lbMVSVAuthors.DragDrop += this.ListBox_DragDrop;
            lbMVSVAuthors.DragOver += this.ListBox_DragOver;
            lbMVSVAuthors.KeyDown += this.ListBox_KeyDown;
            lbMVSVAuthors.MouseDown += this.ListBox_MouseDown;
            lbMVSVAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbMVSVTitle
            // 
            tbMVSVTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVTitle.Location = new Point(0, 132);
            tbMVSVTitle.Name = "tbMVSVTitle";
            tbMVSVTitle.Size = new Size(450, 23);
            tbMVSVTitle.TabIndex = 13;
            ttMain.SetToolTip(tbMVSVTitle, "Общее название многотомного издания.\r\nПример: «История России»");
            tbMVSVTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVTitle
            // 
            labelMVSVTitle.AutoSize = true;
            labelMVSVTitle.Location = new Point(0, 114);
            labelMVSVTitle.Name = "labelMVSVTitle";
            labelMVSVTitle.Size = new Size(57, 15);
            labelMVSVTitle.TabIndex = 4;
            labelMVSVTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelMVSVTitle, "Общее название многотомного издания.\r\nПример: «История России»");
            // 
            // gbMVSeparateVolumeOptional
            // 
            gbMVSeparateVolumeOptional.Controls.Add(panelMVSeparateVolumeOptional);
            gbMVSeparateVolumeOptional.Location = new Point(10, 346);
            gbMVSeparateVolumeOptional.Name = "gbMVSeparateVolumeOptional";
            gbMVSeparateVolumeOptional.Size = new Size(488, 330);
            gbMVSeparateVolumeOptional.TabIndex = 3;
            gbMVSeparateVolumeOptional.TabStop = false;
            gbMVSeparateVolumeOptional.Text = "Необязательные поля";
            // 
            // panelMVSeparateVolumeOptional
            // 
            panelMVSeparateVolumeOptional.AutoScroll = true;
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVTranslator);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVTranslator);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVOrganization);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVOrganization);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVParallelTitle);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVParallelTitle);
            panelMVSeparateVolumeOptional.Controls.Add(cbMVSVEditorType);
            panelMVSeparateVolumeOptional.Controls.Add(lbMVSVEditor);
            panelMVSeparateVolumeOptional.Controls.Add(buttonMVSVEditorAdd);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVContentType);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVVolumeTitle);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVContentType);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVDocumentType);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVVolumeTitle);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVEditor);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVDocumentType);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVISBN);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVPagesCount);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVSeries);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVPagesCount);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVEditionNumber);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVSeries);
            panelMVSeparateVolumeOptional.Controls.Add(labelMVSVEditor);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVEditionNumber);
            panelMVSeparateVolumeOptional.Controls.Add(tbMVSVISBN);
            panelMVSeparateVolumeOptional.Location = new Point(10, 22);
            panelMVSeparateVolumeOptional.Name = "panelMVSeparateVolumeOptional";
            panelMVSeparateVolumeOptional.Size = new Size(473, 302);
            panelMVSeparateVolumeOptional.TabIndex = 12;
            // 
            // labelMVSVTranslator
            // 
            labelMVSVTranslator.AutoSize = true;
            labelMVSVTranslator.Location = new Point(0, 334);
            labelMVSVTranslator.Name = "labelMVSVTranslator";
            labelMVSVTranslator.Size = new Size(74, 15);
            labelMVSVTranslator.TabIndex = 37;
            labelMVSVTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelMVSVTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // tbMVSVTranslator
            // 
            tbMVSVTranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVTranslator.Location = new Point(0, 352);
            tbMVSVTranslator.Name = "tbMVSVTranslator";
            tbMVSVTranslator.Size = new Size(450, 23);
            tbMVSVTranslator.TabIndex = 30;
            ttMain.SetToolTip(tbMVSVTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            tbMVSVTranslator.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVOrganization
            // 
            labelMVSVOrganization.AutoSize = true;
            labelMVSVOrganization.Location = new Point(0, 246);
            labelMVSVOrganization.Name = "labelMVSVOrganization";
            labelMVSVOrganization.Size = new Size(79, 15);
            labelMVSVOrganization.TabIndex = 35;
            labelMVSVOrganization.Text = "Организация";
            ttMain.SetToolTip(labelMVSVOrganization, "Учреждение, ответственное за издание.\r\nПример: «Российская академия наук»");
            // 
            // tbMVSVOrganization
            // 
            tbMVSVOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVOrganization.Location = new Point(0, 264);
            tbMVSVOrganization.Name = "tbMVSVOrganization";
            tbMVSVOrganization.Size = new Size(450, 23);
            tbMVSVOrganization.TabIndex = 28;
            ttMain.SetToolTip(tbMVSVOrganization, "Учреждение, ответственное за издание.\r\nПример: «Российская академия наук»");
            tbMVSVOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVParallelTitle
            // 
            labelMVSVParallelTitle.AutoSize = true;
            labelMVSVParallelTitle.Location = new Point(0, 0);
            labelMVSVParallelTitle.Name = "labelMVSVParallelTitle";
            labelMVSVParallelTitle.Size = new Size(139, 15);
            labelMVSVParallelTitle.TabIndex = 33;
            labelMVSVParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelMVSVParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbMVSVParallelTitle
            // 
            tbMVSVParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVParallelTitle.Location = new Point(0, 18);
            tbMVSVParallelTitle.Name = "tbMVSVParallelTitle";
            tbMVSVParallelTitle.Size = new Size(450, 23);
            tbMVSVParallelTitle.TabIndex = 22;
            ttMain.SetToolTip(tbMVSVParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbMVSVParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // cbMVSVEditorType
            // 
            cbMVSVEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMVSVEditorType.FormattingEnabled = true;
            cbMVSVEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbMVSVEditorType.Location = new Point(194, 150);
            cbMVSVEditorType.Name = "cbMVSVEditorType";
            cbMVSVEditorType.Size = new Size(160, 23);
            cbMVSVEditorType.TabIndex = 26;
            // 
            // lbMVSVEditor
            // 
            lbMVSVEditor.AllowDrop = true;
            lbMVSVEditor.ContextMenuStrip = cmsListBox;
            lbMVSVEditor.ItemHeight = 15;
            lbMVSVEditor.Location = new Point(0, 179);
            lbMVSVEditor.Name = "lbMVSVEditor";
            lbMVSVEditor.Size = new Size(450, 64);
            lbMVSVEditor.TabIndex = 29;
            lbMVSVEditor.TabStop = false;
            lbMVSVEditor.DragDrop += this.ListBox_DragDrop;
            lbMVSVEditor.DragOver += this.ListBox_DragOver;
            lbMVSVEditor.KeyDown += this.ListBox_KeyDown;
            lbMVSVEditor.MouseDown += this.ListBox_MouseDown;
            lbMVSVEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonMVSVEditorAdd
            // 
            buttonMVSVEditorAdd.Location = new Point(360, 150);
            buttonMVSVEditorAdd.Name = "buttonMVSVEditorAdd";
            buttonMVSVEditorAdd.Size = new Size(90, 23);
            buttonMVSVEditorAdd.TabIndex = 27;
            buttonMVSVEditorAdd.Text = "Добавить";
            buttonMVSVEditorAdd.UseVisualStyleBackColor = true;
            buttonMVSVEditorAdd.Click += this.buttonMVSVEditorAdd_Click;
            // 
            // labelMVSVContentType
            // 
            labelMVSVContentType.AutoSize = true;
            labelMVSVContentType.Location = new Point(0, 510);
            labelMVSVContentType.Name = "labelMVSVContentType";
            labelMVSVContentType.Size = new Size(97, 15);
            labelMVSVContentType.TabIndex = 26;
            labelMVSVContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelMVSVContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbMVSVVolumeTitle
            // 
            tbMVSVVolumeTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVVolumeTitle.Location = new Point(0, 62);
            tbMVSVVolumeTitle.Name = "tbMVSVVolumeTitle";
            tbMVSVVolumeTitle.Size = new Size(450, 23);
            tbMVSVVolumeTitle.TabIndex = 23;
            ttMain.SetToolTip(tbMVSVVolumeTitle, "Собственное название тома.\r\nПример: «Период реформ»");
            tbMVSVVolumeTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVContentType
            // 
            tbMVSVContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVContentType.Location = new Point(0, 528);
            tbMVSVContentType.Name = "tbMVSVContentType";
            tbMVSVContentType.Size = new Size(450, 23);
            tbMVSVContentType.TabIndex = 34;
            ttMain.SetToolTip(tbMVSVContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbMVSVContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVDocumentType
            // 
            labelMVSVDocumentType.AutoSize = true;
            labelMVSVDocumentType.Location = new Point(0, 88);
            labelMVSVDocumentType.Name = "labelMVSVDocumentType";
            labelMVSVDocumentType.Size = new Size(88, 15);
            labelMVSVDocumentType.TabIndex = 0;
            labelMVSVDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelMVSVDocumentType, "Тип документа: монография, учебник и т. д.\r\nПример: «монография»");
            // 
            // labelMVSVVolumeTitle
            // 
            labelMVSVVolumeTitle.AutoSize = true;
            labelMVSVVolumeTitle.Location = new Point(0, 44);
            labelMVSVVolumeTitle.Name = "labelMVSVVolumeTitle";
            labelMVSVVolumeTitle.Size = new Size(87, 15);
            labelMVSVVolumeTitle.TabIndex = 10;
            labelMVSVVolumeTitle.Text = "Заглавие тома";
            ttMain.SetToolTip(labelMVSVVolumeTitle, "Собственное название тома.\r\nПример: «Период реформ»");
            // 
            // tbMVSVEditor
            // 
            tbMVSVEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVEditor.Location = new Point(0, 150);
            tbMVSVEditor.Name = "tbMVSVEditor";
            tbMVSVEditor.Size = new Size(188, 23);
            tbMVSVEditor.TabIndex = 25;
            ttMain.SetToolTip(tbMVSVEditor, resources.GetString("tbMVSVEditor.ToolTip"));
            tbMVSVEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVDocumentType
            // 
            tbMVSVDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVDocumentType.Location = new Point(0, 106);
            tbMVSVDocumentType.Name = "tbMVSVDocumentType";
            tbMVSVDocumentType.Size = new Size(450, 23);
            tbMVSVDocumentType.TabIndex = 24;
            ttMain.SetToolTip(tbMVSVDocumentType, "Тип документа: монография, учебник и т. д.\r\nПример: «монография»");
            tbMVSVDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVISBN
            // 
            labelMVSVISBN.AutoSize = true;
            labelMVSVISBN.Location = new Point(0, 466);
            labelMVSVISBN.Name = "labelMVSVISBN";
            labelMVSVISBN.Size = new Size(32, 15);
            labelMVSVISBN.TabIndex = 10;
            labelMVSVISBN.Text = "ISBN";
            ttMain.SetToolTip(labelMVSVISBN, "Международный стандартный номер тома.\r\nПример: «978-5-02-038376-5»");
            // 
            // labelMVSVPagesCount
            // 
            labelMVSVPagesCount.AutoSize = true;
            labelMVSVPagesCount.Location = new Point(0, 378);
            labelMVSVPagesCount.Name = "labelMVSVPagesCount";
            labelMVSVPagesCount.Size = new Size(120, 15);
            labelMVSVPagesCount.TabIndex = 18;
            labelMVSVPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelMVSVPagesCount, "Общее количество страниц в томе.\r\nПример: «450»");
            // 
            // tbMVSVSeries
            // 
            tbMVSVSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVSeries.Location = new Point(0, 440);
            tbMVSVSeries.Name = "tbMVSVSeries";
            tbMVSVSeries.Size = new Size(450, 23);
            tbMVSVSeries.TabIndex = 32;
            ttMain.SetToolTip(tbMVSVSeries, "Название серии, если есть.\r\nПример: «Библиотека отечественной истории»");
            tbMVSVSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVPagesCount
            // 
            tbMVSVPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVPagesCount.Location = new Point(0, 396);
            tbMVSVPagesCount.Name = "tbMVSVPagesCount";
            tbMVSVPagesCount.Size = new Size(450, 23);
            tbMVSVPagesCount.TabIndex = 31;
            ttMain.SetToolTip(tbMVSVPagesCount, "Общее количество страниц в томе.\r\nПример: «450»\r\n");
            tbMVSVPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelMVSVEditionNumber
            // 
            labelMVSVEditionNumber.AutoSize = true;
            labelMVSVEditionNumber.Location = new Point(0, 290);
            labelMVSVEditionNumber.Name = "labelMVSVEditionNumber";
            labelMVSVEditionNumber.Size = new Size(92, 15);
            labelMVSVEditionNumber.TabIndex = 6;
            labelMVSVEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelMVSVEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n\r\n");
            // 
            // labelMVSVSeries
            // 
            labelMVSVSeries.AutoSize = true;
            labelMVSVSeries.Location = new Point(0, 422);
            labelMVSVSeries.Name = "labelMVSVSeries";
            labelMVSVSeries.Size = new Size(41, 15);
            labelMVSVSeries.TabIndex = 8;
            labelMVSVSeries.Text = "Серия";
            ttMain.SetToolTip(labelMVSVSeries, "Название серии, если есть.\r\nПример: «Библиотека отечественной истории»");
            // 
            // labelMVSVEditor
            // 
            labelMVSVEditor.AutoSize = true;
            labelMVSVEditor.Location = new Point(0, 132);
            labelMVSVEditor.Name = "labelMVSVEditor";
            labelMVSVEditor.Size = new Size(74, 15);
            labelMVSVEditor.TabIndex = 4;
            labelMVSVEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelMVSVEditor, resources.GetString("labelMVSVEditor.ToolTip"));
            // 
            // tbMVSVEditionNumber
            // 
            tbMVSVEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVEditionNumber.Location = new Point(0, 308);
            tbMVSVEditionNumber.Name = "tbMVSVEditionNumber";
            tbMVSVEditionNumber.Size = new Size(450, 23);
            tbMVSVEditionNumber.TabIndex = 29;
            ttMain.SetToolTip(tbMVSVEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n\r\n");
            tbMVSVEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // tbMVSVISBN
            // 
            tbMVSVISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbMVSVISBN.Location = new Point(0, 484);
            tbMVSVISBN.Name = "tbMVSVISBN";
            tbMVSVISBN.Size = new Size(450, 23);
            tbMVSVISBN.TabIndex = 33;
            ttMain.SetToolTip(tbMVSVISBN, "Международный стандартный номер тома.\r\nПример: «978-5-02-038376-5»");
            tbMVSVISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // tpElectronicResources
            // 
            tpElectronicResources.BackColor = SystemColors.Control;
            tpElectronicResources.Controls.Add(tcERTypes);
            tpElectronicResources.Location = new Point(4, 24);
            tpElectronicResources.Name = "tpElectronicResources";
            tpElectronicResources.Padding = new Padding(3);
            tpElectronicResources.Size = new Size(521, 720);
            tpElectronicResources.TabIndex = 2;
            tpElectronicResources.Text = "Электронные ресурсы";
            // 
            // tcERTypes
            // 
            tcERTypes.Controls.Add(tpEREbook);
            tcERTypes.Controls.Add(tpERWholeElectronicEdition);
            tcERTypes.Controls.Add(tpERElectronicEditionSeparateVolume);
            tcERTypes.Controls.Add(tpERElectronicConferenceMaterials);
            tcERTypes.Controls.Add(tpERElectronicCollections);
            tcERTypes.Controls.Add(tpEREjournalArticle);
            tcERTypes.Controls.Add(tpERMultimediaEdition);
            tcERTypes.Controls.Add(tpERWebsite);
            tcERTypes.Location = new Point(3, 6);
            tcERTypes.Name = "tcERTypes";
            tcERTypes.SelectedIndex = 0;
            tcERTypes.Size = new Size(513, 709);
            tcERTypes.TabIndex = 1;
            tcERTypes.TabStop = false;
            // 
            // tpEREbook
            // 
            tpEREbook.BackColor = SystemColors.Control;
            tpEREbook.Controls.Add(gbEREbookRequired);
            tpEREbook.Controls.Add(gbEREbookOptional);
            tpEREbook.Location = new Point(4, 24);
            tpEREbook.Name = "tpEREbook";
            tpEREbook.Padding = new Padding(3);
            tpEREbook.Size = new Size(505, 681);
            tpEREbook.TabIndex = 0;
            tpEREbook.Text = "Электронная книга";
            // 
            // gbEREbookRequired
            // 
            gbEREbookRequired.Controls.Add(panelEREbookRequired);
            gbEREbookRequired.Location = new Point(10, 10);
            gbEREbookRequired.Name = "gbEREbookRequired";
            gbEREbookRequired.Size = new Size(488, 330);
            gbEREbookRequired.TabIndex = 0;
            gbEREbookRequired.TabStop = false;
            gbEREbookRequired.Text = "Обязательные поля";
            // 
            // panelEREbookRequired
            // 
            panelEREbookRequired.AutoScroll = true;
            panelEREbookRequired.Controls.Add(lbEREbPublishingLocationSelect);
            panelEREbookRequired.Controls.Add(cbEREbPublisher);
            panelEREbookRequired.Controls.Add(cbEREbAuthors);
            panelEREbookRequired.Controls.Add(buttonEREbPublisherAdd);
            panelEREbookRequired.Controls.Add(lbEREbPublisher);
            panelEREbookRequired.Controls.Add(buttonEREbPublishingLocationAdd);
            panelEREbookRequired.Controls.Add(lbEREbPublishingLocation);
            panelEREbookRequired.Controls.Add(labelEREbAccessMode);
            panelEREbookRequired.Controls.Add(tbEREbAccessMode);
            panelEREbookRequired.Controls.Add(labelEREbAccessDate);
            panelEREbookRequired.Controls.Add(labelEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbAccessDate);
            panelEREbookRequired.Controls.Add(tbEREbURL);
            panelEREbookRequired.Controls.Add(labelEREbURL);
            panelEREbookRequired.Controls.Add(tbEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbPublishYear);
            panelEREbookRequired.Controls.Add(labelEREbAuthorsAdd);
            panelEREbookRequired.Controls.Add(labelEREbPublishYear);
            panelEREbookRequired.Controls.Add(lbEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbPublisher);
            panelEREbookRequired.Controls.Add(labelEREbTitle);
            panelEREbookRequired.Controls.Add(labelEREbPublisher);
            panelEREbookRequired.Controls.Add(tbEREbTitle);
            panelEREbookRequired.Controls.Add(tbEREbPublishingLocation);
            panelEREbookRequired.Controls.Add(labelEREbPublishingLocation);
            panelEREbookRequired.Location = new Point(10, 22);
            panelEREbookRequired.Name = "panelEREbookRequired";
            panelEREbookRequired.Size = new Size(473, 302);
            panelEREbookRequired.TabIndex = 0;
            // 
            // lbEREbPublishingLocationSelect
            // 
            lbEREbPublishingLocationSelect.Enabled = false;
            lbEREbPublishingLocationSelect.FormattingEnabled = true;
            lbEREbPublishingLocationSelect.ItemHeight = 15;
            lbEREbPublishingLocationSelect.Location = new Point(243, 319);
            lbEREbPublishingLocationSelect.Name = "lbEREbPublishingLocationSelect";
            lbEREbPublishingLocationSelect.Size = new Size(207, 64);
            lbEREbPublishingLocationSelect.TabIndex = 43;
            lbEREbPublishingLocationSelect.TabStop = false;
            lbEREbPublishingLocationSelect.SelectedIndexChanged += this.lbEREbPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbEREbPublisher
            // 
            cbEREbPublisher.AutoSize = true;
            cbEREbPublisher.Location = new Point(339, 292);
            cbEREbPublisher.Name = "cbEREbPublisher";
            cbEREbPublisher.Size = new Size(111, 19);
            cbEREbPublisher.TabIndex = 18;
            cbEREbPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbEREbPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbEREbPublisher.UseVisualStyleBackColor = true;
            cbEREbPublisher.CheckedChanged += this.cbEREbPublisher_CheckedChanged;
            // 
            // cbEREbAuthors
            // 
            cbEREbAuthors.AutoSize = true;
            cbEREbAuthors.Location = new Point(371, 20);
            cbEREbAuthors.Name = "cbEREbAuthors";
            cbEREbAuthors.Size = new Size(79, 19);
            cbEREbAuthors.TabIndex = 12;
            cbEREbAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbEREbAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbEREbAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonEREbPublisherAdd
            // 
            buttonEREbPublisherAdd.Location = new Point(243, 290);
            buttonEREbPublisherAdd.Name = "buttonEREbPublisherAdd";
            buttonEREbPublisherAdd.Size = new Size(90, 23);
            buttonEREbPublisherAdd.TabIndex = 17;
            buttonEREbPublisherAdd.Text = "Добавить";
            buttonEREbPublisherAdd.UseVisualStyleBackColor = true;
            buttonEREbPublisherAdd.Click += this.buttonEREbPublisherAdd_Click;
            // 
            // lbEREbPublisher
            // 
            lbEREbPublisher.AllowDrop = true;
            lbEREbPublisher.ContextMenuStrip = cmsListBox;
            lbEREbPublisher.ItemHeight = 15;
            lbEREbPublisher.Location = new Point(0, 319);
            lbEREbPublisher.Name = "lbEREbPublisher";
            lbEREbPublisher.Size = new Size(237, 64);
            lbEREbPublisher.TabIndex = 21;
            lbEREbPublisher.TabStop = false;
            lbEREbPublisher.DragDrop += this.ListBox_DragDrop;
            lbEREbPublisher.DragOver += this.ListBox_DragOver;
            lbEREbPublisher.KeyDown += this.ListBox_KeyDown;
            lbEREbPublisher.MouseDown += this.ListBox_MouseDown;
            lbEREbPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonEREbPublishingLocationAdd
            // 
            buttonEREbPublishingLocationAdd.Location = new Point(360, 176);
            buttonEREbPublishingLocationAdd.Name = "buttonEREbPublishingLocationAdd";
            buttonEREbPublishingLocationAdd.Size = new Size(90, 23);
            buttonEREbPublishingLocationAdd.TabIndex = 15;
            buttonEREbPublishingLocationAdd.Text = "Добавить";
            buttonEREbPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonEREbPublishingLocationAdd.Click += this.buttonEREbPublishingLocationAdd_Click;
            // 
            // lbEREbPublishingLocation
            // 
            lbEREbPublishingLocation.AllowDrop = true;
            lbEREbPublishingLocation.ContextMenuStrip = cmsListBox;
            lbEREbPublishingLocation.ItemHeight = 15;
            lbEREbPublishingLocation.Location = new Point(0, 205);
            lbEREbPublishingLocation.Name = "lbEREbPublishingLocation";
            lbEREbPublishingLocation.Size = new Size(450, 64);
            lbEREbPublishingLocation.TabIndex = 19;
            lbEREbPublishingLocation.TabStop = false;
            lbEREbPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbEREbPublishingLocation.DragOver += this.ListBox_DragOver;
            lbEREbPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbEREbPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbEREbPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // labelEREbAccessMode
            // 
            labelEREbAccessMode.AutoSize = true;
            labelEREbAccessMode.Location = new Point(0, 518);
            labelEREbAccessMode.Name = "labelEREbAccessMode";
            labelEREbAccessMode.Size = new Size(91, 15);
            labelEREbAccessMode.TabIndex = 16;
            labelEREbAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelEREbAccessMode, "Информация об условиях доступа (например, свободный, платный).\r\nПример: «свободный»");
            // 
            // tbEREbAccessMode
            // 
            tbEREbAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbAccessMode.Location = new Point(0, 536);
            tbEREbAccessMode.Name = "tbEREbAccessMode";
            tbEREbAccessMode.Size = new Size(450, 23);
            tbEREbAccessMode.TabIndex = 22;
            ttMain.SetToolTip(tbEREbAccessMode, "Информация об условиях доступа (например, свободный, платный).\r\nПример: «свободный»");
            tbEREbAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbAccessDate
            // 
            labelEREbAccessDate.AutoSize = true;
            labelEREbAccessDate.Location = new Point(0, 474);
            labelEREbAccessDate.Name = "labelEREbAccessDate";
            labelEREbAccessDate.Size = new Size(99, 15);
            labelEREbAccessDate.TabIndex = 14;
            labelEREbAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelEREbAccessDate, "Дата, когда был осуществлён доступ по ссылке.\r\nПример: «20.06.2025»");
            // 
            // labelEREbAuthors
            // 
            labelEREbAuthors.AutoSize = true;
            labelEREbAuthors.Location = new Point(0, 0);
            labelEREbAuthors.Name = "labelEREbAuthors";
            labelEREbAuthors.Size = new Size(57, 15);
            labelEREbAuthors.TabIndex = 0;
            labelEREbAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelEREbAuthors, resources.GetString("labelEREbAuthors.ToolTip"));
            // 
            // tbEREbAccessDate
            // 
            tbEREbAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbAccessDate.Location = new Point(0, 492);
            tbEREbAccessDate.Name = "tbEREbAccessDate";
            tbEREbAccessDate.Size = new Size(450, 23);
            tbEREbAccessDate.TabIndex = 21;
            ttMain.SetToolTip(tbEREbAccessDate, "Дата, когда был осуществлён доступ по ссылке.\r\nПример: «20.06.2025»");
            tbEREbAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREbURL
            // 
            tbEREbURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbURL.Location = new Point(0, 448);
            tbEREbURL.Name = "tbEREbURL";
            tbEREbURL.Size = new Size(450, 23);
            tbEREbURL.TabIndex = 20;
            ttMain.SetToolTip(tbEREbURL, "Ссылка на электронную версию книги.\r\nПример: «https://elib.rsl.ru/book/12345»");
            tbEREbURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbURL
            // 
            labelEREbURL.AutoSize = true;
            labelEREbURL.Location = new Point(0, 430);
            labelEREbURL.Name = "labelEREbURL";
            labelEREbURL.Size = new Size(28, 15);
            labelEREbURL.TabIndex = 12;
            labelEREbURL.Text = "URL";
            ttMain.SetToolTip(labelEREbURL, "Ссылка на электронную версию книги.\r\nПример: «https://elib.rsl.ru/book/12345»");
            // 
            // tbEREbAuthors
            // 
            tbEREbAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbAuthors.Location = new Point(0, 18);
            tbEREbAuthors.Name = "tbEREbAuthors";
            tbEREbAuthors.Size = new Size(269, 23);
            tbEREbAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbEREbAuthors, resources.GetString("tbEREbAuthors.ToolTip"));
            tbEREbAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREbPublishYear
            // 
            tbEREbPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbPublishYear.Location = new Point(0, 404);
            tbEREbPublishYear.Name = "tbEREbPublishYear";
            tbEREbPublishYear.Size = new Size(450, 23);
            tbEREbPublishYear.TabIndex = 19;
            ttMain.SetToolTip(tbEREbPublishYear, "Год публикации книги.\r\nПример: «2021»");
            tbEREbPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbAuthorsAdd
            // 
            labelEREbAuthorsAdd.Location = new Point(275, 18);
            labelEREbAuthorsAdd.Name = "labelEREbAuthorsAdd";
            labelEREbAuthorsAdd.Size = new Size(90, 23);
            labelEREbAuthorsAdd.TabIndex = 11;
            labelEREbAuthorsAdd.Text = "Добавить";
            labelEREbAuthorsAdd.UseVisualStyleBackColor = true;
            labelEREbAuthorsAdd.Click += this.labelEREbAuthorsAdd_Click;
            // 
            // labelEREbPublishYear
            // 
            labelEREbPublishYear.AutoSize = true;
            labelEREbPublishYear.Location = new Point(0, 386);
            labelEREbPublishYear.Name = "labelEREbPublishYear";
            labelEREbPublishYear.Size = new Size(73, 15);
            labelEREbPublishYear.TabIndex = 10;
            labelEREbPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelEREbPublishYear, "Год публикации книги.\r\nПример: «2021»");
            // 
            // lbEREbAuthors
            // 
            lbEREbAuthors.AllowDrop = true;
            lbEREbAuthors.ContextMenuStrip = cmsListBox;
            lbEREbAuthors.ItemHeight = 15;
            lbEREbAuthors.Location = new Point(0, 47);
            lbEREbAuthors.Name = "lbEREbAuthors";
            lbEREbAuthors.Size = new Size(450, 64);
            lbEREbAuthors.TabIndex = 3;
            lbEREbAuthors.TabStop = false;
            lbEREbAuthors.Tag = "";
            lbEREbAuthors.DragDrop += this.ListBox_DragDrop;
            lbEREbAuthors.DragOver += this.ListBox_DragOver;
            lbEREbAuthors.KeyDown += this.ListBox_KeyDown;
            lbEREbAuthors.MouseDown += this.ListBox_MouseDown;
            lbEREbAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbEREbPublisher
            // 
            tbEREbPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbPublisher.Location = new Point(0, 290);
            tbEREbPublisher.Name = "tbEREbPublisher";
            tbEREbPublisher.Size = new Size(237, 23);
            tbEREbPublisher.TabIndex = 16;
            ttMain.SetToolTip(tbEREbPublisher, resources.GetString("tbEREbPublisher.ToolTip"));
            tbEREbPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbTitle
            // 
            labelEREbTitle.AutoSize = true;
            labelEREbTitle.Location = new Point(0, 114);
            labelEREbTitle.Name = "labelEREbTitle";
            labelEREbTitle.Size = new Size(57, 15);
            labelEREbTitle.TabIndex = 4;
            labelEREbTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelEREbTitle, "Основное название книги.\r\nПример: «Русская литература XX века»");
            // 
            // labelEREbPublisher
            // 
            labelEREbPublisher.AutoSize = true;
            labelEREbPublisher.Location = new Point(0, 272);
            labelEREbPublisher.Name = "labelEREbPublisher";
            labelEREbPublisher.Size = new Size(81, 15);
            labelEREbPublisher.TabIndex = 8;
            labelEREbPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelEREbPublisher, resources.GetString("labelEREbPublisher.ToolTip"));
            // 
            // tbEREbTitle
            // 
            tbEREbTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbTitle.Location = new Point(0, 132);
            tbEREbTitle.Name = "tbEREbTitle";
            tbEREbTitle.Size = new Size(450, 23);
            tbEREbTitle.TabIndex = 13;
            ttMain.SetToolTip(tbEREbTitle, "Основное название книги.\r\nПример: «Русская литература XX века»");
            tbEREbTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREbPublishingLocation
            // 
            tbEREbPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbPublishingLocation.Location = new Point(0, 176);
            tbEREbPublishingLocation.Name = "tbEREbPublishingLocation";
            tbEREbPublishingLocation.Size = new Size(354, 23);
            tbEREbPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbEREbPublishingLocation, "Город или города, в которых была опубликована книга.\r\nПример: «Москва»");
            tbEREbPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbPublishingLocation
            // 
            labelEREbPublishingLocation.AutoSize = true;
            labelEREbPublishingLocation.Location = new Point(0, 158);
            labelEREbPublishingLocation.Name = "labelEREbPublishingLocation";
            labelEREbPublishingLocation.Size = new Size(89, 15);
            labelEREbPublishingLocation.TabIndex = 6;
            labelEREbPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelEREbPublishingLocation, "Город или города, в которых была опубликована книга.\r\nПример: «Москва»");
            // 
            // gbEREbookOptional
            // 
            gbEREbookOptional.Controls.Add(panelEREbookOptional);
            gbEREbookOptional.Location = new Point(10, 346);
            gbEREbookOptional.Name = "gbEREbookOptional";
            gbEREbookOptional.Size = new Size(488, 330);
            gbEREbookOptional.TabIndex = 1;
            gbEREbookOptional.TabStop = false;
            gbEREbookOptional.Text = "Необязательные поля";
            // 
            // panelEREbookOptional
            // 
            panelEREbookOptional.AutoScroll = true;
            panelEREbookOptional.Controls.Add(labelEREbTranslator);
            panelEREbookOptional.Controls.Add(tbEREbTranslator);
            panelEREbookOptional.Controls.Add(labelEREbOrganization);
            panelEREbookOptional.Controls.Add(tbEREbOrganization);
            panelEREbookOptional.Controls.Add(labelEREbParallelTitle);
            panelEREbookOptional.Controls.Add(tbEREbParallelTitle);
            panelEREbookOptional.Controls.Add(labelEREbContentType);
            panelEREbookOptional.Controls.Add(tbEREbContentType);
            panelEREbookOptional.Controls.Add(cbEREbEditorType);
            panelEREbookOptional.Controls.Add(lbEREbEditor);
            panelEREbookOptional.Controls.Add(buttonEREbEditorAdd);
            panelEREbookOptional.Controls.Add(labelEREbISBN);
            panelEREbookOptional.Controls.Add(tbEREbISBN);
            panelEREbookOptional.Controls.Add(labelEREbDocumentType);
            panelEREbookOptional.Controls.Add(tbEREbSeries);
            panelEREbookOptional.Controls.Add(tbEREbDocumentType);
            panelEREbookOptional.Controls.Add(labelEREbSeries);
            panelEREbookOptional.Controls.Add(tbEREbPagesCount);
            panelEREbookOptional.Controls.Add(labelEREbPagesCount);
            panelEREbookOptional.Controls.Add(labelEREbEditor);
            panelEREbookOptional.Controls.Add(tbEREbEditionNumber);
            panelEREbookOptional.Controls.Add(tbEREbEditor);
            panelEREbookOptional.Controls.Add(labelEREbEditionNumber);
            panelEREbookOptional.Location = new Point(10, 22);
            panelEREbookOptional.Name = "panelEREbookOptional";
            panelEREbookOptional.Size = new Size(473, 302);
            panelEREbookOptional.TabIndex = 16;
            // 
            // labelEREbTranslator
            // 
            labelEREbTranslator.AutoSize = true;
            labelEREbTranslator.Location = new Point(0, 290);
            labelEREbTranslator.Name = "labelEREbTranslator";
            labelEREbTranslator.Size = new Size(74, 15);
            labelEREbTranslator.TabIndex = 37;
            labelEREbTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelEREbTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // tbEREbTranslator
            // 
            tbEREbTranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbTranslator.Location = new Point(0, 308);
            tbEREbTranslator.Name = "tbEREbTranslator";
            tbEREbTranslator.Size = new Size(450, 23);
            tbEREbTranslator.TabIndex = 30;
            ttMain.SetToolTip(tbEREbTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // labelEREbOrganization
            // 
            labelEREbOrganization.AutoSize = true;
            labelEREbOrganization.Location = new Point(0, 202);
            labelEREbOrganization.Name = "labelEREbOrganization";
            labelEREbOrganization.Size = new Size(79, 15);
            labelEREbOrganization.TabIndex = 35;
            labelEREbOrganization.Text = "Организация";
            ttMain.SetToolTip(labelEREbOrganization, "Организация, ответственная за публикацию или издание.\r\nПример: «МГУ имени М. В. Ломоносова»");
            // 
            // tbEREbOrganization
            // 
            tbEREbOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbOrganization.Location = new Point(0, 220);
            tbEREbOrganization.Name = "tbEREbOrganization";
            tbEREbOrganization.Size = new Size(450, 23);
            tbEREbOrganization.TabIndex = 28;
            ttMain.SetToolTip(tbEREbOrganization, "Организация, ответственная за публикацию или издание.\r\nПример: «МГУ имени М. В. Ломоносова»");
            // 
            // labelEREbParallelTitle
            // 
            labelEREbParallelTitle.AutoSize = true;
            labelEREbParallelTitle.Location = new Point(0, 0);
            labelEREbParallelTitle.Name = "labelEREbParallelTitle";
            labelEREbParallelTitle.Size = new Size(139, 15);
            labelEREbParallelTitle.TabIndex = 29;
            labelEREbParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelEREbParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbEREbParallelTitle
            // 
            tbEREbParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbParallelTitle.Location = new Point(0, 18);
            tbEREbParallelTitle.Name = "tbEREbParallelTitle";
            tbEREbParallelTitle.Size = new Size(450, 23);
            tbEREbParallelTitle.TabIndex = 23;
            ttMain.SetToolTip(tbEREbParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbEREbParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbContentType
            // 
            labelEREbContentType.AutoSize = true;
            labelEREbContentType.Location = new Point(0, 466);
            labelEREbContentType.Name = "labelEREbContentType";
            labelEREbContentType.Size = new Size(97, 15);
            labelEREbContentType.TabIndex = 27;
            labelEREbContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelEREbContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbEREbContentType
            // 
            tbEREbContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbContentType.Location = new Point(0, 484);
            tbEREbContentType.Name = "tbEREbContentType";
            tbEREbContentType.Size = new Size(450, 23);
            tbEREbContentType.TabIndex = 34;
            ttMain.SetToolTip(tbEREbContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbEREbContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // cbEREbEditorType
            // 
            cbEREbEditorType.BackColor = SystemColors.Window;
            cbEREbEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEREbEditorType.FormattingEnabled = true;
            cbEREbEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbEREbEditorType.Location = new Point(194, 106);
            cbEREbEditorType.Name = "cbEREbEditorType";
            cbEREbEditorType.Size = new Size(160, 23);
            cbEREbEditorType.TabIndex = 26;
            // 
            // lbEREbEditor
            // 
            lbEREbEditor.AllowDrop = true;
            lbEREbEditor.ContextMenuStrip = cmsListBox;
            lbEREbEditor.ItemHeight = 15;
            lbEREbEditor.Location = new Point(0, 135);
            lbEREbEditor.Name = "lbEREbEditor";
            lbEREbEditor.Size = new Size(450, 64);
            lbEREbEditor.TabIndex = 25;
            lbEREbEditor.TabStop = false;
            lbEREbEditor.DragDrop += this.ListBox_DragDrop;
            lbEREbEditor.DragOver += this.ListBox_DragOver;
            lbEREbEditor.KeyDown += this.ListBox_KeyDown;
            lbEREbEditor.MouseDown += this.ListBox_MouseDown;
            lbEREbEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonEREbEditorAdd
            // 
            buttonEREbEditorAdd.Location = new Point(360, 106);
            buttonEREbEditorAdd.Name = "buttonEREbEditorAdd";
            buttonEREbEditorAdd.Size = new Size(90, 23);
            buttonEREbEditorAdd.TabIndex = 27;
            buttonEREbEditorAdd.Text = "Добавить";
            buttonEREbEditorAdd.UseVisualStyleBackColor = true;
            buttonEREbEditorAdd.Click += this.buttonEREbEditorAdd_Click;
            // 
            // labelEREbISBN
            // 
            labelEREbISBN.AutoSize = true;
            labelEREbISBN.Location = new Point(0, 422);
            labelEREbISBN.Name = "labelEREbISBN";
            labelEREbISBN.Size = new Size(32, 15);
            labelEREbISBN.TabIndex = 12;
            labelEREbISBN.Text = "ISBN";
            ttMain.SetToolTip(labelEREbISBN, "Международный стандартный номер книги.\r\nПример: «978-5-09-045236-2»");
            // 
            // tbEREbISBN
            // 
            tbEREbISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbISBN.Location = new Point(0, 440);
            tbEREbISBN.Name = "tbEREbISBN";
            tbEREbISBN.Size = new Size(450, 23);
            tbEREbISBN.TabIndex = 33;
            ttMain.SetToolTip(tbEREbISBN, "Международный стандартный номер книги.\r\nПример: «978-5-09-045236-2»");
            tbEREbISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbDocumentType
            // 
            labelEREbDocumentType.AutoSize = true;
            labelEREbDocumentType.Location = new Point(0, 44);
            labelEREbDocumentType.Name = "labelEREbDocumentType";
            labelEREbDocumentType.Size = new Size(88, 15);
            labelEREbDocumentType.TabIndex = 0;
            labelEREbDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelEREbDocumentType, "Тип документа: монография, сборник, учебник и др.\r\nПример: «учебное пособие»");
            // 
            // tbEREbSeries
            // 
            tbEREbSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbSeries.Location = new Point(0, 396);
            tbEREbSeries.Name = "tbEREbSeries";
            tbEREbSeries.Size = new Size(450, 23);
            tbEREbSeries.TabIndex = 32;
            ttMain.SetToolTip(tbEREbSeries, "Название серии, в которой вышла книга.\r\nПример: «Библиотека школьника»");
            tbEREbSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREbDocumentType
            // 
            tbEREbDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbDocumentType.Location = new Point(0, 62);
            tbEREbDocumentType.Name = "tbEREbDocumentType";
            tbEREbDocumentType.Size = new Size(450, 23);
            tbEREbDocumentType.TabIndex = 24;
            ttMain.SetToolTip(tbEREbDocumentType, "Тип документа: монография, сборник, учебник и др.\r\nПример: «учебное пособие»");
            tbEREbDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbSeries
            // 
            labelEREbSeries.AutoSize = true;
            labelEREbSeries.Location = new Point(0, 378);
            labelEREbSeries.Name = "labelEREbSeries";
            labelEREbSeries.Size = new Size(41, 15);
            labelEREbSeries.TabIndex = 10;
            labelEREbSeries.Text = "Серия";
            ttMain.SetToolTip(labelEREbSeries, "Название серии, в которой вышла книга.\r\nПример: «Библиотека школьника»");
            // 
            // tbEREbPagesCount
            // 
            tbEREbPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbPagesCount.Location = new Point(0, 352);
            tbEREbPagesCount.Name = "tbEREbPagesCount";
            tbEREbPagesCount.Size = new Size(450, 23);
            tbEREbPagesCount.TabIndex = 31;
            ttMain.SetToolTip(tbEREbPagesCount, "Общее количество страниц.\r\nПример: «350»\r\n");
            tbEREbPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbPagesCount
            // 
            labelEREbPagesCount.AutoSize = true;
            labelEREbPagesCount.Location = new Point(0, 334);
            labelEREbPagesCount.Name = "labelEREbPagesCount";
            labelEREbPagesCount.Size = new Size(120, 15);
            labelEREbPagesCount.TabIndex = 8;
            labelEREbPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelEREbPagesCount, "Общее количество страниц.\r\nПример: «350»");
            // 
            // labelEREbEditor
            // 
            labelEREbEditor.AutoSize = true;
            labelEREbEditor.Location = new Point(0, 88);
            labelEREbEditor.Name = "labelEREbEditor";
            labelEREbEditor.Size = new Size(74, 15);
            labelEREbEditor.TabIndex = 4;
            labelEREbEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelEREbEditor, resources.GetString("labelEREbEditor.ToolTip"));
            // 
            // tbEREbEditionNumber
            // 
            tbEREbEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbEditionNumber.Location = new Point(0, 264);
            tbEREbEditionNumber.Name = "tbEREbEditionNumber";
            tbEREbEditionNumber.Size = new Size(450, 23);
            tbEREbEditionNumber.TabIndex = 29;
            ttMain.SetToolTip(tbEREbEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n\r\n");
            tbEREbEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREbEditor
            // 
            tbEREbEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREbEditor.Location = new Point(0, 106);
            tbEREbEditor.Name = "tbEREbEditor";
            tbEREbEditor.Size = new Size(188, 23);
            tbEREbEditor.TabIndex = 25;
            ttMain.SetToolTip(tbEREbEditor, resources.GetString("tbEREbEditor.ToolTip"));
            tbEREbEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREbEditionNumber
            // 
            labelEREbEditionNumber.AutoSize = true;
            labelEREbEditionNumber.Location = new Point(0, 246);
            labelEREbEditionNumber.Name = "labelEREbEditionNumber";
            labelEREbEditionNumber.Size = new Size(92, 15);
            labelEREbEditionNumber.TabIndex = 6;
            labelEREbEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelEREbEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n\r\n");
            // 
            // tpERWholeElectronicEdition
            // 
            tpERWholeElectronicEdition.BackColor = SystemColors.Control;
            tpERWholeElectronicEdition.Controls.Add(gbERWholeElectronicEditionRequired);
            tpERWholeElectronicEdition.Controls.Add(gbERWholeElectronicEditionOptional);
            tpERWholeElectronicEdition.Location = new Point(4, 24);
            tpERWholeElectronicEdition.Name = "tpERWholeElectronicEdition";
            tpERWholeElectronicEdition.Size = new Size(505, 681);
            tpERWholeElectronicEdition.TabIndex = 4;
            tpERWholeElectronicEdition.Text = "Многотомное электронное издание в целом";
            // 
            // gbERWholeElectronicEditionRequired
            // 
            gbERWholeElectronicEditionRequired.Controls.Add(panelERWholeElectronicEditionRequired);
            gbERWholeElectronicEditionRequired.Location = new Point(10, 10);
            gbERWholeElectronicEditionRequired.Name = "gbERWholeElectronicEditionRequired";
            gbERWholeElectronicEditionRequired.Size = new Size(488, 330);
            gbERWholeElectronicEditionRequired.TabIndex = 2;
            gbERWholeElectronicEditionRequired.TabStop = false;
            gbERWholeElectronicEditionRequired.Text = "Обязательные поля";
            // 
            // panelERWholeElectronicEditionRequired
            // 
            panelERWholeElectronicEditionRequired.AutoScroll = true;
            panelERWholeElectronicEditionRequired.Controls.Add(lbERWEEPublishingLocationSelect);
            panelERWholeElectronicEditionRequired.Controls.Add(cbERWEEPublisher);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEAccessMode);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEAccessMode);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEAccessDate);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEAccessDate);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEURL);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEURL);
            panelERWholeElectronicEditionRequired.Controls.Add(cbERWEEAuthors);
            panelERWholeElectronicEditionRequired.Controls.Add(buttonERWEEPublisherAdd);
            panelERWholeElectronicEditionRequired.Controls.Add(lbERWEEPublisher);
            panelERWholeElectronicEditionRequired.Controls.Add(buttonERWEEPublishingLocationAdd);
            panelERWholeElectronicEditionRequired.Controls.Add(lbERWEEPublishingLocation);
            panelERWholeElectronicEditionRequired.Controls.Add(panelERWEEAuthors);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEPublishYear);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEPublishYear);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEAuthors);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEPublisher);
            panelERWholeElectronicEditionRequired.Controls.Add(buttonERWEEAuthorsAdd);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEPublisher);
            panelERWholeElectronicEditionRequired.Controls.Add(lbERWEEAuthors);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEPublishingLocation);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEETitle);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEPublishingLocation);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEETitle);
            panelERWholeElectronicEditionRequired.Controls.Add(tbERWEEVolumesCount);
            panelERWholeElectronicEditionRequired.Controls.Add(labelERWEEVolumesCount);
            panelERWholeElectronicEditionRequired.Location = new Point(10, 22);
            panelERWholeElectronicEditionRequired.Name = "panelERWholeElectronicEditionRequired";
            panelERWholeElectronicEditionRequired.Size = new Size(473, 302);
            panelERWholeElectronicEditionRequired.TabIndex = 0;
            // 
            // lbERWEEPublishingLocationSelect
            // 
            lbERWEEPublishingLocationSelect.Enabled = false;
            lbERWEEPublishingLocationSelect.FormattingEnabled = true;
            lbERWEEPublishingLocationSelect.ItemHeight = 15;
            lbERWEEPublishingLocationSelect.Location = new Point(243, 363);
            lbERWEEPublishingLocationSelect.Name = "lbERWEEPublishingLocationSelect";
            lbERWEEPublishingLocationSelect.Size = new Size(207, 64);
            lbERWEEPublishingLocationSelect.TabIndex = 41;
            lbERWEEPublishingLocationSelect.TabStop = false;
            lbERWEEPublishingLocationSelect.SelectedIndexChanged += this.lbERWEEPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbERWEEPublisher
            // 
            cbERWEEPublisher.AutoSize = true;
            cbERWEEPublisher.Location = new Point(339, 336);
            cbERWEEPublisher.Name = "cbERWEEPublisher";
            cbERWEEPublisher.Size = new Size(111, 19);
            cbERWEEPublisher.TabIndex = 19;
            cbERWEEPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbERWEEPublisher, "Включение «умного режима» добавления издательств");
            cbERWEEPublisher.UseVisualStyleBackColor = true;
            cbERWEEPublisher.CheckedChanged += this.cbERWEEPublisher_CheckedChanged;
            // 
            // tbERWEEAccessMode
            // 
            tbERWEEAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEAccessMode.Location = new Point(0, 580);
            tbERWEEAccessMode.Name = "tbERWEEAccessMode";
            tbERWEEAccessMode.Size = new Size(450, 23);
            tbERWEEAccessMode.TabIndex = 23;
            ttMain.SetToolTip(tbERWEEAccessMode, "Информация об условиях доступа (например, свободный, по подписке).\r\nПример: «свободный»");
            tbERWEEAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEAccessMode
            // 
            labelERWEEAccessMode.AutoSize = true;
            labelERWEEAccessMode.Location = new Point(0, 562);
            labelERWEEAccessMode.Name = "labelERWEEAccessMode";
            labelERWEEAccessMode.Size = new Size(91, 15);
            labelERWEEAccessMode.TabIndex = 25;
            labelERWEEAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelERWEEAccessMode, "Информация об условиях доступа (например, свободный, по подписке).\r\nПример: «свободный»");
            // 
            // tbERWEEAccessDate
            // 
            tbERWEEAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEAccessDate.Location = new Point(0, 536);
            tbERWEEAccessDate.Name = "tbERWEEAccessDate";
            tbERWEEAccessDate.Size = new Size(450, 23);
            tbERWEEAccessDate.TabIndex = 22;
            ttMain.SetToolTip(tbERWEEAccessDate, "Дата, когда был осуществлён доступ к документу по указанной ссылке.\r\nПример: «20.06.2025»");
            tbERWEEAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEAccessDate
            // 
            labelERWEEAccessDate.AutoSize = true;
            labelERWEEAccessDate.Location = new Point(0, 518);
            labelERWEEAccessDate.Name = "labelERWEEAccessDate";
            labelERWEEAccessDate.Size = new Size(99, 15);
            labelERWEEAccessDate.TabIndex = 23;
            labelERWEEAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelERWEEAccessDate, "Дата, когда был осуществлён доступ к документу по указанной ссылке.\r\nПример: «20.06.2025»");
            // 
            // tbERWEEURL
            // 
            tbERWEEURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEURL.Location = new Point(0, 492);
            tbERWEEURL.Name = "tbERWEEURL";
            tbERWEEURL.Size = new Size(450, 23);
            tbERWEEURL.TabIndex = 21;
            ttMain.SetToolTip(tbERWEEURL, "Ссылка на доступ к электронной версии.\r\nПример: «https://ebooks.spbu.ru/philosophy_collection»");
            tbERWEEURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEURL
            // 
            labelERWEEURL.AutoSize = true;
            labelERWEEURL.Location = new Point(0, 474);
            labelERWEEURL.Name = "labelERWEEURL";
            labelERWEEURL.Size = new Size(28, 15);
            labelERWEEURL.TabIndex = 21;
            labelERWEEURL.Text = "URL";
            ttMain.SetToolTip(labelERWEEURL, "Ссылка на доступ к электронной версии.\r\nПример: «https://ebooks.spbu.ru/philosophy_collection»");
            // 
            // cbERWEEAuthors
            // 
            cbERWEEAuthors.AutoSize = true;
            cbERWEEAuthors.Location = new Point(371, 20);
            cbERWEEAuthors.Name = "cbERWEEAuthors";
            cbERWEEAuthors.Size = new Size(79, 19);
            cbERWEEAuthors.TabIndex = 12;
            cbERWEEAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbERWEEAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbERWEEAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonERWEEPublisherAdd
            // 
            buttonERWEEPublisherAdd.Location = new Point(243, 334);
            buttonERWEEPublisherAdd.Name = "buttonERWEEPublisherAdd";
            buttonERWEEPublisherAdd.Size = new Size(90, 23);
            buttonERWEEPublisherAdd.TabIndex = 18;
            buttonERWEEPublisherAdd.Text = "Добавить";
            buttonERWEEPublisherAdd.UseVisualStyleBackColor = true;
            buttonERWEEPublisherAdd.Click += this.buttonERWEEPublisherAdd_Click;
            // 
            // lbERWEEPublisher
            // 
            lbERWEEPublisher.AllowDrop = true;
            lbERWEEPublisher.ContextMenuStrip = cmsListBox;
            lbERWEEPublisher.ItemHeight = 15;
            lbERWEEPublisher.Location = new Point(0, 363);
            lbERWEEPublisher.Name = "lbERWEEPublisher";
            lbERWEEPublisher.Size = new Size(237, 64);
            lbERWEEPublisher.TabIndex = 19;
            lbERWEEPublisher.TabStop = false;
            lbERWEEPublisher.DragDrop += this.ListBox_DragDrop;
            lbERWEEPublisher.DragOver += this.ListBox_DragOver;
            lbERWEEPublisher.KeyDown += this.ListBox_KeyDown;
            lbERWEEPublisher.MouseDown += this.ListBox_MouseDown;
            lbERWEEPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERWEEPublishingLocationAdd
            // 
            buttonERWEEPublishingLocationAdd.Location = new Point(360, 220);
            buttonERWEEPublishingLocationAdd.Name = "buttonERWEEPublishingLocationAdd";
            buttonERWEEPublishingLocationAdd.Size = new Size(90, 23);
            buttonERWEEPublishingLocationAdd.TabIndex = 16;
            buttonERWEEPublishingLocationAdd.Text = "Добавить";
            buttonERWEEPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonERWEEPublishingLocationAdd.Click += this.buttonERWEEPublishingLocationAdd_Click;
            // 
            // lbERWEEPublishingLocation
            // 
            lbERWEEPublishingLocation.AllowDrop = true;
            lbERWEEPublishingLocation.ContextMenuStrip = cmsListBox;
            lbERWEEPublishingLocation.ItemHeight = 15;
            lbERWEEPublishingLocation.Location = new Point(0, 249);
            lbERWEEPublishingLocation.Name = "lbERWEEPublishingLocation";
            lbERWEEPublishingLocation.Size = new Size(450, 64);
            lbERWEEPublishingLocation.TabIndex = 17;
            lbERWEEPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbERWEEPublishingLocation.DragOver += this.ListBox_DragOver;
            lbERWEEPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbERWEEPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbERWEEPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // panelERWEEAuthors
            // 
            panelERWEEAuthors.AutoSize = true;
            panelERWEEAuthors.Location = new Point(0, 0);
            panelERWEEAuthors.Name = "panelERWEEAuthors";
            panelERWEEAuthors.Size = new Size(57, 15);
            panelERWEEAuthors.TabIndex = 0;
            panelERWEEAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(panelERWEEAuthors, resources.GetString("panelERWEEAuthors.ToolTip"));
            // 
            // tbERWEEPublishYear
            // 
            tbERWEEPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEPublishYear.Location = new Point(0, 448);
            tbERWEEPublishYear.Name = "tbERWEEPublishYear";
            tbERWEEPublishYear.Size = new Size(450, 23);
            tbERWEEPublishYear.TabIndex = 20;
            ttMain.SetToolTip(tbERWEEPublishYear, "Год, в который было выпущено издание (в целом).\r\nПример: «2020»");
            tbERWEEPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEPublishYear
            // 
            labelERWEEPublishYear.AutoSize = true;
            labelERWEEPublishYear.Location = new Point(0, 430);
            labelERWEEPublishYear.Name = "labelERWEEPublishYear";
            labelERWEEPublishYear.Size = new Size(73, 15);
            labelERWEEPublishYear.TabIndex = 12;
            labelERWEEPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelERWEEPublishYear, "Год, в который было выпущено издание (в целом).\r\nПример: «2020»");
            // 
            // tbERWEEAuthors
            // 
            tbERWEEAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEAuthors.Location = new Point(0, 18);
            tbERWEEAuthors.Name = "tbERWEEAuthors";
            tbERWEEAuthors.Size = new Size(269, 23);
            tbERWEEAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbERWEEAuthors, resources.GetString("tbERWEEAuthors.ToolTip"));
            tbERWEEAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWEEPublisher
            // 
            tbERWEEPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEPublisher.Location = new Point(0, 334);
            tbERWEEPublisher.Name = "tbERWEEPublisher";
            tbERWEEPublisher.Size = new Size(237, 23);
            tbERWEEPublisher.TabIndex = 17;
            ttMain.SetToolTip(tbERWEEPublisher, resources.GetString("tbERWEEPublisher.ToolTip"));
            tbERWEEPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonERWEEAuthorsAdd
            // 
            buttonERWEEAuthorsAdd.Location = new Point(275, 18);
            buttonERWEEAuthorsAdd.Name = "buttonERWEEAuthorsAdd";
            buttonERWEEAuthorsAdd.Size = new Size(90, 23);
            buttonERWEEAuthorsAdd.TabIndex = 11;
            buttonERWEEAuthorsAdd.Text = "Добавить";
            buttonERWEEAuthorsAdd.UseVisualStyleBackColor = true;
            buttonERWEEAuthorsAdd.Click += this.buttonERWEEAuthorsAdd_Click;
            // 
            // labelERWEEPublisher
            // 
            labelERWEEPublisher.AutoSize = true;
            labelERWEEPublisher.Location = new Point(0, 316);
            labelERWEEPublisher.Name = "labelERWEEPublisher";
            labelERWEEPublisher.Size = new Size(81, 15);
            labelERWEEPublisher.TabIndex = 10;
            labelERWEEPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelERWEEPublisher, resources.GetString("labelERWEEPublisher.ToolTip"));
            // 
            // lbERWEEAuthors
            // 
            lbERWEEAuthors.AllowDrop = true;
            lbERWEEAuthors.ContextMenuStrip = cmsListBox;
            lbERWEEAuthors.ItemHeight = 15;
            lbERWEEAuthors.Location = new Point(0, 47);
            lbERWEEAuthors.Name = "lbERWEEAuthors";
            lbERWEEAuthors.Size = new Size(450, 64);
            lbERWEEAuthors.TabIndex = 3;
            lbERWEEAuthors.TabStop = false;
            lbERWEEAuthors.Tag = "";
            lbERWEEAuthors.DragDrop += this.ListBox_DragDrop;
            lbERWEEAuthors.DragOver += this.ListBox_DragOver;
            lbERWEEAuthors.KeyDown += this.ListBox_KeyDown;
            lbERWEEAuthors.MouseDown += this.ListBox_MouseDown;
            lbERWEEAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERWEEPublishingLocation
            // 
            tbERWEEPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEPublishingLocation.Location = new Point(0, 220);
            tbERWEEPublishingLocation.Name = "tbERWEEPublishingLocation";
            tbERWEEPublishingLocation.Size = new Size(354, 23);
            tbERWEEPublishingLocation.TabIndex = 15;
            ttMain.SetToolTip(tbERWEEPublishingLocation, "Город или города, где выпущено электронное издание.\r\nПример: «Санкт-Петербург»");
            tbERWEEPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEETitle
            // 
            labelERWEETitle.AutoSize = true;
            labelERWEETitle.Location = new Point(0, 114);
            labelERWEETitle.Name = "labelERWEETitle";
            labelERWEETitle.Size = new Size(57, 15);
            labelERWEETitle.TabIndex = 4;
            labelERWEETitle.Text = "Заглавие";
            ttMain.SetToolTip(labelERWEETitle, "Основное название всего издания, которое охватывает несколько томов.\r\nПример: «История философии»");
            // 
            // labelERWEEPublishingLocation
            // 
            labelERWEEPublishingLocation.AutoSize = true;
            labelERWEEPublishingLocation.Location = new Point(0, 202);
            labelERWEEPublishingLocation.Name = "labelERWEEPublishingLocation";
            labelERWEEPublishingLocation.Size = new Size(89, 15);
            labelERWEEPublishingLocation.TabIndex = 8;
            labelERWEEPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelERWEEPublishingLocation, "Город или города, где выпущено электронное издание.\r\nПример: «Санкт-Петербург»");
            // 
            // tbERWEETitle
            // 
            tbERWEETitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEETitle.Location = new Point(0, 132);
            tbERWEETitle.Name = "tbERWEETitle";
            tbERWEETitle.Size = new Size(450, 23);
            tbERWEETitle.TabIndex = 13;
            ttMain.SetToolTip(tbERWEETitle, "Основное название всего издания, которое охватывает несколько томов.\r\nПример: «История философии»");
            tbERWEETitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWEEVolumesCount
            // 
            tbERWEEVolumesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEVolumesCount.Location = new Point(0, 176);
            tbERWEEVolumesCount.Name = "tbERWEEVolumesCount";
            tbERWEEVolumesCount.Size = new Size(450, 23);
            tbERWEEVolumesCount.TabIndex = 14;
            ttMain.SetToolTip(tbERWEEVolumesCount, "Общее количество томов в издании.\r\nПример: «5»");
            tbERWEEVolumesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEVolumesCount
            // 
            labelERWEEVolumesCount.AutoSize = true;
            labelERWEEVolumesCount.Location = new Point(0, 158);
            labelERWEEVolumesCount.Name = "labelERWEEVolumesCount";
            labelERWEEVolumesCount.Size = new Size(109, 15);
            labelERWEEVolumesCount.TabIndex = 6;
            labelERWEEVolumesCount.Text = "Количество томов";
            ttMain.SetToolTip(labelERWEEVolumesCount, "Общее количество томов в издании.\r\nПример: «5»");
            // 
            // gbERWholeElectronicEditionOptional
            // 
            gbERWholeElectronicEditionOptional.Controls.Add(panelERWholeElectronicEditionOptional);
            gbERWholeElectronicEditionOptional.Location = new Point(10, 346);
            gbERWholeElectronicEditionOptional.Name = "gbERWholeElectronicEditionOptional";
            gbERWholeElectronicEditionOptional.Size = new Size(488, 330);
            gbERWholeElectronicEditionOptional.TabIndex = 3;
            gbERWholeElectronicEditionOptional.TabStop = false;
            gbERWholeElectronicEditionOptional.Text = "Необязательные поля";
            // 
            // panelERWholeElectronicEditionOptional
            // 
            panelERWholeElectronicEditionOptional.AutoScroll = true;
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEETranslator);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEETranslator);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEOrganization);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEOrganization);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEParallelTitle);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEParallelTitle);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEContentType);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEContentType);
            panelERWholeElectronicEditionOptional.Controls.Add(cbERWEEEditorType);
            panelERWholeElectronicEditionOptional.Controls.Add(lbERWEEEditor);
            panelERWholeElectronicEditionOptional.Controls.Add(buttonERWEEEditorAdd);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEDocumentType);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEISBN);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEESeries);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEEditor);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEPagesCount);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEESeries);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEPagesCount);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEEditionNumber);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEISBN);
            panelERWholeElectronicEditionOptional.Controls.Add(tbERWEEDocumentType);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEEditionNumber);
            panelERWholeElectronicEditionOptional.Controls.Add(labelERWEEEditor);
            panelERWholeElectronicEditionOptional.Location = new Point(10, 22);
            panelERWholeElectronicEditionOptional.Name = "panelERWholeElectronicEditionOptional";
            panelERWholeElectronicEditionOptional.Size = new Size(473, 302);
            panelERWholeElectronicEditionOptional.TabIndex = 12;
            // 
            // labelERWEETranslator
            // 
            labelERWEETranslator.AutoSize = true;
            labelERWEETranslator.Location = new Point(0, 290);
            labelERWEETranslator.Name = "labelERWEETranslator";
            labelERWEETranslator.Size = new Size(74, 15);
            labelERWEETranslator.TabIndex = 35;
            labelERWEETranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelERWEETranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // tbERWEETranslator
            // 
            tbERWEETranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEETranslator.Location = new Point(0, 308);
            tbERWEETranslator.Name = "tbERWEETranslator";
            tbERWEETranslator.Size = new Size(450, 23);
            tbERWEETranslator.TabIndex = 31;
            ttMain.SetToolTip(tbERWEETranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            tbERWEETranslator.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEOrganization
            // 
            labelERWEEOrganization.AutoSize = true;
            labelERWEEOrganization.Location = new Point(0, 202);
            labelERWEEOrganization.Name = "labelERWEEOrganization";
            labelERWEEOrganization.Size = new Size(79, 15);
            labelERWEEOrganization.TabIndex = 33;
            labelERWEEOrganization.Text = "Организация";
            ttMain.SetToolTip(labelERWEEOrganization, "Организация, ответственная за публикацию.\r\nПример: «Российская академия наук»");
            // 
            // tbERWEEOrganization
            // 
            tbERWEEOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEOrganization.Location = new Point(0, 220);
            tbERWEEOrganization.Name = "tbERWEEOrganization";
            tbERWEEOrganization.Size = new Size(450, 23);
            tbERWEEOrganization.TabIndex = 29;
            ttMain.SetToolTip(tbERWEEOrganization, "Организация, ответственная за публикацию.\r\nПример: «Российская академия наук»");
            tbERWEEOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEParallelTitle
            // 
            labelERWEEParallelTitle.AutoSize = true;
            labelERWEEParallelTitle.Location = new Point(0, 0);
            labelERWEEParallelTitle.Name = "labelERWEEParallelTitle";
            labelERWEEParallelTitle.Size = new Size(139, 15);
            labelERWEEParallelTitle.TabIndex = 31;
            labelERWEEParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelERWEEParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbERWEEParallelTitle
            // 
            tbERWEEParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEParallelTitle.Location = new Point(0, 18);
            tbERWEEParallelTitle.Name = "tbERWEEParallelTitle";
            tbERWEEParallelTitle.Size = new Size(450, 23);
            tbERWEEParallelTitle.TabIndex = 24;
            ttMain.SetToolTip(tbERWEEParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbERWEEParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEContentType
            // 
            labelERWEEContentType.AutoSize = true;
            labelERWEEContentType.Location = new Point(0, 466);
            labelERWEEContentType.Name = "labelERWEEContentType";
            labelERWEEContentType.Size = new Size(97, 15);
            labelERWEEContentType.TabIndex = 24;
            labelERWEEContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelERWEEContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbERWEEContentType
            // 
            tbERWEEContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEContentType.Location = new Point(0, 484);
            tbERWEEContentType.Name = "tbERWEEContentType";
            tbERWEEContentType.Size = new Size(450, 23);
            tbERWEEContentType.TabIndex = 35;
            ttMain.SetToolTip(tbERWEEContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbERWEEContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // cbERWEEEditorType
            // 
            cbERWEEEditorType.BackColor = SystemColors.Window;
            cbERWEEEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbERWEEEditorType.FormattingEnabled = true;
            cbERWEEEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbERWEEEditorType.Location = new Point(194, 106);
            cbERWEEEditorType.Name = "cbERWEEEditorType";
            cbERWEEEditorType.Size = new Size(160, 23);
            cbERWEEEditorType.TabIndex = 27;
            // 
            // lbERWEEEditor
            // 
            lbERWEEEditor.AllowDrop = true;
            lbERWEEEditor.ContextMenuStrip = cmsListBox;
            lbERWEEEditor.ItemHeight = 15;
            lbERWEEEditor.Location = new Point(0, 135);
            lbERWEEEditor.Name = "lbERWEEEditor";
            lbERWEEEditor.Size = new Size(450, 64);
            lbERWEEEditor.TabIndex = 22;
            lbERWEEEditor.TabStop = false;
            lbERWEEEditor.DragDrop += this.ListBox_DragDrop;
            lbERWEEEditor.DragOver += this.ListBox_DragOver;
            lbERWEEEditor.KeyDown += this.ListBox_KeyDown;
            lbERWEEEditor.MouseDown += this.ListBox_MouseDown;
            lbERWEEEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERWEEEditorAdd
            // 
            buttonERWEEEditorAdd.Location = new Point(360, 106);
            buttonERWEEEditorAdd.Name = "buttonERWEEEditorAdd";
            buttonERWEEEditorAdd.Size = new Size(90, 23);
            buttonERWEEEditorAdd.TabIndex = 28;
            buttonERWEEEditorAdd.Text = "Добавить";
            buttonERWEEEditorAdd.UseVisualStyleBackColor = true;
            buttonERWEEEditorAdd.Click += this.buttonERWEEEditorAdd_Click;
            // 
            // labelERWEEDocumentType
            // 
            labelERWEEDocumentType.AutoSize = true;
            labelERWEEDocumentType.Location = new Point(0, 44);
            labelERWEEDocumentType.Name = "labelERWEEDocumentType";
            labelERWEEDocumentType.Size = new Size(88, 15);
            labelERWEEDocumentType.TabIndex = 0;
            labelERWEEDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelERWEEDocumentType, "Тип документа (монография, сборник, энциклопедия и т. д.).\r\nПример: «монография»");
            // 
            // tbERWEEISBN
            // 
            tbERWEEISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEISBN.Location = new Point(0, 440);
            tbERWEEISBN.Name = "tbERWEEISBN";
            tbERWEEISBN.Size = new Size(450, 23);
            tbERWEEISBN.TabIndex = 34;
            ttMain.SetToolTip(tbERWEEISBN, "Международный стандартный номер книги.\r\nПример: «978-5-288-06543-1»");
            tbERWEEISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEESeries
            // 
            labelERWEESeries.AutoSize = true;
            labelERWEESeries.Location = new Point(0, 378);
            labelERWEESeries.Name = "labelERWEESeries";
            labelERWEESeries.Size = new Size(41, 15);
            labelERWEESeries.TabIndex = 8;
            labelERWEESeries.Text = "Серия";
            ttMain.SetToolTip(labelERWEESeries, "Серия, в рамках которой выпущено издание.\r\nПример: «Классика философской мысли»");
            // 
            // tbERWEEEditor
            // 
            tbERWEEEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEEditor.Location = new Point(0, 106);
            tbERWEEEditor.Name = "tbERWEEEditor";
            tbERWEEEditor.Size = new Size(188, 23);
            tbERWEEEditor.TabIndex = 26;
            ttMain.SetToolTip(tbERWEEEditor, resources.GetString("tbERWEEEditor.ToolTip"));
            tbERWEEEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEPagesCount
            // 
            labelERWEEPagesCount.AutoSize = true;
            labelERWEEPagesCount.Location = new Point(0, 334);
            labelERWEEPagesCount.Name = "labelERWEEPagesCount";
            labelERWEEPagesCount.Size = new Size(120, 15);
            labelERWEEPagesCount.TabIndex = 14;
            labelERWEEPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelERWEEPagesCount, "Общее количество страниц во всех томах.\r\nПример: «1200»");
            // 
            // tbERWEESeries
            // 
            tbERWEESeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEESeries.Location = new Point(0, 396);
            tbERWEESeries.Name = "tbERWEESeries";
            tbERWEESeries.Size = new Size(450, 23);
            tbERWEESeries.TabIndex = 33;
            ttMain.SetToolTip(tbERWEESeries, "Серия, в рамках которой выпущено издание.\r\nПример: «Классика философской мысли»");
            tbERWEESeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWEEPagesCount
            // 
            tbERWEEPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEPagesCount.Location = new Point(0, 352);
            tbERWEEPagesCount.Name = "tbERWEEPagesCount";
            tbERWEEPagesCount.Size = new Size(450, 23);
            tbERWEEPagesCount.TabIndex = 32;
            ttMain.SetToolTip(tbERWEEPagesCount, "Общее количество страниц во всех томах.\r\nПример: «1200»\r\n");
            tbERWEEPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWEEEditionNumber
            // 
            tbERWEEEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEEditionNumber.Location = new Point(0, 264);
            tbERWEEEditionNumber.Name = "tbERWEEEditionNumber";
            tbERWEEEditionNumber.Size = new Size(450, 23);
            tbERWEEEditionNumber.TabIndex = 30;
            ttMain.SetToolTip(tbERWEEEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            tbERWEEEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEISBN
            // 
            labelERWEEISBN.AutoSize = true;
            labelERWEEISBN.Location = new Point(0, 422);
            labelERWEEISBN.Name = "labelERWEEISBN";
            labelERWEEISBN.Size = new Size(32, 15);
            labelERWEEISBN.TabIndex = 10;
            labelERWEEISBN.Text = "ISBN";
            ttMain.SetToolTip(labelERWEEISBN, "Международный стандартный номер книги.\r\nПример: «978-5-288-06543-1»");
            // 
            // tbERWEEDocumentType
            // 
            tbERWEEDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWEEDocumentType.Location = new Point(0, 62);
            tbERWEEDocumentType.Name = "tbERWEEDocumentType";
            tbERWEEDocumentType.Size = new Size(450, 23);
            tbERWEEDocumentType.TabIndex = 25;
            ttMain.SetToolTip(tbERWEEDocumentType, "Тип документа (монография, сборник, энциклопедия и т. д.).\r\nПример: «монография»");
            tbERWEEDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWEEEditionNumber
            // 
            labelERWEEEditionNumber.AutoSize = true;
            labelERWEEEditionNumber.Location = new Point(0, 246);
            labelERWEEEditionNumber.Name = "labelERWEEEditionNumber";
            labelERWEEEditionNumber.Size = new Size(92, 15);
            labelERWEEEditionNumber.TabIndex = 6;
            labelERWEEEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelERWEEEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            // 
            // labelERWEEEditor
            // 
            labelERWEEEditor.AutoSize = true;
            labelERWEEEditor.Location = new Point(0, 88);
            labelERWEEEditor.Name = "labelERWEEEditor";
            labelERWEEEditor.Size = new Size(74, 15);
            labelERWEEEditor.TabIndex = 4;
            labelERWEEEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelERWEEEditor, resources.GetString("labelERWEEEditor.ToolTip"));
            // 
            // tpERElectronicEditionSeparateVolume
            // 
            tpERElectronicEditionSeparateVolume.BackColor = SystemColors.Control;
            tpERElectronicEditionSeparateVolume.Controls.Add(gbERElectronicEditionSeparateVolumeRequired);
            tpERElectronicEditionSeparateVolume.Controls.Add(gbERElectronicEditionSeparateVolumeOptional);
            tpERElectronicEditionSeparateVolume.Location = new Point(4, 24);
            tpERElectronicEditionSeparateVolume.Name = "tpERElectronicEditionSeparateVolume";
            tpERElectronicEditionSeparateVolume.Size = new Size(505, 681);
            tpERElectronicEditionSeparateVolume.TabIndex = 5;
            tpERElectronicEditionSeparateVolume.Text = "Отдельный том электронного издания";
            // 
            // gbERElectronicEditionSeparateVolumeRequired
            // 
            gbERElectronicEditionSeparateVolumeRequired.Controls.Add(panelERElectronicEditionSeparateVolumeRequired);
            gbERElectronicEditionSeparateVolumeRequired.Location = new Point(10, 10);
            gbERElectronicEditionSeparateVolumeRequired.Name = "gbERElectronicEditionSeparateVolumeRequired";
            gbERElectronicEditionSeparateVolumeRequired.Size = new Size(488, 330);
            gbERElectronicEditionSeparateVolumeRequired.TabIndex = 4;
            gbERElectronicEditionSeparateVolumeRequired.TabStop = false;
            gbERElectronicEditionSeparateVolumeRequired.Text = "Обязательные поля";
            // 
            // panelERElectronicEditionSeparateVolumeRequired
            // 
            panelERElectronicEditionSeparateVolumeRequired.AutoScroll = true;
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(lbEREESVPublishingLocationSelect);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(cbEREESVPublisher);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVVolumeNumber);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVVolumeNumber);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVAccessMode);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVAccessMode);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVAccessDate);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVAccessDate);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVURL);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVURL);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(cbEREESVAuthors);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(buttonEREESVPublisherAdd);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(lbEREESVPublisher);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(buttonEREESVPublishingLocationAdd);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(lbEREESVPublishingLocation);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVAuthors);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVPublishYear);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVPublishYear);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVAuthors);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVPublisher);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(buttonEREESVAuthorsAdd);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVPublisher);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(lbEREESVAuthors);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVPublishingLocation);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVTitle);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVPublishingLocation);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVTitle);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(tbEREESVVolumesCount);
            panelERElectronicEditionSeparateVolumeRequired.Controls.Add(labelEREESVVolumesCount);
            panelERElectronicEditionSeparateVolumeRequired.Location = new Point(10, 22);
            panelERElectronicEditionSeparateVolumeRequired.Name = "panelERElectronicEditionSeparateVolumeRequired";
            panelERElectronicEditionSeparateVolumeRequired.Size = new Size(473, 302);
            panelERElectronicEditionSeparateVolumeRequired.TabIndex = 0;
            // 
            // lbEREESVPublishingLocationSelect
            // 
            lbEREESVPublishingLocationSelect.Enabled = false;
            lbEREESVPublishingLocationSelect.FormattingEnabled = true;
            lbEREESVPublishingLocationSelect.ItemHeight = 15;
            lbEREESVPublishingLocationSelect.Location = new Point(243, 407);
            lbEREESVPublishingLocationSelect.Name = "lbEREESVPublishingLocationSelect";
            lbEREESVPublishingLocationSelect.Size = new Size(207, 64);
            lbEREESVPublishingLocationSelect.TabIndex = 39;
            lbEREESVPublishingLocationSelect.TabStop = false;
            lbEREESVPublishingLocationSelect.SelectedIndexChanged += this.lbEREESVPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbEREESVPublisher
            // 
            cbEREESVPublisher.AutoSize = true;
            cbEREESVPublisher.Location = new Point(339, 380);
            cbEREESVPublisher.Name = "cbEREESVPublisher";
            cbEREESVPublisher.Size = new Size(111, 19);
            cbEREESVPublisher.TabIndex = 20;
            cbEREESVPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbEREESVPublisher, "Включение «умного режима» добавления издательств\r\n\r\n");
            cbEREESVPublisher.UseVisualStyleBackColor = true;
            cbEREESVPublisher.CheckedChanged += this.cbEREESVPublisher_CheckedChanged;
            // 
            // tbEREESVVolumeNumber
            // 
            tbEREESVVolumeNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVVolumeNumber.Location = new Point(0, 220);
            tbEREESVVolumeNumber.Name = "tbEREESVVolumeNumber";
            tbEREESVVolumeNumber.Size = new Size(450, 23);
            tbEREESVVolumeNumber.TabIndex = 15;
            ttMain.SetToolTip(tbEREESVVolumeNumber, "Номер конкретного тома, к которому относится описание.\r\nПример: «3»");
            tbEREESVVolumeNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVVolumeNumber
            // 
            labelEREESVVolumeNumber.AutoSize = true;
            labelEREESVVolumeNumber.Location = new Point(0, 202);
            labelEREESVVolumeNumber.Name = "labelEREESVVolumeNumber";
            labelEREESVVolumeNumber.Size = new Size(75, 15);
            labelEREESVVolumeNumber.TabIndex = 27;
            labelEREESVVolumeNumber.Text = "Номер тома";
            ttMain.SetToolTip(labelEREESVVolumeNumber, "Номер конкретного тома, к которому относится описание.\r\nПример: «3»");
            // 
            // tbEREESVAccessMode
            // 
            tbEREESVAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVAccessMode.Location = new Point(0, 624);
            tbEREESVAccessMode.Name = "tbEREESVAccessMode";
            tbEREESVAccessMode.Size = new Size(450, 23);
            tbEREESVAccessMode.TabIndex = 24;
            ttMain.SetToolTip(tbEREESVAccessMode, "Условия доступа к файлу (например, «свободный», «ограниченный»).\r\nПример: «свободный»");
            // 
            // labelEREESVAccessMode
            // 
            labelEREESVAccessMode.AutoSize = true;
            labelEREESVAccessMode.Location = new Point(0, 606);
            labelEREESVAccessMode.Name = "labelEREESVAccessMode";
            labelEREESVAccessMode.Size = new Size(91, 15);
            labelEREESVAccessMode.TabIndex = 25;
            labelEREESVAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelEREESVAccessMode, "Условия доступа к файлу (например, «свободный», «ограниченный»).\r\nПример: «свободный»");
            // 
            // tbEREESVAccessDate
            // 
            tbEREESVAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVAccessDate.Location = new Point(0, 580);
            tbEREESVAccessDate.Name = "tbEREESVAccessDate";
            tbEREESVAccessDate.Size = new Size(450, 23);
            tbEREESVAccessDate.TabIndex = 23;
            ttMain.SetToolTip(tbEREESVAccessDate, "Дата, когда был произведён просмотр по ссылке.\r\nПример: «20.06.2025»");
            tbEREESVAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVAccessDate
            // 
            labelEREESVAccessDate.AutoSize = true;
            labelEREESVAccessDate.Location = new Point(0, 562);
            labelEREESVAccessDate.Name = "labelEREESVAccessDate";
            labelEREESVAccessDate.Size = new Size(99, 15);
            labelEREESVAccessDate.TabIndex = 23;
            labelEREESVAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelEREESVAccessDate, "Дата, когда был произведён просмотр по ссылке.\r\nПример: «20.06.2025»");
            // 
            // tbEREESVURL
            // 
            tbEREESVURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVURL.Location = new Point(0, 536);
            tbEREESVURL.Name = "tbEREESVURL";
            tbEREESVURL.Size = new Size(450, 23);
            tbEREESVURL.TabIndex = 22;
            ttMain.SetToolTip(tbEREESVURL, "Ссылка на электронную версию тома.\r\nПример: «https://lib.example.org/history_vol3.pdf»");
            tbEREESVURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVURL
            // 
            labelEREESVURL.AutoSize = true;
            labelEREESVURL.Location = new Point(0, 518);
            labelEREESVURL.Name = "labelEREESVURL";
            labelEREESVURL.Size = new Size(28, 15);
            labelEREESVURL.TabIndex = 21;
            labelEREESVURL.Text = "URL";
            ttMain.SetToolTip(labelEREESVURL, "Ссылка на электронную версию тома.\r\nПример: «https://lib.example.org/history_vol3.pdf»");
            // 
            // cbEREESVAuthors
            // 
            cbEREESVAuthors.AutoSize = true;
            cbEREESVAuthors.Location = new Point(371, 20);
            cbEREESVAuthors.Name = "cbEREESVAuthors";
            cbEREESVAuthors.Size = new Size(79, 19);
            cbEREESVAuthors.TabIndex = 12;
            cbEREESVAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbEREESVAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbEREESVAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonEREESVPublisherAdd
            // 
            buttonEREESVPublisherAdd.Location = new Point(243, 378);
            buttonEREESVPublisherAdd.Name = "buttonEREESVPublisherAdd";
            buttonEREESVPublisherAdd.Size = new Size(90, 23);
            buttonEREESVPublisherAdd.TabIndex = 19;
            buttonEREESVPublisherAdd.Text = "Добавить";
            buttonEREESVPublisherAdd.UseVisualStyleBackColor = true;
            buttonEREESVPublisherAdd.Click += this.buttonEREESVPublisherAdd_Click;
            // 
            // lbEREESVPublisher
            // 
            lbEREESVPublisher.AllowDrop = true;
            lbEREESVPublisher.ContextMenuStrip = cmsListBox;
            lbEREESVPublisher.ItemHeight = 15;
            lbEREESVPublisher.Location = new Point(0, 407);
            lbEREESVPublisher.Name = "lbEREESVPublisher";
            lbEREESVPublisher.Size = new Size(237, 64);
            lbEREESVPublisher.TabIndex = 19;
            lbEREESVPublisher.TabStop = false;
            lbEREESVPublisher.DragDrop += this.ListBox_DragDrop;
            lbEREESVPublisher.DragOver += this.ListBox_DragOver;
            lbEREESVPublisher.KeyDown += this.ListBox_KeyDown;
            lbEREESVPublisher.MouseDown += this.ListBox_MouseDown;
            lbEREESVPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonEREESVPublishingLocationAdd
            // 
            buttonEREESVPublishingLocationAdd.Location = new Point(360, 264);
            buttonEREESVPublishingLocationAdd.Name = "buttonEREESVPublishingLocationAdd";
            buttonEREESVPublishingLocationAdd.Size = new Size(90, 23);
            buttonEREESVPublishingLocationAdd.TabIndex = 17;
            buttonEREESVPublishingLocationAdd.Text = "Добавить";
            buttonEREESVPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonEREESVPublishingLocationAdd.Click += this.buttonEREESVPublishingLocationAdd_Click;
            // 
            // lbEREESVPublishingLocation
            // 
            lbEREESVPublishingLocation.AllowDrop = true;
            lbEREESVPublishingLocation.ContextMenuStrip = cmsListBox;
            lbEREESVPublishingLocation.ItemHeight = 15;
            lbEREESVPublishingLocation.Location = new Point(0, 293);
            lbEREESVPublishingLocation.Name = "lbEREESVPublishingLocation";
            lbEREESVPublishingLocation.Size = new Size(450, 64);
            lbEREESVPublishingLocation.TabIndex = 17;
            lbEREESVPublishingLocation.TabStop = false;
            lbEREESVPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbEREESVPublishingLocation.DragOver += this.ListBox_DragOver;
            lbEREESVPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbEREESVPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbEREESVPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // labelEREESVAuthors
            // 
            labelEREESVAuthors.AutoSize = true;
            labelEREESVAuthors.Location = new Point(0, 0);
            labelEREESVAuthors.Name = "labelEREESVAuthors";
            labelEREESVAuthors.Size = new Size(57, 15);
            labelEREESVAuthors.TabIndex = 0;
            labelEREESVAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelEREESVAuthors, resources.GetString("labelEREESVAuthors.ToolTip"));
            // 
            // tbEREESVPublishYear
            // 
            tbEREESVPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVPublishYear.Location = new Point(0, 492);
            tbEREESVPublishYear.Name = "tbEREESVPublishYear";
            tbEREESVPublishYear.Size = new Size(450, 23);
            tbEREESVPublishYear.TabIndex = 21;
            ttMain.SetToolTip(tbEREESVPublishYear, "Год выхода тома.\r\nПример: «2021»");
            tbEREESVPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVPublishYear
            // 
            labelEREESVPublishYear.AutoSize = true;
            labelEREESVPublishYear.Location = new Point(0, 474);
            labelEREESVPublishYear.Name = "labelEREESVPublishYear";
            labelEREESVPublishYear.Size = new Size(73, 15);
            labelEREESVPublishYear.TabIndex = 12;
            labelEREESVPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelEREESVPublishYear, "Год выхода тома.\r\nПример: «2021»");
            // 
            // tbEREESVAuthors
            // 
            tbEREESVAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVAuthors.Location = new Point(0, 18);
            tbEREESVAuthors.Name = "tbEREESVAuthors";
            tbEREESVAuthors.Size = new Size(269, 23);
            tbEREESVAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbEREESVAuthors, resources.GetString("tbEREESVAuthors.ToolTip"));
            tbEREESVAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREESVPublisher
            // 
            tbEREESVPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVPublisher.Location = new Point(0, 378);
            tbEREESVPublisher.Name = "tbEREESVPublisher";
            tbEREESVPublisher.Size = new Size(237, 23);
            tbEREESVPublisher.TabIndex = 18;
            ttMain.SetToolTip(tbEREESVPublisher, resources.GetString("tbEREESVPublisher.ToolTip"));
            tbEREESVPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonEREESVAuthorsAdd
            // 
            buttonEREESVAuthorsAdd.Location = new Point(275, 18);
            buttonEREESVAuthorsAdd.Name = "buttonEREESVAuthorsAdd";
            buttonEREESVAuthorsAdd.Size = new Size(90, 23);
            buttonEREESVAuthorsAdd.TabIndex = 11;
            buttonEREESVAuthorsAdd.Text = "Добавить";
            buttonEREESVAuthorsAdd.UseVisualStyleBackColor = true;
            buttonEREESVAuthorsAdd.Click += this.buttonEREESVAuthorsAdd_Click;
            // 
            // labelEREESVPublisher
            // 
            labelEREESVPublisher.AutoSize = true;
            labelEREESVPublisher.Location = new Point(0, 360);
            labelEREESVPublisher.Name = "labelEREESVPublisher";
            labelEREESVPublisher.Size = new Size(81, 15);
            labelEREESVPublisher.TabIndex = 10;
            labelEREESVPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelEREESVPublisher, resources.GetString("labelEREESVPublisher.ToolTip"));
            // 
            // lbEREESVAuthors
            // 
            lbEREESVAuthors.AllowDrop = true;
            lbEREESVAuthors.ContextMenuStrip = cmsListBox;
            lbEREESVAuthors.ItemHeight = 15;
            lbEREESVAuthors.Location = new Point(0, 47);
            lbEREESVAuthors.Name = "lbEREESVAuthors";
            lbEREESVAuthors.Size = new Size(450, 64);
            lbEREESVAuthors.TabIndex = 3;
            lbEREESVAuthors.TabStop = false;
            lbEREESVAuthors.Tag = "";
            lbEREESVAuthors.DragDrop += this.ListBox_DragDrop;
            lbEREESVAuthors.DragOver += this.ListBox_DragOver;
            lbEREESVAuthors.KeyDown += this.ListBox_KeyDown;
            lbEREESVAuthors.MouseDown += this.ListBox_MouseDown;
            lbEREESVAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbEREESVPublishingLocation
            // 
            tbEREESVPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVPublishingLocation.Location = new Point(0, 264);
            tbEREESVPublishingLocation.Name = "tbEREESVPublishingLocation";
            tbEREESVPublishingLocation.Size = new Size(354, 23);
            tbEREESVPublishingLocation.TabIndex = 16;
            ttMain.SetToolTip(tbEREESVPublishingLocation, "Город или города, где издание опубликовано.\r\nПример: «Москва»");
            tbEREESVPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVTitle
            // 
            labelEREESVTitle.AutoSize = true;
            labelEREESVTitle.Location = new Point(0, 114);
            labelEREESVTitle.Name = "labelEREESVTitle";
            labelEREESVTitle.Size = new Size(57, 15);
            labelEREESVTitle.TabIndex = 4;
            labelEREESVTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelEREESVTitle, "Название всего издания (всех томов).\r\nПример: «История Европы»");
            // 
            // labelEREESVPublishingLocation
            // 
            labelEREESVPublishingLocation.AutoSize = true;
            labelEREESVPublishingLocation.Location = new Point(0, 246);
            labelEREESVPublishingLocation.Name = "labelEREESVPublishingLocation";
            labelEREESVPublishingLocation.Size = new Size(89, 15);
            labelEREESVPublishingLocation.TabIndex = 8;
            labelEREESVPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelEREESVPublishingLocation, "Город или города, где издание опубликовано.\r\nПример: «Москва»");
            // 
            // tbEREESVTitle
            // 
            tbEREESVTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVTitle.Location = new Point(0, 132);
            tbEREESVTitle.Name = "tbEREESVTitle";
            tbEREESVTitle.Size = new Size(450, 23);
            tbEREESVTitle.TabIndex = 13;
            ttMain.SetToolTip(tbEREESVTitle, "Название всего издания (всех томов).\r\nПример: «История Европы»");
            tbEREESVTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREESVVolumesCount
            // 
            tbEREESVVolumesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVVolumesCount.Location = new Point(0, 176);
            tbEREESVVolumesCount.Name = "tbEREESVVolumesCount";
            tbEREESVVolumesCount.Size = new Size(450, 23);
            tbEREESVVolumesCount.TabIndex = 14;
            ttMain.SetToolTip(tbEREESVVolumesCount, "Общее число томов в издании.\r\nПример: «6»");
            tbEREESVVolumesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVVolumesCount
            // 
            labelEREESVVolumesCount.AutoSize = true;
            labelEREESVVolumesCount.Location = new Point(0, 158);
            labelEREESVVolumesCount.Name = "labelEREESVVolumesCount";
            labelEREESVVolumesCount.Size = new Size(109, 15);
            labelEREESVVolumesCount.TabIndex = 6;
            labelEREESVVolumesCount.Text = "Количество томов";
            ttMain.SetToolTip(labelEREESVVolumesCount, "Общее число томов в издании.\r\nПример: «6»");
            // 
            // gbERElectronicEditionSeparateVolumeOptional
            // 
            gbERElectronicEditionSeparateVolumeOptional.Controls.Add(panelERElectronicEditionSeparateVolumeOptional);
            gbERElectronicEditionSeparateVolumeOptional.Location = new Point(10, 346);
            gbERElectronicEditionSeparateVolumeOptional.Name = "gbERElectronicEditionSeparateVolumeOptional";
            gbERElectronicEditionSeparateVolumeOptional.Size = new Size(488, 330);
            gbERElectronicEditionSeparateVolumeOptional.TabIndex = 5;
            gbERElectronicEditionSeparateVolumeOptional.TabStop = false;
            gbERElectronicEditionSeparateVolumeOptional.Text = "Необязательные поля";
            // 
            // panelERElectronicEditionSeparateVolumeOptional
            // 
            panelERElectronicEditionSeparateVolumeOptional.AutoScroll = true;
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVVolumeTitle);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVVolumeTitle);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVTranslator);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVTranslator);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVOrganization);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVOrganization);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVParallelTitle);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVParallelTitle);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVContentType);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVContentType);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(cbEREESVEditorType);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(lbEREESVEditor);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(buttonEREESVEditorAdd);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVDocumentType);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVISBN);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVSeries);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVEditor);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVPagesCount);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVSeries);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVPagesCount);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVEditionNumber);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVISBN);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(tbEREESVDocumentType);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVEditionNumber);
            panelERElectronicEditionSeparateVolumeOptional.Controls.Add(labelEREESVEditor);
            panelERElectronicEditionSeparateVolumeOptional.Location = new Point(10, 22);
            panelERElectronicEditionSeparateVolumeOptional.Name = "panelERElectronicEditionSeparateVolumeOptional";
            panelERElectronicEditionSeparateVolumeOptional.Size = new Size(473, 302);
            panelERElectronicEditionSeparateVolumeOptional.TabIndex = 12;
            // 
            // tbEREESVVolumeTitle
            // 
            tbEREESVVolumeTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVVolumeTitle.Location = new Point(0, 62);
            tbEREESVVolumeTitle.Name = "tbEREESVVolumeTitle";
            tbEREESVVolumeTitle.Size = new Size(450, 23);
            tbEREESVVolumeTitle.TabIndex = 26;
            ttMain.SetToolTip(tbEREESVVolumeTitle, "Уточнение, чему посвящён конкретный том.\r\nПример: «Средневековье»");
            tbEREESVVolumeTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVVolumeTitle
            // 
            labelEREESVVolumeTitle.AutoSize = true;
            labelEREESVVolumeTitle.Location = new Point(0, 44);
            labelEREESVVolumeTitle.Name = "labelEREESVVolumeTitle";
            labelEREESVVolumeTitle.Size = new Size(87, 15);
            labelEREESVVolumeTitle.TabIndex = 37;
            labelEREESVVolumeTitle.Text = "Заглавие тома";
            ttMain.SetToolTip(labelEREESVVolumeTitle, "Уточнение, чему посвящён конкретный том.\r\nПример: «Средневековье»");
            // 
            // labelEREESVTranslator
            // 
            labelEREESVTranslator.AutoSize = true;
            labelEREESVTranslator.Location = new Point(0, 334);
            labelEREESVTranslator.Name = "labelEREESVTranslator";
            labelEREESVTranslator.Size = new Size(74, 15);
            labelEREESVTranslator.TabIndex = 35;
            labelEREESVTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelEREESVTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // tbEREESVTranslator
            // 
            tbEREESVTranslator.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVTranslator.Location = new Point(0, 352);
            tbEREESVTranslator.Name = "tbEREESVTranslator";
            tbEREESVTranslator.Size = new Size(450, 23);
            tbEREESVTranslator.TabIndex = 33;
            ttMain.SetToolTip(tbEREESVTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            tbEREESVTranslator.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVOrganization
            // 
            labelEREESVOrganization.AutoSize = true;
            labelEREESVOrganization.Location = new Point(0, 246);
            labelEREESVOrganization.Name = "labelEREESVOrganization";
            labelEREESVOrganization.Size = new Size(79, 15);
            labelEREESVOrganization.TabIndex = 33;
            labelEREESVOrganization.Text = "Организация";
            ttMain.SetToolTip(labelEREESVOrganization, "Организация, ответственная за публикацию.\r\nПример: «Институт всеобщей истории РАН»");
            // 
            // tbEREESVOrganization
            // 
            tbEREESVOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVOrganization.Location = new Point(0, 264);
            tbEREESVOrganization.Name = "tbEREESVOrganization";
            tbEREESVOrganization.Size = new Size(450, 23);
            tbEREESVOrganization.TabIndex = 31;
            ttMain.SetToolTip(tbEREESVOrganization, "Организация, ответственная за публикацию.\r\nПример: «Институт всеобщей истории РАН»");
            tbEREESVOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVParallelTitle
            // 
            labelEREESVParallelTitle.AutoSize = true;
            labelEREESVParallelTitle.Location = new Point(0, 0);
            labelEREESVParallelTitle.Name = "labelEREESVParallelTitle";
            labelEREESVParallelTitle.Size = new Size(139, 15);
            labelEREESVParallelTitle.TabIndex = 31;
            labelEREESVParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelEREESVParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbEREESVParallelTitle
            // 
            tbEREESVParallelTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVParallelTitle.Location = new Point(0, 18);
            tbEREESVParallelTitle.Name = "tbEREESVParallelTitle";
            tbEREESVParallelTitle.Size = new Size(450, 23);
            tbEREESVParallelTitle.TabIndex = 25;
            ttMain.SetToolTip(tbEREESVParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            tbEREESVParallelTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVContentType
            // 
            labelEREESVContentType.AutoSize = true;
            labelEREESVContentType.Location = new Point(0, 510);
            labelEREESVContentType.Name = "labelEREESVContentType";
            labelEREESVContentType.Size = new Size(97, 15);
            labelEREESVContentType.TabIndex = 24;
            labelEREESVContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelEREESVContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            // 
            // tbEREESVContentType
            // 
            tbEREESVContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVContentType.Location = new Point(0, 528);
            tbEREESVContentType.Name = "tbEREESVContentType";
            tbEREESVContentType.Size = new Size(450, 23);
            tbEREESVContentType.TabIndex = 37;
            ttMain.SetToolTip(tbEREESVContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbEREESVContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // cbEREESVEditorType
            // 
            cbEREESVEditorType.BackColor = SystemColors.Window;
            cbEREESVEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEREESVEditorType.FormattingEnabled = true;
            cbEREESVEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbEREESVEditorType.Location = new Point(194, 150);
            cbEREESVEditorType.Name = "cbEREESVEditorType";
            cbEREESVEditorType.Size = new Size(160, 23);
            cbEREESVEditorType.TabIndex = 29;
            // 
            // lbEREESVEditor
            // 
            lbEREESVEditor.AllowDrop = true;
            lbEREESVEditor.ContextMenuStrip = cmsListBox;
            lbEREESVEditor.ItemHeight = 15;
            lbEREESVEditor.Location = new Point(0, 179);
            lbEREESVEditor.Name = "lbEREESVEditor";
            lbEREESVEditor.Size = new Size(450, 64);
            lbEREESVEditor.TabIndex = 22;
            lbEREESVEditor.TabStop = false;
            lbEREESVEditor.DragDrop += this.ListBox_DragDrop;
            lbEREESVEditor.DragOver += this.ListBox_DragOver;
            lbEREESVEditor.KeyDown += this.ListBox_KeyDown;
            lbEREESVEditor.MouseDown += this.ListBox_MouseDown;
            lbEREESVEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonEREESVEditorAdd
            // 
            buttonEREESVEditorAdd.Location = new Point(360, 150);
            buttonEREESVEditorAdd.Name = "buttonEREESVEditorAdd";
            buttonEREESVEditorAdd.Size = new Size(90, 23);
            buttonEREESVEditorAdd.TabIndex = 30;
            buttonEREESVEditorAdd.Text = "Добавить";
            buttonEREESVEditorAdd.UseVisualStyleBackColor = true;
            buttonEREESVEditorAdd.Click += this.buttonEREESVEditorAdd_Click;
            // 
            // labelEREESVDocumentType
            // 
            labelEREESVDocumentType.AutoSize = true;
            labelEREESVDocumentType.Location = new Point(0, 88);
            labelEREESVDocumentType.Name = "labelEREESVDocumentType";
            labelEREESVDocumentType.Size = new Size(88, 15);
            labelEREESVDocumentType.TabIndex = 0;
            labelEREESVDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelEREESVDocumentType, "Тип материала: монография, сборник и т. д.\r\nПример: «монография»");
            // 
            // tbEREESVISBN
            // 
            tbEREESVISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVISBN.Location = new Point(0, 484);
            tbEREESVISBN.Name = "tbEREESVISBN";
            tbEREESVISBN.Size = new Size(450, 23);
            tbEREESVISBN.TabIndex = 36;
            ttMain.SetToolTip(tbEREESVISBN, "Международный номер книги.\r\nПример: «978-5-4461-1234-6»");
            tbEREESVISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVSeries
            // 
            labelEREESVSeries.AutoSize = true;
            labelEREESVSeries.Location = new Point(0, 422);
            labelEREESVSeries.Name = "labelEREESVSeries";
            labelEREESVSeries.Size = new Size(41, 15);
            labelEREESVSeries.TabIndex = 8;
            labelEREESVSeries.Text = "Серия";
            ttMain.SetToolTip(labelEREESVSeries, "Наименование серии, если книга входит в неё.\r\nПример: «Историческая библиотека»");
            // 
            // tbEREESVEditor
            // 
            tbEREESVEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVEditor.Location = new Point(0, 150);
            tbEREESVEditor.Name = "tbEREESVEditor";
            tbEREESVEditor.Size = new Size(188, 23);
            tbEREESVEditor.TabIndex = 28;
            ttMain.SetToolTip(tbEREESVEditor, resources.GetString("tbEREESVEditor.ToolTip"));
            tbEREESVEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVPagesCount
            // 
            labelEREESVPagesCount.AutoSize = true;
            labelEREESVPagesCount.Location = new Point(0, 378);
            labelEREESVPagesCount.Name = "labelEREESVPagesCount";
            labelEREESVPagesCount.Size = new Size(120, 15);
            labelEREESVPagesCount.TabIndex = 14;
            labelEREESVPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelEREESVPagesCount, "Общее количество страниц в томе.\r\nПример: «320»");
            // 
            // tbEREESVSeries
            // 
            tbEREESVSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVSeries.Location = new Point(0, 440);
            tbEREESVSeries.Name = "tbEREESVSeries";
            tbEREESVSeries.Size = new Size(450, 23);
            tbEREESVSeries.TabIndex = 35;
            ttMain.SetToolTip(tbEREESVSeries, "Наименование серии, если книга входит в неё.\r\nПример: «Историческая библиотека»");
            tbEREESVSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREESVPagesCount
            // 
            tbEREESVPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVPagesCount.Location = new Point(0, 396);
            tbEREESVPagesCount.Name = "tbEREESVPagesCount";
            tbEREESVPagesCount.Size = new Size(450, 23);
            tbEREESVPagesCount.TabIndex = 34;
            ttMain.SetToolTip(tbEREESVPagesCount, "Общее количество страниц в томе.\r\nПример: «320»\r\n");
            tbEREESVPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREESVEditionNumber
            // 
            tbEREESVEditionNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVEditionNumber.Location = new Point(0, 308);
            tbEREESVEditionNumber.Name = "tbEREESVEditionNumber";
            tbEREESVEditionNumber.Size = new Size(450, 23);
            tbEREESVEditionNumber.TabIndex = 32;
            ttMain.SetToolTip(tbEREESVEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            tbEREESVEditionNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVISBN
            // 
            labelEREESVISBN.AutoSize = true;
            labelEREESVISBN.Location = new Point(0, 466);
            labelEREESVISBN.Name = "labelEREESVISBN";
            labelEREESVISBN.Size = new Size(32, 15);
            labelEREESVISBN.TabIndex = 10;
            labelEREESVISBN.Text = "ISBN";
            ttMain.SetToolTip(labelEREESVISBN, "Международный номер книги.\r\nПример: «978-5-4461-1234-6»");
            // 
            // tbEREESVDocumentType
            // 
            tbEREESVDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREESVDocumentType.Location = new Point(0, 106);
            tbEREESVDocumentType.Name = "tbEREESVDocumentType";
            tbEREESVDocumentType.Size = new Size(450, 23);
            tbEREESVDocumentType.TabIndex = 27;
            ttMain.SetToolTip(tbEREESVDocumentType, "Тип материала: монография, сборник и т. д.\r\nПример: «монография»");
            tbEREESVDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREESVEditionNumber
            // 
            labelEREESVEditionNumber.AutoSize = true;
            labelEREESVEditionNumber.Location = new Point(0, 290);
            labelEREESVEditionNumber.Name = "labelEREESVEditionNumber";
            labelEREESVEditionNumber.Size = new Size(92, 15);
            labelEREESVEditionNumber.TabIndex = 6;
            labelEREESVEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelEREESVEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".\r\n");
            // 
            // labelEREESVEditor
            // 
            labelEREESVEditor.AutoSize = true;
            labelEREESVEditor.Location = new Point(0, 132);
            labelEREESVEditor.Name = "labelEREESVEditor";
            labelEREESVEditor.Size = new Size(74, 15);
            labelEREESVEditor.TabIndex = 4;
            labelEREESVEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelEREESVEditor, resources.GetString("labelEREESVEditor.ToolTip"));
            // 
            // tpERElectronicConferenceMaterials
            // 
            tpERElectronicConferenceMaterials.BackColor = SystemColors.Control;
            tpERElectronicConferenceMaterials.Controls.Add(gbERElectronicConferenceMaterialsRequired);
            tpERElectronicConferenceMaterials.Controls.Add(gbERElectronicConferenceMaterialsOptional);
            tpERElectronicConferenceMaterials.Location = new Point(4, 24);
            tpERElectronicConferenceMaterials.Name = "tpERElectronicConferenceMaterials";
            tpERElectronicConferenceMaterials.Size = new Size(505, 681);
            tpERElectronicConferenceMaterials.TabIndex = 6;
            tpERElectronicConferenceMaterials.Text = "Электронные материалы конференций";
            // 
            // gbERElectronicConferenceMaterialsRequired
            // 
            gbERElectronicConferenceMaterialsRequired.Controls.Add(panelERElectronicConferenceMaterialsRequired);
            gbERElectronicConferenceMaterialsRequired.Location = new Point(10, 10);
            gbERElectronicConferenceMaterialsRequired.Name = "gbERElectronicConferenceMaterialsRequired";
            gbERElectronicConferenceMaterialsRequired.Size = new Size(488, 330);
            gbERElectronicConferenceMaterialsRequired.TabIndex = 4;
            gbERElectronicConferenceMaterialsRequired.TabStop = false;
            gbERElectronicConferenceMaterialsRequired.Text = "Обязательные поля";
            // 
            // panelERElectronicConferenceMaterialsRequired
            // 
            panelERElectronicConferenceMaterialsRequired.AutoScroll = true;
            panelERElectronicConferenceMaterialsRequired.Controls.Add(lbERECMPublishingLocationSelect);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(cbERECMPublisher);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMAccessMode);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMAccessMode);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMAccessDate);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMAccessDate);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMURL);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMURL);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(buttonERECMPublisherAdd);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(lbERECMPublisher);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(buttonERECMPublishingLocationAdd);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(lbERECMPublishingLocation);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMPublisher);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMPublisher);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMPublishingLocation);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMPublishingLocation);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMEventDate);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMEventDate);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMEventTitle);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMEventTitle);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMPublishYear);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMPublishYear);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMEventPlace);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMPublicationType);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(labelERECMEventPlace);
            panelERElectronicConferenceMaterialsRequired.Controls.Add(tbERECMPublicationType);
            panelERElectronicConferenceMaterialsRequired.Location = new Point(10, 22);
            panelERElectronicConferenceMaterialsRequired.Name = "panelERElectronicConferenceMaterialsRequired";
            panelERElectronicConferenceMaterialsRequired.Size = new Size(473, 302);
            panelERElectronicConferenceMaterialsRequired.TabIndex = 14;
            // 
            // lbERECMPublishingLocationSelect
            // 
            lbERECMPublishingLocationSelect.Enabled = false;
            lbERECMPublishingLocationSelect.FormattingEnabled = true;
            lbERECMPublishingLocationSelect.ItemHeight = 15;
            lbERECMPublishingLocationSelect.Location = new Point(243, 339);
            lbERECMPublishingLocationSelect.Name = "lbERECMPublishingLocationSelect";
            lbERECMPublishingLocationSelect.Size = new Size(207, 64);
            lbERECMPublishingLocationSelect.TabIndex = 37;
            lbERECMPublishingLocationSelect.TabStop = false;
            lbERECMPublishingLocationSelect.SelectedIndexChanged += this.lbERECMPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbERECMPublisher
            // 
            cbERECMPublisher.AutoSize = true;
            cbERECMPublisher.Location = new Point(339, 312);
            cbERECMPublisher.Name = "cbERECMPublisher";
            cbERECMPublisher.Size = new Size(111, 19);
            cbERECMPublisher.TabIndex = 18;
            cbERECMPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbERECMPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbERECMPublisher.UseVisualStyleBackColor = true;
            cbERECMPublisher.CheckedChanged += this.cbERECMPublisher_CheckedChanged;
            // 
            // tbERECMAccessMode
            // 
            tbERECMAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMAccessMode.Location = new Point(0, 556);
            tbERECMAccessMode.Name = "tbERECMAccessMode";
            tbERECMAccessMode.Size = new Size(450, 23);
            tbERECMAccessMode.TabIndex = 22;
            ttMain.SetToolTip(tbERECMAccessMode, "Информация об условиях доступа.\r\nПример: «свободный»");
            tbERECMAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMAccessMode
            // 
            labelERECMAccessMode.AutoSize = true;
            labelERECMAccessMode.Location = new Point(0, 538);
            labelERECMAccessMode.Name = "labelERECMAccessMode";
            labelERECMAccessMode.Size = new Size(91, 15);
            labelERECMAccessMode.TabIndex = 31;
            labelERECMAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelERECMAccessMode, "Информация об условиях доступа.\r\nПример: «свободный»");
            // 
            // tbERECMAccessDate
            // 
            tbERECMAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMAccessDate.Location = new Point(0, 512);
            tbERECMAccessDate.Name = "tbERECMAccessDate";
            tbERECMAccessDate.Size = new Size(450, 23);
            tbERECMAccessDate.TabIndex = 21;
            ttMain.SetToolTip(tbERECMAccessDate, "Дата последнего просмотра ссылки.\r\nПример: «20.06.2025»");
            tbERECMAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMAccessDate
            // 
            labelERECMAccessDate.AutoSize = true;
            labelERECMAccessDate.Location = new Point(0, 494);
            labelERECMAccessDate.Name = "labelERECMAccessDate";
            labelERECMAccessDate.Size = new Size(99, 15);
            labelERECMAccessDate.TabIndex = 29;
            labelERECMAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelERECMAccessDate, "Дата последнего просмотра ссылки.\r\nПример: «20.06.2025»");
            // 
            // tbERECMURL
            // 
            tbERECMURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMURL.Location = new Point(0, 468);
            tbERECMURL.Name = "tbERECMURL";
            tbERECMURL.Size = new Size(450, 23);
            tbERECMURL.TabIndex = 20;
            ttMain.SetToolTip(tbERECMURL, "Ссылка на страницу издания или файл материалов.\r\nПример: «https://conference.spbu.ru/2024/materials.pdf»");
            tbERECMURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMURL
            // 
            labelERECMURL.AutoSize = true;
            labelERECMURL.Location = new Point(0, 450);
            labelERECMURL.Name = "labelERECMURL";
            labelERECMURL.Size = new Size(28, 15);
            labelERECMURL.TabIndex = 27;
            labelERECMURL.Text = "URL";
            ttMain.SetToolTip(labelERECMURL, "Ссылка на страницу издания или файл материалов.\r\nПример: «https://conference.spbu.ru/2024/materials.pdf»");
            // 
            // buttonERECMPublisherAdd
            // 
            buttonERECMPublisherAdd.Location = new Point(243, 310);
            buttonERECMPublisherAdd.Name = "buttonERECMPublisherAdd";
            buttonERECMPublisherAdd.Size = new Size(90, 23);
            buttonERECMPublisherAdd.TabIndex = 17;
            buttonERECMPublisherAdd.Text = "Добавить";
            buttonERECMPublisherAdd.UseVisualStyleBackColor = true;
            buttonERECMPublisherAdd.Click += this.buttonERECMPublisherAdd_Click;
            // 
            // lbERECMPublisher
            // 
            lbERECMPublisher.AllowDrop = true;
            lbERECMPublisher.ContextMenuStrip = cmsListBox;
            lbERECMPublisher.ItemHeight = 15;
            lbERECMPublisher.Location = new Point(0, 339);
            lbERECMPublisher.Name = "lbERECMPublisher";
            lbERECMPublisher.Size = new Size(237, 64);
            lbERECMPublisher.TabIndex = 22;
            lbERECMPublisher.TabStop = false;
            lbERECMPublisher.DragDrop += this.ListBox_DragDrop;
            lbERECMPublisher.DragOver += this.ListBox_DragOver;
            lbERECMPublisher.KeyDown += this.ListBox_KeyDown;
            lbERECMPublisher.MouseDown += this.ListBox_MouseDown;
            lbERECMPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECMPublishingLocationAdd
            // 
            buttonERECMPublishingLocationAdd.Location = new Point(360, 196);
            buttonERECMPublishingLocationAdd.Name = "buttonERECMPublishingLocationAdd";
            buttonERECMPublishingLocationAdd.Size = new Size(90, 23);
            buttonERECMPublishingLocationAdd.TabIndex = 15;
            buttonERECMPublishingLocationAdd.Text = "Добавить";
            buttonERECMPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonERECMPublishingLocationAdd.Click += this.buttonERECMPublishingLocationAdd_Click;
            // 
            // lbERECMPublishingLocation
            // 
            lbERECMPublishingLocation.AllowDrop = true;
            lbERECMPublishingLocation.ContextMenuStrip = cmsListBox;
            lbERECMPublishingLocation.ItemHeight = 15;
            lbERECMPublishingLocation.Location = new Point(0, 225);
            lbERECMPublishingLocation.Name = "lbERECMPublishingLocation";
            lbERECMPublishingLocation.Size = new Size(450, 64);
            lbERECMPublishingLocation.TabIndex = 20;
            lbERECMPublishingLocation.TabStop = false;
            lbERECMPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbERECMPublishingLocation.DragOver += this.ListBox_DragOver;
            lbERECMPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbERECMPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbERECMPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERECMPublisher
            // 
            tbERECMPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPublisher.Location = new Point(0, 310);
            tbERECMPublisher.Name = "tbERECMPublisher";
            tbERECMPublisher.Size = new Size(237, 23);
            tbERECMPublisher.TabIndex = 16;
            ttMain.SetToolTip(tbERECMPublisher, resources.GetString("tbERECMPublisher.ToolTip"));
            tbERECMPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMPublisher
            // 
            labelERECMPublisher.AutoSize = true;
            labelERECMPublisher.Location = new Point(0, 292);
            labelERECMPublisher.Name = "labelERECMPublisher";
            labelERECMPublisher.Size = new Size(81, 15);
            labelERECMPublisher.TabIndex = 18;
            labelERECMPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelERECMPublisher, resources.GetString("labelERECMPublisher.ToolTip"));
            // 
            // tbERECMPublishingLocation
            // 
            tbERECMPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPublishingLocation.Location = new Point(0, 196);
            tbERECMPublishingLocation.Name = "tbERECMPublishingLocation";
            tbERECMPublishingLocation.Size = new Size(354, 23);
            tbERECMPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbERECMPublishingLocation, "Город, где опубликованы материалы.\r\nПример: «Москва»");
            tbERECMPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMPublishingLocation
            // 
            labelERECMPublishingLocation.AutoSize = true;
            labelERECMPublishingLocation.Location = new Point(0, 176);
            labelERECMPublishingLocation.Name = "labelERECMPublishingLocation";
            labelERECMPublishingLocation.Size = new Size(89, 15);
            labelERECMPublishingLocation.TabIndex = 16;
            labelERECMPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelERECMPublishingLocation, "Город, где опубликованы материалы.\r\nПример: «Москва»");
            // 
            // tbERECMEventDate
            // 
            tbERECMEventDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMEventDate.Location = new Point(0, 150);
            tbERECMEventDate.Name = "tbERECMEventDate";
            tbERECMEventDate.Size = new Size(450, 23);
            tbERECMEventDate.TabIndex = 13;
            ttMain.SetToolTip(tbERECMEventDate, "Точные даты начала и окончания события.\r\nПример: «21-23 мая 2024 г.»\r\n");
            tbERECMEventDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMEventDate
            // 
            labelERECMEventDate.AutoSize = true;
            labelERECMEventDate.Location = new Point(0, 132);
            labelERECMEventDate.Name = "labelERECMEventDate";
            labelERECMEventDate.Size = new Size(100, 15);
            labelERECMEventDate.TabIndex = 14;
            labelERECMEventDate.Text = "Дата проведения";
            ttMain.SetToolTip(labelERECMEventDate, "Точные даты начала и окончания события.\r\nПример: «21-23 мая 2024 г.»");
            // 
            // labelERECMEventTitle
            // 
            labelERECMEventTitle.AutoSize = true;
            labelERECMEventTitle.Location = new Point(0, 0);
            labelERECMEventTitle.Name = "labelERECMEventTitle";
            labelERECMEventTitle.Size = new Size(136, 15);
            labelERECMEventTitle.TabIndex = 0;
            labelERECMEventTitle.Text = "Название мероприятия";
            ttMain.SetToolTip(labelERECMEventTitle, "Полное наименование конференции, семинара и т. п.\r\nПример: «XI Международная конференция по прикладной информатике»");
            // 
            // tbERECMEventTitle
            // 
            tbERECMEventTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMEventTitle.Location = new Point(0, 18);
            tbERECMEventTitle.Name = "tbERECMEventTitle";
            tbERECMEventTitle.Size = new Size(450, 23);
            tbERECMEventTitle.TabIndex = 10;
            ttMain.SetToolTip(tbERECMEventTitle, "Полное наименование конференции, семинара и т. п.\r\nПример: «XI Международная конференция по прикладной информатике»");
            tbERECMEventTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECMPublishYear
            // 
            tbERECMPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPublishYear.Location = new Point(0, 424);
            tbERECMPublishYear.Name = "tbERECMPublishYear";
            tbERECMPublishYear.Size = new Size(450, 23);
            tbERECMPublishYear.TabIndex = 19;
            ttMain.SetToolTip(tbERECMPublishYear, "Год публикации сборника.\r\nПример: «2024»");
            tbERECMPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMPublishYear
            // 
            labelERECMPublishYear.AutoSize = true;
            labelERECMPublishYear.Location = new Point(0, 406);
            labelERECMPublishYear.Name = "labelERECMPublishYear";
            labelERECMPublishYear.Size = new Size(73, 15);
            labelERECMPublishYear.TabIndex = 10;
            labelERECMPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelERECMPublishYear, "Год публикации сборника.\r\nПример: «2024»");
            // 
            // tbERECMEventPlace
            // 
            tbERECMEventPlace.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMEventPlace.Location = new Point(0, 106);
            tbERECMEventPlace.Name = "tbERECMEventPlace";
            tbERECMEventPlace.Size = new Size(450, 23);
            tbERECMEventPlace.TabIndex = 12;
            ttMain.SetToolTip(tbERECMEventPlace, "Населённый пункт, где проводилось мероприятие.\r\nПример: «Санкт-Петербург»");
            tbERECMEventPlace.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMPublicationType
            // 
            labelERECMPublicationType.AutoSize = true;
            labelERECMPublicationType.Location = new Point(0, 44);
            labelERECMPublicationType.Name = "labelERECMPublicationType";
            labelERECMPublicationType.Size = new Size(74, 15);
            labelERECMPublicationType.TabIndex = 6;
            labelERECMPublicationType.Text = "Вид издания";
            ttMain.SetToolTip(labelERECMPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»\r\n**Чаще всего с маленькой буквы**");
            // 
            // labelERECMEventPlace
            // 
            labelERECMEventPlace.AutoSize = true;
            labelERECMEventPlace.Location = new Point(0, 88);
            labelERECMEventPlace.Name = "labelERECMEventPlace";
            labelERECMEventPlace.Size = new Size(108, 15);
            labelERECMEventPlace.TabIndex = 8;
            labelERECMEventPlace.Text = "Город проведения";
            ttMain.SetToolTip(labelERECMEventPlace, "Населённый пункт, где проводилось мероприятие.\r\nПример: «Санкт-Петербург»");
            // 
            // tbERECMPublicationType
            // 
            tbERECMPublicationType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPublicationType.Location = new Point(0, 62);
            tbERECMPublicationType.Name = "tbERECMPublicationType";
            tbERECMPublicationType.Size = new Size(450, 23);
            tbERECMPublicationType.TabIndex = 11;
            ttMain.SetToolTip(tbERECMPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»\r\n**Чаще всего с маленькой буквы**\r\n");
            tbERECMPublicationType.KeyDown += this.TextBox_KeyDown;
            // 
            // gbERElectronicConferenceMaterialsOptional
            // 
            gbERElectronicConferenceMaterialsOptional.Controls.Add(panelERElectronicConferenceMaterialsOptional);
            gbERElectronicConferenceMaterialsOptional.Location = new Point(10, 346);
            gbERElectronicConferenceMaterialsOptional.Name = "gbERElectronicConferenceMaterialsOptional";
            gbERElectronicConferenceMaterialsOptional.Size = new Size(488, 330);
            gbERElectronicConferenceMaterialsOptional.TabIndex = 5;
            gbERElectronicConferenceMaterialsOptional.TabStop = false;
            gbERElectronicConferenceMaterialsOptional.Text = "Необязательные поля";
            // 
            // panelERElectronicConferenceMaterialsOptional
            // 
            panelERElectronicConferenceMaterialsOptional.AutoScroll = true;
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMAccessNote);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMAccessNote);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(cbERECMEditorType);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(lbERECMEditor);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(buttonERECMEditorAdd);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMEditor);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMEditor);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(lbERECMEditorialBoard);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(buttonERECMEditorialBoardAdd);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMPartNumberAndTitle);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMPartNumberAndTitle);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMContentType);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMContentType);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMPartCount);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMPartCount);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMPagesCount);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMISBN);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMPagesCount);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMEditorialBoard);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(tbERECMISBN);
            panelERElectronicConferenceMaterialsOptional.Controls.Add(labelERECMEditorialBoard);
            panelERElectronicConferenceMaterialsOptional.Location = new Point(10, 22);
            panelERElectronicConferenceMaterialsOptional.Name = "panelERElectronicConferenceMaterialsOptional";
            panelERElectronicConferenceMaterialsOptional.Size = new Size(473, 302);
            panelERElectronicConferenceMaterialsOptional.TabIndex = 14;
            // 
            // labelERECMAccessNote
            // 
            labelERECMAccessNote.AutoSize = true;
            labelERECMAccessNote.Location = new Point(0, 404);
            labelERECMAccessNote.Name = "labelERECMAccessNote";
            labelERECMAccessNote.Size = new Size(159, 15);
            labelERECMAccessNote.TabIndex = 29;
            labelERECMAccessNote.Text = "Уточнение режима доступа";
            ttMain.SetToolTip(labelERECMAccessNote, "Дополнительная информация о лицензии, регистрации и т. п.\r\nПример: «требуется регистрация на сайте»");
            // 
            // tbERECMAccessNote
            // 
            tbERECMAccessNote.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMAccessNote.Location = new Point(0, 422);
            tbERECMAccessNote.Name = "tbERECMAccessNote";
            tbERECMAccessNote.Size = new Size(450, 23);
            tbERECMAccessNote.TabIndex = 32;
            ttMain.SetToolTip(tbERECMAccessNote, "Дополнительная информация о лицензии, регистрации и т. п.\r\nПример: «требуется регистрация на сайте»");
            tbERECMAccessNote.KeyDown += this.TextBox_KeyDown;
            // 
            // cbERECMEditorType
            // 
            cbERECMEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbERECMEditorType.FormattingEnabled = true;
            cbERECMEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbERECMEditorType.Location = new Point(194, 220);
            cbERECMEditorType.Name = "cbERECMEditorType";
            cbERECMEditorType.Size = new Size(160, 23);
            cbERECMEditorType.TabIndex = 28;
            // 
            // lbERECMEditor
            // 
            lbERECMEditor.AllowDrop = true;
            lbERECMEditor.ContextMenuStrip = cmsListBox;
            lbERECMEditor.ItemHeight = 15;
            lbERECMEditor.Location = new Point(0, 249);
            lbERECMEditor.Name = "lbERECMEditor";
            lbERECMEditor.Size = new Size(450, 64);
            lbERECMEditor.TabIndex = 27;
            lbERECMEditor.TabStop = false;
            lbERECMEditor.DragDrop += this.ListBox_DragDrop;
            lbERECMEditor.DragOver += this.ListBox_DragOver;
            lbERECMEditor.KeyDown += this.ListBox_KeyDown;
            lbERECMEditor.MouseDown += this.ListBox_MouseDown;
            lbERECMEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECMEditorAdd
            // 
            buttonERECMEditorAdd.Location = new Point(360, 220);
            buttonERECMEditorAdd.Name = "buttonERECMEditorAdd";
            buttonERECMEditorAdd.Size = new Size(90, 23);
            buttonERECMEditorAdd.TabIndex = 29;
            buttonERECMEditorAdd.Text = "Добавить";
            buttonERECMEditorAdd.UseVisualStyleBackColor = true;
            buttonERECMEditorAdd.Click += this.buttonERECMEditorAdd_Click;
            // 
            // tbERECMEditor
            // 
            tbERECMEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMEditor.Location = new Point(0, 220);
            tbERECMEditor.Name = "tbERECMEditor";
            tbERECMEditor.Size = new Size(188, 23);
            tbERECMEditor.TabIndex = 27;
            ttMain.SetToolTip(tbERECMEditor, resources.GetString("tbERECMEditor.ToolTip"));
            tbERECMEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMEditor
            // 
            labelERECMEditor.AutoSize = true;
            labelERECMEditor.Location = new Point(0, 202);
            labelERECMEditor.Name = "labelERECMEditor";
            labelERECMEditor.Size = new Size(74, 15);
            labelERECMEditor.TabIndex = 24;
            labelERECMEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelERECMEditor, resources.GetString("labelERECMEditor.ToolTip"));
            // 
            // lbERECMEditorialBoard
            // 
            lbERECMEditorialBoard.AllowDrop = true;
            lbERECMEditorialBoard.ContextMenuStrip = cmsListBox;
            lbERECMEditorialBoard.ItemHeight = 15;
            lbERECMEditorialBoard.Location = new Point(0, 135);
            lbERECMEditorialBoard.Name = "lbERECMEditorialBoard";
            lbERECMEditorialBoard.Size = new Size(450, 64);
            lbERECMEditorialBoard.TabIndex = 22;
            lbERECMEditorialBoard.TabStop = false;
            lbERECMEditorialBoard.DragDrop += this.ListBox_DragDrop;
            lbERECMEditorialBoard.DragOver += this.ListBox_DragOver;
            lbERECMEditorialBoard.KeyDown += this.ListBox_KeyDown;
            lbERECMEditorialBoard.MouseDown += this.ListBox_MouseDown;
            lbERECMEditorialBoard.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECMEditorialBoardAdd
            // 
            buttonERECMEditorialBoardAdd.Location = new Point(360, 106);
            buttonERECMEditorialBoardAdd.Name = "buttonERECMEditorialBoardAdd";
            buttonERECMEditorialBoardAdd.Size = new Size(90, 23);
            buttonERECMEditorialBoardAdd.TabIndex = 26;
            buttonERECMEditorialBoardAdd.Text = "Добавить";
            buttonERECMEditorialBoardAdd.UseVisualStyleBackColor = true;
            buttonERECMEditorialBoardAdd.Click += this.buttonERECMEditorialBoardAdd_Click;
            // 
            // labelERECMPartNumberAndTitle
            // 
            labelERECMPartNumberAndTitle.AutoSize = true;
            labelERECMPartNumberAndTitle.Location = new Point(0, 44);
            labelERECMPartNumberAndTitle.Name = "labelERECMPartNumberAndTitle";
            labelERECMPartNumberAndTitle.Size = new Size(142, 15);
            labelERECMPartNumberAndTitle.TabIndex = 12;
            labelERECMPartNumberAndTitle.Text = "Номер и название части";
            ttMain.SetToolTip(labelERECMPartNumberAndTitle, resources.GetString("labelERECMPartNumberAndTitle.ToolTip"));
            // 
            // tbERECMPartNumberAndTitle
            // 
            tbERECMPartNumberAndTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPartNumberAndTitle.Location = new Point(0, 62);
            tbERECMPartNumberAndTitle.Name = "tbERECMPartNumberAndTitle";
            tbERECMPartNumberAndTitle.Size = new Size(450, 23);
            tbERECMPartNumberAndTitle.TabIndex = 24;
            ttMain.SetToolTip(tbERECMPartNumberAndTitle, resources.GetString("tbERECMPartNumberAndTitle.ToolTip"));
            tbERECMPartNumberAndTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMContentType
            // 
            labelERECMContentType.AutoSize = true;
            labelERECMContentType.Location = new Point(0, 448);
            labelERECMContentType.Name = "labelERECMContentType";
            labelERECMContentType.Size = new Size(97, 15);
            labelERECMContentType.TabIndex = 14;
            labelERECMContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelERECMContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbERECMContentType
            // 
            tbERECMContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMContentType.Location = new Point(0, 466);
            tbERECMContentType.Name = "tbERECMContentType";
            tbERECMContentType.Size = new Size(450, 23);
            tbERECMContentType.TabIndex = 33;
            ttMain.SetToolTip(tbERECMContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbERECMContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMPartCount
            // 
            labelERECMPartCount.AutoSize = true;
            labelERECMPartCount.Location = new Point(0, 0);
            labelERECMPartCount.Name = "labelERECMPartCount";
            labelERECMPartCount.Size = new Size(157, 15);
            labelERECMPartCount.TabIndex = 0;
            labelERECMPartCount.Text = "Количество частей (томов)";
            ttMain.SetToolTip(labelERECMPartCount, "Количество частей, если издание состоит из нескольких частей или томов.\r\nПример: «3»");
            // 
            // tbERECMPartCount
            // 
            tbERECMPartCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPartCount.Location = new Point(0, 18);
            tbERECMPartCount.Name = "tbERECMPartCount";
            tbERECMPartCount.Size = new Size(450, 23);
            tbERECMPartCount.TabIndex = 23;
            ttMain.SetToolTip(tbERECMPartCount, "Количество частей, если издание состоит из нескольких частей или томов.\r\nПример: «3»\r\n");
            tbERECMPartCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECMPagesCount
            // 
            tbERECMPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMPagesCount.Location = new Point(0, 334);
            tbERECMPagesCount.Name = "tbERECMPagesCount";
            tbERECMPagesCount.Size = new Size(450, 23);
            tbERECMPagesCount.TabIndex = 30;
            ttMain.SetToolTip(tbERECMPagesCount, "Общее объем материалов в страницах.\r\nПример: «382»\r\n");
            tbERECMPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMISBN
            // 
            labelERECMISBN.AutoSize = true;
            labelERECMISBN.Location = new Point(0, 360);
            labelERECMISBN.Name = "labelERECMISBN";
            labelERECMISBN.Size = new Size(32, 15);
            labelERECMISBN.TabIndex = 2;
            labelERECMISBN.Text = "ISBN";
            ttMain.SetToolTip(labelERECMISBN, "Международный книжный номер.\r\nПример: «978-5-9904980-2-4»");
            // 
            // labelERECMPagesCount
            // 
            labelERECMPagesCount.AutoSize = true;
            labelERECMPagesCount.Location = new Point(0, 316);
            labelERECMPagesCount.Name = "labelERECMPagesCount";
            labelERECMPagesCount.Size = new Size(120, 15);
            labelERECMPagesCount.TabIndex = 12;
            labelERECMPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelERECMPagesCount, "Общее объем материалов в страницах.\r\nПример: «382»");
            // 
            // tbERECMEditorialBoard
            // 
            tbERECMEditorialBoard.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMEditorialBoard.Location = new Point(0, 106);
            tbERECMEditorialBoard.Name = "tbERECMEditorialBoard";
            tbERECMEditorialBoard.Size = new Size(354, 23);
            tbERECMEditorialBoard.TabIndex = 25;
            ttMain.SetToolTip(tbERECMEditorialBoard, "Список членов редколлегии, участвовавших в подготовке издания.\r\nПример: «О. И. Маляренко».\r\n");
            tbERECMEditorialBoard.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECMISBN
            // 
            tbERECMISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECMISBN.Location = new Point(0, 378);
            tbERECMISBN.Name = "tbERECMISBN";
            tbERECMISBN.Size = new Size(450, 23);
            tbERECMISBN.TabIndex = 31;
            ttMain.SetToolTip(tbERECMISBN, "Международный книжный номер.\r\nПример: «978-5-9904980-2-4»");
            tbERECMISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECMEditorialBoard
            // 
            labelERECMEditorialBoard.AutoSize = true;
            labelERECMEditorialBoard.Location = new Point(0, 88);
            labelERECMEditorialBoard.Name = "labelERECMEditorialBoard";
            labelERECMEditorialBoard.Size = new Size(139, 15);
            labelERECMEditorialBoard.TabIndex = 10;
            labelERECMEditorialBoard.Text = "Редакционная коллегия";
            ttMain.SetToolTip(labelERECMEditorialBoard, "Список членов редколлегии, участвовавших в подготовке издания.\r\nПример: «О. И. Маляренко».\r\n");
            // 
            // tpERElectronicCollections
            // 
            tpERElectronicCollections.BackColor = SystemColors.Control;
            tpERElectronicCollections.Controls.Add(gbERElectronicCollectionsRequired);
            tpERElectronicCollections.Controls.Add(gbERElectronicCollectionsOptional);
            tpERElectronicCollections.Location = new Point(4, 24);
            tpERElectronicCollections.Name = "tpERElectronicCollections";
            tpERElectronicCollections.Size = new Size(505, 681);
            tpERElectronicCollections.TabIndex = 7;
            tpERElectronicCollections.Text = "Электронные сборники";
            // 
            // gbERElectronicCollectionsRequired
            // 
            gbERElectronicCollectionsRequired.Controls.Add(panelERElectronicCollectionsRequired);
            gbERElectronicCollectionsRequired.Location = new Point(10, 10);
            gbERElectronicCollectionsRequired.Name = "gbERElectronicCollectionsRequired";
            gbERElectronicCollectionsRequired.Size = new Size(488, 330);
            gbERElectronicCollectionsRequired.TabIndex = 6;
            gbERElectronicCollectionsRequired.TabStop = false;
            gbERElectronicCollectionsRequired.Text = "Обязательные поля";
            // 
            // panelERElectronicCollectionsRequired
            // 
            panelERElectronicCollectionsRequired.AutoScroll = true;
            panelERElectronicCollectionsRequired.Controls.Add(lbERECPublishingLocationSelect);
            panelERElectronicCollectionsRequired.Controls.Add(cbERECPublisher);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECAccessMode);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECAccessMode);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECAccessDate);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECAccessDate);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECURL);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECURL);
            panelERElectronicCollectionsRequired.Controls.Add(buttonERECPublisherAdd);
            panelERElectronicCollectionsRequired.Controls.Add(lbERECPublisher);
            panelERElectronicCollectionsRequired.Controls.Add(buttonERECPublishingLocationAdd);
            panelERElectronicCollectionsRequired.Controls.Add(lbERECPublishingLocation);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECPublisher);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECPublisher);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECPublishingLocation);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECPublishingLocation);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECCollectionTitle);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECCollectionTitle);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECPublishYear);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECPublishYear);
            panelERElectronicCollectionsRequired.Controls.Add(labelERECPublicationType);
            panelERElectronicCollectionsRequired.Controls.Add(tbERECPublicationType);
            panelERElectronicCollectionsRequired.Location = new Point(10, 22);
            panelERElectronicCollectionsRequired.Name = "panelERElectronicCollectionsRequired";
            panelERElectronicCollectionsRequired.Size = new Size(473, 302);
            panelERElectronicCollectionsRequired.TabIndex = 14;
            // 
            // lbERECPublishingLocationSelect
            // 
            lbERECPublishingLocationSelect.Enabled = false;
            lbERECPublishingLocationSelect.FormattingEnabled = true;
            lbERECPublishingLocationSelect.ItemHeight = 15;
            lbERECPublishingLocationSelect.Location = new Point(243, 251);
            lbERECPublishingLocationSelect.Name = "lbERECPublishingLocationSelect";
            lbERECPublishingLocationSelect.Size = new Size(207, 64);
            lbERECPublishingLocationSelect.TabIndex = 35;
            lbERECPublishingLocationSelect.TabStop = false;
            lbERECPublishingLocationSelect.SelectedIndexChanged += this.lbERECPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbERECPublisher
            // 
            cbERECPublisher.AutoSize = true;
            cbERECPublisher.Location = new Point(339, 224);
            cbERECPublisher.Name = "cbERECPublisher";
            cbERECPublisher.Size = new Size(111, 19);
            cbERECPublisher.TabIndex = 16;
            cbERECPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbERECPublisher, "Включение «умного режима» добавления издательств");
            cbERECPublisher.UseVisualStyleBackColor = true;
            cbERECPublisher.CheckedChanged += this.cbERECPublisher_CheckedChanged;
            // 
            // tbERECAccessMode
            // 
            tbERECAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECAccessMode.Location = new Point(0, 468);
            tbERECAccessMode.Name = "tbERECAccessMode";
            tbERECAccessMode.Size = new Size(450, 23);
            tbERECAccessMode.TabIndex = 20;
            ttMain.SetToolTip(tbERECAccessMode, "Условия доступа к изданию.\r\nПример: «свободный»");
            tbERECAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECAccessMode
            // 
            labelERECAccessMode.AutoSize = true;
            labelERECAccessMode.Location = new Point(0, 450);
            labelERECAccessMode.Name = "labelERECAccessMode";
            labelERECAccessMode.Size = new Size(91, 15);
            labelERECAccessMode.TabIndex = 31;
            labelERECAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelERECAccessMode, "Условия доступа к изданию.\r\nПример: «свободный»");
            // 
            // tbERECAccessDate
            // 
            tbERECAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECAccessDate.Location = new Point(0, 424);
            tbERECAccessDate.Name = "tbERECAccessDate";
            tbERECAccessDate.Size = new Size(450, 23);
            tbERECAccessDate.TabIndex = 19;
            ttMain.SetToolTip(tbERECAccessDate, "Дата, когда сборник был просмотрен онлайн.\r\nПример: «15.06.2025»");
            tbERECAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECAccessDate
            // 
            labelERECAccessDate.AutoSize = true;
            labelERECAccessDate.Location = new Point(0, 406);
            labelERECAccessDate.Name = "labelERECAccessDate";
            labelERECAccessDate.Size = new Size(99, 15);
            labelERECAccessDate.TabIndex = 29;
            labelERECAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelERECAccessDate, "Дата, когда сборник был просмотрен онлайн.\r\nПример: «15.06.2025»");
            // 
            // tbERECURL
            // 
            tbERECURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECURL.Location = new Point(0, 380);
            tbERECURL.Name = "tbERECURL";
            tbERECURL.Size = new Size(450, 23);
            tbERECURL.TabIndex = 18;
            ttMain.SetToolTip(tbERECURL, "Прямая ссылка на сборник или его страницу.\r\nПример: «https://elib.msu.ru/issue/2023/volume1»");
            tbERECURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECURL
            // 
            labelERECURL.AutoSize = true;
            labelERECURL.Location = new Point(0, 362);
            labelERECURL.Name = "labelERECURL";
            labelERECURL.Size = new Size(28, 15);
            labelERECURL.TabIndex = 27;
            labelERECURL.Text = "URL";
            ttMain.SetToolTip(labelERECURL, "Прямая ссылка на сборник или его страницу.\r\nПример: «https://elib.msu.ru/issue/2023/volume1»");
            // 
            // buttonERECPublisherAdd
            // 
            buttonERECPublisherAdd.Location = new Point(243, 222);
            buttonERECPublisherAdd.Name = "buttonERECPublisherAdd";
            buttonERECPublisherAdd.Size = new Size(90, 23);
            buttonERECPublisherAdd.TabIndex = 15;
            buttonERECPublisherAdd.Text = "Добавить";
            buttonERECPublisherAdd.UseVisualStyleBackColor = true;
            buttonERECPublisherAdd.Click += this.buttonERECPublisherAdd_Click;
            // 
            // lbERECPublisher
            // 
            lbERECPublisher.AllowDrop = true;
            lbERECPublisher.ContextMenuStrip = cmsListBox;
            lbERECPublisher.ItemHeight = 15;
            lbERECPublisher.Location = new Point(0, 251);
            lbERECPublisher.Name = "lbERECPublisher";
            lbERECPublisher.Size = new Size(237, 64);
            lbERECPublisher.TabIndex = 22;
            lbERECPublisher.TabStop = false;
            lbERECPublisher.DragDrop += this.ListBox_DragDrop;
            lbERECPublisher.DragOver += this.ListBox_DragOver;
            lbERECPublisher.KeyDown += this.ListBox_KeyDown;
            lbERECPublisher.MouseDown += this.ListBox_MouseDown;
            lbERECPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECPublishingLocationAdd
            // 
            buttonERECPublishingLocationAdd.Location = new Point(360, 108);
            buttonERECPublishingLocationAdd.Name = "buttonERECPublishingLocationAdd";
            buttonERECPublishingLocationAdd.Size = new Size(90, 23);
            buttonERECPublishingLocationAdd.TabIndex = 13;
            buttonERECPublishingLocationAdd.Text = "Добавить";
            buttonERECPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonERECPublishingLocationAdd.Click += this.buttonERECPublishingLocationAdd_Click;
            // 
            // lbERECPublishingLocation
            // 
            lbERECPublishingLocation.AllowDrop = true;
            lbERECPublishingLocation.ContextMenuStrip = cmsListBox;
            lbERECPublishingLocation.ItemHeight = 15;
            lbERECPublishingLocation.Location = new Point(0, 137);
            lbERECPublishingLocation.Name = "lbERECPublishingLocation";
            lbERECPublishingLocation.Size = new Size(450, 64);
            lbERECPublishingLocation.TabIndex = 20;
            lbERECPublishingLocation.TabStop = false;
            lbERECPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbERECPublishingLocation.DragOver += this.ListBox_DragOver;
            lbERECPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbERECPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbERECPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERECPublisher
            // 
            tbERECPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECPublisher.Location = new Point(0, 222);
            tbERECPublisher.Name = "tbERECPublisher";
            tbERECPublisher.Size = new Size(237, 23);
            tbERECPublisher.TabIndex = 14;
            ttMain.SetToolTip(tbERECPublisher, resources.GetString("tbERECPublisher.ToolTip"));
            tbERECPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECPublisher
            // 
            labelERECPublisher.AutoSize = true;
            labelERECPublisher.Location = new Point(0, 204);
            labelERECPublisher.Name = "labelERECPublisher";
            labelERECPublisher.Size = new Size(81, 15);
            labelERECPublisher.TabIndex = 18;
            labelERECPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelERECPublisher, resources.GetString("labelERECPublisher.ToolTip"));
            // 
            // tbERECPublishingLocation
            // 
            tbERECPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECPublishingLocation.Location = new Point(0, 108);
            tbERECPublishingLocation.Name = "tbERECPublishingLocation";
            tbERECPublishingLocation.Size = new Size(354, 23);
            tbERECPublishingLocation.TabIndex = 12;
            ttMain.SetToolTip(tbERECPublishingLocation, "Город или населённый пункт, где издан сборник.\r\nПример: «Москва»");
            tbERECPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECPublishingLocation
            // 
            labelERECPublishingLocation.AutoSize = true;
            labelERECPublishingLocation.Location = new Point(0, 88);
            labelERECPublishingLocation.Name = "labelERECPublishingLocation";
            labelERECPublishingLocation.Size = new Size(89, 15);
            labelERECPublishingLocation.TabIndex = 16;
            labelERECPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelERECPublishingLocation, "Город или населённый пункт, где издан сборник.\r\nПример: «Москва»");
            // 
            // labelERECCollectionTitle
            // 
            labelERECCollectionTitle.AutoSize = true;
            labelERECCollectionTitle.Location = new Point(0, 0);
            labelERECCollectionTitle.Name = "labelERECCollectionTitle";
            labelERECCollectionTitle.Size = new Size(115, 15);
            labelERECCollectionTitle.TabIndex = 0;
            labelERECCollectionTitle.Text = "Название сборника";
            ttMain.SetToolTip(labelERECCollectionTitle, "Полное заглавие издания, включая при необходимости подзаголовки.\r\nПример: «Информационное общество»");
            // 
            // tbERECCollectionTitle
            // 
            tbERECCollectionTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECCollectionTitle.Location = new Point(0, 18);
            tbERECCollectionTitle.Name = "tbERECCollectionTitle";
            tbERECCollectionTitle.Size = new Size(450, 23);
            tbERECCollectionTitle.TabIndex = 10;
            ttMain.SetToolTip(tbERECCollectionTitle, "Полное заглавие издания, включая при необходимости подзаголовки.\r\nПример: «Информационное общество»");
            tbERECCollectionTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECPublishYear
            // 
            tbERECPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECPublishYear.Location = new Point(0, 336);
            tbERECPublishYear.Name = "tbERECPublishYear";
            tbERECPublishYear.Size = new Size(450, 23);
            tbERECPublishYear.TabIndex = 17;
            ttMain.SetToolTip(tbERECPublishYear, "Год, в который сборник был опубликован.\r\nПример: «2023»");
            tbERECPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECPublishYear
            // 
            labelERECPublishYear.AutoSize = true;
            labelERECPublishYear.Location = new Point(0, 318);
            labelERECPublishYear.Name = "labelERECPublishYear";
            labelERECPublishYear.Size = new Size(73, 15);
            labelERECPublishYear.TabIndex = 10;
            labelERECPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelERECPublishYear, "Год, в который сборник был опубликован.\r\nПример: «2023»");
            // 
            // labelERECPublicationType
            // 
            labelERECPublicationType.AutoSize = true;
            labelERECPublicationType.Location = new Point(0, 44);
            labelERECPublicationType.Name = "labelERECPublicationType";
            labelERECPublicationType.Size = new Size(74, 15);
            labelERECPublicationType.TabIndex = 6;
            labelERECPublicationType.Text = "Вид издания";
            ttMain.SetToolTip(labelERECPublicationType, "Формулировка типа публикации – сборник, материалы конференции и т. п.\r\nПример: «сборник научных трудов»");
            // 
            // tbERECPublicationType
            // 
            tbERECPublicationType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECPublicationType.Location = new Point(0, 62);
            tbERECPublicationType.Name = "tbERECPublicationType";
            tbERECPublicationType.Size = new Size(450, 23);
            tbERECPublicationType.TabIndex = 11;
            ttMain.SetToolTip(tbERECPublicationType, "Формулировка типа публикации – сборник, материалы конференции и т. п.\r\nПример: «сборник научных трудов»\r\n");
            tbERECPublicationType.KeyDown += this.TextBox_KeyDown;
            // 
            // gbERElectronicCollectionsOptional
            // 
            gbERElectronicCollectionsOptional.Controls.Add(panelERElectronicCollectionsOptional);
            gbERElectronicCollectionsOptional.Location = new Point(10, 346);
            gbERElectronicCollectionsOptional.Name = "gbERElectronicCollectionsOptional";
            gbERElectronicCollectionsOptional.Size = new Size(488, 330);
            gbERElectronicCollectionsOptional.TabIndex = 7;
            gbERElectronicCollectionsOptional.TabStop = false;
            gbERElectronicCollectionsOptional.Text = "Необязательные поля";
            // 
            // panelERElectronicCollectionsOptional
            // 
            panelERElectronicCollectionsOptional.AutoScroll = true;
            panelERElectronicCollectionsOptional.Controls.Add(cbERECEditorType);
            panelERElectronicCollectionsOptional.Controls.Add(lbERECEditor);
            panelERElectronicCollectionsOptional.Controls.Add(buttonERECEditor);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECEditor);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECEditor);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECAccessNote);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECAccessNote);
            panelERElectronicCollectionsOptional.Controls.Add(lbERECEditorialBoard);
            panelERElectronicCollectionsOptional.Controls.Add(buttonERECEditorialBoardAdd);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECContentType);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECContentType);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECPagesCount);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECISBN);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECPagesCount);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECEditorialBoard);
            panelERElectronicCollectionsOptional.Controls.Add(tbERECISBN);
            panelERElectronicCollectionsOptional.Controls.Add(labelERECEditorialBoard);
            panelERElectronicCollectionsOptional.Location = new Point(10, 22);
            panelERElectronicCollectionsOptional.Name = "panelERElectronicCollectionsOptional";
            panelERElectronicCollectionsOptional.Size = new Size(473, 302);
            panelERElectronicCollectionsOptional.TabIndex = 14;
            // 
            // cbERECEditorType
            // 
            cbERECEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbERECEditorType.FormattingEnabled = true;
            cbERECEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbERECEditorType.Location = new Point(194, 132);
            cbERECEditorType.Name = "cbERECEditorType";
            cbERECEditorType.Size = new Size(160, 23);
            cbERECEditorType.TabIndex = 24;
            // 
            // lbERECEditor
            // 
            lbERECEditor.AllowDrop = true;
            lbERECEditor.ContextMenuStrip = cmsListBox;
            lbERECEditor.ItemHeight = 15;
            lbERECEditor.Location = new Point(0, 161);
            lbERECEditor.Name = "lbERECEditor";
            lbERECEditor.Size = new Size(450, 64);
            lbERECEditor.TabIndex = 32;
            lbERECEditor.TabStop = false;
            lbERECEditor.DragDrop += this.ListBox_DragDrop;
            lbERECEditor.DragOver += this.ListBox_DragOver;
            lbERECEditor.KeyDown += this.ListBox_KeyDown;
            lbERECEditor.MouseDown += this.ListBox_MouseDown;
            lbERECEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECEditor
            // 
            buttonERECEditor.Location = new Point(360, 132);
            buttonERECEditor.Name = "buttonERECEditor";
            buttonERECEditor.Size = new Size(90, 23);
            buttonERECEditor.TabIndex = 25;
            buttonERECEditor.Text = "Добавить";
            buttonERECEditor.UseVisualStyleBackColor = true;
            buttonERECEditor.Click += this.buttonERECEditor_Click;
            // 
            // tbERECEditor
            // 
            tbERECEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECEditor.Location = new Point(0, 132);
            tbERECEditor.Name = "tbERECEditor";
            tbERECEditor.Size = new Size(188, 23);
            tbERECEditor.TabIndex = 23;
            ttMain.SetToolTip(tbERECEditor, resources.GetString("tbERECEditor.ToolTip"));
            tbERECEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECEditor
            // 
            labelERECEditor.AutoSize = true;
            labelERECEditor.Location = new Point(0, 114);
            labelERECEditor.Name = "labelERECEditor";
            labelERECEditor.Size = new Size(74, 15);
            labelERECEditor.TabIndex = 29;
            labelERECEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelERECEditor, resources.GetString("labelERECEditor.ToolTip"));
            // 
            // labelERECAccessNote
            // 
            labelERECAccessNote.AutoSize = true;
            labelERECAccessNote.Location = new Point(0, 316);
            labelERECAccessNote.Name = "labelERECAccessNote";
            labelERECAccessNote.Size = new Size(159, 15);
            labelERECAccessNote.TabIndex = 23;
            labelERECAccessNote.Text = "Уточнение режима доступа";
            ttMain.SetToolTip(labelERECAccessNote, "Дополнительная информация о доступе, лицензии и т. п.\r\nПример: «доступен после регистрации»");
            // 
            // tbERECAccessNote
            // 
            tbERECAccessNote.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECAccessNote.Location = new Point(0, 334);
            tbERECAccessNote.Name = "tbERECAccessNote";
            tbERECAccessNote.Size = new Size(450, 23);
            tbERECAccessNote.TabIndex = 28;
            ttMain.SetToolTip(tbERECAccessNote, "Дополнительная информация о доступе, лицензии и т. п.\r\nПример: «доступен после регистрации»");
            tbERECAccessNote.KeyDown += this.TextBox_KeyDown;
            // 
            // lbERECEditorialBoard
            // 
            lbERECEditorialBoard.AllowDrop = true;
            lbERECEditorialBoard.ContextMenuStrip = cmsListBox;
            lbERECEditorialBoard.ItemHeight = 15;
            lbERECEditorialBoard.Location = new Point(0, 47);
            lbERECEditorialBoard.Name = "lbERECEditorialBoard";
            lbERECEditorialBoard.Size = new Size(450, 64);
            lbERECEditorialBoard.TabIndex = 22;
            lbERECEditorialBoard.TabStop = false;
            lbERECEditorialBoard.DragDrop += this.ListBox_DragDrop;
            lbERECEditorialBoard.DragOver += this.ListBox_DragOver;
            lbERECEditorialBoard.KeyDown += this.ListBox_KeyDown;
            lbERECEditorialBoard.MouseDown += this.ListBox_MouseDown;
            lbERECEditorialBoard.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERECEditorialBoardAdd
            // 
            buttonERECEditorialBoardAdd.Location = new Point(360, 18);
            buttonERECEditorialBoardAdd.Name = "buttonERECEditorialBoardAdd";
            buttonERECEditorialBoardAdd.Size = new Size(90, 23);
            buttonERECEditorialBoardAdd.TabIndex = 22;
            buttonERECEditorialBoardAdd.Text = "Добавить";
            buttonERECEditorialBoardAdd.UseVisualStyleBackColor = true;
            buttonERECEditorialBoardAdd.Click += this.buttonERECEditorialBoardAdd_Click;
            // 
            // labelERECContentType
            // 
            labelERECContentType.AutoSize = true;
            labelERECContentType.Location = new Point(0, 360);
            labelERECContentType.Name = "labelERECContentType";
            labelERECContentType.Size = new Size(97, 15);
            labelERECContentType.TabIndex = 14;
            labelERECContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelERECContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbERECContentType
            // 
            tbERECContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECContentType.Location = new Point(0, 378);
            tbERECContentType.Name = "tbERECContentType";
            tbERECContentType.Size = new Size(450, 23);
            tbERECContentType.TabIndex = 29;
            ttMain.SetToolTip(tbERECContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbERECContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECPagesCount
            // 
            tbERECPagesCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECPagesCount.Location = new Point(0, 246);
            tbERECPagesCount.Name = "tbERECPagesCount";
            tbERECPagesCount.Size = new Size(450, 23);
            tbERECPagesCount.TabIndex = 26;
            ttMain.SetToolTip(tbERECPagesCount, "Общее количество страниц сборника.\r\nПример: «256»");
            tbERECPagesCount.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECISBN
            // 
            labelERECISBN.AutoSize = true;
            labelERECISBN.Location = new Point(0, 272);
            labelERECISBN.Name = "labelERECISBN";
            labelERECISBN.Size = new Size(32, 15);
            labelERECISBN.TabIndex = 2;
            labelERECISBN.Text = "ISBN";
            ttMain.SetToolTip(labelERECISBN, "Международный книжный номер.\r\nПример: «978-5-6045064-1-5»");
            // 
            // labelERECPagesCount
            // 
            labelERECPagesCount.AutoSize = true;
            labelERECPagesCount.Location = new Point(0, 228);
            labelERECPagesCount.Name = "labelERECPagesCount";
            labelERECPagesCount.Size = new Size(120, 15);
            labelERECPagesCount.TabIndex = 12;
            labelERECPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelERECPagesCount, "Общее количество страниц сборника.\r\nПример: «256»");
            // 
            // tbERECEditorialBoard
            // 
            tbERECEditorialBoard.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECEditorialBoard.Location = new Point(0, 18);
            tbERECEditorialBoard.Name = "tbERECEditorialBoard";
            tbERECEditorialBoard.Size = new Size(354, 23);
            tbERECEditorialBoard.TabIndex = 21;
            ttMain.SetToolTip(tbERECEditorialBoard, "Список членов редколлегии, участвовавших в подготовке издания.\r\nПример: «О. И. Маляренко».");
            tbERECEditorialBoard.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERECISBN
            // 
            tbERECISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERECISBN.Location = new Point(0, 290);
            tbERECISBN.Name = "tbERECISBN";
            tbERECISBN.Size = new Size(450, 23);
            tbERECISBN.TabIndex = 27;
            ttMain.SetToolTip(tbERECISBN, "Международный книжный номер.\r\nПример: «978-5-6045064-1-5»");
            tbERECISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERECEditorialBoard
            // 
            labelERECEditorialBoard.AutoSize = true;
            labelERECEditorialBoard.Location = new Point(0, 0);
            labelERECEditorialBoard.Name = "labelERECEditorialBoard";
            labelERECEditorialBoard.Size = new Size(139, 15);
            labelERECEditorialBoard.TabIndex = 10;
            labelERECEditorialBoard.Text = "Редакционная коллегия\r\n";
            ttMain.SetToolTip(labelERECEditorialBoard, "Список членов редколлегии, участвовавших в подготовке издания.\r\nПример: «О. И. Маляренко».\r\n");
            // 
            // tpEREjournalArticle
            // 
            tpEREjournalArticle.BackColor = SystemColors.Control;
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleReqired);
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleOptional);
            tpEREjournalArticle.Location = new Point(4, 24);
            tpEREjournalArticle.Name = "tpEREjournalArticle";
            tpEREjournalArticle.Padding = new Padding(3);
            tpEREjournalArticle.Size = new Size(505, 681);
            tpEREjournalArticle.TabIndex = 2;
            tpEREjournalArticle.Text = "Статья из электронного журнала";
            // 
            // gbEREjournalArticleReqired
            // 
            gbEREjournalArticleReqired.Controls.Add(panelEREjournalArticleReqired);
            gbEREjournalArticleReqired.Location = new Point(10, 10);
            gbEREjournalArticleReqired.Name = "gbEREjournalArticleReqired";
            gbEREjournalArticleReqired.Size = new Size(488, 330);
            gbEREjournalArticleReqired.TabIndex = 2;
            gbEREjournalArticleReqired.TabStop = false;
            gbEREjournalArticleReqired.Text = "Обязательные поля";
            // 
            // panelEREjournalArticleReqired
            // 
            panelEREjournalArticleReqired.AutoScroll = true;
            panelEREjournalArticleReqired.Controls.Add(cbEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAAccessDate);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAccessDate);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAPages);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAURL);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAPages);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAURL);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAJournalNumber);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAJournalNumber);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAYear);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAuthorsAdd);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAYear);
            panelEREjournalArticleReqired.Controls.Add(lbEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAJournalName);
            panelEREjournalArticleReqired.Controls.Add(labelEREjATitle);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAJournalName);
            panelEREjournalArticleReqired.Controls.Add(tbEREjATitle);
            panelEREjournalArticleReqired.Location = new Point(10, 22);
            panelEREjournalArticleReqired.Name = "panelEREjournalArticleReqired";
            panelEREjournalArticleReqired.Size = new Size(472, 302);
            panelEREjournalArticleReqired.TabIndex = 0;
            // 
            // cbEREjAAuthors
            // 
            cbEREjAAuthors.AutoSize = true;
            cbEREjAAuthors.Location = new Point(371, 20);
            cbEREjAAuthors.Name = "cbEREjAAuthors";
            cbEREjAAuthors.Size = new Size(79, 19);
            cbEREjAAuthors.TabIndex = 12;
            cbEREjAAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbEREjAAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbEREjAAuthors.UseVisualStyleBackColor = true;
            // 
            // labelEREjAAccessDate
            // 
            labelEREjAAccessDate.AutoSize = true;
            labelEREjAAccessDate.Location = new Point(0, 378);
            labelEREjAAccessDate.Name = "labelEREjAAccessDate";
            labelEREjAAccessDate.Size = new Size(99, 15);
            labelEREjAAccessDate.TabIndex = 16;
            labelEREjAAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelEREjAAccessDate, "Дата последнего доступа к странице.\r\nПример: «10.06.2025»");
            // 
            // labelEREjAAuthors
            // 
            labelEREjAAuthors.AutoSize = true;
            labelEREjAAuthors.Location = new Point(0, 0);
            labelEREjAAuthors.Name = "labelEREjAAuthors";
            labelEREjAAuthors.Size = new Size(57, 15);
            labelEREjAAuthors.TabIndex = 0;
            labelEREjAAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelEREjAAuthors, resources.GetString("labelEREjAAuthors.ToolTip"));
            // 
            // tbEREjAAccessDate
            // 
            tbEREjAAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAAccessDate.Location = new Point(0, 396);
            tbEREjAAccessDate.Name = "tbEREjAAccessDate";
            tbEREjAAccessDate.Size = new Size(450, 23);
            tbEREjAAccessDate.TabIndex = 19;
            ttMain.SetToolTip(tbEREjAAccessDate, "Дата последнего доступа к странице.\r\nПример: «10.06.2025»");
            tbEREjAAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREjAPages
            // 
            tbEREjAPages.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAPages.Location = new Point(0, 308);
            tbEREjAPages.Name = "tbEREjAPages";
            tbEREjAPages.Size = new Size(450, 23);
            tbEREjAPages.TabIndex = 17;
            ttMain.SetToolTip(tbEREjAPages, "Диапазон страниц, на которых расположена статья.\r\nПример: «45-52»\r\n");
            tbEREjAPages.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREjAURL
            // 
            labelEREjAURL.AutoSize = true;
            labelEREjAURL.Location = new Point(0, 334);
            labelEREjAURL.Name = "labelEREjAURL";
            labelEREjAURL.Size = new Size(28, 15);
            labelEREjAURL.TabIndex = 14;
            labelEREjAURL.Text = "URL";
            ttMain.SetToolTip(labelEREjAURL, "Полный адрес страницы статьи в интернете.\r\nПример: «https://ejournal.edu.ru/article/2024-3-45»");
            // 
            // labelEREjAPages
            // 
            labelEREjAPages.AutoSize = true;
            labelEREjAPages.Location = new Point(0, 290);
            labelEREjAPages.Name = "labelEREjAPages";
            labelEREjAPages.Size = new Size(63, 15);
            labelEREjAPages.TabIndex = 12;
            labelEREjAPages.Text = "Страницы";
            ttMain.SetToolTip(labelEREjAPages, "Диапазон страниц, на которых расположена статья.\r\nПример: «45-52»");
            // 
            // tbEREjAURL
            // 
            tbEREjAURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAURL.Location = new Point(0, 352);
            tbEREjAURL.Name = "tbEREjAURL";
            tbEREjAURL.Size = new Size(450, 23);
            tbEREjAURL.TabIndex = 18;
            ttMain.SetToolTip(tbEREjAURL, "Полный адрес страницы статьи в интернете.\r\nПример: «https://ejournal.edu.ru/article/2024-3-45»");
            tbEREjAURL.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREjAJournalNumber
            // 
            tbEREjAJournalNumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAJournalNumber.Location = new Point(0, 264);
            tbEREjAJournalNumber.Name = "tbEREjAJournalNumber";
            tbEREjAJournalNumber.Size = new Size(450, 23);
            tbEREjAJournalNumber.TabIndex = 16;
            ttMain.SetToolTip(tbEREjAJournalNumber, "Номер выпуска (в журнале).\r\nПример: «3 (58)»");
            tbEREjAJournalNumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREjAJournalNumber
            // 
            labelEREjAJournalNumber.AutoSize = true;
            labelEREjAJournalNumber.Location = new Point(0, 246);
            labelEREjAJournalNumber.Name = "labelEREjAJournalNumber";
            labelEREjAJournalNumber.Size = new Size(96, 15);
            labelEREjAJournalNumber.TabIndex = 10;
            labelEREjAJournalNumber.Text = "Номер журнала";
            ttMain.SetToolTip(labelEREjAJournalNumber, "Номер выпуска (в журнале).\r\nПример: «3 (58)»");
            // 
            // tbEREjAAuthors
            // 
            tbEREjAAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAAuthors.Location = new Point(0, 18);
            tbEREjAAuthors.Name = "tbEREjAAuthors";
            tbEREjAAuthors.Size = new Size(269, 23);
            tbEREjAAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbEREjAAuthors, resources.GetString("tbEREjAAuthors.ToolTip"));
            tbEREjAAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREjAYear
            // 
            tbEREjAYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAYear.Location = new Point(0, 220);
            tbEREjAYear.Name = "tbEREjAYear";
            tbEREjAYear.Size = new Size(450, 23);
            tbEREjAYear.TabIndex = 15;
            ttMain.SetToolTip(tbEREjAYear, "Год выхода выпуска, в котором размещена статья.\r\nПример: «2024»");
            tbEREjAYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREjAAuthorsAdd
            // 
            tbEREjAAuthorsAdd.Location = new Point(275, 18);
            tbEREjAAuthorsAdd.Name = "tbEREjAAuthorsAdd";
            tbEREjAAuthorsAdd.Size = new Size(90, 23);
            tbEREjAAuthorsAdd.TabIndex = 11;
            tbEREjAAuthorsAdd.Text = "Добавить";
            tbEREjAAuthorsAdd.UseVisualStyleBackColor = true;
            tbEREjAAuthorsAdd.Click += this.tbEREjAAuthorsAdd_Click;
            // 
            // labelEREjAYear
            // 
            labelEREjAYear.AutoSize = true;
            labelEREjAYear.Location = new Point(0, 202);
            labelEREjAYear.Name = "labelEREjAYear";
            labelEREjAYear.Size = new Size(26, 15);
            labelEREjAYear.TabIndex = 8;
            labelEREjAYear.Text = "Год";
            ttMain.SetToolTip(labelEREjAYear, "Год выхода выпуска, в котором размещена статья.\r\nПример: «2024»");
            // 
            // lbEREjAAuthors
            // 
            lbEREjAAuthors.AllowDrop = true;
            lbEREjAAuthors.ContextMenuStrip = cmsListBox;
            lbEREjAAuthors.ItemHeight = 15;
            lbEREjAAuthors.Location = new Point(0, 47);
            lbEREjAAuthors.Name = "lbEREjAAuthors";
            lbEREjAAuthors.Size = new Size(450, 64);
            lbEREjAAuthors.TabIndex = 3;
            lbEREjAAuthors.TabStop = false;
            lbEREjAAuthors.Tag = "";
            lbEREjAAuthors.DragDrop += this.ListBox_DragDrop;
            lbEREjAAuthors.DragOver += this.ListBox_DragOver;
            lbEREjAAuthors.KeyDown += this.ListBox_KeyDown;
            lbEREjAAuthors.MouseDown += this.ListBox_MouseDown;
            lbEREjAAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbEREjAJournalName
            // 
            tbEREjAJournalName.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAJournalName.Location = new Point(0, 176);
            tbEREjAJournalName.Name = "tbEREjAJournalName";
            tbEREjAJournalName.Size = new Size(450, 23);
            tbEREjAJournalName.TabIndex = 14;
            ttMain.SetToolTip(tbEREjAJournalName, "Официальное наименование электронного журнала.\r\nПример: «Современные информационные технологии»");
            tbEREjAJournalName.KeyDown += this.TextBox_KeyDown;
            // 
            // labelEREjATitle
            // 
            labelEREjATitle.AutoSize = true;
            labelEREjATitle.Location = new Point(0, 114);
            labelEREjATitle.Name = "labelEREjATitle";
            labelEREjATitle.Size = new Size(95, 15);
            labelEREjATitle.TabIndex = 4;
            labelEREjATitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelEREjATitle, "Полное название статьи, как указано в источнике.\r\nПример: «Цифровая трансформация образования»");
            // 
            // labelEREjAJournalName
            // 
            labelEREjAJournalName.AutoSize = true;
            labelEREjAJournalName.Location = new Point(0, 158);
            labelEREjAJournalName.Name = "labelEREjAJournalName";
            labelEREjAJournalName.Size = new Size(110, 15);
            labelEREjAJournalName.TabIndex = 6;
            labelEREjAJournalName.Text = "Название журнала";
            ttMain.SetToolTip(labelEREjAJournalName, "Официальное наименование электронного журнала.\r\nПример: «Современные информационные технологии»");
            // 
            // tbEREjATitle
            // 
            tbEREjATitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjATitle.Location = new Point(0, 132);
            tbEREjATitle.Name = "tbEREjATitle";
            tbEREjATitle.Size = new Size(450, 23);
            tbEREjATitle.TabIndex = 13;
            ttMain.SetToolTip(tbEREjATitle, "Полное название статьи, как указано в источнике.\r\nПример: «Цифровая трансформация образования»");
            tbEREjATitle.KeyDown += this.TextBox_KeyDown;
            // 
            // gbEREjournalArticleOptional
            // 
            gbEREjournalArticleOptional.Controls.Add(panelEREjournalArticleOptional);
            gbEREjournalArticleOptional.Location = new Point(10, 346);
            gbEREjournalArticleOptional.Name = "gbEREjournalArticleOptional";
            gbEREjournalArticleOptional.Size = new Size(488, 330);
            gbEREjournalArticleOptional.TabIndex = 3;
            gbEREjournalArticleOptional.TabStop = false;
            gbEREjournalArticleOptional.Text = "Необязательные поля";
            // 
            // panelEREjournalArticleOptional
            // 
            panelEREjournalArticleOptional.AutoScroll = true;
            panelEREjournalArticleOptional.Controls.Add(labelEREjAAccessMode);
            panelEREjournalArticleOptional.Controls.Add(labelEREjAContentType);
            panelEREjournalArticleOptional.Controls.Add(tbEREjAAccessMode);
            panelEREjournalArticleOptional.Controls.Add(tbEREjAContentType);
            panelEREjournalArticleOptional.Location = new Point(10, 22);
            panelEREjournalArticleOptional.Name = "panelEREjournalArticleOptional";
            panelEREjournalArticleOptional.Size = new Size(473, 302);
            panelEREjournalArticleOptional.TabIndex = 18;
            // 
            // labelEREjAAccessMode
            // 
            labelEREjAAccessMode.AutoSize = true;
            labelEREjAAccessMode.Location = new Point(0, 0);
            labelEREjAAccessMode.Name = "labelEREjAAccessMode";
            labelEREjAAccessMode.Size = new Size(91, 15);
            labelEREjAAccessMode.TabIndex = 0;
            labelEREjAAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelEREjAAccessMode, "Фраза, описывающая условия доступа к статье.\r\nПример: «свободный», «по подписке»");
            // 
            // labelEREjAContentType
            // 
            labelEREjAContentType.AutoSize = true;
            labelEREjAContentType.Location = new Point(0, 44);
            labelEREjAContentType.Name = "labelEREjAContentType";
            labelEREjAContentType.Size = new Size(97, 15);
            labelEREjAContentType.TabIndex = 16;
            labelEREjAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelEREjAContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbEREjAAccessMode
            // 
            tbEREjAAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbEREjAAccessMode.Location = new Point(0, 18);
            tbEREjAAccessMode.Name = "tbEREjAAccessMode";
            tbEREjAAccessMode.Size = new Size(450, 23);
            tbEREjAAccessMode.TabIndex = 20;
            ttMain.SetToolTip(tbEREjAAccessMode, "Фраза, описывающая условия доступа к статье.\r\nПример: «свободный», «по подписке»");
            tbEREjAAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // tbEREjAContentType
            // 
            tbEREjAContentType.ContextMenuStrip = cmsMainTabControl;
            tbEREjAContentType.Location = new Point(0, 62);
            tbEREjAContentType.Name = "tbEREjAContentType";
            tbEREjAContentType.Size = new Size(450, 23);
            tbEREjAContentType.TabIndex = 21;
            ttMain.SetToolTip(tbEREjAContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbEREjAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tpERMultimediaEdition
            // 
            tpERMultimediaEdition.BackColor = SystemColors.Control;
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionRequired);
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionOptional);
            tpERMultimediaEdition.Location = new Point(4, 24);
            tpERMultimediaEdition.Name = "tpERMultimediaEdition";
            tpERMultimediaEdition.Padding = new Padding(3);
            tpERMultimediaEdition.Size = new Size(505, 681);
            tpERMultimediaEdition.TabIndex = 1;
            tpERMultimediaEdition.Text = "Мультимедийное издание (на диске)";
            // 
            // gbERMultimediaEditionRequired
            // 
            gbERMultimediaEditionRequired.Controls.Add(panelERMultimediaEditionRequired);
            gbERMultimediaEditionRequired.Location = new Point(10, 10);
            gbERMultimediaEditionRequired.Name = "gbERMultimediaEditionRequired";
            gbERMultimediaEditionRequired.Size = new Size(488, 330);
            gbERMultimediaEditionRequired.TabIndex = 2;
            gbERMultimediaEditionRequired.TabStop = false;
            gbERMultimediaEditionRequired.Text = "Обязательные поля";
            // 
            // panelERMultimediaEditionRequired
            // 
            panelERMultimediaEditionRequired.AutoScroll = true;
            panelERMultimediaEditionRequired.Controls.Add(cbERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(lbERMEPublishingLocationSelect);
            panelERMultimediaEditionRequired.Controls.Add(cbERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(buttonERMEPublisherAdd);
            panelERMultimediaEditionRequired.Controls.Add(lbERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(buttonERMEPublishingLocationAdd);
            panelERMultimediaEditionRequired.Controls.Add(lbERMEPublishingLocation);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublishingLocation);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublishingLocation);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEDataCarrier);
            panelERMultimediaEditionRequired.Controls.Add(buttonERMEAuthorsAdd);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEDataCarrier);
            panelERMultimediaEditionRequired.Controls.Add(lbERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublishYear);
            panelERMultimediaEditionRequired.Controls.Add(labelERMETitle);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublishYear);
            panelERMultimediaEditionRequired.Controls.Add(tbERMETitle);
            panelERMultimediaEditionRequired.Location = new Point(10, 22);
            panelERMultimediaEditionRequired.Name = "panelERMultimediaEditionRequired";
            panelERMultimediaEditionRequired.Size = new Size(473, 302);
            panelERMultimediaEditionRequired.TabIndex = 0;
            // 
            // cbERMEAuthors
            // 
            cbERMEAuthors.AutoSize = true;
            cbERMEAuthors.Location = new Point(371, 20);
            cbERMEAuthors.Name = "cbERMEAuthors";
            cbERMEAuthors.Size = new Size(79, 19);
            cbERMEAuthors.TabIndex = 12;
            cbERMEAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbERMEAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbERMEAuthors.UseVisualStyleBackColor = true;
            // 
            // lbERMEPublishingLocationSelect
            // 
            lbERMEPublishingLocationSelect.Enabled = false;
            lbERMEPublishingLocationSelect.FormattingEnabled = true;
            lbERMEPublishingLocationSelect.ItemHeight = 15;
            lbERMEPublishingLocationSelect.Location = new Point(243, 319);
            lbERMEPublishingLocationSelect.Name = "lbERMEPublishingLocationSelect";
            lbERMEPublishingLocationSelect.Size = new Size(207, 64);
            lbERMEPublishingLocationSelect.TabIndex = 45;
            lbERMEPublishingLocationSelect.TabStop = false;
            lbERMEPublishingLocationSelect.SelectedIndexChanged += this.lbERMEPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbERMEPublisher
            // 
            cbERMEPublisher.AutoSize = true;
            cbERMEPublisher.Location = new Point(339, 292);
            cbERMEPublisher.Name = "cbERMEPublisher";
            cbERMEPublisher.Size = new Size(111, 19);
            cbERMEPublisher.TabIndex = 18;
            cbERMEPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbERMEPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbERMEPublisher.UseVisualStyleBackColor = true;
            cbERMEPublisher.CheckedChanged += this.cbERMEPublisher_CheckedChanged;
            // 
            // buttonERMEPublisherAdd
            // 
            buttonERMEPublisherAdd.Location = new Point(243, 290);
            buttonERMEPublisherAdd.Name = "buttonERMEPublisherAdd";
            buttonERMEPublisherAdd.Size = new Size(90, 23);
            buttonERMEPublisherAdd.TabIndex = 17;
            buttonERMEPublisherAdd.Text = "Добавить";
            buttonERMEPublisherAdd.UseVisualStyleBackColor = true;
            buttonERMEPublisherAdd.Click += this.buttonERMEPublisherAdd_Click;
            // 
            // lbERMEPublisher
            // 
            lbERMEPublisher.AllowDrop = true;
            lbERMEPublisher.ContextMenuStrip = cmsListBox;
            lbERMEPublisher.ItemHeight = 15;
            lbERMEPublisher.Location = new Point(0, 319);
            lbERMEPublisher.Name = "lbERMEPublisher";
            lbERMEPublisher.Size = new Size(237, 64);
            lbERMEPublisher.TabIndex = 42;
            lbERMEPublisher.TabStop = false;
            lbERMEPublisher.DragDrop += this.ListBox_DragDrop;
            lbERMEPublisher.DragOver += this.ListBox_DragOver;
            lbERMEPublisher.KeyDown += this.ListBox_KeyDown;
            lbERMEPublisher.MouseDown += this.ListBox_MouseDown;
            lbERMEPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERMEPublishingLocationAdd
            // 
            buttonERMEPublishingLocationAdd.Location = new Point(360, 176);
            buttonERMEPublishingLocationAdd.Name = "buttonERMEPublishingLocationAdd";
            buttonERMEPublishingLocationAdd.Size = new Size(90, 23);
            buttonERMEPublishingLocationAdd.TabIndex = 15;
            buttonERMEPublishingLocationAdd.Text = "Добавить";
            buttonERMEPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonERMEPublishingLocationAdd.Click += this.buttonERMEPublishingLocationAdd_Click;
            // 
            // lbERMEPublishingLocation
            // 
            lbERMEPublishingLocation.AllowDrop = true;
            lbERMEPublishingLocation.ContextMenuStrip = cmsListBox;
            lbERMEPublishingLocation.ItemHeight = 15;
            lbERMEPublishingLocation.Location = new Point(0, 205);
            lbERMEPublishingLocation.Name = "lbERMEPublishingLocation";
            lbERMEPublishingLocation.Size = new Size(450, 64);
            lbERMEPublishingLocation.TabIndex = 16;
            lbERMEPublishingLocation.TabStop = false;
            lbERMEPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbERMEPublishingLocation.DragOver += this.ListBox_DragOver;
            lbERMEPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbERMEPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbERMEPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERMEPublisher
            // 
            tbERMEPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEPublisher.Location = new Point(0, 290);
            tbERMEPublisher.Name = "tbERMEPublisher";
            tbERMEPublisher.Size = new Size(237, 23);
            tbERMEPublisher.TabIndex = 16;
            ttMain.SetToolTip(tbERMEPublisher, resources.GetString("tbERMEPublisher.ToolTip"));
            tbERMEPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMEPublisher
            // 
            labelERMEPublisher.AutoSize = true;
            labelERMEPublisher.Location = new Point(0, 272);
            labelERMEPublisher.Name = "labelERMEPublisher";
            labelERMEPublisher.Size = new Size(81, 15);
            labelERMEPublisher.TabIndex = 38;
            labelERMEPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelERMEPublisher, resources.GetString("labelERMEPublisher.ToolTip"));
            // 
            // tbERMEPublishingLocation
            // 
            tbERMEPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEPublishingLocation.Location = new Point(0, 176);
            tbERMEPublishingLocation.Name = "tbERMEPublishingLocation";
            tbERMEPublishingLocation.Size = new Size(354, 23);
            tbERMEPublishingLocation.TabIndex = 14;
            ttMain.SetToolTip(tbERMEPublishingLocation, "Город или города, где было выпущено издание.\r\nПример: «Москва»");
            tbERMEPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMEPublishingLocation
            // 
            labelERMEPublishingLocation.AutoSize = true;
            labelERMEPublishingLocation.Location = new Point(0, 158);
            labelERMEPublishingLocation.Name = "labelERMEPublishingLocation";
            labelERMEPublishingLocation.Size = new Size(89, 15);
            labelERMEPublishingLocation.TabIndex = 36;
            labelERMEPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelERMEPublishingLocation, "Город или города, где было выпущено издание.\r\nПример: «Москва»");
            // 
            // labelERMEAuthors
            // 
            labelERMEAuthors.AutoSize = true;
            labelERMEAuthors.Location = new Point(0, 0);
            labelERMEAuthors.Name = "labelERMEAuthors";
            labelERMEAuthors.Size = new Size(57, 15);
            labelERMEAuthors.TabIndex = 0;
            labelERMEAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelERMEAuthors, resources.GetString("labelERMEAuthors.ToolTip"));
            // 
            // tbERMEAuthors
            // 
            tbERMEAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEAuthors.Location = new Point(0, 18);
            tbERMEAuthors.Name = "tbERMEAuthors";
            tbERMEAuthors.Size = new Size(269, 23);
            tbERMEAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbERMEAuthors, resources.GetString("tbERMEAuthors.ToolTip"));
            tbERMEAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERMEDataCarrier
            // 
            tbERMEDataCarrier.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEDataCarrier.Location = new Point(0, 448);
            tbERMEDataCarrier.Name = "tbERMEDataCarrier";
            tbERMEDataCarrier.Size = new Size(450, 23);
            tbERMEDataCarrier.TabIndex = 20;
            ttMain.SetToolTip(tbERMEDataCarrier, "Тип физического носителя.\r\nПример: «CD-ROM», «DVD», «флеш-накопитель»");
            tbERMEDataCarrier.KeyDown += this.TextBox_KeyDown;
            // 
            // buttonERMEAuthorsAdd
            // 
            buttonERMEAuthorsAdd.Location = new Point(275, 18);
            buttonERMEAuthorsAdd.Name = "buttonERMEAuthorsAdd";
            buttonERMEAuthorsAdd.Size = new Size(90, 23);
            buttonERMEAuthorsAdd.TabIndex = 11;
            buttonERMEAuthorsAdd.Text = "Добавить";
            buttonERMEAuthorsAdd.UseVisualStyleBackColor = true;
            buttonERMEAuthorsAdd.Click += this.buttonERMEAuthorsAdd_Click;
            // 
            // labelERMEDataCarrier
            // 
            labelERMEDataCarrier.AutoSize = true;
            labelERMEDataCarrier.Location = new Point(0, 430);
            labelERMEDataCarrier.Name = "labelERMEDataCarrier";
            labelERMEDataCarrier.Size = new Size(60, 15);
            labelERMEDataCarrier.TabIndex = 12;
            labelERMEDataCarrier.Text = "Носитель";
            ttMain.SetToolTip(labelERMEDataCarrier, "Тип физического носителя.\r\nПример: «CD-ROM», «DVD», «флеш-накопитель»");
            // 
            // lbERMEAuthors
            // 
            lbERMEAuthors.AllowDrop = true;
            lbERMEAuthors.ContextMenuStrip = cmsListBox;
            lbERMEAuthors.ItemHeight = 15;
            lbERMEAuthors.Location = new Point(0, 47);
            lbERMEAuthors.Name = "lbERMEAuthors";
            lbERMEAuthors.Size = new Size(450, 64);
            lbERMEAuthors.TabIndex = 3;
            lbERMEAuthors.TabStop = false;
            lbERMEAuthors.Tag = "";
            lbERMEAuthors.DragDrop += this.ListBox_DragDrop;
            lbERMEAuthors.DragOver += this.ListBox_DragOver;
            lbERMEAuthors.KeyDown += this.ListBox_KeyDown;
            lbERMEAuthors.MouseDown += this.ListBox_MouseDown;
            lbERMEAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERMEPublishYear
            // 
            tbERMEPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEPublishYear.Location = new Point(0, 404);
            tbERMEPublishYear.Name = "tbERMEPublishYear";
            tbERMEPublishYear.Size = new Size(450, 23);
            tbERMEPublishYear.TabIndex = 19;
            ttMain.SetToolTip(tbERMEPublishYear, "Год выпуска диска или иного носителя.\r\nПример: «2023»");
            tbERMEPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMETitle
            // 
            labelERMETitle.AutoSize = true;
            labelERMETitle.Location = new Point(0, 114);
            labelERMETitle.Name = "labelERMETitle";
            labelERMETitle.Size = new Size(57, 15);
            labelERMETitle.TabIndex = 4;
            labelERMETitle.Text = "Заглавие";
            ttMain.SetToolTip(labelERMETitle, "Основное название мультимедийного издания.\r\nПример: «Виртуальный музей истории авиации»");
            // 
            // labelERMEPublishYear
            // 
            labelERMEPublishYear.AutoSize = true;
            labelERMEPublishYear.Location = new Point(0, 386);
            labelERMEPublishYear.Name = "labelERMEPublishYear";
            labelERMEPublishYear.Size = new Size(73, 15);
            labelERMEPublishYear.TabIndex = 10;
            labelERMEPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelERMEPublishYear, "Год выпуска диска или иного носителя.\r\nПример: «2023»");
            // 
            // tbERMETitle
            // 
            tbERMETitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMETitle.Location = new Point(0, 132);
            tbERMETitle.Name = "tbERMETitle";
            tbERMETitle.Size = new Size(450, 23);
            tbERMETitle.TabIndex = 13;
            ttMain.SetToolTip(tbERMETitle, "Основное название мультимедийного издания.\r\nПример: «Виртуальный музей истории авиации»");
            tbERMETitle.KeyDown += this.TextBox_KeyDown;
            // 
            // gbERMultimediaEditionOptional
            // 
            gbERMultimediaEditionOptional.Controls.Add(panelERMultimediaEditionOptional);
            gbERMultimediaEditionOptional.Location = new Point(10, 346);
            gbERMultimediaEditionOptional.Name = "gbERMultimediaEditionOptional";
            gbERMultimediaEditionOptional.Size = new Size(488, 330);
            gbERMultimediaEditionOptional.TabIndex = 3;
            gbERMultimediaEditionOptional.TabStop = false;
            gbERMultimediaEditionOptional.Text = "Необязательные поля";
            // 
            // panelERMultimediaEditionOptional
            // 
            panelERMultimediaEditionOptional.AutoScroll = true;
            panelERMultimediaEditionOptional.Controls.Add(tbERMESeries);
            panelERMultimediaEditionOptional.Controls.Add(labelERMESeries);
            panelERMultimediaEditionOptional.Controls.Add(labelERMEContentType);
            panelERMultimediaEditionOptional.Controls.Add(tbERMEContentType);
            panelERMultimediaEditionOptional.Controls.Add(labelERMEDocumentType);
            panelERMultimediaEditionOptional.Controls.Add(labelERMEISBN);
            panelERMultimediaEditionOptional.Controls.Add(tbERMENotation);
            panelERMultimediaEditionOptional.Controls.Add(tbERMEOrganization);
            panelERMultimediaEditionOptional.Controls.Add(tbERMEDocumentType);
            panelERMultimediaEditionOptional.Controls.Add(labelERMENotation);
            panelERMultimediaEditionOptional.Controls.Add(tbERMEISBN);
            panelERMultimediaEditionOptional.Controls.Add(labelERMEOrganization);
            panelERMultimediaEditionOptional.Location = new Point(10, 22);
            panelERMultimediaEditionOptional.Name = "panelERMultimediaEditionOptional";
            panelERMultimediaEditionOptional.Size = new Size(473, 302);
            panelERMultimediaEditionOptional.TabIndex = 12;
            // 
            // tbERMESeries
            // 
            tbERMESeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMESeries.Location = new Point(0, 106);
            tbERMESeries.Name = "tbERMESeries";
            tbERMESeries.Size = new Size(450, 23);
            tbERMESeries.TabIndex = 23;
            ttMain.SetToolTip(tbERMESeries, "Название серии, если издание входит в серию.\r\nПример: «Электронная школа»");
            tbERMESeries.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMESeries
            // 
            labelERMESeries.AutoSize = true;
            labelERMESeries.Location = new Point(0, 88);
            labelERMESeries.Name = "labelERMESeries";
            labelERMESeries.Size = new Size(41, 15);
            labelERMESeries.TabIndex = 20;
            labelERMESeries.Text = "Серия";
            ttMain.SetToolTip(labelERMESeries, "Название серии, если издание входит в серию.\r\nПример: «Электронная школа»");
            // 
            // labelERMEContentType
            // 
            labelERMEContentType.AutoSize = true;
            labelERMEContentType.Location = new Point(0, 220);
            labelERMEContentType.Name = "labelERMEContentType";
            labelERMEContentType.Size = new Size(97, 15);
            labelERMEContentType.TabIndex = 18;
            labelERMEContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelERMEContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbERMEContentType
            // 
            tbERMEContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEContentType.Location = new Point(0, 238);
            tbERMEContentType.Name = "tbERMEContentType";
            tbERMEContentType.Size = new Size(450, 23);
            tbERMEContentType.TabIndex = 26;
            ttMain.SetToolTip(tbERMEContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbERMEContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMEDocumentType
            // 
            labelERMEDocumentType.AutoSize = true;
            labelERMEDocumentType.Location = new Point(0, 0);
            labelERMEDocumentType.Name = "labelERMEDocumentType";
            labelERMEDocumentType.Size = new Size(88, 15);
            labelERMEDocumentType.TabIndex = 0;
            labelERMEDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelERMEDocumentType, "Уточнение вида издания: учебное пособие, каталог и т. д.\r\nПример: «учебное пособие»");
            // 
            // labelERMEISBN
            // 
            labelERMEISBN.AutoSize = true;
            labelERMEISBN.Location = new Point(0, 176);
            labelERMEISBN.Name = "labelERMEISBN";
            labelERMEISBN.Size = new Size(32, 15);
            labelERMEISBN.TabIndex = 10;
            labelERMEISBN.Text = "ISBN";
            ttMain.SetToolTip(labelERMEISBN, "Международный стандартный книжный номер.\r\nПример: «978-5-1234-5678-0»");
            // 
            // tbERMENotation
            // 
            tbERMENotation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMENotation.Location = new Point(0, 150);
            tbERMENotation.Name = "tbERMENotation";
            tbERMENotation.Size = new Size(450, 23);
            tbERMENotation.TabIndex = 24;
            ttMain.SetToolTip(tbERMENotation, "УДК, ББК и другие обозначения.\r\nПример: «УДК 528.44»");
            tbERMENotation.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERMEOrganization
            // 
            tbERMEOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEOrganization.Location = new Point(0, 62);
            tbERMEOrganization.Name = "tbERMEOrganization";
            tbERMEOrganization.Size = new Size(450, 23);
            tbERMEOrganization.TabIndex = 22;
            ttMain.SetToolTip(tbERMEOrganization, "Научная, образовательная или иная организация, участвующая в создании.\r\nПример: «Российская академия наук»");
            tbERMEOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERMEDocumentType
            // 
            tbERMEDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEDocumentType.Location = new Point(0, 18);
            tbERMEDocumentType.Name = "tbERMEDocumentType";
            tbERMEDocumentType.Size = new Size(450, 23);
            tbERMEDocumentType.TabIndex = 21;
            ttMain.SetToolTip(tbERMEDocumentType, "Уточнение вида издания: учебное пособие, каталог и т. д.\r\nПример: «учебное пособие»");
            tbERMEDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMENotation
            // 
            labelERMENotation.AutoSize = true;
            labelERMENotation.Location = new Point(0, 132);
            labelERMENotation.Name = "labelERMENotation";
            labelERMENotation.Size = new Size(78, 15);
            labelERMENotation.TabIndex = 8;
            labelERMENotation.Text = "Примечание";
            ttMain.SetToolTip(labelERMENotation, "УДК, ББК и другие обозначения.\r\nПример: «УДК 528.44»");
            // 
            // tbERMEISBN
            // 
            tbERMEISBN.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERMEISBN.Location = new Point(0, 194);
            tbERMEISBN.Name = "tbERMEISBN";
            tbERMEISBN.Size = new Size(450, 23);
            tbERMEISBN.TabIndex = 25;
            ttMain.SetToolTip(tbERMEISBN, "Международный стандартный книжный номер.\r\nПример: «978-5-1234-5678-0»");
            tbERMEISBN.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERMEOrganization
            // 
            labelERMEOrganization.AutoSize = true;
            labelERMEOrganization.Location = new Point(0, 44);
            labelERMEOrganization.Name = "labelERMEOrganization";
            labelERMEOrganization.Size = new Size(79, 15);
            labelERMEOrganization.TabIndex = 6;
            labelERMEOrganization.Text = "Организация";
            ttMain.SetToolTip(labelERMEOrganization, "Научная, образовательная или иная организация, участвующая в создании.\r\nПример: «Российская академия наук»");
            // 
            // tpERWebsite
            // 
            tpERWebsite.BackColor = SystemColors.Control;
            tpERWebsite.Controls.Add(gbERWebsiteRequired);
            tpERWebsite.Controls.Add(gbERWebsiteOptional);
            tpERWebsite.Location = new Point(4, 24);
            tpERWebsite.Name = "tpERWebsite";
            tpERWebsite.Padding = new Padding(3);
            tpERWebsite.Size = new Size(505, 681);
            tpERWebsite.TabIndex = 3;
            tpERWebsite.Text = "Сайт";
            // 
            // gbERWebsiteRequired
            // 
            gbERWebsiteRequired.Controls.Add(panelERWebsiteRequired);
            gbERWebsiteRequired.Location = new Point(10, 10);
            gbERWebsiteRequired.Name = "gbERWebsiteRequired";
            gbERWebsiteRequired.Size = new Size(488, 330);
            gbERWebsiteRequired.TabIndex = 6;
            gbERWebsiteRequired.TabStop = false;
            gbERWebsiteRequired.Text = "Обязательные поля";
            // 
            // panelERWebsiteRequired
            // 
            panelERWebsiteRequired.AutoScroll = true;
            panelERWebsiteRequired.Controls.Add(labelERWWebsiteName);
            panelERWebsiteRequired.Controls.Add(labelERWURL);
            panelERWebsiteRequired.Controls.Add(tbERWAccessDate);
            panelERWebsiteRequired.Controls.Add(tbERWURL);
            panelERWebsiteRequired.Controls.Add(labelERWAccessDate);
            panelERWebsiteRequired.Controls.Add(tbERWWebsiteName);
            panelERWebsiteRequired.Location = new Point(10, 22);
            panelERWebsiteRequired.Name = "panelERWebsiteRequired";
            panelERWebsiteRequired.Size = new Size(473, 302);
            panelERWebsiteRequired.TabIndex = 16;
            // 
            // labelERWWebsiteName
            // 
            labelERWWebsiteName.AutoSize = true;
            labelERWWebsiteName.Location = new Point(0, 0);
            labelERWWebsiteName.Name = "labelERWWebsiteName";
            labelERWWebsiteName.Size = new Size(92, 15);
            labelERWWebsiteName.TabIndex = 4;
            labelERWWebsiteName.Text = "Название сайта";
            ttMain.SetToolTip(labelERWWebsiteName, "Название ресурса, как указано на самом сайте.\r\nПример: «Министерство финансов Российской Федерации»");
            // 
            // labelERWURL
            // 
            labelERWURL.AutoSize = true;
            labelERWURL.Location = new Point(0, 44);
            labelERWURL.Name = "labelERWURL";
            labelERWURL.Size = new Size(28, 15);
            labelERWURL.TabIndex = 14;
            labelERWURL.Text = "URL";
            ttMain.SetToolTip(labelERWURL, "Полный адрес ресурса в интернете.\r\nПример: «https://minfin.gov.ru»");
            // 
            // tbERWAccessDate
            // 
            tbERWAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWAccessDate.Location = new Point(0, 106);
            tbERWAccessDate.Name = "tbERWAccessDate";
            tbERWAccessDate.Size = new Size(450, 23);
            tbERWAccessDate.TabIndex = 12;
            ttMain.SetToolTip(tbERWAccessDate, "Дата, когда вы последний раз обращались к ресурсу.\r\nПример: «02.06.2025»");
            tbERWAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWURL
            // 
            tbERWURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWURL.Location = new Point(0, 62);
            tbERWURL.Name = "tbERWURL";
            tbERWURL.Size = new Size(450, 23);
            tbERWURL.TabIndex = 11;
            ttMain.SetToolTip(tbERWURL, "Полный адрес ресурса в интернете.\r\nПример: «https://minfin.gov.ru»");
            tbERWURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWAccessDate
            // 
            labelERWAccessDate.AutoSize = true;
            labelERWAccessDate.Location = new Point(0, 88);
            labelERWAccessDate.Name = "labelERWAccessDate";
            labelERWAccessDate.Size = new Size(99, 15);
            labelERWAccessDate.TabIndex = 6;
            labelERWAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelERWAccessDate, "Дата, когда вы последний раз обращались к ресурсу.\r\nПример: «02.06.2025»");
            // 
            // tbERWWebsiteName
            // 
            tbERWWebsiteName.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWWebsiteName.Location = new Point(0, 18);
            tbERWWebsiteName.Name = "tbERWWebsiteName";
            tbERWWebsiteName.Size = new Size(450, 23);
            tbERWWebsiteName.TabIndex = 10;
            ttMain.SetToolTip(tbERWWebsiteName, "Название ресурса, как указано на самом сайте.\r\nПример: «Министерство финансов Российской Федерации»");
            tbERWWebsiteName.KeyDown += this.TextBox_KeyDown;
            // 
            // gbERWebsiteOptional
            // 
            gbERWebsiteOptional.Controls.Add(panelERWebsiteOptional);
            gbERWebsiteOptional.Location = new Point(10, 346);
            gbERWebsiteOptional.Name = "gbERWebsiteOptional";
            gbERWebsiteOptional.Size = new Size(488, 330);
            gbERWebsiteOptional.TabIndex = 7;
            gbERWebsiteOptional.TabStop = false;
            gbERWebsiteOptional.Text = "Необязательные поля";
            // 
            // panelERWebsiteOptional
            // 
            panelERWebsiteOptional.AutoScroll = true;
            panelERWebsiteOptional.Controls.Add(lbERWPublishingLocationSelect);
            panelERWebsiteOptional.Controls.Add(cbERWPublisher);
            panelERWebsiteOptional.Controls.Add(buttonERWPublisherAdd);
            panelERWebsiteOptional.Controls.Add(lbERWPublisher);
            panelERWebsiteOptional.Controls.Add(buttonERWPublishingLocationAdd);
            panelERWebsiteOptional.Controls.Add(lbERWPublishingLocation);
            panelERWebsiteOptional.Controls.Add(tbERWPublisher);
            panelERWebsiteOptional.Controls.Add(labelERWPublisher);
            panelERWebsiteOptional.Controls.Add(tbERWPublishingLocation);
            panelERWebsiteOptional.Controls.Add(labelERWPublishingLocation);
            panelERWebsiteOptional.Controls.Add(labelERWDetails);
            panelERWebsiteOptional.Controls.Add(tbERWDetails);
            panelERWebsiteOptional.Controls.Add(labelERWPublicationDate);
            panelERWebsiteOptional.Controls.Add(tbERWPublicationDate);
            panelERWebsiteOptional.Controls.Add(labelERWResourceDescription);
            panelERWebsiteOptional.Controls.Add(tbERWResourceDescription);
            panelERWebsiteOptional.Controls.Add(labelERWContentType);
            panelERWebsiteOptional.Controls.Add(tbERWContentType);
            panelERWebsiteOptional.Controls.Add(labelERWResourceType);
            panelERWebsiteOptional.Controls.Add(labelERWOrganization);
            panelERWebsiteOptional.Controls.Add(tbERWAccessMode);
            panelERWebsiteOptional.Controls.Add(tbERWOrganization);
            panelERWebsiteOptional.Controls.Add(labelERWAccessMode);
            panelERWebsiteOptional.Controls.Add(tbERWCreationYear);
            panelERWebsiteOptional.Controls.Add(tbERWResourceType);
            panelERWebsiteOptional.Controls.Add(labelERWCreationYear);
            panelERWebsiteOptional.Location = new Point(10, 22);
            panelERWebsiteOptional.Name = "panelERWebsiteOptional";
            panelERWebsiteOptional.Size = new Size(473, 302);
            panelERWebsiteOptional.TabIndex = 10;
            // 
            // lbERWPublishingLocationSelect
            // 
            lbERWPublishingLocationSelect.Enabled = false;
            lbERWPublishingLocationSelect.FormattingEnabled = true;
            lbERWPublishingLocationSelect.ItemHeight = 15;
            lbERWPublishingLocationSelect.Location = new Point(243, 249);
            lbERWPublishingLocationSelect.Name = "lbERWPublishingLocationSelect";
            lbERWPublishingLocationSelect.Size = new Size(207, 64);
            lbERWPublishingLocationSelect.TabIndex = 55;
            lbERWPublishingLocationSelect.TabStop = false;
            // 
            // cbERWPublisher
            // 
            cbERWPublisher.AutoSize = true;
            cbERWPublisher.Location = new Point(339, 222);
            cbERWPublisher.Name = "cbERWPublisher";
            cbERWPublisher.Size = new Size(111, 19);
            cbERWPublisher.TabIndex = 19;
            cbERWPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbERWPublisher, "Включение «умного режима» добавления издательств");
            cbERWPublisher.UseVisualStyleBackColor = true;
            // 
            // buttonERWPublisherAdd
            // 
            buttonERWPublisherAdd.Location = new Point(243, 220);
            buttonERWPublisherAdd.Name = "buttonERWPublisherAdd";
            buttonERWPublisherAdd.Size = new Size(90, 23);
            buttonERWPublisherAdd.TabIndex = 18;
            buttonERWPublisherAdd.Text = "Добавить";
            buttonERWPublisherAdd.UseVisualStyleBackColor = true;
            buttonERWPublisherAdd.Click += this.buttonERWPublisherAdd_Click;
            // 
            // lbERWPublisher
            // 
            lbERWPublisher.AllowDrop = true;
            lbERWPublisher.ContextMenuStrip = cmsListBox;
            lbERWPublisher.ItemHeight = 15;
            lbERWPublisher.Location = new Point(0, 249);
            lbERWPublisher.Name = "lbERWPublisher";
            lbERWPublisher.Size = new Size(237, 64);
            lbERWPublisher.TabIndex = 52;
            lbERWPublisher.TabStop = false;
            lbERWPublisher.DragDrop += this.ListBox_DragDrop;
            lbERWPublisher.DragOver += this.ListBox_DragOver;
            lbERWPublisher.KeyDown += this.ListBox_KeyDown;
            lbERWPublisher.MouseDown += this.ListBox_MouseDown;
            lbERWPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonERWPublishingLocationAdd
            // 
            buttonERWPublishingLocationAdd.Location = new Point(360, 106);
            buttonERWPublishingLocationAdd.Name = "buttonERWPublishingLocationAdd";
            buttonERWPublishingLocationAdd.Size = new Size(90, 23);
            buttonERWPublishingLocationAdd.TabIndex = 16;
            buttonERWPublishingLocationAdd.Text = "Добавить";
            buttonERWPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonERWPublishingLocationAdd.Click += this.buttonERWPublishingLocationAdd_Click;
            // 
            // lbERWPublishingLocation
            // 
            lbERWPublishingLocation.AllowDrop = true;
            lbERWPublishingLocation.ContextMenuStrip = cmsListBox;
            lbERWPublishingLocation.ItemHeight = 15;
            lbERWPublishingLocation.Location = new Point(0, 135);
            lbERWPublishingLocation.Name = "lbERWPublishingLocation";
            lbERWPublishingLocation.Size = new Size(450, 64);
            lbERWPublishingLocation.TabIndex = 50;
            lbERWPublishingLocation.TabStop = false;
            lbERWPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbERWPublishingLocation.DragOver += this.ListBox_DragOver;
            lbERWPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbERWPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbERWPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbERWPublisher
            // 
            tbERWPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWPublisher.Location = new Point(0, 220);
            tbERWPublisher.Name = "tbERWPublisher";
            tbERWPublisher.Size = new Size(237, 23);
            tbERWPublisher.TabIndex = 17;
            ttMain.SetToolTip(tbERWPublisher, resources.GetString("tbERWPublisher.ToolTip"));
            tbERWPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWPublisher
            // 
            labelERWPublisher.AutoSize = true;
            labelERWPublisher.Location = new Point(0, 202);
            labelERWPublisher.Name = "labelERWPublisher";
            labelERWPublisher.Size = new Size(81, 15);
            labelERWPublisher.TabIndex = 48;
            labelERWPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelERWPublisher, resources.GetString("labelERWPublisher.ToolTip"));
            // 
            // tbERWPublishingLocation
            // 
            tbERWPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWPublishingLocation.Location = new Point(0, 106);
            tbERWPublishingLocation.Name = "tbERWPublishingLocation";
            tbERWPublishingLocation.Size = new Size(354, 23);
            tbERWPublishingLocation.TabIndex = 15;
            ttMain.SetToolTip(tbERWPublishingLocation, "Город или несколько городов, где размещён сайт или находится организация.\r\nПример: «Москва»");
            tbERWPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWPublishingLocation
            // 
            labelERWPublishingLocation.AutoSize = true;
            labelERWPublishingLocation.Location = new Point(0, 88);
            labelERWPublishingLocation.Name = "labelERWPublishingLocation";
            labelERWPublishingLocation.Size = new Size(89, 15);
            labelERWPublishingLocation.TabIndex = 46;
            labelERWPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelERWPublishingLocation, "Город или несколько городов, где размещён сайт или находится организация.\r\nПример: «Москва»");
            // 
            // labelERWDetails
            // 
            labelERWDetails.AutoSize = true;
            labelERWDetails.Location = new Point(0, 404);
            labelERWDetails.Name = "labelERWDetails";
            labelERWDetails.Size = new Size(156, 15);
            labelERWDetails.TabIndex = 26;
            labelERWDetails.Text = "Дополнительные сведения";
            ttMain.SetToolTip(labelERWDetails, "Любая дополнительная информация, не попавшая в другие поля.\r\nПример: «Обновляется ежеквартально»");
            // 
            // tbERWDetails
            // 
            tbERWDetails.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWDetails.Location = new Point(0, 422);
            tbERWDetails.Name = "tbERWDetails";
            tbERWDetails.Size = new Size(450, 23);
            tbERWDetails.TabIndex = 22;
            ttMain.SetToolTip(tbERWDetails, "Любая дополнительная информация, не попавшая в другие поля.\r\nПример: «Обновляется ежеквартально»");
            tbERWDetails.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWPublicationDate
            // 
            labelERWPublicationDate.AutoSize = true;
            labelERWPublicationDate.Location = new Point(0, 492);
            labelERWPublicationDate.Name = "labelERWPublicationDate";
            labelERWPublicationDate.Size = new Size(102, 15);
            labelERWPublicationDate.TabIndex = 24;
            labelERWPublicationDate.Text = "Дата публикации";
            ttMain.SetToolTip(labelERWPublicationDate, "Дата последнего значимого обновления конкретного раздела или страницы.\r\nПример: «17 января 2023»");
            // 
            // tbERWPublicationDate
            // 
            tbERWPublicationDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWPublicationDate.Location = new Point(0, 510);
            tbERWPublicationDate.Name = "tbERWPublicationDate";
            tbERWPublicationDate.Size = new Size(450, 23);
            tbERWPublicationDate.TabIndex = 24;
            ttMain.SetToolTip(tbERWPublicationDate, "Дата последнего значимого обновления конкретного раздела или страницы.\r\nПример: «17 января 2023»");
            tbERWPublicationDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWResourceDescription
            // 
            labelERWResourceDescription.AutoSize = true;
            labelERWResourceDescription.Location = new Point(0, 0);
            labelERWResourceDescription.Name = "labelERWResourceDescription";
            labelERWResourceDescription.Size = new Size(109, 15);
            labelERWResourceDescription.TabIndex = 22;
            labelERWResourceDescription.Text = "Описание ресурса";
            ttMain.SetToolTip(labelERWResourceDescription, "Краткое пояснение о типе сайта или его направленности.\r\nПример: «научная электронная библиотека»");
            // 
            // tbERWResourceDescription
            // 
            tbERWResourceDescription.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWResourceDescription.Location = new Point(0, 18);
            tbERWResourceDescription.Name = "tbERWResourceDescription";
            tbERWResourceDescription.Size = new Size(450, 23);
            tbERWResourceDescription.TabIndex = 13;
            ttMain.SetToolTip(tbERWResourceDescription, "Краткое пояснение о типе сайта или его направленности.\r\nПример: «научная электронная библиотека»");
            tbERWResourceDescription.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWContentType
            // 
            labelERWContentType.AutoSize = true;
            labelERWContentType.Location = new Point(0, 536);
            labelERWContentType.Name = "labelERWContentType";
            labelERWContentType.Size = new Size(97, 15);
            labelERWContentType.TabIndex = 20;
            labelERWContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelERWContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbERWContentType
            // 
            tbERWContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWContentType.Location = new Point(0, 554);
            tbERWContentType.Name = "tbERWContentType";
            tbERWContentType.Size = new Size(450, 23);
            tbERWContentType.TabIndex = 25;
            ttMain.SetToolTip(tbERWContentType, "Уточняет тип содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbERWContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWResourceType
            // 
            labelERWResourceType.AutoSize = true;
            labelERWResourceType.Location = new Point(0, 44);
            labelERWResourceType.Name = "labelERWResourceType";
            labelERWResourceType.Size = new Size(74, 15);
            labelERWResourceType.TabIndex = 0;
            labelERWResourceType.Text = "Тип ресурса";
            ttMain.SetToolTip(labelERWResourceType, "Уточнение типа: сайт, официальный сайт, электронный журнал и т. п.\r\nПример: «официальный сайт»");
            // 
            // labelERWOrganization
            // 
            labelERWOrganization.AutoSize = true;
            labelERWOrganization.Location = new Point(0, 448);
            labelERWOrganization.Name = "labelERWOrganization";
            labelERWOrganization.Size = new Size(146, 15);
            labelERWOrganization.TabIndex = 8;
            labelERWOrganization.Text = "Учредитель/организация";
            ttMain.SetToolTip(labelERWOrganization, "Организация, ответственно за наполнение или публикацию ресурса.\r\nПример: «Министерство цифрового развития»");
            // 
            // tbERWAccessMode
            // 
            tbERWAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWAccessMode.Location = new Point(0, 378);
            tbERWAccessMode.Name = "tbERWAccessMode";
            tbERWAccessMode.Size = new Size(450, 23);
            tbERWAccessMode.TabIndex = 21;
            ttMain.SetToolTip(tbERWAccessMode, "Как именно осуществляется доступ: свободный, по подписке, платный и т. д.\r\nПример: «свободный»");
            tbERWAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWOrganization
            // 
            tbERWOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWOrganization.Location = new Point(0, 466);
            tbERWOrganization.Name = "tbERWOrganization";
            tbERWOrganization.Size = new Size(450, 23);
            tbERWOrganization.TabIndex = 23;
            ttMain.SetToolTip(tbERWOrganization, "Организация, ответственно за наполнение или публикацию ресурса.\r\nПример: «Министерство цифрового развития»");
            tbERWOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWAccessMode
            // 
            labelERWAccessMode.AutoSize = true;
            labelERWAccessMode.Location = new Point(0, 360);
            labelERWAccessMode.Name = "labelERWAccessMode";
            labelERWAccessMode.Size = new Size(91, 15);
            labelERWAccessMode.TabIndex = 6;
            labelERWAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelERWAccessMode, "Как именно осуществляется доступ: свободный, по подписке, платный и т. д.\r\nПример: «свободный»");
            // 
            // tbERWCreationYear
            // 
            tbERWCreationYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWCreationYear.Location = new Point(0, 334);
            tbERWCreationYear.Name = "tbERWCreationYear";
            tbERWCreationYear.Size = new Size(450, 23);
            tbERWCreationYear.TabIndex = 20;
            ttMain.SetToolTip(tbERWCreationYear, "Год первоначального размещения или запуска сайта или обновления сайта.\r\nПример: «2012»\r\n");
            tbERWCreationYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbERWResourceType
            // 
            tbERWResourceType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbERWResourceType.Location = new Point(0, 62);
            tbERWResourceType.Name = "tbERWResourceType";
            tbERWResourceType.Size = new Size(450, 23);
            tbERWResourceType.TabIndex = 14;
            ttMain.SetToolTip(tbERWResourceType, "Уточнение типа: сайт, официальный сайт, электронный журнал и т. п.\r\nПример: «официальный сайт»");
            tbERWResourceType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelERWCreationYear
            // 
            labelERWCreationYear.AutoSize = true;
            labelERWCreationYear.Location = new Point(0, 316);
            labelERWCreationYear.Name = "labelERWCreationYear";
            labelERWCreationYear.Size = new Size(151, 15);
            labelERWCreationYear.TabIndex = 4;
            labelERWCreationYear.Text = "Год создания/обновления";
            ttMain.SetToolTip(labelERWCreationYear, "Год первоначального размещения или запуска сайта или обновления сайта.\r\nПример: «2012»");
            // 
            // tpConstituentParts
            // 
            tpConstituentParts.BackColor = SystemColors.Control;
            tpConstituentParts.Controls.Add(tcCPTypes);
            tpConstituentParts.Location = new Point(4, 24);
            tpConstituentParts.Name = "tpConstituentParts";
            tpConstituentParts.Padding = new Padding(3);
            tpConstituentParts.Size = new Size(521, 720);
            tpConstituentParts.TabIndex = 3;
            tpConstituentParts.Text = "Составные части (статьи, главы) ресурсов";
            // 
            // tcCPTypes
            // 
            tcCPTypes.Controls.Add(tpCPBookArticle);
            tcCPTypes.Controls.Add(tpCPConferenceArticle);
            tcCPTypes.Controls.Add(tpCPJournalArticle);
            tcCPTypes.Controls.Add(tpCPNewspaperArticle);
            tcCPTypes.Controls.Add(tpCPWebsiteArticle);
            tcCPTypes.Location = new Point(3, 6);
            tcCPTypes.Name = "tcCPTypes";
            tcCPTypes.SelectedIndex = 0;
            tcCPTypes.Size = new Size(513, 709);
            tcCPTypes.TabIndex = 2;
            tcCPTypes.TabStop = false;
            // 
            // tpCPBookArticle
            // 
            tpCPBookArticle.BackColor = SystemColors.Control;
            tpCPBookArticle.Controls.Add(gbCPBookArticleRequired);
            tpCPBookArticle.Controls.Add(gbCPBookArticleOptional);
            tpCPBookArticle.Location = new Point(4, 24);
            tpCPBookArticle.Name = "tpCPBookArticle";
            tpCPBookArticle.Padding = new Padding(3);
            tpCPBookArticle.Size = new Size(505, 681);
            tpCPBookArticle.TabIndex = 0;
            tpCPBookArticle.Text = "Статья из книги";
            // 
            // gbCPBookArticleRequired
            // 
            gbCPBookArticleRequired.Controls.Add(panelCPBookArticleRequired);
            gbCPBookArticleRequired.Location = new Point(10, 10);
            gbCPBookArticleRequired.Name = "gbCPBookArticleRequired";
            gbCPBookArticleRequired.Size = new Size(488, 330);
            gbCPBookArticleRequired.TabIndex = 0;
            gbCPBookArticleRequired.TabStop = false;
            gbCPBookArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPBookArticleRequired
            // 
            panelCPBookArticleRequired.AutoScroll = true;
            panelCPBookArticleRequired.Controls.Add(cbCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(labelCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(tbCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(lbCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(buttonCPBABookAuthorsAdd);
            panelCPBookArticleRequired.Controls.Add(lbCPBAPublishingLocationSelect);
            panelCPBookArticleRequired.Controls.Add(cbCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(buttonCPBAPublisherAdd);
            panelCPBookArticleRequired.Controls.Add(lbCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(buttonCPBAPublishingLocationAdd);
            panelCPBookArticleRequired.Controls.Add(lbCPBAPublishingLocation);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublishingLocation);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublishingLocation);
            panelCPBookArticleRequired.Controls.Add(cbCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPages);
            panelCPBookArticleRequired.Controls.Add(labelCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPages);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublishYear);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublishYear);
            panelCPBookArticleRequired.Controls.Add(tbCPBABookTitle);
            panelCPBookArticleRequired.Controls.Add(labelCPBABookTitle);
            panelCPBookArticleRequired.Controls.Add(tbCPBAArticleTitle);
            panelCPBookArticleRequired.Controls.Add(labelCPBAArticleTitle);
            panelCPBookArticleRequired.Controls.Add(tbCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(lbCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(buttonCPBAArticleAuthorsAdd);
            panelCPBookArticleRequired.Location = new Point(10, 22);
            panelCPBookArticleRequired.Name = "panelCPBookArticleRequired";
            panelCPBookArticleRequired.Size = new Size(473, 302);
            panelCPBookArticleRequired.TabIndex = 0;
            // 
            // cbCPBABookAuthors
            // 
            cbCPBABookAuthors.AutoSize = true;
            cbCPBABookAuthors.Location = new Point(371, 178);
            cbCPBABookAuthors.Name = "cbCPBABookAuthors";
            cbCPBABookAuthors.Size = new Size(79, 19);
            cbCPBABookAuthors.TabIndex = 16;
            cbCPBABookAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPBABookAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPBABookAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPBABookAuthors
            // 
            labelCPBABookAuthors.AutoSize = true;
            labelCPBABookAuthors.Location = new Point(0, 158);
            labelCPBABookAuthors.Name = "labelCPBABookAuthors";
            labelCPBABookAuthors.Size = new Size(92, 15);
            labelCPBABookAuthors.TabIndex = 54;
            labelCPBABookAuthors.Text = "Автор(ы) книги";
            ttMain.SetToolTip(labelCPBABookAuthors, resources.GetString("labelCPBABookAuthors.ToolTip"));
            // 
            // tbCPBABookAuthors
            // 
            tbCPBABookAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBABookAuthors.Location = new Point(0, 176);
            tbCPBABookAuthors.Name = "tbCPBABookAuthors";
            tbCPBABookAuthors.Size = new Size(269, 23);
            tbCPBABookAuthors.TabIndex = 14;
            ttMain.SetToolTip(tbCPBABookAuthors, resources.GetString("tbCPBABookAuthors.ToolTip"));
            tbCPBABookAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPBABookAuthors
            // 
            lbCPBABookAuthors.AllowDrop = true;
            lbCPBABookAuthors.ContextMenuStrip = cmsListBox;
            lbCPBABookAuthors.ItemHeight = 15;
            lbCPBABookAuthors.Location = new Point(0, 205);
            lbCPBABookAuthors.Name = "lbCPBABookAuthors";
            lbCPBABookAuthors.Size = new Size(450, 64);
            lbCPBABookAuthors.TabIndex = 57;
            lbCPBABookAuthors.TabStop = false;
            lbCPBABookAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPBABookAuthors.DragOver += this.ListBox_DragOver;
            lbCPBABookAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPBABookAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPBABookAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPBABookAuthorsAdd
            // 
            buttonCPBABookAuthorsAdd.Location = new Point(275, 176);
            buttonCPBABookAuthorsAdd.Name = "buttonCPBABookAuthorsAdd";
            buttonCPBABookAuthorsAdd.Size = new Size(90, 23);
            buttonCPBABookAuthorsAdd.TabIndex = 15;
            buttonCPBABookAuthorsAdd.Text = "Добавить";
            buttonCPBABookAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPBABookAuthorsAdd.Click += this.buttonCPBABookAuthorsAdd_Click;
            // 
            // lbCPBAPublishingLocationSelect
            // 
            lbCPBAPublishingLocationSelect.Enabled = false;
            lbCPBAPublishingLocationSelect.FormattingEnabled = true;
            lbCPBAPublishingLocationSelect.ItemHeight = 15;
            lbCPBAPublishingLocationSelect.Location = new Point(243, 477);
            lbCPBAPublishingLocationSelect.Name = "lbCPBAPublishingLocationSelect";
            lbCPBAPublishingLocationSelect.Size = new Size(207, 64);
            lbCPBAPublishingLocationSelect.TabIndex = 53;
            lbCPBAPublishingLocationSelect.TabStop = false;
            lbCPBAPublishingLocationSelect.SelectedIndexChanged += this.lbCPBAPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbCPBAPublisher
            // 
            cbCPBAPublisher.AutoSize = true;
            cbCPBAPublisher.Location = new Point(339, 450);
            cbCPBAPublisher.Name = "cbCPBAPublisher";
            cbCPBAPublisher.Size = new Size(111, 19);
            cbCPBAPublisher.TabIndex = 22;
            cbCPBAPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbCPBAPublisher, "Включение «умного режима» добавления издательств\r\n");
            cbCPBAPublisher.UseVisualStyleBackColor = true;
            cbCPBAPublisher.CheckedChanged += this.cbCPBAPublisher_CheckedChanged;
            // 
            // buttonCPBAPublisherAdd
            // 
            buttonCPBAPublisherAdd.Location = new Point(243, 448);
            buttonCPBAPublisherAdd.Name = "buttonCPBAPublisherAdd";
            buttonCPBAPublisherAdd.Size = new Size(90, 23);
            buttonCPBAPublisherAdd.TabIndex = 21;
            buttonCPBAPublisherAdd.Text = "Добавить";
            buttonCPBAPublisherAdd.UseVisualStyleBackColor = true;
            buttonCPBAPublisherAdd.Click += this.buttonCPBAPublisherAdd_Click;
            // 
            // lbCPBAPublisher
            // 
            lbCPBAPublisher.AllowDrop = true;
            lbCPBAPublisher.ContextMenuStrip = cmsListBox;
            lbCPBAPublisher.ItemHeight = 15;
            lbCPBAPublisher.Location = new Point(0, 477);
            lbCPBAPublisher.Name = "lbCPBAPublisher";
            lbCPBAPublisher.Size = new Size(237, 64);
            lbCPBAPublisher.TabIndex = 51;
            lbCPBAPublisher.TabStop = false;
            lbCPBAPublisher.DragDrop += this.ListBox_DragDrop;
            lbCPBAPublisher.DragOver += this.ListBox_DragOver;
            lbCPBAPublisher.KeyDown += this.ListBox_KeyDown;
            lbCPBAPublisher.MouseDown += this.ListBox_MouseDown;
            lbCPBAPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPBAPublishingLocationAdd
            // 
            buttonCPBAPublishingLocationAdd.Location = new Point(360, 334);
            buttonCPBAPublishingLocationAdd.Name = "buttonCPBAPublishingLocationAdd";
            buttonCPBAPublishingLocationAdd.Size = new Size(90, 23);
            buttonCPBAPublishingLocationAdd.TabIndex = 19;
            buttonCPBAPublishingLocationAdd.Text = "Добавить";
            buttonCPBAPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonCPBAPublishingLocationAdd.Click += this.buttonCPBAPublishingLocationAdd_Click;
            // 
            // lbCPBAPublishingLocation
            // 
            lbCPBAPublishingLocation.AllowDrop = true;
            lbCPBAPublishingLocation.ContextMenuStrip = cmsListBox;
            lbCPBAPublishingLocation.ItemHeight = 15;
            lbCPBAPublishingLocation.Location = new Point(0, 363);
            lbCPBAPublishingLocation.Name = "lbCPBAPublishingLocation";
            lbCPBAPublishingLocation.Size = new Size(450, 64);
            lbCPBAPublishingLocation.TabIndex = 49;
            lbCPBAPublishingLocation.TabStop = false;
            lbCPBAPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbCPBAPublishingLocation.DragOver += this.ListBox_DragOver;
            lbCPBAPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbCPBAPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbCPBAPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbCPBAPublisher
            // 
            tbCPBAPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAPublisher.Location = new Point(0, 448);
            tbCPBAPublisher.Name = "tbCPBAPublisher";
            tbCPBAPublisher.Size = new Size(237, 23);
            tbCPBAPublisher.TabIndex = 20;
            ttMain.SetToolTip(tbCPBAPublisher, resources.GetString("tbCPBAPublisher.ToolTip"));
            tbCPBAPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBAPublisher
            // 
            labelCPBAPublisher.AutoSize = true;
            labelCPBAPublisher.Location = new Point(0, 430);
            labelCPBAPublisher.Name = "labelCPBAPublisher";
            labelCPBAPublisher.Size = new Size(81, 15);
            labelCPBAPublisher.TabIndex = 46;
            labelCPBAPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelCPBAPublisher, resources.GetString("labelCPBAPublisher.ToolTip"));
            // 
            // tbCPBAPublishingLocation
            // 
            tbCPBAPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAPublishingLocation.Location = new Point(0, 334);
            tbCPBAPublishingLocation.Name = "tbCPBAPublishingLocation";
            tbCPBAPublishingLocation.Size = new Size(354, 23);
            tbCPBAPublishingLocation.TabIndex = 18;
            ttMain.SetToolTip(tbCPBAPublishingLocation, "Город, где издана статья. Может быть несколько.\r\nПример: «Москва»\r\n\r\n");
            tbCPBAPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBAPublishingLocation
            // 
            labelCPBAPublishingLocation.AutoSize = true;
            labelCPBAPublishingLocation.Location = new Point(0, 316);
            labelCPBAPublishingLocation.Name = "labelCPBAPublishingLocation";
            labelCPBAPublishingLocation.Size = new Size(89, 15);
            labelCPBAPublishingLocation.TabIndex = 44;
            labelCPBAPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelCPBAPublishingLocation, "Город, где издана статья. Может быть несколько.\r\nПример: «Москва»\r\n");
            // 
            // cbCPBAArticleAuthors
            // 
            cbCPBAArticleAuthors.AutoSize = true;
            cbCPBAArticleAuthors.Location = new Point(371, 20);
            cbCPBAArticleAuthors.Name = "cbCPBAArticleAuthors";
            cbCPBAArticleAuthors.Size = new Size(79, 19);
            cbCPBAArticleAuthors.TabIndex = 12;
            cbCPBAArticleAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPBAArticleAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPBAArticleAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPBAPages
            // 
            labelCPBAPages.AutoSize = true;
            labelCPBAPages.Location = new Point(0, 588);
            labelCPBAPages.Name = "labelCPBAPages";
            labelCPBAPages.Size = new Size(108, 15);
            labelCPBAPages.TabIndex = 20;
            labelCPBAPages.Text = "Диапазон страниц";
            ttMain.SetToolTip(labelCPBAPages, "Номера страниц, на которых размещена статья.\r\nПример: «75-88»");
            // 
            // labelCPBAArticleAuthors
            // 
            labelCPBAArticleAuthors.AutoSize = true;
            labelCPBAArticleAuthors.Location = new Point(0, 0);
            labelCPBAArticleAuthors.Name = "labelCPBAArticleAuthors";
            labelCPBAArticleAuthors.Size = new Size(95, 15);
            labelCPBAArticleAuthors.TabIndex = 0;
            labelCPBAArticleAuthors.Text = "Автор(ы) статьи";
            ttMain.SetToolTip(labelCPBAArticleAuthors, resources.GetString("labelCPBAArticleAuthors.ToolTip"));
            // 
            // tbCPBAPages
            // 
            tbCPBAPages.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAPages.Location = new Point(0, 606);
            tbCPBAPages.Name = "tbCPBAPages";
            tbCPBAPages.Size = new Size(450, 23);
            tbCPBAPages.TabIndex = 24;
            ttMain.SetToolTip(tbCPBAPages, "Номера страниц, на которых размещена статья.\r\nПример: «75-88»\r\n");
            tbCPBAPages.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBAPublishYear
            // 
            labelCPBAPublishYear.AutoSize = true;
            labelCPBAPublishYear.Location = new Point(0, 544);
            labelCPBAPublishYear.Name = "labelCPBAPublishYear";
            labelCPBAPublishYear.Size = new Size(73, 15);
            labelCPBAPublishYear.TabIndex = 18;
            labelCPBAPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelCPBAPublishYear, "Год публикации книги.\r\nПример: «2021»");
            // 
            // tbCPBAPublishYear
            // 
            tbCPBAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAPublishYear.Location = new Point(0, 562);
            tbCPBAPublishYear.Name = "tbCPBAPublishYear";
            tbCPBAPublishYear.Size = new Size(450, 23);
            tbCPBAPublishYear.TabIndex = 23;
            ttMain.SetToolTip(tbCPBAPublishYear, "Год публикации книги.\r\nПример: «2021»");
            tbCPBAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPBABookTitle
            // 
            tbCPBABookTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBABookTitle.Location = new Point(0, 290);
            tbCPBABookTitle.Name = "tbCPBABookTitle";
            tbCPBABookTitle.Size = new Size(450, 23);
            tbCPBABookTitle.TabIndex = 17;
            ttMain.SetToolTip(tbCPBABookTitle, "Общее название книги, в которой опубликована статья.\r\nПример: «Современные исследования по истории книги»");
            tbCPBABookTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBABookTitle
            // 
            labelCPBABookTitle.AutoSize = true;
            labelCPBABookTitle.Location = new Point(0, 272);
            labelCPBABookTitle.Name = "labelCPBABookTitle";
            labelCPBABookTitle.Size = new Size(92, 15);
            labelCPBABookTitle.TabIndex = 8;
            labelCPBABookTitle.Text = "Заглавие книги";
            ttMain.SetToolTip(labelCPBABookTitle, "Общее название книги, в которой опубликована статья.\r\nПример: «Современные исследования по истории книги»");
            // 
            // tbCPBAArticleTitle
            // 
            tbCPBAArticleTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAArticleTitle.Location = new Point(0, 132);
            tbCPBAArticleTitle.Name = "tbCPBAArticleTitle";
            tbCPBAArticleTitle.Size = new Size(450, 23);
            tbCPBAArticleTitle.TabIndex = 13;
            ttMain.SetToolTip(tbCPBAArticleTitle, "Название конкретной статьи или главы.\r\nПример: «История типографики в России»");
            tbCPBAArticleTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBAArticleTitle
            // 
            labelCPBAArticleTitle.AutoSize = true;
            labelCPBAArticleTitle.Location = new Point(0, 114);
            labelCPBAArticleTitle.Name = "labelCPBAArticleTitle";
            labelCPBAArticleTitle.Size = new Size(95, 15);
            labelCPBAArticleTitle.TabIndex = 4;
            labelCPBAArticleTitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelCPBAArticleTitle, "Название конкретной статьи или главы.\r\nПример: «История типографики в России»");
            // 
            // tbCPBAArticleAuthors
            // 
            tbCPBAArticleAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAArticleAuthors.Location = new Point(0, 18);
            tbCPBAArticleAuthors.Name = "tbCPBAArticleAuthors";
            tbCPBAArticleAuthors.Size = new Size(269, 23);
            tbCPBAArticleAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbCPBAArticleAuthors, resources.GetString("tbCPBAArticleAuthors.ToolTip"));
            tbCPBAArticleAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPBAArticleAuthors
            // 
            lbCPBAArticleAuthors.AllowDrop = true;
            lbCPBAArticleAuthors.ContextMenuStrip = cmsListBox;
            lbCPBAArticleAuthors.ItemHeight = 15;
            lbCPBAArticleAuthors.Location = new Point(0, 47);
            lbCPBAArticleAuthors.Name = "lbCPBAArticleAuthors";
            lbCPBAArticleAuthors.Size = new Size(450, 64);
            lbCPBAArticleAuthors.TabIndex = 13;
            lbCPBAArticleAuthors.TabStop = false;
            lbCPBAArticleAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPBAArticleAuthors.DragOver += this.ListBox_DragOver;
            lbCPBAArticleAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPBAArticleAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPBAArticleAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPBAArticleAuthorsAdd
            // 
            buttonCPBAArticleAuthorsAdd.Location = new Point(275, 18);
            buttonCPBAArticleAuthorsAdd.Name = "buttonCPBAArticleAuthorsAdd";
            buttonCPBAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPBAArticleAuthorsAdd.TabIndex = 11;
            buttonCPBAArticleAuthorsAdd.Text = "Добавить";
            buttonCPBAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPBAArticleAuthorsAdd.Click += this.buttonCPBAArticleAuthorsAdd_Click;
            // 
            // gbCPBookArticleOptional
            // 
            gbCPBookArticleOptional.Controls.Add(panelCPBookArticleOptional);
            gbCPBookArticleOptional.Location = new Point(10, 346);
            gbCPBookArticleOptional.Name = "gbCPBookArticleOptional";
            gbCPBookArticleOptional.Size = new Size(488, 330);
            gbCPBookArticleOptional.TabIndex = 1;
            gbCPBookArticleOptional.TabStop = false;
            gbCPBookArticleOptional.Text = "Необязательные поля";
            // 
            // panelCPBookArticleOptional
            // 
            panelCPBookArticleOptional.AutoScroll = true;
            panelCPBookArticleOptional.Controls.Add(labelCPBAContentType);
            panelCPBookArticleOptional.Controls.Add(tbCPBAContentType);
            panelCPBookArticleOptional.Controls.Add(labelCPBAOrganization);
            panelCPBookArticleOptional.Controls.Add(tbCPBAOrganization);
            panelCPBookArticleOptional.Controls.Add(labelCPBABookDocumentType);
            panelCPBookArticleOptional.Controls.Add(tbCPBABookDocumentType);
            panelCPBookArticleOptional.Location = new Point(10, 22);
            panelCPBookArticleOptional.Name = "panelCPBookArticleOptional";
            panelCPBookArticleOptional.Size = new Size(473, 302);
            panelCPBookArticleOptional.TabIndex = 32;
            // 
            // labelCPBAContentType
            // 
            labelCPBAContentType.AutoSize = true;
            labelCPBAContentType.Location = new Point(0, 90);
            labelCPBAContentType.Name = "labelCPBAContentType";
            labelCPBAContentType.Size = new Size(97, 15);
            labelCPBAContentType.TabIndex = 29;
            labelCPBAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelCPBAContentType, "Уточняет вид содержания. Формат: тип содержания без \"Текст\".\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbCPBAContentType
            // 
            tbCPBAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAContentType.Location = new Point(0, 108);
            tbCPBAContentType.Name = "tbCPBAContentType";
            tbCPBAContentType.Size = new Size(450, 23);
            tbCPBAContentType.TabIndex = 27;
            ttMain.SetToolTip(tbCPBAContentType, "Уточняет вид содержания. Формат: тип содержания без \"Текст\".\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbCPBAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBAOrganization
            // 
            labelCPBAOrganization.AutoSize = true;
            labelCPBAOrganization.Location = new Point(0, 46);
            labelCPBAOrganization.Name = "labelCPBAOrganization";
            labelCPBAOrganization.Size = new Size(79, 15);
            labelCPBAOrganization.TabIndex = 2;
            labelCPBAOrganization.Text = "Организация";
            ttMain.SetToolTip(labelCPBAOrganization, "Организация, ответственная за издание или координацию публикации.\r\nПример: «Институт русской литературы РАН»");
            // 
            // tbCPBAOrganization
            // 
            tbCPBAOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBAOrganization.Location = new Point(0, 64);
            tbCPBAOrganization.Name = "tbCPBAOrganization";
            tbCPBAOrganization.Size = new Size(450, 23);
            tbCPBAOrganization.TabIndex = 26;
            ttMain.SetToolTip(tbCPBAOrganization, "Организация, ответственная за издание или координацию публикации.\r\nПример: «Институт русской литературы РАН»");
            tbCPBAOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPBABookDocumentType
            // 
            labelCPBABookDocumentType.AutoSize = true;
            labelCPBABookDocumentType.Location = new Point(0, 0);
            labelCPBABookDocumentType.Name = "labelCPBABookDocumentType";
            labelCPBABookDocumentType.Size = new Size(123, 15);
            labelCPBABookDocumentType.TabIndex = 0;
            labelCPBABookDocumentType.Text = "Вид документа книги";
            ttMain.SetToolTip(labelCPBABookDocumentType, "Тип книги, если он указан: «монография», «учебник», «сборник научных трудов» и т.д.\r\nПример: «монография»");
            // 
            // tbCPBABookDocumentType
            // 
            tbCPBABookDocumentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPBABookDocumentType.Location = new Point(0, 20);
            tbCPBABookDocumentType.Name = "tbCPBABookDocumentType";
            tbCPBABookDocumentType.Size = new Size(450, 23);
            tbCPBABookDocumentType.TabIndex = 25;
            ttMain.SetToolTip(tbCPBABookDocumentType, "Тип книги, если он указан: «монография», «учебник», «сборник научных трудов» и т.д.\r\nПример: «монография»");
            tbCPBABookDocumentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tpCPConferenceArticle
            // 
            tpCPConferenceArticle.BackColor = SystemColors.Control;
            tpCPConferenceArticle.Controls.Add(gbCPConferenceArticleRequired);
            tpCPConferenceArticle.Controls.Add(gbCPConferenceArticleOptional);
            tpCPConferenceArticle.Location = new Point(4, 24);
            tpCPConferenceArticle.Name = "tpCPConferenceArticle";
            tpCPConferenceArticle.Size = new Size(505, 681);
            tpCPConferenceArticle.TabIndex = 4;
            tpCPConferenceArticle.Text = "Статья из материалов конференции";
            // 
            // gbCPConferenceArticleRequired
            // 
            gbCPConferenceArticleRequired.Controls.Add(panelCPConferenceArticleRequired);
            gbCPConferenceArticleRequired.Location = new Point(10, 10);
            gbCPConferenceArticleRequired.Name = "gbCPConferenceArticleRequired";
            gbCPConferenceArticleRequired.Size = new Size(488, 330);
            gbCPConferenceArticleRequired.TabIndex = 2;
            gbCPConferenceArticleRequired.TabStop = false;
            gbCPConferenceArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPConferenceArticleRequired
            // 
            panelCPConferenceArticleRequired.AutoScroll = true;
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAPublicationType);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAPublicationType);
            panelCPConferenceArticleRequired.Controls.Add(lbCPCAPublishingLocationSelect);
            panelCPConferenceArticleRequired.Controls.Add(cbCPCAPublisher);
            panelCPConferenceArticleRequired.Controls.Add(buttonCPCAPublisherAdd);
            panelCPConferenceArticleRequired.Controls.Add(lbCPCAPublisher);
            panelCPConferenceArticleRequired.Controls.Add(buttonCPCAPublishingLocationAdd);
            panelCPConferenceArticleRequired.Controls.Add(lbCPCAPublishingLocation);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAPublisher);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAPublisher);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAPublishingLocation);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAPublishingLocation);
            panelCPConferenceArticleRequired.Controls.Add(cbCPCAArticleAuthors);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAPages);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAArticleAuthors);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAPages);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAPublishYear);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAPublishYear);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAEventTitle);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAEventTitle);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAArticleTitle);
            panelCPConferenceArticleRequired.Controls.Add(labelCPCAArticleTitle);
            panelCPConferenceArticleRequired.Controls.Add(tbCPCAArticleAuthors);
            panelCPConferenceArticleRequired.Controls.Add(lbCPCAArticleAuthors);
            panelCPConferenceArticleRequired.Controls.Add(buttonCPCAArticleAuthorsAdd);
            panelCPConferenceArticleRequired.Location = new Point(10, 22);
            panelCPConferenceArticleRequired.Name = "panelCPConferenceArticleRequired";
            panelCPConferenceArticleRequired.Size = new Size(473, 302);
            panelCPConferenceArticleRequired.TabIndex = 0;
            // 
            // labelCPCAPublicationType
            // 
            labelCPCAPublicationType.AutoSize = true;
            labelCPCAPublicationType.Location = new Point(0, 202);
            labelCPCAPublicationType.Name = "labelCPCAPublicationType";
            labelCPCAPublicationType.Size = new Size(74, 15);
            labelCPCAPublicationType.TabIndex = 54;
            labelCPCAPublicationType.Text = "Вид издания";
            ttMain.SetToolTip(labelCPCAPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»\r\n**Чаще всего с маленькой буквы**");
            // 
            // tbCPCAPublicationType
            // 
            tbCPCAPublicationType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPublicationType.Location = new Point(0, 220);
            tbCPCAPublicationType.Name = "tbCPCAPublicationType";
            tbCPCAPublicationType.Size = new Size(450, 23);
            tbCPCAPublicationType.TabIndex = 15;
            ttMain.SetToolTip(tbCPCAPublicationType, "Как оформлено издание: сборник статей, материалы конференции и т. д.\r\nПример: «Сборник научных статей», «Материалы конференции»\r\n**Чаще всего с маленькой буквы**\r\n");
            tbCPCAPublicationType.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPCAPublishingLocationSelect
            // 
            lbCPCAPublishingLocationSelect.Enabled = false;
            lbCPCAPublishingLocationSelect.FormattingEnabled = true;
            lbCPCAPublishingLocationSelect.ItemHeight = 15;
            lbCPCAPublishingLocationSelect.Location = new Point(243, 407);
            lbCPCAPublishingLocationSelect.Name = "lbCPCAPublishingLocationSelect";
            lbCPCAPublishingLocationSelect.Size = new Size(207, 64);
            lbCPCAPublishingLocationSelect.TabIndex = 53;
            lbCPCAPublishingLocationSelect.TabStop = false;
            lbCPCAPublishingLocationSelect.SelectedIndexChanged += this.lbCPCAPublishingLocationSelect_SelectedIndexChanged;
            // 
            // cbCPCAPublisher
            // 
            cbCPCAPublisher.AutoSize = true;
            cbCPCAPublisher.Location = new Point(339, 380);
            cbCPCAPublisher.Name = "cbCPCAPublisher";
            cbCPCAPublisher.Size = new Size(111, 19);
            cbCPCAPublisher.TabIndex = 20;
            cbCPCAPublisher.Text = "Отдельные изд.";
            ttMain.SetToolTip(cbCPCAPublisher, "Включение «умного режима» добавления издательств");
            cbCPCAPublisher.UseVisualStyleBackColor = true;
            cbCPCAPublisher.CheckedChanged += this.cbCPCAPublisher_CheckedChanged;
            // 
            // buttonCPCAPublisherAdd
            // 
            buttonCPCAPublisherAdd.Location = new Point(243, 378);
            buttonCPCAPublisherAdd.Name = "buttonCPCAPublisherAdd";
            buttonCPCAPublisherAdd.Size = new Size(90, 23);
            buttonCPCAPublisherAdd.TabIndex = 19;
            buttonCPCAPublisherAdd.Text = "Добавить";
            buttonCPCAPublisherAdd.UseVisualStyleBackColor = true;
            buttonCPCAPublisherAdd.Click += this.buttonCPCAPublisherAdd_Click;
            // 
            // lbCPCAPublisher
            // 
            lbCPCAPublisher.AllowDrop = true;
            lbCPCAPublisher.ContextMenuStrip = cmsListBox;
            lbCPCAPublisher.ItemHeight = 15;
            lbCPCAPublisher.Location = new Point(0, 407);
            lbCPCAPublisher.Name = "lbCPCAPublisher";
            lbCPCAPublisher.Size = new Size(237, 64);
            lbCPCAPublisher.TabIndex = 51;
            lbCPCAPublisher.TabStop = false;
            lbCPCAPublisher.DragDrop += this.ListBox_DragDrop;
            lbCPCAPublisher.DragOver += this.ListBox_DragOver;
            lbCPCAPublisher.KeyDown += this.ListBox_KeyDown;
            lbCPCAPublisher.MouseDown += this.ListBox_MouseDown;
            lbCPCAPublisher.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPCAPublishingLocationAdd
            // 
            buttonCPCAPublishingLocationAdd.Location = new Point(360, 264);
            buttonCPCAPublishingLocationAdd.Name = "buttonCPCAPublishingLocationAdd";
            buttonCPCAPublishingLocationAdd.Size = new Size(90, 23);
            buttonCPCAPublishingLocationAdd.TabIndex = 17;
            buttonCPCAPublishingLocationAdd.Text = "Добавить";
            buttonCPCAPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonCPCAPublishingLocationAdd.Click += this.buttonCPCAPublishingLocationAdd_Click;
            // 
            // lbCPCAPublishingLocation
            // 
            lbCPCAPublishingLocation.AllowDrop = true;
            lbCPCAPublishingLocation.ContextMenuStrip = cmsListBox;
            lbCPCAPublishingLocation.ItemHeight = 15;
            lbCPCAPublishingLocation.Location = new Point(0, 293);
            lbCPCAPublishingLocation.Name = "lbCPCAPublishingLocation";
            lbCPCAPublishingLocation.Size = new Size(450, 64);
            lbCPCAPublishingLocation.TabIndex = 49;
            lbCPCAPublishingLocation.TabStop = false;
            lbCPCAPublishingLocation.DragDrop += this.ListBox_DragDrop;
            lbCPCAPublishingLocation.DragOver += this.ListBox_DragOver;
            lbCPCAPublishingLocation.KeyDown += this.ListBox_KeyDown;
            lbCPCAPublishingLocation.MouseDown += this.ListBox_MouseDown;
            lbCPCAPublishingLocation.MouseMove += this.ListBox_MouseMove;
            // 
            // tbCPCAPublisher
            // 
            tbCPCAPublisher.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPublisher.Location = new Point(0, 378);
            tbCPCAPublisher.Name = "tbCPCAPublisher";
            tbCPCAPublisher.Size = new Size(237, 23);
            tbCPCAPublisher.TabIndex = 18;
            ttMain.SetToolTip(tbCPCAPublisher, resources.GetString("tbCPCAPublisher.ToolTip"));
            tbCPCAPublisher.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAPublisher
            // 
            labelCPCAPublisher.AutoSize = true;
            labelCPCAPublisher.Location = new Point(0, 360);
            labelCPCAPublisher.Name = "labelCPCAPublisher";
            labelCPCAPublisher.Size = new Size(81, 15);
            labelCPCAPublisher.TabIndex = 46;
            labelCPCAPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelCPCAPublisher, resources.GetString("labelCPCAPublisher.ToolTip"));
            // 
            // tbCPCAPublishingLocation
            // 
            tbCPCAPublishingLocation.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPublishingLocation.Location = new Point(0, 264);
            tbCPCAPublishingLocation.Name = "tbCPCAPublishingLocation";
            tbCPCAPublishingLocation.Size = new Size(354, 23);
            tbCPCAPublishingLocation.TabIndex = 16;
            ttMain.SetToolTip(tbCPCAPublishingLocation, "Город, где издан сборник. Может быть несколько.\r\nПример: «Москва»");
            tbCPCAPublishingLocation.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAPublishingLocation
            // 
            labelCPCAPublishingLocation.AutoSize = true;
            labelCPCAPublishingLocation.Location = new Point(0, 246);
            labelCPCAPublishingLocation.Name = "labelCPCAPublishingLocation";
            labelCPCAPublishingLocation.Size = new Size(89, 15);
            labelCPCAPublishingLocation.TabIndex = 44;
            labelCPCAPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelCPCAPublishingLocation, "Город, где издан сборник. Может быть несколько.\r\nПример: «Москва»");
            // 
            // cbCPCAArticleAuthors
            // 
            cbCPCAArticleAuthors.AutoSize = true;
            cbCPCAArticleAuthors.Location = new Point(371, 20);
            cbCPCAArticleAuthors.Name = "cbCPCAArticleAuthors";
            cbCPCAArticleAuthors.Size = new Size(79, 19);
            cbCPCAArticleAuthors.TabIndex = 12;
            cbCPCAArticleAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPCAArticleAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPCAArticleAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPCAPages
            // 
            labelCPCAPages.AutoSize = true;
            labelCPCAPages.Location = new Point(0, 518);
            labelCPCAPages.Name = "labelCPCAPages";
            labelCPCAPages.Size = new Size(108, 15);
            labelCPCAPages.TabIndex = 20;
            labelCPCAPages.Text = "Диапазон страниц";
            ttMain.SetToolTip(labelCPCAPages, "Номера страниц статьи в сборнике.\r\nПример: «112-117»");
            // 
            // labelCPCAArticleAuthors
            // 
            labelCPCAArticleAuthors.AutoSize = true;
            labelCPCAArticleAuthors.Location = new Point(0, 0);
            labelCPCAArticleAuthors.Name = "labelCPCAArticleAuthors";
            labelCPCAArticleAuthors.Size = new Size(95, 15);
            labelCPCAArticleAuthors.TabIndex = 0;
            labelCPCAArticleAuthors.Text = "Автор(ы) статьи";
            ttMain.SetToolTip(labelCPCAArticleAuthors, resources.GetString("labelCPCAArticleAuthors.ToolTip"));
            // 
            // tbCPCAPages
            // 
            tbCPCAPages.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPages.Location = new Point(0, 536);
            tbCPCAPages.Name = "tbCPCAPages";
            tbCPCAPages.Size = new Size(450, 23);
            tbCPCAPages.TabIndex = 22;
            ttMain.SetToolTip(tbCPCAPages, "Номера страниц статьи в сборнике.\r\nПример: «112-117»\r\n");
            tbCPCAPages.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAPublishYear
            // 
            labelCPCAPublishYear.AutoSize = true;
            labelCPCAPublishYear.Location = new Point(0, 474);
            labelCPCAPublishYear.Name = "labelCPCAPublishYear";
            labelCPCAPublishYear.Size = new Size(73, 15);
            labelCPCAPublishYear.TabIndex = 18;
            labelCPCAPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelCPCAPublishYear, "Год выпуска сборника.\r\nПример: «2023»");
            // 
            // tbCPCAPublishYear
            // 
            tbCPCAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPublishYear.Location = new Point(0, 492);
            tbCPCAPublishYear.Name = "tbCPCAPublishYear";
            tbCPCAPublishYear.Size = new Size(450, 23);
            tbCPCAPublishYear.TabIndex = 21;
            ttMain.SetToolTip(tbCPCAPublishYear, "Год выпуска сборника.\r\nПример: «2023»");
            tbCPCAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPCAEventTitle
            // 
            tbCPCAEventTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAEventTitle.Location = new Point(0, 176);
            tbCPCAEventTitle.Name = "tbCPCAEventTitle";
            tbCPCAEventTitle.Size = new Size(450, 23);
            tbCPCAEventTitle.TabIndex = 14;
            ttMain.SetToolTip(tbCPCAEventTitle, "Полное название конференции, форума, семинара и т. п.\r\nПример: «Международная научно-практическая конференция «Румянцевские чтения 2023»»");
            tbCPCAEventTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAEventTitle
            // 
            labelCPCAEventTitle.AutoSize = true;
            labelCPCAEventTitle.Location = new Point(0, 158);
            labelCPCAEventTitle.Name = "labelCPCAEventTitle";
            labelCPCAEventTitle.Size = new Size(136, 15);
            labelCPCAEventTitle.TabIndex = 8;
            labelCPCAEventTitle.Text = "Название мероприятия";
            ttMain.SetToolTip(labelCPCAEventTitle, "Полное название конференции, форума, семинара и т. п.\r\nПример: «Международная научно-практическая конференция «Румянцевские чтения 2023»»");
            // 
            // tbCPCAArticleTitle
            // 
            tbCPCAArticleTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAArticleTitle.Location = new Point(0, 132);
            tbCPCAArticleTitle.Name = "tbCPCAArticleTitle";
            tbCPCAArticleTitle.Size = new Size(450, 23);
            tbCPCAArticleTitle.TabIndex = 13;
            ttMain.SetToolTip(tbCPCAArticleTitle, "Название статьи, опубликованной в материалах конференции.\r\nПример: «Цифровые ресурсы в гуманитарных исследованиях»");
            tbCPCAArticleTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAArticleTitle
            // 
            labelCPCAArticleTitle.AutoSize = true;
            labelCPCAArticleTitle.Location = new Point(0, 114);
            labelCPCAArticleTitle.Name = "labelCPCAArticleTitle";
            labelCPCAArticleTitle.Size = new Size(95, 15);
            labelCPCAArticleTitle.TabIndex = 4;
            labelCPCAArticleTitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelCPCAArticleTitle, "Название статьи, опубликованной в материалах конференции.\r\nПример: «Цифровые ресурсы в гуманитарных исследованиях»");
            // 
            // tbCPCAArticleAuthors
            // 
            tbCPCAArticleAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAArticleAuthors.Location = new Point(0, 18);
            tbCPCAArticleAuthors.Name = "tbCPCAArticleAuthors";
            tbCPCAArticleAuthors.Size = new Size(269, 23);
            tbCPCAArticleAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbCPCAArticleAuthors, resources.GetString("tbCPCAArticleAuthors.ToolTip"));
            tbCPCAArticleAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPCAArticleAuthors
            // 
            lbCPCAArticleAuthors.AllowDrop = true;
            lbCPCAArticleAuthors.ContextMenuStrip = cmsListBox;
            lbCPCAArticleAuthors.ItemHeight = 15;
            lbCPCAArticleAuthors.Location = new Point(0, 47);
            lbCPCAArticleAuthors.Name = "lbCPCAArticleAuthors";
            lbCPCAArticleAuthors.Size = new Size(450, 64);
            lbCPCAArticleAuthors.TabIndex = 3;
            lbCPCAArticleAuthors.TabStop = false;
            lbCPCAArticleAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPCAArticleAuthors.DragOver += this.ListBox_DragOver;
            lbCPCAArticleAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPCAArticleAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPCAArticleAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPCAArticleAuthorsAdd
            // 
            buttonCPCAArticleAuthorsAdd.Location = new Point(275, 18);
            buttonCPCAArticleAuthorsAdd.Name = "buttonCPCAArticleAuthorsAdd";
            buttonCPCAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPCAArticleAuthorsAdd.TabIndex = 11;
            buttonCPCAArticleAuthorsAdd.Text = "Добавить";
            buttonCPCAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPCAArticleAuthorsAdd.Click += this.buttonCPCAArticleAuthorsAdd_Click;
            // 
            // gbCPConferenceArticleOptional
            // 
            gbCPConferenceArticleOptional.Controls.Add(panelCPConferenceArticleOptional);
            gbCPConferenceArticleOptional.Location = new Point(10, 346);
            gbCPConferenceArticleOptional.Name = "gbCPConferenceArticleOptional";
            gbCPConferenceArticleOptional.Size = new Size(488, 330);
            gbCPConferenceArticleOptional.TabIndex = 3;
            gbCPConferenceArticleOptional.TabStop = false;
            gbCPConferenceArticleOptional.Text = "Необязательные поля";
            // 
            // panelCPConferenceArticleOptional
            // 
            panelCPConferenceArticleOptional.AutoScroll = true;
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAEventDate);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAEventDate);
            panelCPConferenceArticleOptional.Controls.Add(cbCPCAConferenceAuthors);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAEventPlace);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAConferenceAuthors);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAConferenceAuthors);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAEventPlace);
            panelCPConferenceArticleOptional.Controls.Add(lbCPCAConferenceAuthors);
            panelCPConferenceArticleOptional.Controls.Add(buttonCPCAConferenceAuthorsAdd);
            panelCPConferenceArticleOptional.Controls.Add(cbCPCAEditorType);
            panelCPConferenceArticleOptional.Controls.Add(lbCPCAEditor);
            panelCPConferenceArticleOptional.Controls.Add(buttonCPCAEditorAdd);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAPartNumberAndTitle);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAPartNumberAndTitle);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAPartCount);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAPartCount);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAEditor);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAEditor);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAContentType);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAContentType);
            panelCPConferenceArticleOptional.Controls.Add(labelCPCAOrganization);
            panelCPConferenceArticleOptional.Controls.Add(tbCPCAOrganization);
            panelCPConferenceArticleOptional.Location = new Point(10, 22);
            panelCPConferenceArticleOptional.Name = "panelCPConferenceArticleOptional";
            panelCPConferenceArticleOptional.Size = new Size(473, 302);
            panelCPConferenceArticleOptional.TabIndex = 32;
            // 
            // tbCPCAEventDate
            // 
            tbCPCAEventDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAEventDate.Location = new Point(0, 150);
            tbCPCAEventDate.Name = "tbCPCAEventDate";
            tbCPCAEventDate.Size = new Size(450, 23);
            tbCPCAEventDate.TabIndex = 26;
            ttMain.SetToolTip(tbCPCAEventDate, "Даты проведения конференции.\r\nПример: «18-19 апреля 2023 г.»");
            tbCPCAEventDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAEventDate
            // 
            labelCPCAEventDate.AutoSize = true;
            labelCPCAEventDate.Location = new Point(0, 132);
            labelCPCAEventDate.Name = "labelCPCAEventDate";
            labelCPCAEventDate.Size = new Size(100, 15);
            labelCPCAEventDate.TabIndex = 58;
            labelCPCAEventDate.Text = "Дата проведения";
            ttMain.SetToolTip(labelCPCAEventDate, "Даты проведения конференции.\r\nПример: «18-19 апреля 2023 г.»");
            // 
            // cbCPCAConferenceAuthors
            // 
            cbCPCAConferenceAuthors.AutoSize = true;
            cbCPCAConferenceAuthors.Location = new Point(371, 196);
            cbCPCAConferenceAuthors.Name = "cbCPCAConferenceAuthors";
            cbCPCAConferenceAuthors.Size = new Size(79, 19);
            cbCPCAConferenceAuthors.TabIndex = 29;
            cbCPCAConferenceAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPCAConferenceAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPCAConferenceAuthors.UseVisualStyleBackColor = true;
            // 
            // tbCPCAEventPlace
            // 
            tbCPCAEventPlace.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAEventPlace.Location = new Point(0, 106);
            tbCPCAEventPlace.Name = "tbCPCAEventPlace";
            tbCPCAEventPlace.Size = new Size(450, 23);
            tbCPCAEventPlace.TabIndex = 25;
            ttMain.SetToolTip(tbCPCAEventPlace, "Город или место, где проходила конференция.\r\nПример: «Москва»");
            tbCPCAEventPlace.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAConferenceAuthors
            // 
            labelCPCAConferenceAuthors.AutoSize = true;
            labelCPCAConferenceAuthors.Location = new Point(0, 176);
            labelCPCAConferenceAuthors.Name = "labelCPCAConferenceAuthors";
            labelCPCAConferenceAuthors.Size = new Size(126, 15);
            labelCPCAConferenceAuthors.TabIndex = 40;
            labelCPCAConferenceAuthors.Text = "Автор(ы) материалов";
            ttMain.SetToolTip(labelCPCAConferenceAuthors, resources.GetString("labelCPCAConferenceAuthors.ToolTip"));
            // 
            // tbCPCAConferenceAuthors
            // 
            tbCPCAConferenceAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAConferenceAuthors.Location = new Point(0, 194);
            tbCPCAConferenceAuthors.Name = "tbCPCAConferenceAuthors";
            tbCPCAConferenceAuthors.Size = new Size(269, 23);
            tbCPCAConferenceAuthors.TabIndex = 27;
            ttMain.SetToolTip(tbCPCAConferenceAuthors, resources.GetString("tbCPCAConferenceAuthors.ToolTip"));
            tbCPCAConferenceAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAEventPlace
            // 
            labelCPCAEventPlace.AutoSize = true;
            labelCPCAEventPlace.Location = new Point(0, 88);
            labelCPCAEventPlace.Name = "labelCPCAEventPlace";
            labelCPCAEventPlace.Size = new Size(108, 15);
            labelCPCAEventPlace.TabIndex = 56;
            labelCPCAEventPlace.Text = "Город проведения";
            ttMain.SetToolTip(labelCPCAEventPlace, "Город или место, где проходила конференция.\r\nПример: «Москва»");
            // 
            // lbCPCAConferenceAuthors
            // 
            lbCPCAConferenceAuthors.AllowDrop = true;
            lbCPCAConferenceAuthors.ContextMenuStrip = cmsListBox;
            lbCPCAConferenceAuthors.ItemHeight = 15;
            lbCPCAConferenceAuthors.Location = new Point(0, 223);
            lbCPCAConferenceAuthors.Name = "lbCPCAConferenceAuthors";
            lbCPCAConferenceAuthors.Size = new Size(450, 64);
            lbCPCAConferenceAuthors.TabIndex = 30;
            lbCPCAConferenceAuthors.TabStop = false;
            lbCPCAConferenceAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPCAConferenceAuthors.DragOver += this.ListBox_DragOver;
            lbCPCAConferenceAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPCAConferenceAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPCAConferenceAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPCAConferenceAuthorsAdd
            // 
            buttonCPCAConferenceAuthorsAdd.Location = new Point(275, 194);
            buttonCPCAConferenceAuthorsAdd.Name = "buttonCPCAConferenceAuthorsAdd";
            buttonCPCAConferenceAuthorsAdd.Size = new Size(90, 23);
            buttonCPCAConferenceAuthorsAdd.TabIndex = 28;
            buttonCPCAConferenceAuthorsAdd.Text = "Добавить";
            buttonCPCAConferenceAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPCAConferenceAuthorsAdd.Click += this.buttonCPCAConferenceAuthorsAdd_Click;
            // 
            // cbCPCAEditorType
            // 
            cbCPCAEditorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCPCAEditorType.FormattingEnabled = true;
            cbCPCAEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbCPCAEditorType.Location = new Point(194, 352);
            cbCPCAEditorType.Name = "cbCPCAEditorType";
            cbCPCAEditorType.Size = new Size(160, 23);
            cbCPCAEditorType.TabIndex = 32;
            // 
            // lbCPCAEditor
            // 
            lbCPCAEditor.AllowDrop = true;
            lbCPCAEditor.ContextMenuStrip = cmsListBox;
            lbCPCAEditor.ItemHeight = 15;
            lbCPCAEditor.Location = new Point(0, 381);
            lbCPCAEditor.Name = "lbCPCAEditor";
            lbCPCAEditor.Size = new Size(450, 64);
            lbCPCAEditor.TabIndex = 38;
            lbCPCAEditor.TabStop = false;
            lbCPCAEditor.DragDrop += this.ListBox_DragDrop;
            lbCPCAEditor.DragOver += this.ListBox_DragOver;
            lbCPCAEditor.KeyDown += this.ListBox_KeyDown;
            lbCPCAEditor.MouseDown += this.ListBox_MouseDown;
            lbCPCAEditor.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPCAEditorAdd
            // 
            buttonCPCAEditorAdd.Location = new Point(360, 352);
            buttonCPCAEditorAdd.Name = "buttonCPCAEditorAdd";
            buttonCPCAEditorAdd.Size = new Size(90, 23);
            buttonCPCAEditorAdd.TabIndex = 33;
            buttonCPCAEditorAdd.Text = "Добавить";
            buttonCPCAEditorAdd.UseVisualStyleBackColor = true;
            buttonCPCAEditorAdd.Click += this.buttonCPCAEditorAdd_Click;
            // 
            // labelCPCAPartNumberAndTitle
            // 
            labelCPCAPartNumberAndTitle.AutoSize = true;
            labelCPCAPartNumberAndTitle.Location = new Point(0, 44);
            labelCPCAPartNumberAndTitle.Name = "labelCPCAPartNumberAndTitle";
            labelCPCAPartNumberAndTitle.Size = new Size(180, 15);
            labelCPCAPartNumberAndTitle.TabIndex = 35;
            labelCPCAPartNumberAndTitle.Text = "Номер и название части (тома)";
            ttMain.SetToolTip(labelCPCAPartNumberAndTitle, "Конкретная часть сборника.\r\nПример: «Ч. 1: Методология»");
            // 
            // tbCPCAPartNumberAndTitle
            // 
            tbCPCAPartNumberAndTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPartNumberAndTitle.Location = new Point(0, 62);
            tbCPCAPartNumberAndTitle.Name = "tbCPCAPartNumberAndTitle";
            tbCPCAPartNumberAndTitle.Size = new Size(450, 23);
            tbCPCAPartNumberAndTitle.TabIndex = 24;
            ttMain.SetToolTip(tbCPCAPartNumberAndTitle, "Конкретная часть сборника.\r\nПример: «Ч. 1: Методология»");
            tbCPCAPartNumberAndTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAPartCount
            // 
            labelCPCAPartCount.AutoSize = true;
            labelCPCAPartCount.Location = new Point(0, 0);
            labelCPCAPartCount.Name = "labelCPCAPartCount";
            labelCPCAPartCount.Size = new Size(157, 15);
            labelCPCAPartCount.TabIndex = 31;
            labelCPCAPartCount.Text = "Количество частей (томов)";
            ttMain.SetToolTip(labelCPCAPartCount, "Если сборник состоит из нескольких частей.\r\nПример: «2»");
            // 
            // tbCPCAPartCount
            // 
            tbCPCAPartCount.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAPartCount.Location = new Point(0, 18);
            tbCPCAPartCount.Name = "tbCPCAPartCount";
            tbCPCAPartCount.Size = new Size(450, 23);
            tbCPCAPartCount.TabIndex = 23;
            ttMain.SetToolTip(tbCPCAPartCount, "Если сборник состоит из нескольких частей.\r\nПример: «2»");
            tbCPCAPartCount.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPCAEditor
            // 
            tbCPCAEditor.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAEditor.Location = new Point(0, 352);
            tbCPCAEditor.Name = "tbCPCAEditor";
            tbCPCAEditor.Size = new Size(188, 23);
            tbCPCAEditor.TabIndex = 31;
            ttMain.SetToolTip(tbCPCAEditor, resources.GetString("tbCPCAEditor.ToolTip"));
            tbCPCAEditor.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAEditor
            // 
            labelCPCAEditor.AutoSize = true;
            labelCPCAEditor.Location = new Point(0, 334);
            labelCPCAEditor.Name = "labelCPCAEditor";
            labelCPCAEditor.Size = new Size(74, 15);
            labelCPCAEditor.TabIndex = 33;
            labelCPCAEditor.Text = "Редактор(ы)";
            ttMain.SetToolTip(labelCPCAEditor, resources.GetString("labelCPCAEditor.ToolTip"));
            // 
            // labelCPCAContentType
            // 
            labelCPCAContentType.AutoSize = true;
            labelCPCAContentType.Location = new Point(0, 448);
            labelCPCAContentType.Name = "labelCPCAContentType";
            labelCPCAContentType.Size = new Size(97, 15);
            labelCPCAContentType.TabIndex = 29;
            labelCPCAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelCPCAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbCPCAContentType
            // 
            tbCPCAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAContentType.Location = new Point(0, 466);
            tbCPCAContentType.Name = "tbCPCAContentType";
            tbCPCAContentType.Size = new Size(450, 23);
            tbCPCAContentType.TabIndex = 34;
            ttMain.SetToolTip(tbCPCAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbCPCAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPCAOrganization
            // 
            labelCPCAOrganization.AutoSize = true;
            labelCPCAOrganization.Location = new Point(0, 290);
            labelCPCAOrganization.Name = "labelCPCAOrganization";
            labelCPCAOrganization.Size = new Size(79, 15);
            labelCPCAOrganization.TabIndex = 2;
            labelCPCAOrganization.Text = "Организация";
            ttMain.SetToolTip(labelCPCAOrganization, "Организация, проводившая конференцию или ответственная за публикацию.\r\nПример: «Институт философии РАН»");
            // 
            // tbCPCAOrganization
            // 
            tbCPCAOrganization.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPCAOrganization.Location = new Point(0, 308);
            tbCPCAOrganization.Name = "tbCPCAOrganization";
            tbCPCAOrganization.Size = new Size(450, 23);
            tbCPCAOrganization.TabIndex = 30;
            ttMain.SetToolTip(tbCPCAOrganization, "Организация, проводившая конференцию или ответственная за публикацию.\r\nПример: «Институт философии РАН»");
            tbCPCAOrganization.KeyDown += this.TextBox_KeyDown;
            // 
            // tpCPJournalArticle
            // 
            tpCPJournalArticle.BackColor = SystemColors.Control;
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleRequired);
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleOptional);
            tpCPJournalArticle.Location = new Point(4, 24);
            tpCPJournalArticle.Name = "tpCPJournalArticle";
            tpCPJournalArticle.Padding = new Padding(3);
            tpCPJournalArticle.Size = new Size(505, 681);
            tpCPJournalArticle.TabIndex = 1;
            tpCPJournalArticle.Text = "Статья из журнала";
            // 
            // gbCPJournalArticleRequired
            // 
            gbCPJournalArticleRequired.Controls.Add(panelCPJournalArticleRequired);
            gbCPJournalArticleRequired.Location = new Point(10, 10);
            gbCPJournalArticleRequired.Name = "gbCPJournalArticleRequired";
            gbCPJournalArticleRequired.Size = new Size(488, 330);
            gbCPJournalArticleRequired.TabIndex = 2;
            gbCPJournalArticleRequired.TabStop = false;
            gbCPJournalArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPJournalArticleRequired
            // 
            panelCPJournalArticleRequired.AutoScroll = true;
            panelCPJournalArticleRequired.Controls.Add(cbCPJAArticleAuthors);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAArticleAuthors);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAArticleAuthors);
            panelCPJournalArticleRequired.Controls.Add(lbCPJAArticleAuthors);
            panelCPJournalArticleRequired.Controls.Add(buttonCPJAArticleAuthorsAdd);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAPages);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAPages);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAArticleTitle);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAArticleTitle);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAPublishYear);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAJournalName);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAPublishYear);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAJournalName);
            panelCPJournalArticleRequired.Location = new Point(10, 22);
            panelCPJournalArticleRequired.Name = "panelCPJournalArticleRequired";
            panelCPJournalArticleRequired.Size = new Size(473, 302);
            panelCPJournalArticleRequired.TabIndex = 0;
            // 
            // cbCPJAArticleAuthors
            // 
            cbCPJAArticleAuthors.AutoSize = true;
            cbCPJAArticleAuthors.Location = new Point(371, 20);
            cbCPJAArticleAuthors.Name = "cbCPJAArticleAuthors";
            cbCPJAArticleAuthors.Size = new Size(79, 19);
            cbCPJAArticleAuthors.TabIndex = 12;
            cbCPJAArticleAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPJAArticleAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPJAArticleAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPJAArticleAuthors
            // 
            labelCPJAArticleAuthors.AutoSize = true;
            labelCPJAArticleAuthors.Location = new Point(0, 0);
            labelCPJAArticleAuthors.Name = "labelCPJAArticleAuthors";
            labelCPJAArticleAuthors.Size = new Size(95, 15);
            labelCPJAArticleAuthors.TabIndex = 24;
            labelCPJAArticleAuthors.Text = "Автор(ы) статьи";
            ttMain.SetToolTip(labelCPJAArticleAuthors, resources.GetString("labelCPJAArticleAuthors.ToolTip"));
            // 
            // tbCPJAArticleAuthors
            // 
            tbCPJAArticleAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAArticleAuthors.Location = new Point(0, 18);
            tbCPJAArticleAuthors.Name = "tbCPJAArticleAuthors";
            tbCPJAArticleAuthors.Size = new Size(269, 23);
            tbCPJAArticleAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbCPJAArticleAuthors, resources.GetString("tbCPJAArticleAuthors.ToolTip"));
            tbCPJAArticleAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPJAArticleAuthors
            // 
            lbCPJAArticleAuthors.AllowDrop = true;
            lbCPJAArticleAuthors.ContextMenuStrip = cmsListBox;
            lbCPJAArticleAuthors.ItemHeight = 15;
            lbCPJAArticleAuthors.Location = new Point(0, 47);
            lbCPJAArticleAuthors.Name = "lbCPJAArticleAuthors";
            lbCPJAArticleAuthors.Size = new Size(450, 64);
            lbCPJAArticleAuthors.TabIndex = 27;
            lbCPJAArticleAuthors.TabStop = false;
            lbCPJAArticleAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPJAArticleAuthors.DragOver += this.ListBox_DragOver;
            lbCPJAArticleAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPJAArticleAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPJAArticleAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPJAArticleAuthorsAdd
            // 
            buttonCPJAArticleAuthorsAdd.Location = new Point(275, 18);
            buttonCPJAArticleAuthorsAdd.Name = "buttonCPJAArticleAuthorsAdd";
            buttonCPJAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPJAArticleAuthorsAdd.TabIndex = 11;
            buttonCPJAArticleAuthorsAdd.Text = "Добавить";
            buttonCPJAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPJAArticleAuthorsAdd.Click += this.buttonCPJAArticleAuthorsAdd_Click;
            // 
            // tbCPJAPages
            // 
            tbCPJAPages.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAPages.Location = new Point(0, 264);
            tbCPJAPages.Name = "tbCPJAPages";
            tbCPJAPages.Size = new Size(450, 23);
            tbCPJAPages.TabIndex = 16;
            ttMain.SetToolTip(tbCPJAPages, "Номера страниц, на которых размещена статья.\r\nПример: «139-146»\r\n");
            tbCPJAPages.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAPages
            // 
            labelCPJAPages.AutoSize = true;
            labelCPJAPages.Location = new Point(0, 246);
            labelCPJAPages.Name = "labelCPJAPages";
            labelCPJAPages.Size = new Size(108, 15);
            labelCPJAPages.TabIndex = 12;
            labelCPJAPages.Text = "Диапазон страниц";
            ttMain.SetToolTip(labelCPJAPages, "Номера страниц, на которых размещена статья.\r\nПример: «139-146»");
            // 
            // labelCPJAArticleTitle
            // 
            labelCPJAArticleTitle.AutoSize = true;
            labelCPJAArticleTitle.Location = new Point(0, 114);
            labelCPJAArticleTitle.Name = "labelCPJAArticleTitle";
            labelCPJAArticleTitle.Size = new Size(95, 15);
            labelCPJAArticleTitle.TabIndex = 4;
            labelCPJAArticleTitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelCPJAArticleTitle, "Название статьи, как оно указано в журнале.\r\nПример: «Лингвистический поворот и философия языка Дж. Локка»");
            // 
            // tbCPJAArticleTitle
            // 
            tbCPJAArticleTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAArticleTitle.Location = new Point(0, 132);
            tbCPJAArticleTitle.Name = "tbCPJAArticleTitle";
            tbCPJAArticleTitle.Size = new Size(450, 23);
            tbCPJAArticleTitle.TabIndex = 13;
            ttMain.SetToolTip(tbCPJAArticleTitle, "Название статьи, как оно указано в журнале.\r\nПример: «Лингвистический поворот и философия языка Дж. Локка»");
            tbCPJAArticleTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPJAPublishYear
            // 
            tbCPJAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAPublishYear.Location = new Point(0, 220);
            tbCPJAPublishYear.Name = "tbCPJAPublishYear";
            tbCPJAPublishYear.Size = new Size(450, 23);
            tbCPJAPublishYear.TabIndex = 15;
            ttMain.SetToolTip(tbCPJAPublishYear, "Год выпуска журнала.\r\nПример: «2017»");
            tbCPJAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAJournalName
            // 
            labelCPJAJournalName.AutoSize = true;
            labelCPJAJournalName.Location = new Point(0, 158);
            labelCPJAJournalName.Name = "labelCPJAJournalName";
            labelCPJAJournalName.Size = new Size(110, 15);
            labelCPJAJournalName.TabIndex = 6;
            labelCPJAJournalName.Text = "Название журнала";
            ttMain.SetToolTip(labelCPJAJournalName, "Полное название журнала, в котором опубликована статья.\r\nПример: «Вестник Удмуртского университета»");
            // 
            // labelCPJAPublishYear
            // 
            labelCPJAPublishYear.AutoSize = true;
            labelCPJAPublishYear.Location = new Point(0, 202);
            labelCPJAPublishYear.Name = "labelCPJAPublishYear";
            labelCPJAPublishYear.Size = new Size(73, 15);
            labelCPJAPublishYear.TabIndex = 8;
            labelCPJAPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelCPJAPublishYear, "Год выпуска журнала.\r\nПример: «2017»");
            // 
            // tbCPJAJournalName
            // 
            tbCPJAJournalName.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAJournalName.Location = new Point(0, 176);
            tbCPJAJournalName.Name = "tbCPJAJournalName";
            tbCPJAJournalName.Size = new Size(450, 23);
            tbCPJAJournalName.TabIndex = 14;
            ttMain.SetToolTip(tbCPJAJournalName, "Полное название журнала, в котором опубликована статья.\r\nПример: «Вестник Удмуртского университета»");
            tbCPJAJournalName.KeyDown += this.TextBox_KeyDown;
            // 
            // gbCPJournalArticleOptional
            // 
            gbCPJournalArticleOptional.Controls.Add(panelCPJournalArticleOptional);
            gbCPJournalArticleOptional.Location = new Point(10, 346);
            gbCPJournalArticleOptional.Name = "gbCPJournalArticleOptional";
            gbCPJournalArticleOptional.Size = new Size(488, 330);
            gbCPJournalArticleOptional.TabIndex = 3;
            gbCPJournalArticleOptional.TabStop = false;
            gbCPJournalArticleOptional.Text = "Необязательные поля";
            // 
            // panelCPJournalArticleOptional
            // 
            panelCPJournalArticleOptional.AutoScroll = true;
            panelCPJournalArticleOptional.Controls.Add(labelCPJAContentType);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAContentType);
            panelCPJournalArticleOptional.Controls.Add(labelCPJAIssue);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAIssue);
            panelCPJournalArticleOptional.Controls.Add(labelCPJAJournalSeries);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAJournalSeries);
            panelCPJournalArticleOptional.Controls.Add(rbCPJAVolume);
            panelCPJournalArticleOptional.Controls.Add(rbCPJANumber);
            panelCPJournalArticleOptional.Controls.Add(labelCPJAAccessMode);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAAccessMode);
            panelCPJournalArticleOptional.Controls.Add(labelCPJAAccessDate);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAAccessDate);
            panelCPJournalArticleOptional.Controls.Add(labelCPJAURL);
            panelCPJournalArticleOptional.Controls.Add(tbCPJAURL);
            panelCPJournalArticleOptional.Controls.Add(labelCPJADOI);
            panelCPJournalArticleOptional.Controls.Add(tbCPJADOI);
            panelCPJournalArticleOptional.Controls.Add(labelCPJANumberOrVolume);
            panelCPJournalArticleOptional.Controls.Add(tbCPJANumberOrVolume);
            panelCPJournalArticleOptional.Location = new Point(10, 22);
            panelCPJournalArticleOptional.Name = "panelCPJournalArticleOptional";
            panelCPJournalArticleOptional.Size = new Size(473, 302);
            panelCPJournalArticleOptional.TabIndex = 2;
            // 
            // labelCPJAContentType
            // 
            labelCPJAContentType.AutoSize = true;
            labelCPJAContentType.Location = new Point(0, 309);
            labelCPJAContentType.Name = "labelCPJAContentType";
            labelCPJAContentType.Size = new Size(97, 15);
            labelCPJAContentType.TabIndex = 31;
            labelCPJAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelCPJAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbCPJAContentType
            // 
            tbCPJAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAContentType.Location = new Point(0, 327);
            tbCPJAContentType.Name = "tbCPJAContentType";
            tbCPJAContentType.Size = new Size(450, 23);
            tbCPJAContentType.TabIndex = 26;
            ttMain.SetToolTip(tbCPJAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbCPJAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAIssue
            // 
            labelCPJAIssue.AutoSize = true;
            labelCPJAIssue.Location = new Point(0, 133);
            labelCPJAIssue.Name = "labelCPJAIssue";
            labelCPJAIssue.Size = new Size(48, 15);
            labelCPJAIssue.TabIndex = 18;
            labelCPJAIssue.Text = "Выпуск";
            ttMain.SetToolTip(labelCPJAIssue, "Дополнительный номер внутри тома.\r\nПример: «2»");
            // 
            // tbCPJAIssue
            // 
            tbCPJAIssue.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAIssue.Location = new Point(0, 151);
            tbCPJAIssue.Name = "tbCPJAIssue";
            tbCPJAIssue.Size = new Size(450, 23);
            tbCPJAIssue.TabIndex = 22;
            ttMain.SetToolTip(tbCPJAIssue, "Дополнительный номер внутри тома.\r\nПример: «2»");
            tbCPJAIssue.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAJournalSeries
            // 
            labelCPJAJournalSeries.AutoSize = true;
            labelCPJAJournalSeries.Location = new Point(0, 44);
            labelCPJAJournalSeries.Name = "labelCPJAJournalSeries";
            labelCPJAJournalSeries.Size = new Size(92, 15);
            labelCPJAJournalSeries.TabIndex = 16;
            labelCPJAJournalSeries.Text = "Серия журнала";
            ttMain.SetToolTip(labelCPJAJournalSeries, "Название серии, если журнал выпускается по сериям.\r\nПример: «Философия. Психология. Педагогика»");
            // 
            // tbCPJAJournalSeries
            // 
            tbCPJAJournalSeries.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAJournalSeries.Location = new Point(0, 62);
            tbCPJAJournalSeries.Name = "tbCPJAJournalSeries";
            tbCPJAJournalSeries.Size = new Size(450, 23);
            tbCPJAJournalSeries.TabIndex = 18;
            ttMain.SetToolTip(tbCPJAJournalSeries, "Название серии, если журнал выпускается по сериям.\r\nПример: «Философия. Психология. Педагогика»");
            tbCPJAJournalSeries.KeyDown += this.TextBox_KeyDown;
            // 
            // rbCPJAVolume
            // 
            rbCPJAVolume.AutoSize = true;
            rbCPJAVolume.Location = new Point(403, 108);
            rbCPJAVolume.Name = "rbCPJAVolume";
            rbCPJAVolume.Size = new Size(47, 19);
            rbCPJAVolume.TabIndex = 21;
            rbCPJAVolume.TabStop = true;
            rbCPJAVolume.Text = "Том";
            rbCPJAVolume.UseVisualStyleBackColor = true;
            // 
            // rbCPJANumber
            // 
            rbCPJANumber.AutoSize = true;
            rbCPJANumber.Checked = true;
            rbCPJANumber.Location = new Point(334, 108);
            rbCPJANumber.Name = "rbCPJANumber";
            rbCPJANumber.Size = new Size(63, 19);
            rbCPJANumber.TabIndex = 20;
            rbCPJANumber.TabStop = true;
            rbCPJANumber.Text = "Номер";
            rbCPJANumber.UseVisualStyleBackColor = true;
            // 
            // labelCPJAAccessMode
            // 
            labelCPJAAccessMode.AutoSize = true;
            labelCPJAAccessMode.Location = new Point(0, 265);
            labelCPJAAccessMode.Name = "labelCPJAAccessMode";
            labelCPJAAccessMode.Size = new Size(91, 15);
            labelCPJAAccessMode.TabIndex = 12;
            labelCPJAAccessMode.Text = "Режим доступа";
            ttMain.SetToolTip(labelCPJAAccessMode, "Дополнительная информация о доступе.\r\nПример: «свободный доступ»");
            // 
            // tbCPJAAccessMode
            // 
            tbCPJAAccessMode.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAAccessMode.Location = new Point(0, 283);
            tbCPJAAccessMode.Name = "tbCPJAAccessMode";
            tbCPJAAccessMode.Size = new Size(450, 23);
            tbCPJAAccessMode.TabIndex = 25;
            ttMain.SetToolTip(tbCPJAAccessMode, "Дополнительная информация о доступе.\r\nПример: «свободный доступ»");
            tbCPJAAccessMode.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAAccessDate
            // 
            labelCPJAAccessDate.AutoSize = true;
            labelCPJAAccessDate.Location = new Point(0, 221);
            labelCPJAAccessDate.Name = "labelCPJAAccessDate";
            labelCPJAAccessDate.Size = new Size(99, 15);
            labelCPJAAccessDate.TabIndex = 4;
            labelCPJAAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelCPJAAccessDate, "Дата, когда был осуществлён доступ по URL.\r\nПример: «11.03.2017»");
            // 
            // tbCPJAAccessDate
            // 
            tbCPJAAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAAccessDate.Location = new Point(0, 239);
            tbCPJAAccessDate.Name = "tbCPJAAccessDate";
            tbCPJAAccessDate.Size = new Size(450, 23);
            tbCPJAAccessDate.TabIndex = 24;
            ttMain.SetToolTip(tbCPJAAccessDate, "Дата, когда был осуществлён доступ по URL.\r\nПример: «11.03.2017»");
            tbCPJAAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJAURL
            // 
            labelCPJAURL.AutoSize = true;
            labelCPJAURL.Location = new Point(0, 177);
            labelCPJAURL.Name = "labelCPJAURL";
            labelCPJAURL.Size = new Size(28, 15);
            labelCPJAURL.TabIndex = 2;
            labelCPJAURL.Text = "URL";
            ttMain.SetToolTip(labelCPJAURL, "Ссылка на статью в интернете, если доступна онлайн.\r\nПример: «https://cyberleninka.ru/article/n/...»");
            // 
            // tbCPJAURL
            // 
            tbCPJAURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJAURL.Location = new Point(0, 195);
            tbCPJAURL.Name = "tbCPJAURL";
            tbCPJAURL.Size = new Size(450, 23);
            tbCPJAURL.TabIndex = 23;
            ttMain.SetToolTip(tbCPJAURL, "Ссылка на статью в интернете, если доступна онлайн.\r\nПример: «https://cyberleninka.ru/article/n/...»");
            tbCPJAURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJADOI
            // 
            labelCPJADOI.AutoSize = true;
            labelCPJADOI.Location = new Point(0, 0);
            labelCPJADOI.Name = "labelCPJADOI";
            labelCPJADOI.Size = new Size(27, 15);
            labelCPJADOI.TabIndex = 0;
            labelCPJADOI.Text = "DOI";
            ttMain.SetToolTip(labelCPJADOI, "Идентификатор DOI статьи, если есть.\r\nПример: «10.14515/monitoring.2017.6.02»");
            // 
            // tbCPJADOI
            // 
            tbCPJADOI.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJADOI.Location = new Point(0, 18);
            tbCPJADOI.Name = "tbCPJADOI";
            tbCPJADOI.Size = new Size(450, 23);
            tbCPJADOI.TabIndex = 17;
            ttMain.SetToolTip(tbCPJADOI, "Идентификатор DOI статьи, если есть.\r\nПример: «10.14515/monitoring.2017.6.02»");
            tbCPJADOI.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPJANumberOrVolume
            // 
            labelCPJANumberOrVolume.AutoSize = true;
            labelCPJANumberOrVolume.Location = new Point(0, 89);
            labelCPJANumberOrVolume.Name = "labelCPJANumberOrVolume";
            labelCPJANumberOrVolume.Size = new Size(122, 15);
            labelCPJANumberOrVolume.TabIndex = 10;
            labelCPJANumberOrVolume.Text = "Номер/том журнала";
            ttMain.SetToolTip(labelCPJANumberOrVolume, "Номер выпуска или том журнала, с радиокнопкой, определяющей, как его подписывать (например, Т. или №).\r\nПример: «27»");
            // 
            // tbCPJANumberOrVolume
            // 
            tbCPJANumberOrVolume.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPJANumberOrVolume.Location = new Point(0, 107);
            tbCPJANumberOrVolume.Name = "tbCPJANumberOrVolume";
            tbCPJANumberOrVolume.Size = new Size(328, 23);
            tbCPJANumberOrVolume.TabIndex = 19;
            ttMain.SetToolTip(tbCPJANumberOrVolume, "Номер выпуска или том журнала, с радиокнопкой, определяющей, как его подписывать (например, Т. или №).\r\nПример: «27»");
            tbCPJANumberOrVolume.KeyDown += this.TextBox_KeyDown;
            // 
            // tpCPNewspaperArticle
            // 
            tpCPNewspaperArticle.BackColor = SystemColors.Control;
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleReqired);
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleOptional);
            tpCPNewspaperArticle.Location = new Point(4, 24);
            tpCPNewspaperArticle.Name = "tpCPNewspaperArticle";
            tpCPNewspaperArticle.Padding = new Padding(3);
            tpCPNewspaperArticle.Size = new Size(505, 681);
            tpCPNewspaperArticle.TabIndex = 2;
            tpCPNewspaperArticle.Text = "Статья из газеты";
            // 
            // gbCPNewspaperArticleReqired
            // 
            gbCPNewspaperArticleReqired.Controls.Add(panelCPNewspaperArticleReqired);
            gbCPNewspaperArticleReqired.Location = new Point(10, 10);
            gbCPNewspaperArticleReqired.Name = "gbCPNewspaperArticleReqired";
            gbCPNewspaperArticleReqired.Size = new Size(488, 330);
            gbCPNewspaperArticleReqired.TabIndex = 2;
            gbCPNewspaperArticleReqired.TabStop = false;
            gbCPNewspaperArticleReqired.Text = "Обязательные поля";
            // 
            // panelCPNewspaperArticleReqired
            // 
            panelCPNewspaperArticleReqired.AutoScroll = true;
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNANumber);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNANumber);
            panelCPNewspaperArticleReqired.Controls.Add(cbCPNAArticleAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAArticleAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAArticleAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(lbCPNAArticleAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(buttonCPNAArticleAuthorsAdd);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAPages);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAPages);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAReleaseDate);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAArticleTitle);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAReleaseDate);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAArticleTitle);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAPublishYear);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNANewspaperName);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAPublishYear);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNANewspaperName);
            panelCPNewspaperArticleReqired.Location = new Point(10, 22);
            panelCPNewspaperArticleReqired.Name = "panelCPNewspaperArticleReqired";
            panelCPNewspaperArticleReqired.Size = new Size(473, 302);
            panelCPNewspaperArticleReqired.TabIndex = 0;
            // 
            // tbCPNANumber
            // 
            tbCPNANumber.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNANumber.Location = new Point(0, 308);
            tbCPNANumber.Name = "tbCPNANumber";
            tbCPNANumber.Size = new Size(450, 23);
            tbCPNANumber.TabIndex = 17;
            ttMain.SetToolTip(tbCPNANumber, "Номер газеты, в которой напечатана статья.\r\nПример: «143»");
            tbCPNANumber.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNANumber
            // 
            labelCPNANumber.AutoSize = true;
            labelCPNANumber.Location = new Point(0, 290);
            labelCPNANumber.Name = "labelCPNANumber";
            labelCPNANumber.Size = new Size(84, 15);
            labelCPNANumber.TabIndex = 34;
            labelCPNANumber.Text = "Номер газеты";
            ttMain.SetToolTip(labelCPNANumber, "Номер газеты, в которой напечатана статья.\r\nПример: «143»");
            // 
            // cbCPNAArticleAuthors
            // 
            cbCPNAArticleAuthors.AutoSize = true;
            cbCPNAArticleAuthors.Location = new Point(371, 20);
            cbCPNAArticleAuthors.Name = "cbCPNAArticleAuthors";
            cbCPNAArticleAuthors.Size = new Size(79, 19);
            cbCPNAArticleAuthors.TabIndex = 12;
            cbCPNAArticleAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPNAArticleAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPNAArticleAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPNAArticleAuthors
            // 
            labelCPNAArticleAuthors.AutoSize = true;
            labelCPNAArticleAuthors.Location = new Point(0, 0);
            labelCPNAArticleAuthors.Name = "labelCPNAArticleAuthors";
            labelCPNAArticleAuthors.Size = new Size(95, 15);
            labelCPNAArticleAuthors.TabIndex = 29;
            labelCPNAArticleAuthors.Text = "Автор(ы) статьи";
            ttMain.SetToolTip(labelCPNAArticleAuthors, resources.GetString("labelCPNAArticleAuthors.ToolTip"));
            // 
            // tbCPNAArticleAuthors
            // 
            tbCPNAArticleAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAArticleAuthors.Location = new Point(0, 18);
            tbCPNAArticleAuthors.Name = "tbCPNAArticleAuthors";
            tbCPNAArticleAuthors.Size = new Size(269, 23);
            tbCPNAArticleAuthors.TabIndex = 10;
            ttMain.SetToolTip(tbCPNAArticleAuthors, resources.GetString("tbCPNAArticleAuthors.ToolTip"));
            tbCPNAArticleAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPNAArticleAuthors
            // 
            lbCPNAArticleAuthors.AllowDrop = true;
            lbCPNAArticleAuthors.ContextMenuStrip = cmsListBox;
            lbCPNAArticleAuthors.ItemHeight = 15;
            lbCPNAArticleAuthors.Location = new Point(0, 47);
            lbCPNAArticleAuthors.Name = "lbCPNAArticleAuthors";
            lbCPNAArticleAuthors.Size = new Size(450, 64);
            lbCPNAArticleAuthors.TabIndex = 32;
            lbCPNAArticleAuthors.TabStop = false;
            lbCPNAArticleAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPNAArticleAuthors.DragOver += this.ListBox_DragOver;
            lbCPNAArticleAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPNAArticleAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPNAArticleAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPNAArticleAuthorsAdd
            // 
            buttonCPNAArticleAuthorsAdd.Location = new Point(275, 18);
            buttonCPNAArticleAuthorsAdd.Name = "buttonCPNAArticleAuthorsAdd";
            buttonCPNAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPNAArticleAuthorsAdd.TabIndex = 11;
            buttonCPNAArticleAuthorsAdd.Text = "Добавить";
            buttonCPNAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPNAArticleAuthorsAdd.Click += this.buttonCPNAArticleAuthorsAdd_Click;
            // 
            // tbCPNAPages
            // 
            tbCPNAPages.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAPages.Location = new Point(0, 352);
            tbCPNAPages.Name = "tbCPNAPages";
            tbCPNAPages.Size = new Size(450, 23);
            tbCPNAPages.TabIndex = 18;
            ttMain.SetToolTip(tbCPNAPages, "Номера страниц, на которых размещена статья.\r\nПример: «6-7»\r\n");
            tbCPNAPages.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNAPages
            // 
            labelCPNAPages.AutoSize = true;
            labelCPNAPages.Location = new Point(0, 334);
            labelCPNAPages.Name = "labelCPNAPages";
            labelCPNAPages.Size = new Size(108, 15);
            labelCPNAPages.TabIndex = 12;
            labelCPNAPages.Text = "Диапазон страниц";
            ttMain.SetToolTip(labelCPNAPages, "Номера страниц, на которых размещена статья.\r\nПример: «6-7»");
            // 
            // tbCPNAReleaseDate
            // 
            tbCPNAReleaseDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAReleaseDate.Location = new Point(0, 264);
            tbCPNAReleaseDate.Name = "tbCPNAReleaseDate";
            tbCPNAReleaseDate.Size = new Size(450, 23);
            tbCPNAReleaseDate.TabIndex = 16;
            ttMain.SetToolTip(tbCPNAReleaseDate, "Конкретная дата выхода газеты.\r\nПример: «22 дек.»");
            tbCPNAReleaseDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNAArticleTitle
            // 
            labelCPNAArticleTitle.AutoSize = true;
            labelCPNAArticleTitle.Location = new Point(0, 114);
            labelCPNAArticleTitle.Name = "labelCPNAArticleTitle";
            labelCPNAArticleTitle.Size = new Size(95, 15);
            labelCPNAArticleTitle.TabIndex = 4;
            labelCPNAArticleTitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelCPNAArticleTitle, "Основное название статьи.\r\nПример: «„Пустое занятие“: кто лишает Россию права вето в СБ ООН»");
            // 
            // labelCPNAReleaseDate
            // 
            labelCPNAReleaseDate.AutoSize = true;
            labelCPNAReleaseDate.Location = new Point(0, 246);
            labelCPNAReleaseDate.Name = "labelCPNAReleaseDate";
            labelCPNAReleaseDate.Size = new Size(81, 15);
            labelCPNAReleaseDate.TabIndex = 10;
            labelCPNAReleaseDate.Text = "Дата выпуска";
            ttMain.SetToolTip(labelCPNAReleaseDate, "Конкретная дата выхода газеты.\r\nПример: «22 дек.»");
            // 
            // tbCPNAArticleTitle
            // 
            tbCPNAArticleTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAArticleTitle.Location = new Point(0, 132);
            tbCPNAArticleTitle.Name = "tbCPNAArticleTitle";
            tbCPNAArticleTitle.Size = new Size(450, 23);
            tbCPNAArticleTitle.TabIndex = 13;
            ttMain.SetToolTip(tbCPNAArticleTitle, "Основное название статьи.\r\nПример: «„Пустое занятие“: кто лишает Россию права вето в СБ ООН»\r\n");
            tbCPNAArticleTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPNAPublishYear
            // 
            tbCPNAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAPublishYear.Location = new Point(0, 220);
            tbCPNAPublishYear.Name = "tbCPNAPublishYear";
            tbCPNAPublishYear.Size = new Size(450, 23);
            tbCPNAPublishYear.TabIndex = 15;
            ttMain.SetToolTip(tbCPNAPublishYear, "Год выхода газеты, в которой опубликована статья.\r\nПример: «2017»");
            tbCPNAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNANewspaperName
            // 
            labelCPNANewspaperName.AutoSize = true;
            labelCPNANewspaperName.Location = new Point(0, 158);
            labelCPNANewspaperName.Name = "labelCPNANewspaperName";
            labelCPNANewspaperName.Size = new Size(98, 15);
            labelCPNANewspaperName.TabIndex = 6;
            labelCPNANewspaperName.Text = "Название газеты";
            ttMain.SetToolTip(labelCPNANewspaperName, "Полное наименование газеты, где опубликована статья.\r\nПример: «Новая газета»");
            // 
            // labelCPNAPublishYear
            // 
            labelCPNAPublishYear.AutoSize = true;
            labelCPNAPublishYear.Location = new Point(0, 202);
            labelCPNAPublishYear.Name = "labelCPNAPublishYear";
            labelCPNAPublishYear.Size = new Size(73, 15);
            labelCPNAPublishYear.TabIndex = 8;
            labelCPNAPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelCPNAPublishYear, "Год выхода газеты, в которой опубликована статья.\r\nПример: «2017»");
            // 
            // tbCPNANewspaperName
            // 
            tbCPNANewspaperName.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNANewspaperName.Location = new Point(0, 176);
            tbCPNANewspaperName.Name = "tbCPNANewspaperName";
            tbCPNANewspaperName.Size = new Size(450, 23);
            tbCPNANewspaperName.TabIndex = 14;
            ttMain.SetToolTip(tbCPNANewspaperName, "Полное наименование газеты, где опубликована статья.\r\nПример: «Новая газета»\r\n");
            tbCPNANewspaperName.KeyDown += this.TextBox_KeyDown;
            // 
            // gbCPNewspaperArticleOptional
            // 
            gbCPNewspaperArticleOptional.Controls.Add(panelCPNewspaperArticleOptional);
            gbCPNewspaperArticleOptional.Location = new Point(10, 346);
            gbCPNewspaperArticleOptional.Name = "gbCPNewspaperArticleOptional";
            gbCPNewspaperArticleOptional.Size = new Size(488, 330);
            gbCPNewspaperArticleOptional.TabIndex = 3;
            gbCPNewspaperArticleOptional.TabStop = false;
            gbCPNewspaperArticleOptional.Text = "Необязательные поля";
            // 
            // panelCPNewspaperArticleOptional
            // 
            panelCPNewspaperArticleOptional.Controls.Add(labelCPNAContentType);
            panelCPNewspaperArticleOptional.Controls.Add(tbCPNAContentType);
            panelCPNewspaperArticleOptional.Controls.Add(labelCPNAArticleNote);
            panelCPNewspaperArticleOptional.Controls.Add(tbCPNAInterviewer);
            panelCPNewspaperArticleOptional.Controls.Add(tbCPNAArticleNote);
            panelCPNewspaperArticleOptional.Controls.Add(labelCPNAInterviewer);
            panelCPNewspaperArticleOptional.Location = new Point(10, 22);
            panelCPNewspaperArticleOptional.Name = "panelCPNewspaperArticleOptional";
            panelCPNewspaperArticleOptional.Size = new Size(473, 302);
            panelCPNewspaperArticleOptional.TabIndex = 4;
            // 
            // labelCPNAContentType
            // 
            labelCPNAContentType.AutoSize = true;
            labelCPNAContentType.Location = new Point(0, 88);
            labelCPNAContentType.Name = "labelCPNAContentType";
            labelCPNAContentType.Size = new Size(97, 15);
            labelCPNAContentType.TabIndex = 33;
            labelCPNAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelCPNAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            // 
            // tbCPNAContentType
            // 
            tbCPNAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAContentType.Location = new Point(0, 106);
            tbCPNAContentType.Name = "tbCPNAContentType";
            tbCPNAContentType.Size = new Size(450, 23);
            tbCPNAContentType.TabIndex = 21;
            ttMain.SetToolTip(tbCPNAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            tbCPNAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNAArticleNote
            // 
            labelCPNAArticleNote.AutoSize = true;
            labelCPNAArticleNote.Location = new Point(0, 0);
            labelCPNAArticleNote.Name = "labelCPNAArticleNote";
            labelCPNAArticleNote.Size = new Size(124, 15);
            labelCPNAArticleNote.TabIndex = 0;
            labelCPNAArticleNote.Text = "Примечание к статье";
            ttMain.SetToolTip(labelCPNAArticleNote, "Дополнительное пояснение к содержанию статьи, например, форма подачи или контекст.\r\nПример: «об экономической ситуации: беседа с научным руководителем ВШЭ»");
            // 
            // tbCPNAInterviewer
            // 
            tbCPNAInterviewer.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAInterviewer.Location = new Point(0, 62);
            tbCPNAInterviewer.Name = "tbCPNAInterviewer";
            tbCPNAInterviewer.Size = new Size(450, 23);
            tbCPNAInterviewer.TabIndex = 20;
            ttMain.SetToolTip(tbCPNAInterviewer, "Имя лица, записавшего интервью или беседу.\r\nПример: «П. Каныгин»");
            tbCPNAInterviewer.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPNAArticleNote
            // 
            tbCPNAArticleNote.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPNAArticleNote.Location = new Point(0, 18);
            tbCPNAArticleNote.Name = "tbCPNAArticleNote";
            tbCPNAArticleNote.Size = new Size(450, 23);
            tbCPNAArticleNote.TabIndex = 19;
            ttMain.SetToolTip(tbCPNAArticleNote, "Дополнительное пояснение к содержанию статьи, например, форма подачи или контекст.\r\nПример: «об экономической ситуации: беседа с научным руководителем ВШЭ»");
            tbCPNAArticleNote.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPNAInterviewer
            // 
            labelCPNAInterviewer.AutoSize = true;
            labelCPNAInterviewer.Location = new Point(0, 44);
            labelCPNAInterviewer.Name = "labelCPNAInterviewer";
            labelCPNAInterviewer.Size = new Size(131, 15);
            labelCPNAInterviewer.TabIndex = 2;
            labelCPNAInterviewer.Text = "Записал (интервьюер)";
            ttMain.SetToolTip(labelCPNAInterviewer, "Имя лица, записавшего интервью или беседу.\r\nПример: «П. Каныгин»");
            // 
            // tpCPWebsiteArticle
            // 
            tpCPWebsiteArticle.BackColor = SystemColors.Control;
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleRequired);
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleOptional);
            tpCPWebsiteArticle.Location = new Point(4, 24);
            tpCPWebsiteArticle.Name = "tpCPWebsiteArticle";
            tpCPWebsiteArticle.Padding = new Padding(3);
            tpCPWebsiteArticle.Size = new Size(505, 681);
            tpCPWebsiteArticle.TabIndex = 3;
            tpCPWebsiteArticle.Text = "Статья с сайта";
            // 
            // gbCPWebsiteArticleRequired
            // 
            gbCPWebsiteArticleRequired.Controls.Add(panelCPWebsiteArticleRequired);
            gbCPWebsiteArticleRequired.Location = new Point(10, 10);
            gbCPWebsiteArticleRequired.Name = "gbCPWebsiteArticleRequired";
            gbCPWebsiteArticleRequired.Size = new Size(488, 330);
            gbCPWebsiteArticleRequired.TabIndex = 2;
            gbCPWebsiteArticleRequired.TabStop = false;
            gbCPWebsiteArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPWebsiteArticleRequired
            // 
            panelCPWebsiteArticleRequired.AutoScroll = true;
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAURL);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAArticleTitle);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAURL);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAArticleTitle);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAWebsiteName);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAWebsiteName);
            panelCPWebsiteArticleRequired.Location = new Point(10, 22);
            panelCPWebsiteArticleRequired.Name = "panelCPWebsiteArticleRequired";
            panelCPWebsiteArticleRequired.Size = new Size(473, 302);
            panelCPWebsiteArticleRequired.TabIndex = 0;
            // 
            // tbCPWAURL
            // 
            tbCPWAURL.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAURL.Location = new Point(0, 106);
            tbCPWAURL.Name = "tbCPWAURL";
            tbCPWAURL.Size = new Size(450, 23);
            tbCPWAURL.TabIndex = 12;
            ttMain.SetToolTip(tbCPWAURL, "Прямая ссылка на электронную публикацию. Всегда указывается в полном формате, начинающемся с http или https.\r\nПример: «http://www.nilc.ru/journal/»");
            tbCPWAURL.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAArticleTitle
            // 
            labelCPWAArticleTitle.AutoSize = true;
            labelCPWAArticleTitle.Location = new Point(0, 0);
            labelCPWAArticleTitle.Name = "labelCPWAArticleTitle";
            labelCPWAArticleTitle.Size = new Size(95, 15);
            labelCPWAArticleTitle.TabIndex = 4;
            labelCPWAArticleTitle.Text = "Заглавие статьи";
            ttMain.SetToolTip(labelCPWAArticleTitle, "Основное заглавие статьи без кавычек, включая подзаголовки и уточнения.\r\nПример: «От MARC 21 к модели BIBFRAME: эволюция машиночитаемых форматов Библиотеки Конгресса США»");
            // 
            // labelCPWAURL
            // 
            labelCPWAURL.AutoSize = true;
            labelCPWAURL.Location = new Point(0, 88);
            labelCPWAURL.Name = "labelCPWAURL";
            labelCPWAURL.Size = new Size(28, 15);
            labelCPWAURL.TabIndex = 8;
            labelCPWAURL.Text = "URL";
            ttMain.SetToolTip(labelCPWAURL, "Прямая ссылка на электронную публикацию. Всегда указывается в полном формате, начинающемся с http или https.\r\nПример: «http://www.nilc.ru/journal/»");
            // 
            // tbCPWAArticleTitle
            // 
            tbCPWAArticleTitle.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAArticleTitle.Location = new Point(0, 18);
            tbCPWAArticleTitle.Name = "tbCPWAArticleTitle";
            tbCPWAArticleTitle.Size = new Size(450, 23);
            tbCPWAArticleTitle.TabIndex = 10;
            ttMain.SetToolTip(tbCPWAArticleTitle, "Основное заглавие статьи без кавычек, включая подзаголовки и уточнения.\r\nПример: «От MARC 21 к модели BIBFRAME: эволюция машиночитаемых форматов Библиотеки Конгресса США»");
            tbCPWAArticleTitle.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPWAWebsiteName
            // 
            tbCPWAWebsiteName.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAWebsiteName.Location = new Point(0, 62);
            tbCPWAWebsiteName.Name = "tbCPWAWebsiteName";
            tbCPWAWebsiteName.Size = new Size(450, 23);
            tbCPWAWebsiteName.TabIndex = 11;
            ttMain.SetToolTip(tbCPWAWebsiteName, "Наименование электронного ресурса (сайта), на котором размещена статья. Указывается без URL и технических подробностей.\r\nПример: «Теория и практика каталогизации и поиска библиотечных ресурсов»");
            tbCPWAWebsiteName.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAWebsiteName
            // 
            labelCPWAWebsiteName.AutoSize = true;
            labelCPWAWebsiteName.Location = new Point(0, 44);
            labelCPWAWebsiteName.Name = "labelCPWAWebsiteName";
            labelCPWAWebsiteName.Size = new Size(92, 15);
            labelCPWAWebsiteName.TabIndex = 6;
            labelCPWAWebsiteName.Text = "Название сайта";
            ttMain.SetToolTip(labelCPWAWebsiteName, "Наименование электронного ресурса (сайта), на котором размещена статья. Указывается без URL и технических подробностей.\r\nПример: «Теория и практика каталогизации и поиска библиотечных ресурсов»");
            // 
            // gbCPWebsiteArticleOptional
            // 
            gbCPWebsiteArticleOptional.Controls.Add(panelCPWebsiteArticleOptional);
            gbCPWebsiteArticleOptional.Location = new Point(10, 346);
            gbCPWebsiteArticleOptional.Name = "gbCPWebsiteArticleOptional";
            gbCPWebsiteArticleOptional.Size = new Size(488, 330);
            gbCPWebsiteArticleOptional.TabIndex = 3;
            gbCPWebsiteArticleOptional.TabStop = false;
            gbCPWebsiteArticleOptional.Text = "Необязательные поля";
            // 
            // panelCPWebsiteArticleOptional
            // 
            panelCPWebsiteArticleOptional.AutoScroll = true;
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAAccessDate);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAPublicationType);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAAccessDate);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAPublicationType);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAMaterialType);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAMaterialType);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAContentType);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAContentType);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAEventDate);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAEventDate);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAEventPlace);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAEventPlace);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAResourceDescription);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAResourceDescription);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAResourceType);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAResourceType);
            panelCPWebsiteArticleOptional.Controls.Add(cbCPWAArticleAuthors);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAArticleAuthors);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAArticleAuthors);
            panelCPWebsiteArticleOptional.Controls.Add(lbCPWAArticleAuthors);
            panelCPWebsiteArticleOptional.Controls.Add(buttonCPWAArticleAuthorsAdd);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAPublishYear);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAPublishDate);
            panelCPWebsiteArticleOptional.Controls.Add(tbCPWAPublishYear);
            panelCPWebsiteArticleOptional.Controls.Add(labelCPWAPublishDate);
            panelCPWebsiteArticleOptional.Location = new Point(10, 22);
            panelCPWebsiteArticleOptional.Name = "panelCPWebsiteArticleOptional";
            panelCPWebsiteArticleOptional.Size = new Size(473, 302);
            panelCPWebsiteArticleOptional.TabIndex = 8;
            // 
            // tbCPWAAccessDate
            // 
            tbCPWAAccessDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAAccessDate.Location = new Point(0, 440);
            tbCPWAAccessDate.Name = "tbCPWAAccessDate";
            tbCPWAAccessDate.Size = new Size(450, 23);
            tbCPWAAccessDate.TabIndex = 23;
            ttMain.SetToolTip(tbCPWAAccessDate, "Дата последнего обращения к ресурсу. Используется для всех электронных публикаций.\r\nПример: «02.05.2025»");
            tbCPWAAccessDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAPublicationType
            // 
            labelCPWAPublicationType.AutoSize = true;
            labelCPWAPublicationType.Location = new Point(0, 158);
            labelCPWAPublicationType.Name = "labelCPWAPublicationType";
            labelCPWAPublicationType.Size = new Size(74, 15);
            labelCPWAPublicationType.TabIndex = 68;
            labelCPWAPublicationType.Text = "Вид издания";
            ttMain.SetToolTip(labelCPWAPublicationType, resources.GetString("labelCPWAPublicationType.ToolTip"));
            // 
            // labelCPWAAccessDate
            // 
            labelCPWAAccessDate.AutoSize = true;
            labelCPWAAccessDate.Location = new Point(0, 422);
            labelCPWAAccessDate.Name = "labelCPWAAccessDate";
            labelCPWAAccessDate.Size = new Size(99, 15);
            labelCPWAAccessDate.TabIndex = 10;
            labelCPWAAccessDate.Text = "Дата обращения";
            ttMain.SetToolTip(labelCPWAAccessDate, "Дата последнего обращения к ресурсу. Используется для всех электронных публикаций.\r\nПример: «02.05.2025»");
            // 
            // tbCPWAPublicationType
            // 
            tbCPWAPublicationType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAPublicationType.Location = new Point(0, 176);
            tbCPWAPublicationType.Name = "tbCPWAPublicationType";
            tbCPWAPublicationType.Size = new Size(450, 23);
            tbCPWAPublicationType.TabIndex = 17;
            ttMain.SetToolTip(tbCPWAPublicationType, resources.GetString("tbCPWAPublicationType.ToolTip"));
            tbCPWAPublicationType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAMaterialType
            // 
            labelCPWAMaterialType.AutoSize = true;
            labelCPWAMaterialType.Location = new Point(0, 114);
            labelCPWAMaterialType.Name = "labelCPWAMaterialType";
            labelCPWAMaterialType.Size = new Size(89, 15);
            labelCPWAMaterialType.TabIndex = 66;
            labelCPWAMaterialType.Text = "Вид материала";
            ttMain.SetToolTip(labelCPWAMaterialType, "Тип представленного материала - указание на форму представления, например: презентация, интервью, доклад. Не включает в себя сведения о конференции.\r\nПример: «презентация»");
            // 
            // tbCPWAMaterialType
            // 
            tbCPWAMaterialType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAMaterialType.Location = new Point(0, 132);
            tbCPWAMaterialType.Name = "tbCPWAMaterialType";
            tbCPWAMaterialType.Size = new Size(450, 23);
            tbCPWAMaterialType.TabIndex = 16;
            ttMain.SetToolTip(tbCPWAMaterialType, "Тип представленного материала - указание на форму представления, например: презентация, интервью, доклад. Не включает в себя сведения о конференции.\r\nПример: «презентация»\r\n");
            tbCPWAMaterialType.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAContentType
            // 
            labelCPWAContentType.AutoSize = true;
            labelCPWAContentType.Location = new Point(0, 510);
            labelCPWAContentType.Name = "labelCPWAContentType";
            labelCPWAContentType.Size = new Size(97, 15);
            labelCPWAContentType.TabIndex = 64;
            labelCPWAContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelCPWAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            // 
            // tbCPWAContentType
            // 
            tbCPWAContentType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAContentType.Location = new Point(0, 528);
            tbCPWAContentType.Name = "tbCPWAContentType";
            tbCPWAContentType.Size = new Size(450, 23);
            tbCPWAContentType.TabIndex = 25;
            ttMain.SetToolTip(tbCPWAContentType, "Уточняет вид содержания.\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".\r\n");
            tbCPWAContentType.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPWAEventDate
            // 
            tbCPWAEventDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAEventDate.Location = new Point(0, 264);
            tbCPWAEventDate.Name = "tbCPWAEventDate";
            tbCPWAEventDate.Size = new Size(450, 23);
            tbCPWAEventDate.TabIndex = 19;
            ttMain.SetToolTip(tbCPWAEventDate, "Конкретные даты проведения мероприятия. Указывается в полной форме.\r\nПример: «18–19 апреля 2017 г.»");
            tbCPWAEventDate.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAEventDate
            // 
            labelCPWAEventDate.AutoSize = true;
            labelCPWAEventDate.Location = new Point(0, 246);
            labelCPWAEventDate.Name = "labelCPWAEventDate";
            labelCPWAEventDate.Size = new Size(100, 15);
            labelCPWAEventDate.TabIndex = 62;
            labelCPWAEventDate.Text = "Дата проведения";
            ttMain.SetToolTip(labelCPWAEventDate, "Конкретные даты проведения мероприятия. Указывается в полной форме.\r\nПример: «18–19 апреля 2017 г.»");
            // 
            // tbCPWAEventPlace
            // 
            tbCPWAEventPlace.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAEventPlace.Location = new Point(0, 220);
            tbCPWAEventPlace.Name = "tbCPWAEventPlace";
            tbCPWAEventPlace.Size = new Size(450, 23);
            tbCPWAEventPlace.TabIndex = 18;
            ttMain.SetToolTip(tbCPWAEventPlace, "Город или населённый пункт, где проводилось мероприятие, связанное с публикацией статьи.\r\nПример: «Москва»");
            tbCPWAEventPlace.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAEventPlace
            // 
            labelCPWAEventPlace.AutoSize = true;
            labelCPWAEventPlace.Location = new Point(0, 202);
            labelCPWAEventPlace.Name = "labelCPWAEventPlace";
            labelCPWAEventPlace.Size = new Size(108, 15);
            labelCPWAEventPlace.TabIndex = 60;
            labelCPWAEventPlace.Text = "Город проведения";
            ttMain.SetToolTip(labelCPWAEventPlace, "Город или населённый пункт, где проводилось мероприятие, связанное с публикацией статьи.\r\nПример: «Москва»");
            // 
            // labelCPWAResourceDescription
            // 
            labelCPWAResourceDescription.AutoSize = true;
            labelCPWAResourceDescription.Location = new Point(0, 290);
            labelCPWAResourceDescription.Name = "labelCPWAResourceDescription";
            labelCPWAResourceDescription.Size = new Size(109, 15);
            labelCPWAResourceDescription.TabIndex = 39;
            labelCPWAResourceDescription.Text = "Описание ресурса";
            ttMain.SetToolTip(labelCPWAResourceDescription, "Дополнительное описание ресурса, поясняющее его назначение или тематику.\r\nПример: «научная электронная библиотека»");
            // 
            // tbCPWAResourceDescription
            // 
            tbCPWAResourceDescription.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAResourceDescription.Location = new Point(0, 308);
            tbCPWAResourceDescription.Name = "tbCPWAResourceDescription";
            tbCPWAResourceDescription.Size = new Size(450, 23);
            tbCPWAResourceDescription.TabIndex = 20;
            ttMain.SetToolTip(tbCPWAResourceDescription, "Дополнительное описание ресурса, поясняющее его назначение или тематику.\r\nПример: «научная электронная библиотека»");
            tbCPWAResourceDescription.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAResourceType
            // 
            labelCPWAResourceType.AutoSize = true;
            labelCPWAResourceType.Location = new Point(0, 334);
            labelCPWAResourceType.Name = "labelCPWAResourceType";
            labelCPWAResourceType.Size = new Size(74, 15);
            labelCPWAResourceType.TabIndex = 12;
            labelCPWAResourceType.Text = "Тип ресурса";
            ttMain.SetToolTip(labelCPWAResourceType, "Тип сайта или платформы, на которой опубликован материал (например, официальный сайт, электронный журнал и т. д.).\r\nПример: «электронный журнал»");
            // 
            // tbCPWAResourceType
            // 
            tbCPWAResourceType.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAResourceType.Location = new Point(0, 352);
            tbCPWAResourceType.Name = "tbCPWAResourceType";
            tbCPWAResourceType.Size = new Size(450, 23);
            tbCPWAResourceType.TabIndex = 21;
            ttMain.SetToolTip(tbCPWAResourceType, "Тип сайта или платформы, на которой опубликован материал (например, официальный сайт, электронный журнал и т. д.).\r\nПример: «электронный журнал»");
            tbCPWAResourceType.KeyDown += this.TextBox_KeyDown;
            // 
            // cbCPWAArticleAuthors
            // 
            cbCPWAArticleAuthors.AutoSize = true;
            cbCPWAArticleAuthors.Location = new Point(371, 20);
            cbCPWAArticleAuthors.Name = "cbCPWAArticleAuthors";
            cbCPWAArticleAuthors.Size = new Size(79, 19);
            cbCPWAArticleAuthors.TabIndex = 15;
            cbCPWAArticleAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbCPWAArticleAuthors, "Включить логику формирования для 5 и более авторов.\r\n**Включается автоматически при добавлении 5 и более авторов**");
            cbCPWAArticleAuthors.UseVisualStyleBackColor = true;
            // 
            // labelCPWAArticleAuthors
            // 
            labelCPWAArticleAuthors.AutoSize = true;
            labelCPWAArticleAuthors.Location = new Point(0, 0);
            labelCPWAArticleAuthors.Name = "labelCPWAArticleAuthors";
            labelCPWAArticleAuthors.Size = new Size(95, 15);
            labelCPWAArticleAuthors.TabIndex = 34;
            labelCPWAArticleAuthors.Text = "Автор(ы) статьи";
            ttMain.SetToolTip(labelCPWAArticleAuthors, resources.GetString("labelCPWAArticleAuthors.ToolTip"));
            // 
            // tbCPWAArticleAuthors
            // 
            tbCPWAArticleAuthors.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAArticleAuthors.Location = new Point(0, 18);
            tbCPWAArticleAuthors.Name = "tbCPWAArticleAuthors";
            tbCPWAArticleAuthors.Size = new Size(269, 23);
            tbCPWAArticleAuthors.TabIndex = 13;
            ttMain.SetToolTip(tbCPWAArticleAuthors, resources.GetString("tbCPWAArticleAuthors.ToolTip"));
            tbCPWAArticleAuthors.KeyDown += this.TextBox_KeyDown;
            // 
            // lbCPWAArticleAuthors
            // 
            lbCPWAArticleAuthors.AllowDrop = true;
            lbCPWAArticleAuthors.ContextMenuStrip = cmsListBox;
            lbCPWAArticleAuthors.ItemHeight = 15;
            lbCPWAArticleAuthors.Location = new Point(0, 47);
            lbCPWAArticleAuthors.Name = "lbCPWAArticleAuthors";
            lbCPWAArticleAuthors.Size = new Size(450, 64);
            lbCPWAArticleAuthors.TabIndex = 37;
            lbCPWAArticleAuthors.TabStop = false;
            lbCPWAArticleAuthors.DragDrop += this.ListBox_DragDrop;
            lbCPWAArticleAuthors.DragOver += this.ListBox_DragOver;
            lbCPWAArticleAuthors.KeyDown += this.ListBox_KeyDown;
            lbCPWAArticleAuthors.MouseDown += this.ListBox_MouseDown;
            lbCPWAArticleAuthors.MouseMove += this.ListBox_MouseMove;
            // 
            // buttonCPWAArticleAuthorsAdd
            // 
            buttonCPWAArticleAuthorsAdd.Location = new Point(275, 18);
            buttonCPWAArticleAuthorsAdd.Name = "buttonCPWAArticleAuthorsAdd";
            buttonCPWAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPWAArticleAuthorsAdd.TabIndex = 14;
            buttonCPWAArticleAuthorsAdd.Text = "Добавить";
            buttonCPWAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            buttonCPWAArticleAuthorsAdd.Click += this.buttonCPWAArticleAuthorsAdd_Click;
            // 
            // labelCPWAPublishYear
            // 
            labelCPWAPublishYear.AutoSize = true;
            labelCPWAPublishYear.Location = new Point(0, 378);
            labelCPWAPublishYear.Name = "labelCPWAPublishYear";
            labelCPWAPublishYear.Size = new Size(96, 15);
            labelCPWAPublishYear.TabIndex = 2;
            labelCPWAPublishYear.Text = "Год публикации";
            ttMain.SetToolTip(labelCPWAPublishYear, "Год публикации статьи (если известен). Обычно указывается рядом с названием сайта.\r\nПример: «2018»");
            // 
            // tbCPWAPublishDate
            // 
            tbCPWAPublishDate.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAPublishDate.Location = new Point(0, 484);
            tbCPWAPublishDate.Name = "tbCPWAPublishDate";
            tbCPWAPublishDate.Size = new Size(450, 23);
            tbCPWAPublishDate.TabIndex = 24;
            ttMain.SetToolTip(tbCPWAPublishDate, "Дата выхода статьи или её размещения на сайте. Если известны только день и месяц, указываются они; если известна вся дата — используется она одна.\r\nПример: «2 февр.»");
            tbCPWAPublishDate.KeyDown += this.TextBox_KeyDown;
            // 
            // tbCPWAPublishYear
            // 
            tbCPWAPublishYear.ContextMenuStrip = cmsRichTextBox_TextBox;
            tbCPWAPublishYear.Location = new Point(0, 396);
            tbCPWAPublishYear.Name = "tbCPWAPublishYear";
            tbCPWAPublishYear.Size = new Size(450, 23);
            tbCPWAPublishYear.TabIndex = 22;
            ttMain.SetToolTip(tbCPWAPublishYear, "Год публикации статьи (если известен). Обычно указывается рядом с названием сайта.\r\nПример: «2018»");
            tbCPWAPublishYear.KeyDown += this.TextBox_KeyDown;
            // 
            // labelCPWAPublishDate
            // 
            labelCPWAPublishDate.AutoSize = true;
            labelCPWAPublishDate.Location = new Point(0, 466);
            labelCPWAPublishDate.Name = "labelCPWAPublishDate";
            labelCPWAPublishDate.Size = new Size(102, 15);
            labelCPWAPublishDate.TabIndex = 4;
            labelCPWAPublishDate.Text = "Дата публикации";
            ttMain.SetToolTip(labelCPWAPublishDate, "Дата выхода статьи или её размещения на сайте. Если известны только день и месяц, указываются они; если известна вся дата — используется она одна.\r\nПример: «2 февр.»");
            // 
            // GOST2018
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(837, 808);
            this.Controls.Add(splitContainer1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)(resources.GetObject("$this.Icon"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GOST2018";
            this.Text = "Оформление списка литературы по ГОСТ Р 7.0.100-2018";
            this.FormClosed += this.GOST2018_FormClosed;
            this.Load += this.GOST2018_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(splitContainer3)).EndInit();
            splitContainer3.ResumeLayout(false);
            panelRtbMLA.ResumeLayout(false);
            cmsRichTextBox_TextBox.ResumeLayout(false);
            panelRtbGOST.ResumeLayout(false);
            panelConvertTitle.ResumeLayout(false);
            panelConvertTitle.PerformLayout();
            cmsListBox.ResumeLayout(false);
            panelAddRecord.ResumeLayout(false);
            panelAddRecord.PerformLayout();
            tcCategories.ResumeLayout(false);
            cmsMainTabControl.ResumeLayout(false);
            tpSingleVolume.ResumeLayout(false);
            tcSVTypes.ResumeLayout(false);
            tpSVBook.ResumeLayout(false);
            gpSVBookRequired.ResumeLayout(false);
            panelSVBookRequired.ResumeLayout(false);
            panelSVBookRequired.PerformLayout();
            gpSVBookOptional.ResumeLayout(false);
            panelSVBookOptional.ResumeLayout(false);
            panelSVBookOptional.PerformLayout();
            tpSVConferenceMaterials.ResumeLayout(false);
            gbSVConferenceMaterialsRequired.ResumeLayout(false);
            panelSVConferenceMaterialsRequired.ResumeLayout(false);
            panelSVConferenceMaterialsRequired.PerformLayout();
            gbSVConferenceMaterialsOptional.ResumeLayout(false);
            panelSVConferenceMaterialsOptional.ResumeLayout(false);
            panelSVConferenceMaterialsOptional.PerformLayout();
            tpSVGOST.ResumeLayout(false);
            gbSVGOSTRequired.ResumeLayout(false);
            panelSVGOSTRequired.ResumeLayout(false);
            panelSVGOSTRequired.PerformLayout();
            gbSVGOSTOptional.ResumeLayout(false);
            panelSVGOSTOptional.ResumeLayout(false);
            panelSVGOSTOptional.PerformLayout();
            tpSVLegislativeMaterial.ResumeLayout(false);
            gbSVLegislativeMaterialRequired.ResumeLayout(false);
            panelSVLegislativeMaterialRequired.ResumeLayout(false);
            panelSVLegislativeMaterialRequired.PerformLayout();
            gbSVLegislativeMaterialOptional.ResumeLayout(false);
            panelSVLegislativeMaterialOptional.ResumeLayout(false);
            panelSVLegislativeMaterialOptional.PerformLayout();
            tpSVDissertationAbstract.ResumeLayout(false);
            gbSVDissertationAbstractRequired.ResumeLayout(false);
            panelSVDissertationAbstractRequired.ResumeLayout(false);
            panelSVDissertationAbstractRequired.PerformLayout();
            gbSVDissertationAbstractOptional.ResumeLayout(false);
            panelSVDissertationAbstractOptional.ResumeLayout(false);
            panelSVDissertationAbstractOptional.PerformLayout();
            tpSVDissertation.ResumeLayout(false);
            gbSVDissertationRequired.ResumeLayout(false);
            panelSVDissertationRequired.ResumeLayout(false);
            panelSVDissertationRequired.PerformLayout();
            gbSVDissertationOptional.ResumeLayout(false);
            panelSVDissertationOptional.ResumeLayout(false);
            panelSVDissertationOptional.PerformLayout();
            tpMultiVolume.ResumeLayout(false);
            tcMVTypes.ResumeLayout(false);
            tpMVWholeMultivolume.ResumeLayout(false);
            gbMVWholeMultivolumeRequired.ResumeLayout(false);
            panelMVWholeMultivolumeRequired.ResumeLayout(false);
            panelMVWholeMultivolumeRequired.PerformLayout();
            gbMVWholeMultivolumeOptional.ResumeLayout(false);
            panelMVWholeMultivolumeOptional.ResumeLayout(false);
            panelMVWholeMultivolumeOptional.PerformLayout();
            tpMVSeparateVolume.ResumeLayout(false);
            gbMVSeparateVolumeRequired.ResumeLayout(false);
            panelMVSeparateVolumeRequired.ResumeLayout(false);
            panelMVSeparateVolumeRequired.PerformLayout();
            gbMVSeparateVolumeOptional.ResumeLayout(false);
            panelMVSeparateVolumeOptional.ResumeLayout(false);
            panelMVSeparateVolumeOptional.PerformLayout();
            tpElectronicResources.ResumeLayout(false);
            tcERTypes.ResumeLayout(false);
            tpEREbook.ResumeLayout(false);
            gbEREbookRequired.ResumeLayout(false);
            panelEREbookRequired.ResumeLayout(false);
            panelEREbookRequired.PerformLayout();
            gbEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.PerformLayout();
            tpERWholeElectronicEdition.ResumeLayout(false);
            gbERWholeElectronicEditionRequired.ResumeLayout(false);
            panelERWholeElectronicEditionRequired.ResumeLayout(false);
            panelERWholeElectronicEditionRequired.PerformLayout();
            gbERWholeElectronicEditionOptional.ResumeLayout(false);
            panelERWholeElectronicEditionOptional.ResumeLayout(false);
            panelERWholeElectronicEditionOptional.PerformLayout();
            tpERElectronicEditionSeparateVolume.ResumeLayout(false);
            gbERElectronicEditionSeparateVolumeRequired.ResumeLayout(false);
            panelERElectronicEditionSeparateVolumeRequired.ResumeLayout(false);
            panelERElectronicEditionSeparateVolumeRequired.PerformLayout();
            gbERElectronicEditionSeparateVolumeOptional.ResumeLayout(false);
            panelERElectronicEditionSeparateVolumeOptional.ResumeLayout(false);
            panelERElectronicEditionSeparateVolumeOptional.PerformLayout();
            tpERElectronicConferenceMaterials.ResumeLayout(false);
            gbERElectronicConferenceMaterialsRequired.ResumeLayout(false);
            panelERElectronicConferenceMaterialsRequired.ResumeLayout(false);
            panelERElectronicConferenceMaterialsRequired.PerformLayout();
            gbERElectronicConferenceMaterialsOptional.ResumeLayout(false);
            panelERElectronicConferenceMaterialsOptional.ResumeLayout(false);
            panelERElectronicConferenceMaterialsOptional.PerformLayout();
            tpERElectronicCollections.ResumeLayout(false);
            gbERElectronicCollectionsRequired.ResumeLayout(false);
            panelERElectronicCollectionsRequired.ResumeLayout(false);
            panelERElectronicCollectionsRequired.PerformLayout();
            gbERElectronicCollectionsOptional.ResumeLayout(false);
            panelERElectronicCollectionsOptional.ResumeLayout(false);
            panelERElectronicCollectionsOptional.PerformLayout();
            tpEREjournalArticle.ResumeLayout(false);
            gbEREjournalArticleReqired.ResumeLayout(false);
            panelEREjournalArticleReqired.ResumeLayout(false);
            panelEREjournalArticleReqired.PerformLayout();
            gbEREjournalArticleOptional.ResumeLayout(false);
            panelEREjournalArticleOptional.ResumeLayout(false);
            panelEREjournalArticleOptional.PerformLayout();
            tpERMultimediaEdition.ResumeLayout(false);
            gbERMultimediaEditionRequired.ResumeLayout(false);
            panelERMultimediaEditionRequired.ResumeLayout(false);
            panelERMultimediaEditionRequired.PerformLayout();
            gbERMultimediaEditionOptional.ResumeLayout(false);
            panelERMultimediaEditionOptional.ResumeLayout(false);
            panelERMultimediaEditionOptional.PerformLayout();
            tpERWebsite.ResumeLayout(false);
            gbERWebsiteRequired.ResumeLayout(false);
            panelERWebsiteRequired.ResumeLayout(false);
            panelERWebsiteRequired.PerformLayout();
            gbERWebsiteOptional.ResumeLayout(false);
            panelERWebsiteOptional.ResumeLayout(false);
            panelERWebsiteOptional.PerformLayout();
            tpConstituentParts.ResumeLayout(false);
            tcCPTypes.ResumeLayout(false);
            tpCPBookArticle.ResumeLayout(false);
            gbCPBookArticleRequired.ResumeLayout(false);
            panelCPBookArticleRequired.ResumeLayout(false);
            panelCPBookArticleRequired.PerformLayout();
            gbCPBookArticleOptional.ResumeLayout(false);
            panelCPBookArticleOptional.ResumeLayout(false);
            panelCPBookArticleOptional.PerformLayout();
            tpCPConferenceArticle.ResumeLayout(false);
            gbCPConferenceArticleRequired.ResumeLayout(false);
            panelCPConferenceArticleRequired.ResumeLayout(false);
            panelCPConferenceArticleRequired.PerformLayout();
            gbCPConferenceArticleOptional.ResumeLayout(false);
            panelCPConferenceArticleOptional.ResumeLayout(false);
            panelCPConferenceArticleOptional.PerformLayout();
            tpCPJournalArticle.ResumeLayout(false);
            gbCPJournalArticleRequired.ResumeLayout(false);
            panelCPJournalArticleRequired.ResumeLayout(false);
            panelCPJournalArticleRequired.PerformLayout();
            gbCPJournalArticleOptional.ResumeLayout(false);
            panelCPJournalArticleOptional.ResumeLayout(false);
            panelCPJournalArticleOptional.PerformLayout();
            tpCPNewspaperArticle.ResumeLayout(false);
            gbCPNewspaperArticleReqired.ResumeLayout(false);
            panelCPNewspaperArticleReqired.ResumeLayout(false);
            panelCPNewspaperArticleReqired.PerformLayout();
            gbCPNewspaperArticleOptional.ResumeLayout(false);
            panelCPNewspaperArticleOptional.ResumeLayout(false);
            panelCPNewspaperArticleOptional.PerformLayout();
            tpCPWebsiteArticle.ResumeLayout(false);
            gbCPWebsiteArticleRequired.ResumeLayout(false);
            panelCPWebsiteArticleRequired.ResumeLayout(false);
            panelCPWebsiteArticleRequired.PerformLayout();
            gbCPWebsiteArticleOptional.ResumeLayout(false);
            panelCPWebsiteArticleOptional.ResumeLayout(false);
            panelCPWebsiteArticleOptional.PerformLayout();
            this.ResumeLayout(false);
        }

        private GroupBox gbSVGOSTRequired;
        private Label labelSVGOSTTitle;
        private TextBox tbSVGOSTTitle;
        private Label labelSVGOSTPublishingLocation;
        private Label labelSVGOSTPublisher;
        private Label labelSVGOSTPublishYear;
        private TextBox tbSVGOSTPublishYear;
        private GroupBox gbSVGOSTOptional;
        private Label labelSVGOSTDocumentType;
        private TextBox tbSVGOSTDocumentType;
        private Label labelSVGOSTApprovalDate;
        private TextBox tbSVGOSTApprovalDate;
        private Label labelSVGOSTImplementDate;
        private TextBox tbSVGOSTImplementDate;
        private Label labelSVGOSTDeveloper;
        private TextBox tbSVGOSTDeveloper;
        private Label labelSVGOSTContentType;
        private TextBox tbSVGOSTContentType;
        private TabPage tpSVDissertationAbstract;
        private TabPage tpSVDissertation;
        private Label labelSVGOSTDocumentNumber;
        private TextBox tbSVGOSTDocumentNumber;
        private Label labelSVGOSTPagesCount;
        private TextBox tbSVGOSTPagesCount;
        private GroupBox gbSVDissertationAbstractRequired;
        private Label labelSVDATitle;
        private TextBox tbSVDATitle;
        private Label labelSVDAAuthor;
        private TextBox tbSVDAAuthor;
        private Label labelSVDASpecialty;
        private TextBox tbSVDASpecialty;
        private Label labelSVDADegree;
        private TextBox tbSVDADegree;
        private Label labelSVDAPublishingLocation;
        private TextBox tbSVDAPublishingLocation;
        private GroupBox gbSVDissertationAbstractOptional;
        private Label labelSVDAOrganization;
        private TextBox tbSVDAOrganization;
        private Label labelSVDABibliography;
        private TextBox tbSVDABibliography;
        private Label labelSVDADefenseLocation;
        private TextBox tbSVDADefenseLocation;
        private Label labelSVDAPagesCount;
        private TextBox tbSVDAPagesCount;
        private Label labelSVDAPublishYear;
        private TextBox tbSVDAPublishYear;
        private TabControl tcCategories;
        private TabPage tpSingleVolume;
        private TabPage tpMultiVolume;
        private TabControl tcMVTypes;
        private TabPage tpMVWholeMultivolume;
        private GroupBox gbMVWholeMultivolumeOptional;
        private Label labelMVWMDocumentType;
        private TextBox tbMVWMDocumentType;
        private Label labelMVWMEditor;
        private TextBox tbMVWMEditor;
        private Label labelMVWMEditionNumber;
        private TextBox tbMVWMEditionNumber;
        private Label labelMVWMSeries;
        private TextBox tbMVWMSeries;
        private Label labelMVWMISBN;
        private TextBox tbMVWMISBN;
        private TabPage tpMVSeparateVolume;
        private TabPage tpElectronicResources;
        private TabPage tpConstituentParts;
        private GroupBox gbMVWholeMultivolumeRequired;
        private Label labelMVWMPagesCount;
        private TextBox tbMVWMPagesCount;
        private Label labelMVWMAuthors;
        private TextBox tbMVWMAuthors;
        private Button buttonMVWMAuthorsAdd;
        private ListBox lbMVWMAuthors;
        private Label labelMVWMTitle;
        private TextBox tbMVWMTitle;
        private Label labelMVWMVolumesCount;
        private TextBox tbMVWMVolumesCount;
        private Label labelMVWMPublishingLocation;
        private TextBox tbMVWMPublishingLocation;
        private Label labelMVWMPublisher;
        private TextBox tbMVWMPublisher;
        private Label labelMVWMPublishYear;
        private TextBox tbMVWMPublishYear;
        private GroupBox gbMVSeparateVolumeRequired;
        private Label labelMVSVPublisher;
        private TextBox tbMVSVPublisher;
        private Label labelMVSVAuthors;
        private TextBox tbMVSVAuthors;
        private Button buttonMVSVAuthorsAdd;
        private ListBox lbMVSVAuthors;
        private Label labelMVSVTitle;
        private TextBox tbMVSVTitle;
        private Label labelMVSVVolumesCount;
        private TextBox tbMVSVVolumesCount;
        private Label labelMVSVVolumeNumber;
        private TextBox tbMVSVVolumeNumber;
        private Label labelMVSVVolumeTitle;
        private TextBox tbMVSVVolumeTitle;
        private Label labelMVSVPublishingLocation;
        private TextBox tbMVSVPublishingLocation;
        private GroupBox gbMVSeparateVolumeOptional;
        private Label labelMVSVDocumentType;
        private TextBox tbMVSVDocumentType;
        private Label labelMVSVEditor;
        private TextBox tbMVSVEditor;
        private Label labelMVSVEditionNumber;
        private TextBox tbMVSVEditionNumber;
        private Label labelMVSVSeries;
        private TextBox tbMVSVSeries;
        private Label labelMVSVISBN;
        private TextBox tbMVSVISBN;
        private Label labelMVSVPagesCount;
        private TextBox tbMVSVPagesCount;
        private Label labelMVSVPublishYear;
        private TextBox tbMVSVPublishYear;
        private TabControl tcERTypes;
        private TabPage tpEREbook;
        private GroupBox gbEREbookRequired;
        private Label labelEREbAuthors;
        private TextBox tbEREbAuthors;
        private Button labelEREbAuthorsAdd;
        private ListBox lbEREbAuthors;
        private Label labelEREbTitle;
        private TextBox tbEREbTitle;
        private Label labelEREbPublishingLocation;
        private TextBox tbEREbPublishingLocation;
        private Label labelEREbPublisher;
        private TextBox tbEREbPublisher;
        private Label labelEREbPublishYear;
        private TextBox tbEREbPublishYear;
        private Label labelEREbURL;
        private TextBox tbEREbURL;
        private GroupBox gbEREbookOptional;
        private Label labelEREbDocumentType;
        private TextBox tbEREbDocumentType;
        private Label labelEREbEditor;
        private TextBox tbEREbEditor;
        private Label labelEREbEditionNumber;
        private TextBox tbEREbEditionNumber;
        private Label labelEREbPagesCount;
        private TextBox tbEREbPagesCount;
        private Label labelEREbSeries;
        private TextBox tbEREbSeries;
        private Label labelEREbISBN;
        private TextBox tbEREbISBN;
        private TabPage tpERMultimediaEdition;
        private TabPage tpEREjournalArticle;
        private TabPage tpERWebsite;
        private GroupBox gbERWebsiteRequired;
        private Label labelERWURL;
        private TextBox tbERWURL;
        private Label labelERWWebsiteName;
        private TextBox tbERWWebsiteName;
        private Label labelERWAccessDate;
        private TextBox tbERWAccessDate;
        private GroupBox gbERWebsiteOptional;
        private Label labelERWResourceType;
        private TextBox tbERWResourceType;
        private Label labelERWCreationYear;
        private TextBox tbERWCreationYear;
        private Label labelERWAccessMode;
        private TextBox tbERWAccessMode;
        private TabControl tcCPTypes;
        private TabPage tpCPBookArticle;
        private GroupBox gbCPBookArticleRequired;
        private Label labelCPBAArticleAuthors;
        private TextBox tbCPBAArticleAuthors;
        private Button buttonCPBAArticleAuthorsAdd;
        private ListBox lbCPBAArticleAuthors;
        private Label labelCPBAArticleTitle;
        private TextBox tbCPBAArticleTitle;
        private Label labelCPBABookTitle;
        private TextBox tbCPBABookTitle;
        private GroupBox gbCPBookArticleOptional;
        private Label labelCPBABookDocumentType;
        private TextBox tbCPBABookDocumentType;
        private Label labelCPBABookEditor;
        private TextBox tbCPBABookEditor;
        private TabPage tpCPJournalArticle;
        private TabPage tpCPNewspaperArticle;
        private TabPage tpCPWebsiteArticle;
        private Label labelEREbAccessDate;
        private TextBox tbEREbAccessDate;
        private GroupBox gbERMultimediaEditionRequired;
        private Label labelERMEAuthors;
        private TextBox tbERMEAuthors;
        private Button buttonERMEAuthorsAdd;
        private ListBox lbERMEAuthors;
        private Label labelERMETitle;
        private TextBox tbERMETitle;
        private Label labelERMEPublishYear;
        private TextBox tbERMEPublishYear;
        private Label labelERMEDataCarrier;
        private TextBox tbERMEDataCarrier;
        private GroupBox gbERMultimediaEditionOptional;
        private Label labelERMEDocumentType;
        private TextBox tbERMEDocumentType;
        private Label labelERMEResponsibilityArea;
        private TextBox tbERMEResponsibilityArea;
        private Label labelERMEEditor;
        private TextBox tbERMEEditor;
        private Label labelERMEOrganization;
        private TextBox tbERMEOrganization;
        private Label labelERMENotation;
        private TextBox tbERMENotation;
        private Label labelERMEISBN;
        private TextBox tbERMEISBN;
        private GroupBox gbEREjournalArticleReqired;
        private Label labelEREjAURL;
        private TextBox tbEREjAURL;
        private Label labelEREjAAuthors;
        private TextBox tbEREjAAuthors;
        private Button tbEREjAAuthorsAdd;
        private ListBox lbEREjAAuthors;
        private Label labelEREjATitle;
        private TextBox tbEREjATitle;
        private Label labelEREjAJournalName;
        private TextBox tbEREjAJournalName;
        private Label labelEREjAYear;
        private TextBox tbEREjAYear;
        private Label labelEREjAJournalNumber;
        private TextBox tbEREjAJournalNumber;
        private Label labelEREjAPages;
        private TextBox tbEREjAPages;
        private GroupBox gbEREjournalArticleOptional;
        private Label labelEREjAAccessMode;
        private TextBox tbEREjAAccessMode;
        private Label labelEREjAAccessDate;
        private TextBox tbEREjAAccessDate;
        private Label labelERWOrganization;
        private TextBox tbERWOrganization;
        private GroupBox gbCPJournalArticleRequired;
        private Label labelCPJAAuthors;
        private TextBox tbCPJAAuthors;
        private Button buttonCPJAAuthorsAdd;
        private Label labelCPJAArticleTitle;
        private TextBox tbCPJAArticleTitle;
        private Label labelCPJAJournalName;
        private TextBox tbCPJAJournalName;
        private Label labelCPJAYear;
        private TextBox tbCPJAPublishYear;
        private Label labelCPJANumberOrVolume;
        private TextBox tbCPJANumberOrVolume;
        private Label labelCPJAPages;
        private TextBox tbCPJAPages;
        private GroupBox gbCPJournalArticleOptional;
        private Label labelCPJADOI;
        private TextBox tbCPJADOI;
        private GroupBox gbCPNewspaperArticleReqired;
        private Label labelCPNAArticleTitle;
        private TextBox tbCPNAArticleTitle;
        private Label labelCPNANewspaperName;
        private TextBox tbCPNANewspaperName;
        private Label labelCPNAPublishYear;
        private TextBox tbCPNAPublishYear;
        private Label labelCPNAReleaseDate;
        private TextBox tbCPNAReleaseDate;
        private Label labelCPNAPages;
        private TextBox tbCPNAPages;
        private GroupBox gbCPNewspaperArticleOptional;
        private Label labelCPNAArticleNote;
        private TextBox tbCPNAArticleNote;
        private Label labelCPNAInterviewer;
        private TextBox tbCPNAInterviewer;
        private GroupBox gbCPWebsiteArticleRequired;
        private Label labelCPWAArticleTitle;
        private TextBox tbCPWAArticleTitle;
        private Label labelCPWAWebsiteName;
        private TextBox tbCPWAWebsiteName;
        private Label labelCPWAURL;
        private TextBox tbCPWAURL;
        private Label labelCPWAAccessDate;
        private TextBox tbCPWAAccessDate;
        private GroupBox gbCPWebsiteArticleOptional;
        private Label labelCPWAPublishYear;
        private TextBox tbCPWAPublishYear;
        private Label labelCPWAPublishDate;
        private TextBox tbCPWAPublishDate;
        private Label labelCPBAPages;
        private TextBox tbCPBAPages;
        private Label labelCPBAPublishYear;
        private TextBox tbCPBAPublishYear;
        private Panel panelAddRecord;
        private CheckBox cbWordAbbreviation;
        private Button buttonAddRecord;
        private Panel panelSVBookOptional;
        private Panel panelSVGOSTOptional;
        private Panel panelEREbookOptional;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Panel panelSVDissertationAbstractRequired;
        private Panel panelSVBookRequired;
        private Panel panelMVWholeMultivolumeRequired;
        private Panel panelMVSeparateVolumeRequired;
        private Panel panelEREbookRequired;
        private Panel panelERMultimediaEditionRequired;
        private Panel panelEREjournalArticleReqired;
        private Panel panelCPBookArticleRequired;
        private Panel panelCPJournalArticleRequired;
        private Panel panelCPNewspaperArticleReqired;
        private Panel panelCPWebsiteArticleRequired;
        private ListBox lbResult;
        private Button buttonCopyResult;
        private Button buttonWordExportResult;
        private Button buttonConvert;
        private RichTextBox rtbMLA;
        private Label labelConvert;
        private Label labelResult;
        private Label labelMLA;
        private Label labelGOST;
        private RichTextBox rtbGOST;
        private Panel panelConvertTitle;
        private Button buttonToGOST2008;
        private Panel panelRtbGOST;
        private Panel panelRtbMLA;
        private ToolTip ttMain;
        private ContextMenuStrip cmsListBox;
        private ToolStripMenuItem tsmiDeleteSelected;
        private ToolStripMenuItem tsmiDeleteAll;
        private ToolStripMenuItem tsmiCopy;
        private ListBox lbSVBPublisher;
        private Button buttonSVBPublishingLocationAdd;
        private ListBox lbSVBPublishingLocation;
        private Button buttonSVBPublisherAdd;
        private Label labelSVBContentType;
        private TextBox tbSVBContentType;
        private CheckBox cbSVBAuthors;
        private Label labelSVBParallelTitle;
        private TextBox tbSVBParallelTitle;
        private ListBox lbSVBEditor;
        private Button buttonSVBEditorAdd;
        private Button buttonPDFExportResult;
        private ComboBox cbSVBEditorType;
        private TabPage tpSVConferenceMaterials;
        private GroupBox gbSVConferenceMaterialsRequired;
        private Panel panelSVConferenceMaterialsRequired;
        private TextBox tbSVCMEventDate;
        private Label labelSVCMEventDate;
        private Label labelSVCMEventTitle;
        private TextBox tbSVCMEventTitle;
        private TextBox tbSVCMPagesCount;
        private Label labelSVCMPagesCount;
        private TextBox tbSVCMPublishYear;
        private Label labelSVCMPublishYear;
        private TextBox tbSVCMEventPlace;
        private Label labelSVCMPublicationType;
        private Label labelSVCMEventPlace;
        private TextBox tbSVCMPublicationType;
        private GroupBox gbSVConferenceMaterialsOptional;
        private Panel panelSVConferenceMaterialsOptional;
        private Label labelSVCMPartNumberAndTitle;
        private TextBox tbSVCMPartNumberAndTitle;
        private Label labelSVCMContentType;
        private TextBox tbSVCMContentType;
        private Label labelSVCMPartCount;
        private TextBox tbSVCMPartCount;
        private Label labelSVCMISBN;
        private TextBox tbSVCMEditor;
        private TextBox tbSVCMISBN;
        private Label labelSVCMEditor;
        private TextBox tbSVCMPublisher;
        private Label labelSVCMPublisher;
        private TextBox tbSVCMPublishingLocation;
        private Label labelSVCMPublishingLocation;
        private Button buttonSVCMPublisherAdd;
        private ListBox lbSVCMPublisher;
        private Button buttonSVCMPublishingLocationAdd;
        private ListBox lbSVCMPublishingLocation;
        private ComboBox cbSVCMEditorType;
        private ListBox lbSVCMEditor;
        private Button buttonSVCMEditorAdd;
        private Panel panelSVGOSTRequired;
        private TabPage tpSVLegislativeMaterial;
        private Button buttonSVGOSTPublisher;
        private ListBox lbSVGOSTPublisher;
        private TextBox tbSVGOSTPublisher;
        private Button buttonSVGOSTPublishingLocationAdd;
        private ListBox lbSVGOSTPublishingLocation;
        private TextBox tbSVGOSTPublishingLocation;
        private Label labelSVGOSTParallelTitle;
        private TextBox tbSVGOSTParallelTitle;
        private GroupBox gbSVLegislativeMaterialRequired;
        private Panel panelSVLegislativeMaterialRequired;
        private Button buttonSVLMPublisher;
        private ListBox lbSVLMPublisher;
        private TextBox tbSVLMPublisher;
        private Button buttonSVLMPublishingLocationAdd;
        private ListBox lbSVLMPublishingLocation;
        private TextBox tbSVLMPublishingLocation;
        private Label labelSVLMTitle;
        private TextBox tbSVLMPublishYear;
        private Label labelSVLMPublishYear;
        private TextBox tbSVLMTitle;
        private Label labelSVLMPublisher;
        private Label labelSVLMPublishingLocation;
        private GroupBox gbSVLegislativeMaterialOptional;
        private Panel panelSVLegislativeMaterialOptional;
        private Label labelSVLMAbbreviation;
        private TextBox tbSVLMAbbreviation;
        private Label labelSVLMAdditions;
        private TextBox tbSVLMContentType;
        private Label labelSVLMPagesCount;
        private Label labelSVLMContentType;
        private TextBox tbSVLMPagesCount;
        private TextBox tbSVLMSeries;
        private Label labelSVLMSeries;
        private TextBox tbSVLMAdditions;
        private TextBox tbSVLMISBN;
        private Label labelSVLMISBN;
        private Label labelSVGOSTAdditions;
        private TextBox tbSVGOSTAdditions;
        private CheckBox cbGOSTFirstTime;
        private TextBox tbSVLMApprovalDate;
        private Label labelSVLMApprovalDate;
        private Label labelSVLMDocumentType;
        private TextBox tbSVLMDocumentType;
        private TextBox tbSVLMImplementDate;
        private Label labelSVLMImplementDate;
        private Panel panelSVDissertationAbstractOptional;
        private Label labelSVDAContentType;
        private TextBox tbSVDAContentType;
        private GroupBox gbSVDissertationRequired;
        private Panel panelSVDissertationRequired;
        private Label labelSVDAuthor;
        private TextBox tbSVDPublishingLocation;
        private Label labelSVDPublishingLocation;
        private TextBox tbSVDDegree;
        private Label labelSVDPublishYear;
        private Label labelSVDDegree;
        private TextBox tbSVDPublishYear;
        private TextBox tbSVDSpecialty;
        private Label labelSVDTitle;
        private Label labelSVDSpecialty;
        private TextBox tbSVDTitle;
        private TextBox tbSVDAuthor;
        private GroupBox gbSVDissertationOptional;
        private Panel panelSVDissertationOptional;
        private TextBox tbSVDContentType;
        private Label labelSVDContentType;
        private TextBox tbSVDBibliography;
        private Label labelSVDBibliography;
        private Label labelSVDPagesCount;
        private TextBox tbSVDOrganization;
        private TextBox tbSVDPagesCount;
        private Label labelSVDOrganization;
        private Button buttonMVWMPublisherAdd;
        private ListBox lbMVWMPublisher;
        private Button buttonMVWMPublishingLocationAdd;
        private ListBox lbMVWMPublishingLocation;
        private Panel panelMVWholeMultivolumeOptional;
        private Label labelMVWMContentType;
        private TextBox tbMVWMContentType;
        private ComboBox cbMVWMEditorType;
        private ListBox lbMVWMEditor;
        private Button buttonMVWMEditorAdd;
        private Button buttonMVSVPublisherAdd;
        private ListBox lbMVSVPublisher;
        private Button buttonMVSVPublishingLocationAdd;
        private ListBox lbMVSVPublishingLocation;
        private Panel panelMVSeparateVolumeOptional;
        private ComboBox cbMVSVEditorType;
        private ListBox lbMVSVEditor;
        private Button buttonMVSVEditorAdd;
        private Label labelMVSVContentType;
        private TextBox tbMVSVContentType;
        private CheckBox cbMVWMAuthors;
        private CheckBox cbMVSVAuthors;
        private Button buttonEREbPublisherAdd;
        private ListBox lbEREbPublisher;
        private Button buttonEREbPublishingLocationAdd;
        private ListBox lbEREbPublishingLocation;
        private Label labelEREbAccessMode;
        private TextBox tbEREbAccessMode;
        private CheckBox cbEREbAuthors;
        private Label labelEREbContentType;
        private TextBox tbEREbContentType;
        private ComboBox cbEREbEditorType;
        private ListBox lbEREbEditor;
        private Button buttonEREbEditorAdd;
        private Label labelEREbParallelTitle;
        private TextBox tbEREbParallelTitle;
        private Label labelMVWMParallelTitle;
        private TextBox tbMVWMParallelTitle;
        private Label labelMVSVParallelTitle;
        private TextBox tbMVSVParallelTitle;
        private Label labelMVWMTranslator;
        private TextBox tbMVWMTranslator;
        private Label labelMVWMOrganization;
        private TextBox tbMVWMOrganization;
        private Label labelMVSVTranslator;
        private TextBox tbMVSVTranslator;
        private Label labelMVSVOrganization;
        private TextBox tbMVSVOrganization;
        private TabPage tpERWholeElectronicEdition;
        private TabPage tpERElectronicEditionSeparateVolume;
        private GroupBox gbERWholeElectronicEditionRequired;
        private Panel panelERWholeElectronicEditionRequired;
        private CheckBox cbERWEEAuthors;
        private Button buttonERWEEPublisherAdd;
        private ListBox lbERWEEPublisher;
        private Button buttonERWEEPublishingLocationAdd;
        private ListBox lbERWEEPublishingLocation;
        private Label panelERWEEAuthors;
        private TextBox tbERWEEPublishYear;
        private Label labelERWEEPublishYear;
        private TextBox tbERWEEAuthors;
        private TextBox tbERWEEPublisher;
        private Button buttonERWEEAuthorsAdd;
        private Label labelERWEEPublisher;
        private ListBox lbERWEEAuthors;
        private TextBox tbERWEEPublishingLocation;
        private Label labelERWEETitle;
        private Label labelERWEEPublishingLocation;
        private TextBox tbERWEETitle;
        private TextBox tbERWEEVolumesCount;
        private Label labelERWEEVolumesCount;
        private GroupBox gbERWholeElectronicEditionOptional;
        private Panel panelERWholeElectronicEditionOptional;
        private Label labelERWEETranslator;
        private TextBox tbERWEETranslator;
        private Label labelERWEEOrganization;
        private TextBox tbERWEEOrganization;
        private Label labelERWEEParallelTitle;
        private TextBox tbERWEEParallelTitle;
        private Label labelERWEEContentType;
        private TextBox tbERWEEContentType;
        private ComboBox cbERWEEEditorType;
        private ListBox lbERWEEEditor;
        private Button buttonERWEEEditorAdd;
        private Label labelERWEEDocumentType;
        private TextBox tbERWEEISBN;
        private Label labelERWEESeries;
        private TextBox tbERWEEEditor;
        private Label labelERWEEPagesCount;
        private TextBox tbERWEESeries;
        private TextBox tbERWEEPagesCount;
        private TextBox tbERWEEEditionNumber;
        private Label labelERWEEISBN;
        private TextBox tbERWEEDocumentType;
        private Label labelERWEEEditionNumber;
        private Label labelERWEEEditor;
        private TextBox tbERWEEAccessMode;
        private Label labelERWEEAccessMode;
        private TextBox tbERWEEAccessDate;
        private Label labelERWEEAccessDate;
        private TextBox tbERWEEURL;
        private Label labelERWEEURL;
        private GroupBox gbERElectronicEditionSeparateVolumeRequired;
        private Panel panelERElectronicEditionSeparateVolumeRequired;
        private TextBox tbEREESVAccessMode;
        private Label labelEREESVAccessMode;
        private TextBox tbEREESVAccessDate;
        private Label labelEREESVAccessDate;
        private TextBox tbEREESVURL;
        private Label labelEREESVURL;
        private CheckBox cbEREESVAuthors;
        private Button buttonEREESVPublisherAdd;
        private ListBox lbEREESVPublisher;
        private Button buttonEREESVPublishingLocationAdd;
        private ListBox lbEREESVPublishingLocation;
        private Label labelEREESVAuthors;
        private TextBox tbEREESVPublishYear;
        private Label labelEREESVPublishYear;
        private TextBox tbEREESVAuthors;
        private TextBox tbEREESVPublisher;
        private Button buttonEREESVAuthorsAdd;
        private Label labelEREESVPublisher;
        private ListBox lbEREESVAuthors;
        private TextBox tbEREESVPublishingLocation;
        private Label labelEREESVTitle;
        private Label labelEREESVPublishingLocation;
        private TextBox tbEREESVTitle;
        private TextBox tbEREESVVolumesCount;
        private Label labelEREESVVolumesCount;
        private GroupBox gbERElectronicEditionSeparateVolumeOptional;
        private Panel panelERElectronicEditionSeparateVolumeOptional;
        private Label labelEREESVTranslator;
        private TextBox tbEREESVTranslator;
        private Label labelEREESVOrganization;
        private TextBox tbEREESVOrganization;
        private Label labelEREESVParallelTitle;
        private TextBox tbEREESVParallelTitle;
        private Label labelEREESVContentType;
        private TextBox tbEREESVContentType;
        private ComboBox cbEREESVEditorType;
        private ListBox lbEREESVEditor;
        private Button buttonEREESVEditorAdd;
        private Label labelEREESVDocumentType;
        private TextBox tbEREESVISBN;
        private Label labelEREESVSeries;
        private TextBox tbEREESVEditor;
        private Label labelEREESVPagesCount;
        private TextBox tbEREESVSeries;
        private TextBox tbEREESVPagesCount;
        private TextBox tbEREESVEditionNumber;
        private Label labelEREESVISBN;
        private TextBox tbEREESVDocumentType;
        private Label labelEREESVEditionNumber;
        private Label labelEREESVEditor;
        private TextBox tbEREESVVolumeNumber;
        private Label labelEREESVVolumeNumber;
        private TextBox tbEREESVVolumeTitle;
        private Label labelEREESVVolumeTitle;
        private Label labelEREbTranslator;
        private TextBox tbEREbTranslator;
        private Label labelEREbOrganization;
        private TextBox tbEREbOrganization;
        private TabPage tpERElectronicConferenceMaterials;
        private TabPage tpERElectronicCollections;
        private GroupBox gbERElectronicConferenceMaterialsRequired;
        private Panel panelERElectronicConferenceMaterialsRequired;
        private Button buttonERECMPublisherAdd;
        private ListBox lbERECMPublisher;
        private Button buttonERECMPublishingLocationAdd;
        private ListBox lbERECMPublishingLocation;
        private TextBox tbERECMPublisher;
        private Label labelERECMPublisher;
        private TextBox tbERECMPublishingLocation;
        private Label labelERECMPublishingLocation;
        private TextBox tbERECMEventDate;
        private Label labelERECMEventDate;
        private Label labelERECMEventTitle;
        private TextBox tbERECMEventTitle;
        private TextBox tbERECMPublishYear;
        private Label labelERECMPublishYear;
        private TextBox tbERECMEventPlace;
        private Label labelERECMPublicationType;
        private Label labelERECMEventPlace;
        private TextBox tbERECMPublicationType;
        private GroupBox gbERElectronicConferenceMaterialsOptional;
        private Panel panelERElectronicConferenceMaterialsOptional;
        private ListBox lbERECMEditorialBoard;
        private Button buttonERECMEditorialBoardAdd;
        private Label labelERECMPartNumberAndTitle;
        private TextBox tbERECMPartNumberAndTitle;
        private Label labelERECMContentType;
        private TextBox tbERECMContentType;
        private Label labelERECMPartCount;
        private TextBox tbERECMPartCount;
        private TextBox tbERECMPagesCount;
        private Label labelERECMISBN;
        private Label labelERECMPagesCount;
        private TextBox tbERECMEditorialBoard;
        private TextBox tbERECMISBN;
        private Label labelERECMEditorialBoard;
        private TextBox tbERECMAccessMode;
        private Label labelERECMAccessMode;
        private TextBox tbERECMAccessDate;
        private Label labelERECMAccessDate;
        private TextBox tbERECMURL;
        private Label labelERECMURL;
        private GroupBox gbERElectronicCollectionsRequired;
        private Panel panelERElectronicCollectionsRequired;
        private TextBox tbERECAccessMode;
        private Label labelERECAccessMode;
        private TextBox tbERECAccessDate;
        private Label labelERECAccessDate;
        private TextBox tbERECURL;
        private Label labelERECURL;
        private Button buttonERECPublisherAdd;
        private ListBox lbERECPublisher;
        private Button buttonERECPublishingLocationAdd;
        private ListBox lbERECPublishingLocation;
        private TextBox tbERECPublisher;
        private Label labelERECPublisher;
        private TextBox tbERECPublishingLocation;
        private Label labelERECPublishingLocation;
        private Label labelERECCollectionTitle;
        private TextBox tbERECCollectionTitle;
        private TextBox tbERECPublishYear;
        private Label labelERECPublishYear;
        private Label labelERECPublicationType;
        private TextBox tbERECPublicationType;
        private GroupBox gbERElectronicCollectionsOptional;
        private Panel panelERElectronicCollectionsOptional;
        private ListBox lbERECEditorialBoard;
        private Button buttonERECEditorialBoardAdd;
        private Label labelERECContentType;
        private TextBox tbERECContentType;
        private TextBox tbERECPagesCount;
        private Label labelERECISBN;
        private Label labelERECPagesCount;
        private TextBox tbERECEditorialBoard;
        private TextBox tbERECISBN;
        private Label labelERECEditorialBoard;
        private Label labelERECAccessNote;
        private TextBox tbERECAccessNote;
        private ComboBox cbERECMEditorType;
        private ListBox lbERECMEditor;
        private Button buttonERECMEditorAdd;
        private TextBox tbERECMEditor;
        private Label labelERECMEditor;
        private ComboBox cbERECEditorType;
        private ListBox lbERECEditor;
        private Button buttonERECEditor;
        private TextBox tbERECEditor;
        private Label labelERECEditor;
        private Label labelERECMAccessNote;
        private TextBox tbERECMAccessNote;
        private CheckBox cbEREjAAuthors;
        private Label labelEREjAContentType;
        private TextBox tbEREjAContentType;
        private CheckBox cbERECPublisher;
        private ListBox lbERECPublishingLocationSelect;
        private ListBox lbEREbPublishingLocationSelect;
        private CheckBox cbEREbPublisher;
        private ListBox lbERWEEPublishingLocationSelect;
        private CheckBox cbERWEEPublisher;
        private ListBox lbEREESVPublishingLocationSelect;
        private CheckBox cbEREESVPublisher;
        private ListBox lbERECMPublishingLocationSelect;
        private CheckBox cbERECMPublisher;
        private ListBox lbSVBPublishingLocationSelect;
        private CheckBox cbSVBPublisher;
        private ListBox lbSVCMPublishingLocationSelect;
        private CheckBox cbSVCMPublisher;
        private ListBox lbSVGOSTPublishingLocationSelect;
        private CheckBox cbSVGOSTPublisher;
        private ListBox lbMVWMPublishingLocationSelect;
        private CheckBox cbMVWMPublisher;
        private ListBox lbMVSVPublishingLocationSelect;
        private CheckBox cbMVSVPublisher;
        private ListBox lbSVLMPublishingLocationSelect;
        private CheckBox cbSVLMPublisher;
        private Panel panelEREjournalArticleOptional;
        private Panel panelERMultimediaEditionOptional;
        private ListBox lbERMEPublishingLocationSelect;
        private CheckBox cbERMEPublisher;
        private Button buttonERMEPublisherAdd;
        private ListBox lbERMEPublisher;
        private Button buttonERMEPublishingLocationAdd;
        private ListBox lbERMEPublishingLocation;
        private TextBox tbERMEPublisher;
        private Label labelERMEPublisher;
        private TextBox tbERMEPublishingLocation;
        private Label labelERMEPublishingLocation;
        private Label labelERMEContentType;
        private TextBox tbERMEContentType;
        private CheckBox cbERMEAuthors;
        private TextBox tbERMESeries;
        private Label labelERMESeries;
        private Panel panelERWebsiteRequired;
        private Panel panelERWebsiteOptional;
        private Label labelERWContentType;
        private TextBox tbERWContentType;
        private Label labelERWResourceDescription;
        private TextBox tbERWResourceDescription;
        private Label labelERWPublicationDate;
        private TextBox tbERWPublicationDate;
        private Label labelERWDetails;
        private TextBox tbERWDetails;
        private ListBox lbERWPublishingLocationSelect;
        private CheckBox cbERWPublisher;
        private Button buttonERWPublisherAdd;
        private ListBox lbERWPublisher;
        private Button buttonERWPublishingLocationAdd;
        private ListBox lbERWPublishingLocation;
        private TextBox tbERWPublisher;
        private Label labelERWPublisher;
        private TextBox tbERWPublishingLocation;
        private Label labelERWPublishingLocation;
        private TabPage tpCPConferenceArticle;
        private ListBox lbCPBAPublishingLocationSelect;
        private CheckBox cbCPBAPublisher;
        private Button buttonCPBAPublisherAdd;
        private ListBox lbCPBAPublisher;
        private Button buttonCPBAPublishingLocationAdd;
        private ListBox lbCPBAPublishingLocation;
        private TextBox tbCPBAPublisher;
        private Label labelCPBAPublisher;
        private TextBox tbCPBAPublishingLocation;
        private Label labelCPBAPublishingLocation;
        private CheckBox cbCPBAArticleAuthors;
        private Panel panelCPBookArticleOptional;
        private CheckBox cbCPBABookAuthors;
        private Label labelCPBABookAuthors;
        private TextBox tbCPBABookAuthors;
        private ListBox lbCPBABookAuthors;
        private Button buttonCPBABookAuthorsAdd;
        private Label labelCPBAOrganization;
        private TextBox tbCPBAOrganization;
        private Label labelCPBAContentType;
        private TextBox tbCPBAContentType;
        private GroupBox gbCPConferenceArticleRequired;
        private Panel panelCPConferenceArticleRequired;
        private ListBox lbCPCAPublishingLocationSelect;
        private CheckBox cbCPCAPublisher;
        private Button buttonCPCAPublisherAdd;
        private ListBox lbCPCAPublisher;
        private Button buttonCPCAPublishingLocationAdd;
        private ListBox lbCPCAPublishingLocation;
        private TextBox tbCPCAPublisher;
        private Label labelCPCAPublisher;
        private TextBox tbCPCAPublishingLocation;
        private Label labelCPCAPublishingLocation;
        private CheckBox cbCPCAArticleAuthors;
        private Label labelCPCAPages;
        private Label labelCPCAArticleAuthors;
        private TextBox tbCPCAPages;
        private Label labelCPCAPublishYear;
        private TextBox tbCPCAPublishYear;
        private TextBox tbCPCAEventTitle;
        private Label labelCPCAEventTitle;
        private TextBox tbCPCAArticleTitle;
        private Label labelCPCAArticleTitle;
        private TextBox tbCPCAArticleAuthors;
        private ListBox lbCPCAArticleAuthors;
        private Button buttonCPCAArticleAuthorsAdd;
        private GroupBox gbCPConferenceArticleOptional;
        private Label labelCPCAContentType;
        private TextBox tbCPCAContentType;
        private Label labelCPCAOrganization;
        private TextBox tbCPCAOrganization;
        private TextBox tbCPCAEventDate;
        private Label labelCPCAEventDate;
        private TextBox tbCPCAEventPlace;
        private Label labelCPCAPublicationType;
        private Label labelCPCAEventPlace;
        private TextBox tbCPCAPublicationType;
        private ComboBox cbCPCAEditorType;
        private ListBox lbCPCAEditor;
        private Button buttonCPCAEditorAdd;
        private Label labelCPCAPartNumberAndTitle;
        private TextBox tbCPCAPartNumberAndTitle;
        private Label labelCPCAPartCount;
        private TextBox tbCPCAPartCount;
        private TextBox tbCPCAEditor;
        private Label labelCPCAEditor;
        private CheckBox cbCPCAConferenceAuthors;
        private Label labelCPCAConferenceAuthors;
        private TextBox tbCPCAConferenceAuthors;
        private ListBox lbCPCAConferenceAuthors;
        private Button buttonCPCAConferenceAuthorsAdd;
        private Panel panelCPConferenceArticleOptional;
        private Panel panelCPJournalArticleOptional;
        private CheckBox cbCPJAArticleAuthors;
        private Label labelCPJAArticleAuthors;
        private TextBox tbCPJAArticleAuthors;
        private ListBox lbCPJAArticleAuthors;
        private Button buttonCPJAArticleAuthorsAdd;
        private Label labelCPJAAccessDate;
        private TextBox tbCPJAAccessDate;
        private Label labelCPJAURL;
        private TextBox tbCPJAURL;
        private RadioButton rbCPJAVolume;
        private RadioButton rbCPJANumber;
        private Label labelCPJAAccessMode;
        private TextBox tbCPJAAccessMode;
        private Label labelCPJAJournalSeries;
        private TextBox tbCPJAJournalSeries;
        private Label labelCPJAIssue;
        private TextBox tbCPJAIssue;
        private Label labelCPJAPublishYear;
        private Label labelCPJAContentType;
        private TextBox tbCPJAContentType;
        private CheckBox cbCPNAArticleAuthors;
        private Label labelCPNAArticleAuthors;
        private TextBox tbCPNAArticleAuthors;
        private ListBox lbCPNAArticleAuthors;
        private Button buttonCPNAArticleAuthorsAdd;
        private Panel panelCPNewspaperArticleOptional;
        private Panel panelCPWebsiteArticleOptional;
        private Label labelCPNAContentType;
        private TextBox tbCPNAContentType;
        private TextBox tbCPNANumber;
        private Label labelCPNANumber;
        private CheckBox cbCPWAArticleAuthors;
        private Label labelCPWAArticleAuthors;
        private TextBox tbCPWAArticleAuthors;
        private ListBox lbCPWAArticleAuthors;
        private Button buttonCPWAArticleAuthorsAdd;
        private Label labelCPWAResourceType;
        private TextBox tbCPWAResourceType;
        private TextBox tbCPWAEventDate;
        private Label labelCPWAEventDate;
        private TextBox tbCPWAEventPlace;
        private Label labelCPWAEventPlace;
        private Label labelCPWAResourceDescription;
        private TextBox tbCPWAResourceDescription;
        private Label labelCPWAContentType;
        private TextBox tbCPWAContentType;
        private ToolStripMenuItem tsmiEdit;
        private Label labelCPWAMaterialType;
        private TextBox tbCPWAMaterialType;
        private Label labelCPWAPublicationType;
        private TextBox tbCPWAPublicationType;
        private Button buttonFillForm;
        private ContextMenuStrip cmsMainTabControl;
        private ToolStripMenuItem tsmiSaveFormData;
        private ToolStripMenuItem tsmiRestoreLastEntry;
        private ToolStripMenuItem tsmiRestoreEntry;
        private ToolStripMenuItem tsmiClearForm;
        private ContextMenuStrip cmsRichTextBox_TextBox;
        private ToolStripMenuItem tsmiClearRichTextBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiUndoRichTextBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiCutRichTextBox;
        private ToolStripMenuItem tsmiCopyRichTextBox;
        private ToolStripMenuItem tsmiPasteRichTextBox;
        private ToolStripMenuItem tsmiDeleteRichTextBox;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmiSelectAllRichTextBox;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmiUnableClearingRichTextBox1;
        private ToolStripMenuItem tsmiUnableClearingRichTextBox2;
        private ToolStripMenuItem tsmiUndo;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
    }
}
