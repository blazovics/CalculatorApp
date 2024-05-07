---
name: Custom issue template
about: Describe this issue template's purpose here.
title: Test failed
assignees: bela
labels: bug
---
One or more test failed on dev by {{ payload.sender.login }}'s commit.
{{ date | date('dddd, MMMM Do') }}
