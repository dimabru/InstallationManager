# InstallationTool
Overview: An IaaS software, designed to support the deployment process using several DevOps tools, created to dismiss the need of developing a customized tool for a specific product. 

1.	Use Case: Companies who work on windows-based software, in need of a simple, easily installed and easy-to-use task-based installation software.

2.	Open and Free: The installation tool will be completely free and maintained on GitHub. Hopefully, the tool will generate many users who will eventually contribute to its development and help in enhancing its functionalities and supporting features.

Features: The installation tool will have four major features. Each of them is responsible for a different aspect of the tool and will be maintained and developed separately. 

1.	Main Project Creation Tool: This tool will allow any company to create its own customized projects, designed to support its own unique requirements. The project creation tool is the main window the local DevOps team will use to create its projects. A project is a set of prerequisites, pre and post installation tasks, and action-providers the Installation Builder will then be able to use to create any set of installation sequels. 

2.	Action Providers Creation Tool: This tool will serve as a creation hub to set up all the different actions the installation will be able to perform. A set of preloaded Action Providers will be supplied and using the existing set (Action such as running a cmd command, sql script, powershell, ansible, etc.). The user will be able to create any unique Action Providers necessary for the specific product. 

3.	Installation Builder Tool: This tool will be used as the builder of the installation. Using the created project in the Main Project Creation Tool, the user can add his own set of tasks, creating them with the preloaded action providers. Any installation builds created will then be saved and able to be executed. 

4.	Installation Executor: This tool will serve as the execution software for any installations created in the Installation Builder. After entering the predesigned set of parameters needed for the installation, the user can execute the installation, monitor its progress using a log window and stop the installation if necessary. 

Technologies: Several software and automation tools will be used to support the installation tool.
1.	Visual Studio: The platform used to create the specified-above tools, using WPF MVVM model.
2.	SQL Server: Will be used to store any required information by the users, on their own servers. Information on any recent installations will also be stored using SQL database.
3.	Ansible: Automation tool for remote deployment.
4.	Jenkins: To run any internal CI deployments, a console application version of the Executor must be created as well.

Required Knowledge: C# Programming, WPF, Multithreading, Powershell scripting, Ansible, Networking.
