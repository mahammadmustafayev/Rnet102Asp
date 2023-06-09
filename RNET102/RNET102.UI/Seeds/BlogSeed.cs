using Microsoft.EntityFrameworkCore;
using RNET102.UI.Data;
using RNET102.UI.Models;

namespace RNET102.UI.Seeds;

public static class BlogsSeed
{
    private static List<Blog> BlogsSeedData = new()
    {
    new Blog{Title="Sed ut perspiciatis unde omnis iste",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Donec sagittis euismod purus",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Natus error sit voluptatem",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Free Shopping",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Eget elementum vel",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Mauris accumsan nulla",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Praesent justo dolor",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Eget elementum vel",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    new Blog{Title="Donec sagittis euismod purus",
        Content="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
        ImageURL="https://media.istockphoto.com/id/1140180560/photo/colored-powder-explosion-on-black-background.jpg?s=612x612&w=0&k=20&c=gH_tj4MVWr0226qcq_uJ4nxfLTKG-7T29rtUklT4Obk=",
        PublishDate=DateTime.Now.AddDays(-1)},
    };


    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context= new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            foreach (Blog  blog in BlogsSeedData)
            {
                if (context.Blog.FirstOrDefault(b=>b.Title== b.Title) is null)
                {
                    context.Blog.Add(blog);
                }

            }
            context.SaveChanges();
        }
    }
}
