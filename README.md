# xunit-view

This is a GUI (Windows Forms) runner and result viewer for XUnit based tests. It is based on the standard console runner (package xunit.runner.console), which is run in background and the test results are produced as XML structure content.

This runner is created with two objectives in mind:

* Easy running of tests - so all relevant arguments and paths are stored in a config file prepared once, then reused during actual test runs

* Structured display of results - in a tree structure as "deep" as possible given the XML test result format

For now the project is merely a "working proof of concept", it is usable for small projects but still needs indispensable features to be used in larger projects.