using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToDoByCity.ListAPI.Model.Base;

namespace ToDoByCity.ListAPI.Model;

[Table("ToDo")]
public class ToDo : BaseEntity
{
    [Column("Title")]
    [Required]
    [MaxLength(30)]
    public string Title { get; set; }

    [Column("Description")]
    [Required]
    [MaxLength(100)]
    public string Description { get; set; }

    [Column("Category")]
    [Required]
    [MaxLength(30)]
    public string Category { get; set; }

    [Column("Done")]
    public bool Done { get; set; }
    
    [Column("Created_At")]
    public DateTime Created_At { get; set; }

    [Column("Updated_At")]
    public DateTime Updated_At { get; set; }

    [Column("Done_At")]
    public DateTime Done_At { get; set; }

    [Column("Deleted_At")]
    public DateTime Deleted_At { get; set; }

    [Column("Price")]
    [Required]
    public decimal Price { get; set; } 

    [Column("City")]
    [Required]
    [MaxLength(30)]
    public string City { get; set; }

    [Column("Country")]
    [Required]
    [MaxLength(30)]
    public string Country { get; set; }

    [Column("Currency")]
    [MaxLength(3)]
    public string Currency { get; set; }

    [Column("Language")]
    [Required]
    [MaxLength(30)]
    public string Language { get; set; }

    [Column("Latitude")]
    [Required]
    public decimal Latitude { get; set; }

    [Column("Longitude")]
    [Required]
    public decimal Longitude { get; set; }

    [Column("Image")]
    public string Image { get; set; }

    [Column("Image_Url")]
    public string Image_Url { get; set; }

    [Column("Image_Thumb_Url")]
    public string Image_Thumb_Url { get; set; }



    
}
