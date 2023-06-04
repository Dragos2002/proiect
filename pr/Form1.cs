using System.Data.SqlClient;

namespace pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cicluriDeInvatamantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void automaticăȘiInformaticăAplicatăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Automatica();
            newform.Show();
            this.Hide();
        }

        private void tehnologiaInformațieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new TehnologiaInformatiei();
            newform.Show();
            this.Hide();
        }

        private void calculatoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Calculatoare();
            newform.Show();
            this.Hide();
        }

        private void roboticăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Robotica();
            newform.Show();
            this.Hide();
        }

        private void cyberEcurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new CyberSecurity();
            newform.Show();
            this.Hide();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new SistemeElectriceAvansate();
            newform.Show();
            this.Hide();
        }

        private void inginerieElectricăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new InginerieElectrica();
            newform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inginerieElectronicăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new InginerieElectronica();
            newform.Show();
            this.Hide();
        }

        private void ingineriaSistemelorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new IngineriaSistemelor();
            newform.Show();
            this.Hide();
        }

        private void matematicăInformaticăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new MatematicaInformatica();
            newform.Show();
            this.Hide();
        }

        private void informaticăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Informatica();
            newform.Show();
            this.Hide();
        }

        private void informaticăAplicatăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new InformaticaAplicata();
            newform.Show();
            this.Hide();
        }

        private void structuriMatematiceFundamentaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new StructuriMatematiceFundamentale();
            newform.Show();
            this.Hide();
        }

        private void tehnologiiInternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new TehnologiiInternet();
            newform.Show();
            this.Hide();
        }

        private void matematicăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Matematica();
            newform.Show();
            this.Hide();
        }

        private void informaticăToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newform = new InformaticaDoctorat();
            newform.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void medicinăToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newform = new Medicina();
            newform.Show();
            this.Hide();
        }

        private void asistențăMedicalăGeneralăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new AsistentaMedicalaGenerala();
            newform.Show();
            this.Hide();
        }

        private void laboratorClinicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new LaboratorClinic();
            newform.Show();
            this.Hide();
        }

        private void managmentulStrategiilorPreventiveȘiPoliticiDeSănătateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new ManagmentulStrategiilorPreventiveSiPoliticiDeSanatate();
            newform.Show();
            this.Hide();

        }

        private void medicinăTradiționalăChinezeascăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new MedicinaTraditionalaChineza();
            newform.Show();
            this.Hide();
        }

        private void medicinăToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var newform = new MedicinaDoctorat();
            newform.Show();
            this.Hide();
        }

        private void rezidențiatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Rezidentiat();
            newform.Show();
            this.Hide();
        }
    }
}