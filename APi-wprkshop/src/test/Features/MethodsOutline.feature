@API
  @API_METHODS_OUTLINE
  Feature: Test the API methods using scenarios outline

    @METHODS_OUTLINE
    Scenario Outline: Test <method> method on Anything endpoint
      Given A user have a Body Request
      When A user "<method>" the endpoint
      Then A user verify the response

      Examples:
      | method |
      | GET    |
      | POST   |
      | PUT    |
      | PATCH  |
      | DELETE |
