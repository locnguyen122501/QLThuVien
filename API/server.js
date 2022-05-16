const express = require('express');
const port = 3002;
const bodyParser = require('body-parser');
const db = require('./api/controllers/db');
const route = require('./api/controllers/routes');
const app = express();
 
// Use Node.js body parsing middleware
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: true,
}));
 
app.use("/api", route)

app.get('/', (request, response) => {
    response.send({
        message: 'Node.js and Express REST API'}
    );
});
 
// Start the server
const server = app.listen(port, (error) => {
    if (error) return console.log(`Error: ${error}`);
    db.connect(function(err) {
        if (err) throw err;
        console.log("Connected!!!")
      });
    console.log(`Server listening on port ${server.address().port}`);
});