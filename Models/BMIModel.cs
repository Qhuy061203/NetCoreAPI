namespace YourNamespace.Models
{
    public class BMIModel
    {
        // Cân nặng (kg)
        public double Weight { get; set; }

        // Chiều cao (m)
        public double Height { get; set; }

        // Tính BMI
        public double BMI => Weight / (Height * Height);

        // Phân loại BMI
        public string BMICategory()
        {
            if (BMI < 18.5) return "Gầy";
            if (BMI < 24.9) return "Bình thường";
            if (BMI < 29.9) return "Thừa cân";
            return "Béo phì";
        }
    }
}
