using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor
{
    [Table("AUTOMATION_obj_executed_commands")]
    public class ExecutedCommands
    {
        [Key][Column("id_executed_command")]public required int IdDeviceCommand { get; set; }
        [Column("id_region")]public required int IdRegion { get; set; }
        [Column("id_command")]public required int IdCommand { get; set; }
        [Column("id_command_type")]public required int IdCommandType { get; set; }
    }
}
