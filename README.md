# TabPageSizeAndPickerFocusRepro
Trying to reproduce two bugs that I've heard of in XF.

So far can't reproduce either bug.

1. We have many pages with both buttons and picker list fields. When we click in the picker list, the list comes up and we select something - all good. To save a click (which is important) the user click the “Save” button (say) while the picker list is still displayed. 
We get three different responses but no idea why or what is different:
a) (expected response) the command in the VM related to the button is actioned and the focused action gets executed, as expected.
b) the picker list resigns and we have to click the SAVE button a second time - and the focus action is gets executed.
c) the picker list resigns and we have to click the SAVE button a second time - and the focus action is NOT executed.

2. We have a list view in a tab page. We navigate to a modal page (e.g. a help page) and then put it in landscape and then back to portrait. When we return to the previous page the List view now half covers the tab bars at the bottom. To fix the problem we turn the (non modal) list view page into portrait and then landscape - everything gets redrawn correctly.
