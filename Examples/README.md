# XComponent Examples

## Build all examples

Execute the following script:
```
$ examples\build.cmd
```
Build results are in the *build* folder of each example.

> Note: the build is based on [Fake](http://fsharp.github.io/FAKE/)

## Examples overview

### Step by Step tutorials
* **Hello World** ([Click here](xc.helloworld)): 
standard example to demonstrate the use of XComponent without knowing too much about microservices
* **Order Processing** ([Click here](xc.orderprocessing)): 
a simple and naïve Order Processing microservice implemented using XComponent

### In depth with XComponent

* **Simple Authentication service** ([Click here](xc.authentication)): 
example to demonstrate how to develop a simple authentication microservice with XComponent: you will learn how to store data in a component and how to use file resources
* **Trade Capture** ([Click here](xc.tradecapture)): 
example to demonstrate how to develop a simple Trade Capture application with two microservices and two Wpf applications that interact wich each other
* **Rest Api Client** ([Click here](xc.restapiclient)): 
example to demonstrate how to consume a RestFul service with XComponent
* **Slack Gateway** ([Click here](xc.slack)): 
example to demonstrate how to post messages to Slack with XComponent
