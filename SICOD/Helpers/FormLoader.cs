using System.Windows.Forms;

namespace SICOD.Helpers
{
    public static class FormLoader
    {

        private static Form AcF { get; set; }
        private static QBinary.UI.MDI.Manager.MdiTabControl tabf { get; set; }
        /// <summary>
        /// Metodo para chamar o formulario par o MDI
        /// </summary>
        /// <param name="AChamar">Formulario a Chamar</param>
        /// <param name="frmfrmOwner">Formulario pai</param>
        /// <returns></returns>
        public static void Load(Form AChamar, QBinary.UI.MDI.Manager.MdiTabControl tab, Form frmOwner)
        {

            try
            {
                AcF = AChamar;
                tabf = tab;

                Form obj = Application.OpenForms[AcF.Name];
                if (obj != null)
                {
                    tabf.TabPages[obj].Select();
                    obj.Focus();
                    obj.BringToFront();
                }
                else
                {
                    csc();
                }


            }
            catch
            {



            }

        }
        static void csc()
        {
            AcF.Tag = tabf.TabPages.Add(AcF);
        }
        public static void Dialog(Form frm)
        {

            frm.ShowDialog();
        }


    }
}
