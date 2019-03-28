# Backend Assignment: Simple Todos and Reminder API

The assignment involves the creation of a ToDo and Reminder REST JSON API using ASP.NET Core. Please use the following libraries and versions:

* ASP.NET Core 2.2+

**Updated @ Mar'19**

## Simple ToDo API (2-4h)

Create a CRUD API for a simple ToDo management application. ToDos are organized in boards, on every board there can be multiple ToDos. A ToDo contains a title (str), done (bool), a created (datetime) and updated (datetime) timestamp. A board has a name (str). 

Via a REST API it must be possible to:

*   List all boards
*   Add a new board
*   Change a board's title
*   Remove a board
*   List all ToDos on a board
*   List only uncompleted ToDos
*   Add a ToDo to a board
*   Change a ToDo's title or status
*   Delete a ToDo

User management and authentication is are **NOT** required. The data doesn't have to be persisted, this repository already holds the basic data structures and a configured in-memory database.

## Real Time Event API Architecture (1-2h)

Let's assume the ToDo API is now live in a high traffic (1 million users / day) environment. The following additions are planned:

* Updates to ToDos and boards should be available to all users in real time 
* ToDos can be assigned to users
* ToDos can have due dates
* If a ToDo is due, all users should receive a notication via e-mail
* Due ToDos should also create a notification in an internal chat application

Describe (don't code) the technical architecture, the required services and a high level infrastructure layout that allows the extension of the ToDo application. If you see multiple options fit for certain aspects of your solution, please explain which information/decisions are required in order to decide one the best solution. 

## How to work on the assessment

*   Clone this repository
*   Start working on the assignment
*   Please do periodic commits with meaningful commit messages
*   Once you are done push your final results
*   If you don't want to create a public repository please invite (@phelmig, @erzaehlsalex, @flore2003) to your working repository
*   Please include a brief description how to run your solution
*   If you have any questions contact us (jobs@rocketloop.de)

Please note that we don't accept solutions without periodic commits or if we are unable to execute the solution.

