# [Git With It!](https://github.com/jeffdoolittle/git-demo)

Supercharge your development with `git` wizardry!

See [License](https://github.com//jeffdoolittle/git-with-it/blob/main/LICENSE) for copyright and usage restrictions.

## Recommended .gitconfig Settings

0. Make VS Code your default editor, merge tool and diff viewer!
1. Configure git lfs
2. Only pull if you can fast forward (no merge commits!).

``` config
[core]
    editor = code --wait

[merge]
    tool = code

[mergetool "code"]
    cmd = code --wait $MERGED

[diff]
    tool = code

[difftool "code"]
    cmd = code --wait --diff $LOCAL $REMOTE

[filter "lfs"]
    clean = git-lfs clean -- %f
    smudge = git-lfs smudge -- %f
    process = git-lfs filter-process
    required = true

[pull]
    ff = only

```

## Common Aliases

*I strongly recommend that teams use the same aliases for git. This provides multiple benefits including shared learning and reduced friction when pair programming.*

### Informational

`alias glog='git log --oneline --decorate --graph'`

`alias gss='git status -s' # short`
`alias gst='git status'`

`alias gba='git branch -a'`

`alias grv='git remote -v'`

`alias gd='git diff'`

### Local and Remote Branching and Committing

`gwip='git add -A; git rm $(git ls-files --deleted) 2> /dev/null; git commit --no-verify --no-gpg-sign -m "--wip-- [skip ci]"'`

`alias gco='git checkout'`

`alias gaa='git add --all'`
`alias grhh='git reset --hard'`

`alias gbd='git branch -d'`
`alias gbD='git branch -D'`
`alias ggsup='git branch --set-upstream-to=origin/$(git_current_branch)'`

`alias gc='git commit -v'`
`alias gc!='git commit -v --amend'`
`alias gcam='git commit -a -m'`

`alias gfa='git fetch --all --prune'`
`alias gfo='git fetch origin'`

`alias ggpull='git pull origin "$(git_current_branch)"'`
`alias ggpush='git push origin "$(git_current_branch)"'`

`alias gpsup='git push --set-upstream origin $(git_current_branch)'`

`alias gpf!='git push --force'`

`alias gra='git remote add'`

### Integrating

`alias gm='git merge'`
`alias gma='git merge --abort'`

`alias grb='git rebase'`
`alias grba='git rebase --abort'`
`alias grbc='git rebase --continue'`
`alias grbd='git rebase develop'`
`alias grbi='git rebase -i'`
`alias grbm='git rebase $(git_main_branch)'`

`alias gcp='git cherry-pick'`
`alias gcpa='git cherry-pick --abort'`
`alias gcpc='git cherry-pick --continue'`

## Author

| [Jeff Doolittle](https://jeffdoolittle.com) | *Software Architect. Transformational Leader. I help make good software professionals great!* |
|-|-|
|![Jeff Doolittle](./assets/jeff_doolittle_avatar.png) | Visit [jeffdoolittle.com](https://jeffdoolittle.com) to find out more about my work. |

&copy; 2020 Jeff Doolittle. All Rights Reserved.