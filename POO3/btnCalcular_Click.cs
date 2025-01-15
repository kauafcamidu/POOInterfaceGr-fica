private void btnCalcular_Click(object sender, EventArgs e)
{
    try
    {
        // Obter valor da TextBox
        double diagonal = Convert.ToDouble(txtDiagonal.Text);

        // Instanciar o objeto Quadrado e calcular a área
        Quadrado quadrado = new Quadrado(diagonal);
        double area = quadrado.CalcularArea();

        // Exibir a área
        lblResultado.Text = $"Área: {area:F2}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
