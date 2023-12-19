using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Models
{
  public class Service
  {
    public int ServiceId { get; }
    [Required(ErrorMessage = "The Employee's name can't be empty!")]
    public string Name { get; set; }
    public List<ServiceEmployeeEntity> ServiceEmployeeEntities{ get; set; }
  }
}