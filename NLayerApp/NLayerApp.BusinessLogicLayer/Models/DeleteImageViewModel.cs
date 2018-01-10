namespace NLayerApp.BusinessLogicLayer.Models
{
    public class DeleteImageViewModel
    {
        public int Id { get; set; }
        public string fotoName { get; set; }
        public byte[] Image { get; set; }
        public int InfoId { get; set; }
    }
}
