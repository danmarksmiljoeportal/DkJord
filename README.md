#DKJord API integration guide

## 1. Support

Please visit the wiki page for support: 


## 2. Security and access to the endpoint

In order to communicate with the api, the code has to use the OAUTH codeflow against the endpoint. That means you have to contact DMP for registration on the DMP useradm for both test and production.

You will need the role `DKJordlaes, dkjordvedligehold, DKJordSlet` in order to access the endpoint. 

Please contact Danmarks Mlijøportal's support at support@miljoeportal.dk to get a client id and client secret for authorization.

### Endpoint urls

| Environment | Url |Swagger | API Document|
| ----------- | ---------------- |----|---|
| TEST        |  https://dkjord-api.test.miljoeportal.dk/ | https://dkjord-api.test.miljoeportal.dk/swagger/ |https://dkjord-api.test.miljoeportal.dk/openapi |
| DEMO        | https://dkjord-api.demo.miljoeportal.dk/ | https://dkjord-api.demo.miljoeportal.dk/swagger/ |https://dkjord-api.demo.miljoeportal.dk/swagger/openapi |
| PROD        | https://dkjord-api.miljoeportal.dk/ | https://dkjord-api.miljoeportal.dk/swagger/ |https://dkjord-api.miljoeportal.dk/swagger/openapi |


## 3. Danmarks Miljøportal's Identity Provider
Danmarks Miljøportal's identity provider supports OpenID Connect, a simple identity layer on top of the OAuth 2.0 protocol, which allows computing clients to verify the identity of an end-user based on the authentication performed by an authorization server, as well as to obtain basic profile information about the end-user in an interoperable and REST-like manner. In technical terms, OpenID Connect specifies a RESTful HTTP API, using JSON as a data format.

OpenID Connect allows a range of clients, including Web-based, mobile, and JavaScript clients, to request and receive information about authenticated sessions and end-users. The specification suite is extensible, supporting optional features such as encryption of identity data, discovery of OpenID Providers, and session management.

OpenID Connect defines a discovery mechanism, called OpenID Connect Discovery, where an OpenID server publishes its metadata at a well-known URL. The discovery documents are available on the following URL's for the test and production environment respectively.

https://log-in.test.miljoeportal.dk/runtime/oauth2/.well-known/openid-configuration

https://log-in.miljoeportal.dk/runtime/oauth2/.well-known/openid-configuration


The identity provider supports the OAuth 2.0 / OpenID Connect flow ``Authorization code``.

The Authorization Code grant type is used by confidential and public clients to exchange an authorization code for an access token.

After the user returns to the client via the redirect URL, the application will get the authorization code from the URL and use it to request an access token.

## 4. Manual Testing via Swagger

You can do manual testing via Swagger, which will help you understand how to implement up against the the REST API.

Check out this wiki page to learn more: https://github.com/danmarksmiljoeportal/DkJord/wiki/REST-API:-Manual-Testing-via-Swagger
