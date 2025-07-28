using System.ComponentModel.DataAnnotations;

namespace MyModels {
  public class CheckValidYear : ValidationAttribute {
    public CheckValidYear( ) {
      ErrorMessage = "年代不可小於1900";
    }
    public override bool IsValid( object? value ) {
      if ( value is DateTime date ) {
        return date.Year >= 1900;
      }

      return false;
    }
  }
}
