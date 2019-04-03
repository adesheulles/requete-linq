using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace requete_linq
{
    delegate void RequeteLinq();
    public partial class Form1 : Form
    {
        private ModelGesper bd;
        private List<RequeteLinq> lesRequetes;
        public Form1()
        {
            InitializeComponent();
            bd = new ModelGesper();
            lesRequetes = new List<RequeteLinq>();
            listerRequetes();
            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (cb_requete.SelectedIndex != -1)
            {
                tb_resultat.Clear();
                lesRequetes[cb_requete.SelectedIndex]();
            }
        }

        private void listerRequetes()
        {
            cb_requete.Items.Add("requete 0 : liste des noms des employés");
            lesRequetes.Add(requete0);
            cb_requete.Items.Add("requete 1 : liste des noms et prénoms des employés");
            lesRequetes.Add(requete1);
            cb_requete.Items.Add("requete 2 : service des employés");
            lesRequetes.Add(requete2);
            cb_requete.Items.Add("requete 3 : nom des employés et désignation de leur service");
            lesRequetes.Add(requete3);
            cb_requete.Items.Add("requete 4 : nom des employés et désignation de leur service avec un type anonyme");
            lesRequetes.Add(requete4);
            cb_requete.Items.Add("requete 5 : nom et prénom des employés masculins");
            lesRequetes.Add(requete5);
            cb_requete.Items.Add("requete 6 : nom et prénom des employés masculins gagnant plus de 3000");
            lesRequetes.Add(requete6);
            cb_requete.Items.Add("requete 7 : nom et prénom des employés du service commercial");
            lesRequetes.Add(requete7);
            cb_requete.Items.Add("requete 8 : nom et prenom des employés cadres");
            lesRequetes.Add(requete8);
            cb_requete.Items.Add("requete 9 : nom et prénom des employés dont le nom contient 'du' (contains)");
            lesRequetes.Add(requete9);
            cb_requete.Items.Add("requete 10 : nom et prénom des employés travaillant dans un atelier (StartWith)");
            lesRequetes.Add(requete10);
            cb_requete.Items.Add("requete 11 : liste des services productifs(ofType)");
            lesRequetes.Add(requete11);
            cb_requete.Items.Add("requete 12 : employés masculin triés par nom (orderby)");
            lesRequetes.Add(requete12);
            cb_requete.Items.Add("requete 13 : employés masculin triés par longeur de prénom (lenght)");
            lesRequetes.Add(requete13);
            cb_requete.Items.Add("requete 14 : employés masculins triés par sexe et prénom");
            lesRequetes.Add(requete14);
            cb_requete.Items.Add("requete 15 : nombre d'employés");
            lesRequetes.Add(requete15);
            cb_requete.Items.Add("requete 16 : nombre de cadres (expression lambda)");
            lesRequetes.Add(requete16);
            cb_requete.Items.Add("requete 17 : salaire maximun,plus petit nom et salaire moyen");
            lesRequetes.Add(requete17);
            cb_requete.Items.Add("requete 18 : ");
            lesRequetes.Add(requete18);
            cb_requete.Items.Add("requete 19 : ");
            lesRequetes.Add(requete19);
            cb_requete.Items.Add("requete 20 : ");
            lesRequetes.Add(requete20);
            cb_requete.Items.Add("requete 21 : ");
            lesRequetes.Add(requete21);
            cb_requete.Items.Add("requete 22 : ");
            lesRequetes.Add(requete22);
            cb_requete.Items.Add("requete 23 : ");
            lesRequetes.Add(requete23);
            cb_requete.Items.Add("requete 24 : ");
            lesRequetes.Add(requete24);
            cb_requete.Items.Add("requete 25 : ");
            lesRequetes.Add(requete25);
            cb_requete.Items.Add("requete 26 : ");
            lesRequetes.Add(requete26);
            cb_requete.Items.Add("requete 27 : ");
            lesRequetes.Add(requete27);
            cb_requete.Items.Add("requete 28 : ");
            lesRequetes.Add(requete28);
            cb_requete.Items.Add("requete 29 : ");
            lesRequetes.Add(requete29);
            cb_requete.Items.Add("requete 30 : ");
            lesRequetes.Add(requete30);
            cb_requete.Items.Add("requete 31 : ");
            lesRequetes.Add(requete31);
        }

        private void requete31()
        {
            throw new NotImplementedException();
        }
        private void requete30()
        {
            throw new NotImplementedException();
        }
        private void requete29()
        {
            throw new NotImplementedException();
        }
        private void requete28()
        {
            throw new NotImplementedException();
        }
        private void requete27()
        {
            throw new NotImplementedException();
        }
        private void requete26()
        {
            throw new NotImplementedException();
        }
        private void requete25()
        {
            throw new NotImplementedException();
        }
        private void requete24()
        {
            throw new NotImplementedException();
        }
        private void requete23()
        {
            throw new NotImplementedException();
        }
        private void requete22()
        {
            throw new NotImplementedException();
        }
        private void requete21()
        {
            throw new NotImplementedException();
        }
        private void requete20()
        {
            throw new NotImplementedException();
        }
        private void requete19()
        {
            throw new NotImplementedException();
        }
        private void requete18()
        {
            throw new NotImplementedException();
        }
        private void requete17()
        {
            var req = from emp in bd.employes where emp.emp_sexe == "M" orderby emp.emp_prenom.Length select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_prenom + " " + e.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete16()
        {
            var req = bd.employes.Count(emp => emp.emp_cadre==true);
            tb_resultat.AppendText(Convert.ToString(req));
            tb_resultat.AppendText(Environment.NewLine);
        }
        private void requete15()
        {
            var req = (from emp in bd.employes select emp.emp_id).Count();
            tb_resultat.AppendText(Convert.ToString(req));
            tb_resultat.AppendText(Environment.NewLine);
        }
        private void requete14()
        {
            var req = from emp in bd.employes orderby emp.emp_sexe  ascending, emp.emp_prenom ascending select new { emp.emp_nom, emp.emp_prenom };
            foreach (var s in req)
            {
                tb_resultat.AppendText(s.emp_prenom + " " + s.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete13()
        {
            var req = from emp in bd.employes where emp.emp_sexe == "M" orderby emp.emp_prenom.Length select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_prenom + " " + e.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete12()
        {
            var req = from emp in bd.employes where emp.emp_sexe == "M" orderby emp.emp_prenom select new { emp.emp_nom, emp.emp_prenom };
            foreach (var s in req)
            {
                tb_resultat.AppendText(s.emp_prenom + " " + s.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete11()
        {
            var req = from ser in bd.services where ser.ser_type.StartsWith("P") select new { ser.ser_designation };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete10()
        {
            var req = from emp in bd.employes join ser in bd.services on emp.emp_service equals ser.ser_id where ser.ser_designation.StartsWith("Atelier") select new { emp.emp_nom, emp.emp_prenom };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.emp_nom + " " + v.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete9()
        {
            var req = from emp in bd.employes where emp.emp_nom.Contains("du")  select new { emp.emp_nom, emp.emp_prenom };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.emp_nom + " " + v.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete8()
        {
            var req = from emp in bd.employes  where emp.emp_cadre == true select new { emp.emp_nom, emp.emp_prenom };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.emp_nom + " " + v.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete7()
        {
            var req = from emp in bd.employes join ser in bd.services on emp.emp_service equals ser.ser_id where ser.ser_designation=="commercial" select new { emp.emp_nom, emp.emp_prenom };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.emp_nom + " " + v.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete6()
        {
            var req = from emp in bd.employes where emp.emp_sexe == "M" && emp.emp_salaire>=3000 select new { emp.emp_nom, emp.emp_prenom };
            foreach (var s in req)
            {
                tb_resultat.AppendText(s.emp_nom + " " + s.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete5()
        {
            var req = from emp in bd.employes where emp.emp_sexe=="M" select new { emp.emp_nom, emp.emp_prenom };
            foreach (var s in req)
            {
                tb_resultat.AppendText(s.emp_nom+" "+s.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete4()
        {
            var req = from emp in bd.employes  join ser in bd.services on emp.emp_service equals ser.ser_id  select new { emp.emp_nom, ser.ser_designation };
            foreach(var v in req)
            {
                tb_resultat.AppendText(v.emp_nom+" "+v.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete3()
        {
            var req = from emp in bd.employes join ser in bd.services on emp.emp_service equals ser.ser_id  select new { emp.emp_nom, ser.ser_designation };
            foreach (var v in req)
            {
                tb_resultat.AppendText(v.emp_nom + " " + v.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete2()
        {
            var req = from ser in bd.services select ser;
            foreach (service s in req)
            {
                tb_resultat.AppendText(s.ser_designation +" " + s.ser_type);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete0()
        {
            var req = from emp in bd.employes select emp.emp_nom;
            foreach(string s in req)
            {
                tb_resultat.AppendText(s);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete1()
        {
            var req = from emp in bd.employes select emp;
            foreach(employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
    }
}
