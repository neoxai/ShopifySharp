﻿using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyAuthorizationService_Tests
{
    [Subject(typeof(ShopifyAuthorizationService))]
    class When_checking_if_a_shopify_url_is_valid
    {
        Establish context = () =>
        {
            
        };

        Because of = () =>
        {
            IsValid = ShopifyAuthorizationService.IsValidMyShopifyUrl("stages-test-shop-2.myshopify.com").Await().AsTask.Result;
        };

        It should_return_true = () =>
        {
            IsValid.ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };
        
        static bool IsValid;
    }
}