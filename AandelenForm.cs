namespace Les_8_3
{
    public partial class AandelenForm : Form
    {
        BindingSource aandelenBindingSource = new BindingSource();
        AandelenDAO aandelenDAO;

        public AandelenForm()
        {
            InitializeComponent();

        }

        private void AandelenForm_Load(object sender, EventArgs e)
        {
            aandelenDAO = new AandelenDAO();
            aandelenDAO.Aandelen = aandelenDAO.getAlleAandelen();

            aandelenBindingSource.DataSource = aandelenDAO.Aandelen;
            aandelenDataGridView.DataSource = aandelenBindingSource;
        }

        private void aandelenDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Aandeel a = aandelenDAO.Aandelen.Last();
        }
    }
}