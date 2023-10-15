ETF-RI-CEG-Advanced is a .NET desktop application for cause-effect graphing. It is intended to help domain experts and software quality engineers who use cause-effect graphs, by simplifying the CEG specification process, enabling the usage of the forward-propagation algorithm for generating the full feasible black-box testing suite, and two minimization algorithms for reducing the test suite size.

All details about the installation and usage of this tool can be found at the [ETF-RI-CEG-Advanced wiki](https://github.com/ehlymana/ETF-RI-CEG-Advanced/wiki).

Structure of the repository:

* **bin** folder - contains the executive files of the software tool used for its installation by users of different operating systems.
* **src** folder - contains the C# programming code of the .NET Windows Forms desktop application, including the UI and all implemented algorithms.
* **ml** folder - contains the C# programming code of the ML.NET console application used for pre-training the feasibility analysis model.
* **examples** folder - contains the exported TXT cause-effect graph specifications which can be used for usage in the software tool.

If you use this tool for your research, please cite the following work:

```
E. Krupalija, E. Cogo, S. Omanović, A. Karabegović, R. Turčinhodžić Mulahasanović, and I. Bešić, "ETF-RI-CEG-Advanced: A graphical tool for black-box testing by using cause-effect graphs", submitted to SoftwareX, 2023.
```
