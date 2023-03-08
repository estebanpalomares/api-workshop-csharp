@API
  @API_METHODS
  Feature: Test the API methods

    @GET_METHOD
    Scenario: Test GET method
      Given A user have a Body Request
      When A user "GET" the endpoint
      Then A user verify the response

    @POST_METHOD
    Scenario: Test POST method
      Given A user have a Body Request
      When A user "POST" the endpoint
      Then A user verify the response

    @PUT_METHOD
    Scenario: Test PUT method
      Given A user have a Body Request
      When A user "PUT" the endpoint
      Then A user verify the response

    @PATCH_METHOD
    Scenario: Test PATCH method
      Given A user have a Body Request
      When A user "PATCH" the endpoint
      Then A user verify the response

    @DELETE_METHOD
    Scenario: Test DELETE method
      Given A user have a Body Request
      When A user "DELETE" the endpoint
      Then A user verify the response
