using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models;

public class PointOfInterestForUpdateDto
{
    [Required(ErrorMessage = "You should provide a name value")]
    [MaxLength(50, ErrorMessage = "The max lenght is 50 characters")]
    public string Name { get; set; } = string.Empty;
    [MaxLength(200, ErrorMessage = "The max lenght is 200 characters")]
    public string? Description { get; set; }
}