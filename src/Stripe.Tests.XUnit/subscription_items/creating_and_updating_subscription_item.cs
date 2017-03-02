﻿using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_subscription_item : IClassFixture<subscription_item_fixture>
    {
        private readonly subscription_item_fixture fixture;

        public creating_and_updating_subscription_item(subscription_item_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.SubscriptionItem.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_quantity()
        {
            fixture.SubscriptionItem.Quantity.Should().Be(fixture.SubscriptionItemCreateOptions.Quantity);
        }

        [Fact]
        public void created_has_right_plan()
        {
            fixture.SubscriptionItem.Plan.Id.Should().Be(fixture.SubscriptionItemCreateOptions.PlanId);
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.SubscriptionItemUpdated.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_quantity()
        {
            fixture.SubscriptionItemUpdated.Quantity.Should().Be(fixture.SubscriptionItemUpdateOptions.Quantity);
        }
    }
}
