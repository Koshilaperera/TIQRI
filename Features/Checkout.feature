Feature: Checkout

  Scenario: Complete checkout flow
    Given I am logged in with standard_user credentials
    When I add a product to the cart
    And I navigate to the cart
    And I proceed to checkout
    And I enter valid checkout information
    And I finish the checkout
    Then I should see the order confirmation
