# AdminLteMvc
A NuGet package for integrating Admin LTE 2.0.4 into ASP.Net MVC 4-style web apps.

DEPRECATION WARNING: If you are using the new ASP.Net 5 (Core) project structure, you should search Bower for AdminLte (http://bower.io/search/?q=adminlte) and use that instead. This is only appropriate for projects using the old NuGet-managed client-side dependencies style.

This project has applied the CSS, JavaScript, and default images for the AdminLTE dashboard to the standard Content and Scripts folders. This is useful for traditional multi-page MVC pages or single-page apps that use the standard asset structure for ASP.Net MVC. It also supplies example CSHTML files for the AdminLTE dashboard homepage, including a Layout CSHTML for the CSS and script includes, plus general page structure with partials for the top and left menus.

If you're making a single-page ASP.Net MVC web applications using Angular and want a grunt+bower-style - one component per folder - structure to your project, check out the AdminLte NuGet package: https://www.nuget.org/packages/AdminLTE/

What is AdminLTE?
---------------------
AdminLTE is a free premium admin control panel and dashboard template build on Bootstrap 3.x, originally created by Almsaeed Studio (https://almsaeedstudio.com/). Like Bootstrap itself, it is a useful collection of CSS with supporting HTML snippets that make your web app's UI more visually appealing. You can see a full demo of AdminLTE on their website here: https://almsaeedstudio.com/preview

Installation
------------------
Install the package via NuGet (https://www.nuget.org/packages/AdminLteMvc/) using the following command:

```
Install-Package AdminLteMvc
```

After installation, you should be able to build your MVC application and navigate to the route "/AdminLte" to see the AdminLTE 2.0 dashboard homepage. If you see a gap at the top of the page, it's a side-effect of the detault site.css containing a rule that applies padding to the body element. Go in and delete it: 

```
body {
    padding-top: 50px;
    padding-bottom: 20px;
}
```

Contents
---------------------
After installation, you will have a new DLL reference in your project to "AdminLte.dll" - which provides supporting classes for interacting with AdminLte elements and classes in your CSHTML files. Also, new content will be evident in solution explorer as follows:

- A new directory full of CSS and images in "Content/AdminLte"
- A new directory full of script files in "Scripts/AdminLte"
- A new directory of CSHTML files in "View/AdminLte"
- A few new CSHTML files in "View/Shared"
- A new example controller in "Controller" named "AdminLteController"

The controller contains example pages that utilize the AdminLte components in the package, providing an example implementation to start your project. There are many "TODO" comments in the project to help prompt you on how to proceed, such as the suggestion that you might want to modify ViewStart.cshtml to use the _AdminLteLauout.cshtml view instead of your current setting. Once you're off and running, you likely want to delete the AdminLteController class and its supporting views.

License
---------------------
AdminLteMVC, like AdminLTE itself, is open source under the MIT License (http://opensource.org/licenses/MIT).
