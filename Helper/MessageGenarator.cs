public static class MessageGenarator
{
    public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
        = new Dictionary<ResponseCodeEnum, string>
    {

         { ResponseCodeEnum.Success, "Ok" },
         {ResponseCodeEnum.OperationFail,"Yapılmak istenen İşlemde Hata Oluştu"},

//Account
        {ResponseCodeEnum.GetAllAccountOperationSuccess,"Tüm Hesaplar Başarılı Bir Şekilde Getirildi" },
        {ResponseCodeEnum.GetAllAccountOperationFail,"Tüm Hesaplar Getirilirken Hata Oluştu"},
        {ResponseCodeEnum.DuplicateAccountError,"Girilen e mail sistemde kayıtlı" },
        {ResponseCodeEnum.GetAccountByEmailOperationSuccess,"Girilen maile sahip account başarılı bir şekilde bulundu."},
        {ResponseCodeEnum.GetAccountByEmailOperationFail,"Girilen maile sahip account bulunamadı"},
        {ResponseCodeEnum.UpdateAccountByEmailSuccess,"Email Başarılı Bir Şekilde Güncellendi"},
        {ResponseCodeEnum.UpdateAccountByEmailOperationFail,"Email Güncelleme Hatalı"},
        {ResponseCodeEnum.UpdateAccountPasswordSuccess,"Şifre Başarılı Bir Şekilde Güncellendi"},
        {ResponseCodeEnum.UpdateAccountPasswordOperationFail,"Şifre Güncellenemedi,Eski Şifre Hatalı."},
        {ResponseCodeEnum.AccountBlockSuccess,"Hesap Engelleme Başarılı."},
        {ResponseCodeEnum.AccountBlockOperationFail,"Hesap Engelleme Başarısız."},
        {ResponseCodeEnum.AccountCreateSuccess,"Hesap Oluşturma Başarılı."},
        {ResponseCodeEnum.AccountCreateOperationFail,"Hesap Oluşturma Başarısız."},
        {ResponseCodeEnum.ChangeVisibilityOfAccountSuccess,"Hesap Görünürlüğünü Değiştirme Başarılı."},
        {ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail,"Hesap Görünürlüğünü Değiştirme Başarısız."},


    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return ResponseMessages[ResponseCode];
    }

}