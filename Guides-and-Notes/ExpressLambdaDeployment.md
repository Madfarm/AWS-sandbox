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

8. Next, in the code tab, find "Runtime settings", edit them
   - change the Handler from index.handler to lambda.handler

   this instructs it where to locate the handler in the lambda.js file we created

   if you zipped the express application with an outer directory you will need to the Handler to reflect that:

   {outer-directory}/lambda.handler

9. If you have any environment variables make sure to set them in the configuration tab

10. With the environment variables set and the Handler properly we can now test the lambda function
    Go to the Test tab and click Test

    It should exceed and in the body of the response you should see whatever you configured in step 3


11. Now, find the "Add trigger" button
    - for the source select API Gateway
    - Create a new API
    - REST API
    - Security is up to you
    - Add

12. In the configuration section of the lambda, it should list our new API Gateway as a trigger, click it
    - This will open the API Gateway menu and you should "Resources" and a dropdown that says "Actions" if you're using the old console. The new console you will see a button labeled "Create resource"
    - Create a resource that is a proxy resource, with the base path "\"
    - in the name fild provide it with any path parameter with a plus  
    - ex: {proxy+}
    
    you should see it in your list of resources

13. Click into the newly created resource and find the "Edit Integration" button
    - Lambda Function integration type
    - check the box/button that says "Lambda proxy integration"
    - Select the lambda function from the list
    - save

14. Now find the Deploy API button and click it
    - create a stage like "test" or "production" or choose default then deploy

15. You will be given an Invoke URL, this is where the Express app is deployed to
    - Navigate to it and test your routes, note the Base path or Home route will return

    ```
    {"message":"Missing Authentication Token"}
    ```


You now have an Express app deployed on AWS
