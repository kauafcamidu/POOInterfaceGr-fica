private void btnCalcular_Click(object sender, EventArgs e)
{
    try
    {
        // Obter valores das TextBoxes
        double baseTriangulo = Convert.ToDouble(txtBase.Text);
        double alturaTriangulo = Convert.ToDouble(txtAltura.Text);

        // Instanciar o objeto Triangulo e calcular a área
        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
        double area = triangulo.CalcularArea();

        // Exibir a área
        lblResultado.Text = $"Área: {area:F2}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
