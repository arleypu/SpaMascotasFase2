namespace SpaMascotasFase2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Ingreso al sistema";

        // propiedades del label de información del estudiante, nombre, grado..
        lb_InfoEst = new Label();
        lb_InfoEst.Name = "lb_InfoEst";
        lb_InfoEst.Text = "Arley Pulido\nEstructura de datos";
        lb_InfoEst.Location = new System.Drawing.Point(320, 180);
        
        tb_clave = new TextBox();
        tb_clave.Name = "tb_clave";
        tb_clave.PlaceholderText = "Ingrese la clave";
        tb_clave.Location = new System.Drawing.Point(320, 200);

        btn_ingresar = new Button();
        btn_ingresar.Name = "btn_ingresar";
        btn_ingresar.Text = "Ingresar";
        btn_ingresar.Location = new System.Drawing.Point(320, 220);

        this.Controls.Add(lb_InfoEst);
        this.Controls.Add(tb_clave);
        this.Controls.Add(btn_ingresar);

    }

    #endregion

    private Label lb_InfoEst;
    private TextBox tb_clave;
    private Button btn_ingresar;
}
