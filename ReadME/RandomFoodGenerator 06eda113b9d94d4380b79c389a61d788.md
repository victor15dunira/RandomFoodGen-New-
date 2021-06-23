# RandomFoodGenerator

Created: Jun 22, 2021 9:50 PM

# RandomFoodGenerator

## Brief/ Introduction

Outlined below is a README. File for the DevOps project “RandomFood Generator”. The main objectives and aims for the project were to create an application that creates Objects, upon a set of predefined rules.

Architectural Requirements

The project should have consisted of a service-orientated architecture ,made up of 4 services which are interconnected. 

- Service one - (Core service) responsible for rendering the HTML required to interact with the application, as well as the other 3 services.
- Service two - Generation of random Object.
- Service three- Generation of random Object.
- Service Four- The creation of an Object, based on the results of services two and three.

Skills Requirement 

To highlight the key fundamental skills developed throughout the project. The following requirements were:

- A Trello Board, or Kanban board technology, with full expansion on user stories, use cases and tasks.
- Clear documentation from design phase to architecture
- An application fully integrated using the feature-branch model into a Version Control System
- Code integrated into a version control system, built through a CI server and deployed to a cloud-based environment.
- The project must follow the service-orientated architecture

## Approach

Initially from a design viewpoint there were two ideas which sprung to mind, the first idea was an application which would generate random ASCII numbers and Binary Numbers, to present you with positive or inspirational messages. But the implementation seemed time-costly, so a random food generator seemed more appropriate.  

### Architecture

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled.png)

- Service One - was responsible for visual HTML functionality
- Service Two- was responsible for the random generation of a cuisine type
- Service Three- was responsible for the random generation of a meal type
- Service Four- was responsible for merging the results of service two and three together

### Project Tracking

Trello was used to highlight and make note of progression throughout different stages in the project, varying from testing up until deployment. A link for the board is attached below.

[https://trello.com/b/hyipzWpK/qa-project-2](https://trello.com/b/hyipzWpK/qa-project-2)

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%201.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%201.png)

## Risk Assessment

Here is screenshot highlights a section of the risk assessment.

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%202.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%202.png)

## CI Pipeline

The CI pipeline is a system which encompasses the four stages: Push, Build, Test and Run. Whereby the push stage consists of sending code stored locally to a Git repository online, which is followed by the Build stage , the build is depend on the infrastructure of the Git repository, then comes the testing stage which requires unit tests on sections of the project. Lastly the Run section is the installation of the web application on to some form of cloud service, in which tests and reports are comprehensively produced to highlight passed/failed build stages. Which provide the user with a more accurate diagnosis of failed builds and error troubleshooting.

The chosen CI pipeline implemented for this particular project was the Github Actions, since in the previous project there were some difficulties faced when using Azure CI CD pipeline. The use of Github Actions was challenging, however following the step by step guides helped to build a better fundamental understanding of it's use case and it's benefits such as a use in a variety of environments such as development and testing, this further helped my appreciation of the technology.   

Code Deployment

Having understood how Github Actions works, the implementation of deploying my webservices to Azure services, may have been the most challenging aspect of the project, there was some misunderstanding on how the resources all linked together and how they were interconnected. However towards the end of the project, after trial and error, the concept of deployment had been clarified. 

Shown below are a collection of failed/passed workflows

 

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%203.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%203.png)

For the deployment of my web services there were a total of four yml files, specifying configuration settings for each particular resource.

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%204.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%204.png)

## Testing

A series of unit tests were carried out enabling me to isolate and test particular sections of the project, I was able to perform checks on data returned and if the datatypes set and returned were as desired, ensuring the functions carried out expected results.

- Cuisine Controller Testing, Meal Controller Testing and MergeControllerTest

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%205.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%205.png)

The Cuisine, Meal and the Merge Controller's were the sections which were tested and the screenshot above shows the tests passed. The tests had random test data inserted and the functions were able to return expected results.

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%206.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%206.png)

### Test Coverage Report

The Test Coverage Report presents a summary of components tested throughout the project, as shown below 3 out of 4 of the total services were tested. The frontend wasn't tested, due to the minimalistic design, there were not many objects to test, besides the return of data created from the  merge service. However as shown below the tests which were carried out showed 100% coverage. 

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%207.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%207.png)

## Infrastructure

### Terraform

The use of Terraform was implemented in order to provide exposure to a high level descriptive programming language. Terraform was used to describe and manage infrastructure. As shown in the image below the four services were spilt into individual modules, each responsible for create Azure Web Service Applications, the main script consisted of the creation of a resource to house all the services and an application service plan, which configured the same cloud instances for each application within the plan. 

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%208.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%208.png)

Upon completion of the Terraform scripts, the following resources were created as shown below.

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%209.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%209.png)

The relevance of Terraform was understood towards the end of the project, as it highlighted the ease of deploying various resources and management without using the azure portal ,it show cased efficiency and ease of use. With time the ease of use will improve as there is more frequent exposure to such technologies. 

## Front-End

The Front-End design of the Web application carries the default, minimalistic design implemented using a bootstrap layout.

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%2010.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%2010.png)

The heading at the top of the webpage, shows the return value created within with the merge service, it is displayed by using a viewbag in the cshtml file. The value shown is of the summation of the cuisine and meal services. 

![RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%2011.png](RandomFoodGenerator%2006eda113b9d94d4380b79c389a61d788/Untitled%2011.png)

As you can see the application changes and generates a random and unorthodox set of food types for you to try to cook at home.

## Known Issues

- There is one instance where only one service is returned which is the cuisine type, which seems to be an issue in the programming logic.

## Future Improvements

- Implement some error messages to state when incorrect datatypes or incorrect parameters have been returned.
- Possibly improve the visual look of the webpage and add more features
- Possibly adding images to match the food types
- Add an option for normal dishes to match together, as the unorthodox dishes maybe slightly overboard.
- Testing the front-end controller
- Implementation of a database