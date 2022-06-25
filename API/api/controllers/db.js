'use strict';
const mysql = require('mysql');

/*const db = mysql.createConnection({
  host: "127.0.0.1",
  port: "3306",
  user: "root",
  password: 'oneteam123@',
  database: "quanlythuvien",
});*/
const db = mysql.createConnection({
  host: "127.0.0.1",
  //port: "3306",
  user: "root",
  password: '',
  database: "quanlythuvien",
});

module.exports = db;