using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels {
  public class Book {
    [Display(Name = "圖書編號")]
    public int Id { get; set; }
    [Display(Name = "圖書名稱")]
    [Required(ErrorMessage = "圖書名稱不可為空白")]
    [MaxLength(50, ErrorMessage = "長度不可超過 {1}")]

    public string Title { get; set; } = null!;
    [Display(Name = "價格")]
    [Range(1, int.MaxValue, ErrorMessage = "{0} 有效範圍在 {1} 與 {2} 之間")]

    public int Price { get; set; }
    [Display(Name = "出版日期")]
    [DataType(DataType.Date)]
    [CheckValidYear]
    public DateTime PublishDate { get; set; }
    [Display(Name = "庫存")]
    public bool InStock { get; set; }
    [Display(Name = "說明")]
    [MaxLength(50, ErrorMessage = "長度不可超過 {1}")]

    public string? Description { get; set; }
    [Display(Name = "圖書分類")]
    public Category? Category { get; set; }
  }
}
