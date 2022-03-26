double anguloGraus, anguloRad, velocidade, alcance, alturaMax;
const double gravidade = 9.80665;

Console.WriteLine("-----------Projétil----------\n");

Console.Write("Por favor, insira a velocidade (em m/s): ");
velocidade = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Por favor, insira o ângulo (em graus): ");
anguloGraus = Convert.ToDouble(Console.ReadLine()!);

anguloRad = (anguloGraus * Math.PI) / 180; // Converte angulo de graus para Radiano

alturaMax = Math.Pow((velocidade * Math.Sin(anguloRad)), 2) / (2 * gravidade); // Calculando altura máxima atingida

alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRad)) / gravidade;  // Calculando alcance

Console.WriteLine($"\nAltura máxima: {alturaMax:N2} m");
Console.WriteLine($"Alcance:       {alcance:N2} m");
