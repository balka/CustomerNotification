Customer Notification

Please clone reposityory <br/>
Run the applcation
<br/>
<hr>

In order to create customer call fallowing API <br/>

/api/message/register <br/>
With the following payload in the body <br/>
{ <br/>
  "UserId": "bec0e6ba-d6fd-4199-8760-abb8764661c3", <br/>
  "Email": "test@email.com", <br/>
  "FirstName": "Ned", <br/>
  "LastName": "Markovic" <br/>
} <br/>

Provide in query string what type of message you request<br/>
For example <br/>
https://localhost:44356/api/message/register?format=0  <br/>
format=0 will return CSV <br/>
format=1 will return SMS <br/>
format=2 will return JSON <br/>



To delete customer call call fallowing API <br/>
/api/message/delete
With the following payload in the body
{
"UserId": "bec0e6ba-d6fd-4199-8760-abb8764661c3",
}

Provide in query string what type of message you request<br/>
For example<br/>
https://localhost:44356/api/message/register?format=0<br/>
format=0 will return CSV <br/>
format=1 will return SMS <br/>
format=2 will return JSON <br/>

To delete customer call call fallowing API <br/>
/api/message/block
With the following payload in the body
{
"UserId": "bec0e6ba-d6fd-4199-8760-abb8764661c3",
}

Provide in query string what type of message you request<br/>
For example<br/>
https://localhost:44356/api/message/register?format=0<br/>
format=0 will return CSV <br/>
format=1 will return SMS <br/>
format=2 will return JSON <br/>
