namespace backend.Entities
{
    public class Lol
    {
        public string LolId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public string YoloId { get; set; }

        public string Stringify () {
            return $"Name: {Name}\n"
              + $"Text: {Text}\n"
              + $"Amount: {Amount}\n"
              + $"YoloId: {YoloId}";
        }

        public static Lol CreateLol () {
            return new Lol {
                Name = "Name",
                Text = "Some text bruh",
                Amount = 69,
                YoloId = null
            };
        }
    }
}