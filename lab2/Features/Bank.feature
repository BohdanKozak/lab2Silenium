Feature: : Search Customer

  Scenario: : Search Customer from the account
    Given I am on the banking website
    When I select "Login as Bank Manager" option
    When I select customers
    When I write to search bar name
    Then I should check if the name is correct
    When I should write surname to the search-bar
    Then I should check if the Surname is correct
    When I should write PostCode to the search-bar
    Then I should check if the PostCode is correct
    Then I should close Chrome