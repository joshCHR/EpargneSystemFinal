using ADTMPDapk.Handlers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_dashoard : UserControl

    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        public uc_dashoard()
        {
            InitializeComponent();
            graphiqueRemboursement();
            graphiqueEpargne();
            graphiquePret();
            VusLabel();

        }
        private void graphiqueEpargne()
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            cnx.Open();
            string query = "select designationEpargne,sum(montantEpargne)as total from t_epargne group by designationEpargne";
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartGrossEpargne.Series["Series1"].Points.AddXY(reader["designationEpargne"], reader["total"]);

            }
            cnx.Close();
        }

        private void graphiqueRemboursement()
        {

            cnx = new SqlConnection(datas.GetInstance().ToString());
            cnx.Open();
            string query = "select top 5 nom, montantRemb from t_remboursement inner join t_Pret on t_remboursement.id_pret = t_Pret.id_pret inner join t_membre on t_Pret.membre = t_membre.matricule order by id_remb desc";
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartTopRemboursement.Series["Series1"].Points.AddXY(reader["nom"], reader["montantRemb"]);
            }
            cnx.Close();

        }
        private void graphiquePret()
        {

            cnx = new SqlConnection(datas.GetInstance().ToString());
            cnx.Open();
            string query = "select top 5 sum(versement) as total,nom,secteur from t_Pret inner join t_membre on t_Pret.membre = t_membre.matricule group by nom,secteur ";
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartPret.Series["Series1"].Points.AddXY(reader["nom"], reader["total"]);
               
            }
            cnx.Close();

        }
        private void chart2_Click(object sender, System.EventArgs e)
        {

        }

        private void VusLabel()
        {
            try
            {
                int value = 0;
                cnx = new SqlConnection(datas.GetInstance().ToString());
                cnx.Open();
                //////   sommes ////////
                string pret = "select sum(versement) from t_pret";
                string epargne = "select  sum(montantEpargne) from t_epargne";
                string remboursement = "select sum(montantRemb) from t_remboursement";
                /////////////////////Nombre//////
                string N_pret = "select count(id_pret) from t_Pret";
                string N_pargne = "select count(idEpargne) from t_epargne";
                string R_remboursement = "select count(id_remb) from t_remboursement";
                string N_membre = "select count(matricule) from t_membre";
                //////////////////////////////////////////////
                var cmd = new SqlCommand(pret, cnx);
                var cmd1 = new SqlCommand(epargne, cnx);
                var cmd2 = new SqlCommand(remboursement, cnx);

                var cmd5 = new SqlCommand(N_pret, cnx);
                var cmd3 = new SqlCommand(N_pargne, cnx);
                var cmd4 = new SqlCommand(R_remboursement, cnx);
                var cmd6 = new SqlCommand(N_membre, cnx);

                float totat = float.Parse(cmd.ExecuteScalar().ToString());
                float totat_epargne = float.Parse(cmd1.ExecuteScalar().ToString());
                float totat_rem = float.Parse(cmd2.ExecuteScalar().ToString());
                ////////////////////////nombre/////
                float n1 = float.Parse(cmd5.ExecuteScalar().ToString());
                float n2 = float.Parse(cmd3.ExecuteScalar().ToString());
                float n3 = float.Parse(cmd4.ExecuteScalar().ToString());
                float n4 = float.Parse(cmd6.ExecuteScalar().ToString());


                lblpret.Text = totat.ToString();
                lblepargne.Text = totat_epargne.ToString();
                lblremb.Text = totat_rem.ToString();
                /////////////////////////////////////////////

                lblNumberPret.Text = n1.ToString();
                lblNumberRemboursement.Text = n2.ToString();
                lblNumberEpargne.Text = n3.ToString();
                lblMembre.Text = n4.ToString();


                value = cmd.ExecuteNonQuery();
                cnx.Close();


            }
            catch (Exception)
            {


            }
        }
        private void uc_dashoard_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
