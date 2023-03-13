#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class WeddingAttendance {
    [Key]
    public int WeddingAttendanceId {get; set;}
    public int UserId {get; set;}
    public int WeddingId {get; set;}
    public User? User {get; set;}
    public Wedding? Wedding {get; set;}
}