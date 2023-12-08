# How to Deploy an Express REST API as a Lambda function

1. First, we need to install a helpful package AWS provides to make this process easier called AWS Serverless Express
   >npm i aws-serverless-express  

2. Next, comment out the app.listen in our web server's entry point
   ```
   // app.listen(PORT, () => console.log(`Listening on PORT: ${PORT}))
   ```
3. In that same file, make sure the base path sends some form of response
   ```
   app.get('/', (req,res) => res.send('Hitting home route'));
   ```
5. At the bottom of that same file, export the express server
   ```
   module.exports = app;
   ```
4. At the root of the application make a new file called "lambda.js". In that file, import the express server we just exported as a variable
   ```
   cont app = require(In here goes the entry point of your Express application, mine is ./server.js);
   ```
   Now add the following code under that
   ```
   const awsServerlessExpress = require("aws-serverless-express");
   const server = awsServerlessExpress.createServer(app);

   exports.handler = (event, context) => {
     return awsServerlessExpress.proxy(server, event, context);
   }
   ```

   The lambda.js file should look like this now:
   ```
   const app = require("./server");
   const awsServerlessExpress = require("aws-serverless-express");

   const server = awsServerlessExpress.createServer(app);

   exports.handler = (event, context) => {
     return awsServerlessExpress.proxy(server, event, context);
   }
   
   ```
5. Next, compress the entire Express application into a .zip file

6. Log into your AWS account and navigate to Lambda then click "Create function"
   - Make sure "Author from scratch" is selected and the runtime is Node
   - Give the function a name and click "Create function"

7. In the code tab, find the drop down that says "Upload from" and select zip file then upload the .zip of the express app
