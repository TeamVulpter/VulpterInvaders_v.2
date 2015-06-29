namespace Game.Interfaces
{
    using System.Windows.Forms;
    using Classes.Items;

    interface IItem
    {
        PictureBox Picture { get; set; }
        ItemType ItemType { get; set; }
        int BonusHealth { get; set; }
        int BonusScore { get; set; }
        int BonusLife { get; set; }
    }
}
