namespace Les_8_3
{
    public partial class AandelenForm : Form
    {
        BindingSource aandelenBindingSource = new BindingSource();
        AandelenDAO aandelenDAO;

 //       bool isAanHetLaden = true;

        public AandelenForm()
        {
            InitializeComponent();

        }

        private void AandelenForm_Load(object sender, EventArgs e)
        {

            // haal even de methode aandelenDataGridView_RowsAdd uit de lijst van RowAdded eventhandlers
            aandelenDataGridView.RowsAdded -= new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aandelenDataGridView_RowsAdded);

            aandelenDAO = new AandelenDAO();
            aandelenDAO.Aandelen = aandelenDAO.getAlleAandelen();

            aandelenBindingSource.DataSource = aandelenDAO.Aandelen;
            aandelenDataGridView.DataSource = aandelenBindingSource;

            // voeg de methode aandelenDataGridView_RowsAdd weer toe aan de lijst van RowAdded eventhandlers
            aandelenDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aandelenDataGridView_RowsAdded);

            //           isAanHetLaden = false;

        }


        private void aandelenDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (!isAanHetLaden)
            //{
                Aandeel a = aandelenDAO.Aandelen.Last();
                a.Toevoegen();
                btBewaar.Enabled = true;
            //}
        }

        private void btBewaar_Click(object sender, EventArgs e)
        {
            // Bewaar alle wijzigingen in de databank

            aandelenDAO.setAllAandelen();
            btBewaar.Enabled = false;

        }

        private void aandelenDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            aandelenDAO.Aandelen[aandelenDataGridView.CurrentCell.RowIndex].isGewijzigd = true;
            btBewaar.Enabled = true;
        }

        private void aandelenDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Haal de rij op de verwijderd werd

            // Voeg deze rij toe aan de deletedAandelen

        }

        private void aandelenDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            aandelenDAO.deletedIds.Add(aandelenDAO.Aandelen[e.Row.Index].Id);
            btBewaar.Enabled = true;
        }
    }
}