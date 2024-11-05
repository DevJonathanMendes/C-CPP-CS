// Fig. 20.05: WebTime.aspx.cs
// O arquivo de código de retaguarda de uma página que exibe a hora do servidor da Web.

// Definição dos controles gráficos usados em formulários Web.
using System;
using System.Web;

namespace WebTime
{
	/// <summary>
	///		display current time
	/// </summary>
	partial class WebTimeTest : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label promptLabel;
		protected System.Web.UI.WebControls.Label timeLabel;

		// Manipulador do evento Load.
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Exibe a hora atual.
			timeLabel.Text = String.Format("{0:D2}:{1:D2}:{2:D2}",
				DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second
			);
		}

		// Manipulador do evento Init; configura o timeLabel com a hora do servidor da Web.
		#region Web Form Designer Generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: Essa chamada é pelo ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}

		///	<summary>
		///		Método exigido para o suporte do projetista -
		///		não modifique o conteúdo deste método com o editor de código
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
