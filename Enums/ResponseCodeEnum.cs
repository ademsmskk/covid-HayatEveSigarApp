public enum ResponseCodeEnum
{
    Success,
    DuplicateAccountError,
    UserNotFound,
    AccountCreated,
    GetAllAccountOperationSuccess,
    GetAllAccountOperationFail,
    GetAccountByEmailOperationSuccess,
    GetAccountByEmailOperationFail,
    //Product Enums
    GetProductByNameOperationSuccess,
    GetProductByNameOperationFail,
    GetProductsByBrandNameOperationSuccess,
    GetProductsByBrandNameOperationFail,
    GetProductsInStockOperationSuccess,
    GetProductsInStockOperationFailed,
    GetProductsByCategorySuccess,
    GetProductsByCategoryFail,
    GetProductsBetweenMinMaxPriceSuccess,
    GetProductsBetweenMinMaxPriceFail,
    ProductNotFound,
    ProductUpdatedSuccess,
    ProductDeletedSuccess,
    GetAllProductOperationSuccess,
    GetAllProductOperationFail,
    DuplicateProductError,
    ProductCreated,
    GetProductsGreaterThanFail,
    GetProductsLessThanFail,
    BadRequest = 400,
    GetAllPetHelperSuccess,
    GetAllPetHelperFail,
    FindPetHelperByLatLongSuccess,
    FindPetHelperByLatLongFail,
    PetHelperAddSuccess,
    PetHelperAddFail,

    //pet Operations
    GetPetByIDOperationFail,
    GetPetByIDOperationSuccess,
    GetAllPetOperationSuccess,
    GetPetByGenusOperationSuccess,
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,
    GetPetByGenusOperationFail,


    
    

}