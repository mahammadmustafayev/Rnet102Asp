namespace RNET102.UI.Models;

public class Blog
{
    public int Id { get; set; }
    public string ImageURL { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;

}


