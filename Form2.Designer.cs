namespace SpaMascotasFase2;

partial class Form2
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
        this.Text = "Ingreso de información";



        lb_Identificacion = new Label();
        lb_Identificacion.Name = "lb_Identificacion";
        lb_Identificacion.AutoSize = true;
        lb_Identificacion.Text = "Identificación";
        lb_Identificacion.Location = new System.Drawing.Point(50, 50);
        
        tb_Identificacion = new TextBox();
        tb_Identificacion.Name = "tb_Identificacion";
        tb_Identificacion.PlaceholderText = "Ingrese la Identificación";
        tb_Identificacion.Location = new System.Drawing.Point(200, 50);
        // end 
        
        lb_NombreProp = new Label();
        lb_NombreProp.Name = "lb_NombreProp";
        lb_NombreProp.AutoSize = true;
        lb_NombreProp.Text = "Nombre Propietario";
        lb_NombreProp.Location = new System.Drawing.Point(50, 75);
        
        tb_NombreProp = new TextBox();
        tb_NombreProp.Name = "tb_NombreProp";
        tb_NombreProp.PlaceholderText = "Ingrese Nombre";
        tb_NombreProp.Location = new System.Drawing.Point(200, 75);
        // end 
        
        lb_NombreMasc = new Label();
        lb_NombreMasc.Name = "lb_NombreMasc";
        lb_NombreMasc.AutoSize = true;
        lb_NombreMasc.Text = "Nombre Mascota";
        lb_NombreMasc.Location = new System.Drawing.Point(50, 100);
        
        tb_NombreMasc = new TextBox();
        tb_NombreMasc.Name = "tb_NombreMasc";
        tb_NombreMasc.PlaceholderText = "Ingrese Nombre";
        tb_NombreMasc.Location = new System.Drawing.Point(200, 100);
        // end 
        
        lb_estrato = new Label();
        lb_estrato.Name = "lb_estrato";
        lb_estrato.AutoSize = true;
        lb_estrato.Text = "Estrato Económico";
        lb_estrato.Location = new System.Drawing.Point(50, 125);
        
        tb_estrato = new TextBox();
        tb_estrato.Name = "tb_estrato";
        tb_estrato.PlaceholderText = "Ingrese Estrato";
        tb_estrato.Location = new System.Drawing.Point(200, 125);
        // end 





        btn_ingresar = new Button();
        btn_ingresar.Name = "btn_ingresar";
        btn_ingresar.Text = "Ingresar";
        btn_ingresar.Location = new System.Drawing.Point(320, 220);

        this.Controls.Add(lb_Identificacion);
        this.Controls.Add(tb_Identificacion);
        
        this.Controls.Add(lb_NombreProp);
        this.Controls.Add(tb_NombreProp);
        
        this.Controls.Add(lb_NombreMasc);
        this.Controls.Add(tb_NombreMasc);
        
        this.Controls.Add(lb_estrato);
        this.Controls.Add(tb_estrato);
        
        
        
        this.Controls.Add(btn_ingresar);

    }

    #endregion

    private Label lb_Identificacion;
    private TextBox tb_Identificacion;

    private Label lb_NombreProp;
    private TextBox tb_NombreProp;

    private Label lb_NombreMasc;
    private TextBox tb_NombreMasc;

    private Label lb_estrato;
    private TextBox tb_estrato;


    private Button btn_ingresar;
}
