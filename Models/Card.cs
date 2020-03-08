namespace BlazorHearthstone
{
    public class Card
    {
        public string cardId { get; set; }
        public string dbfId { get; set; }
        public string name { get; set; }
        public string cardSet { get; set; }
        public string type { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string playerClass { get; set; }
        public string img { get; set; }
        public string imgGold { get; set; }
        public string locale { get; set; }
    }
}