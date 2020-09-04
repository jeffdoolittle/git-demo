# Aliases for `bash/zsh/etc.`

*I strongly recommend that teams use the same aliases for git. This provides multiple benefits including shared learning and reduced friction when pair programming.*

Usage: add the following aliases to your `.bashrc/.zshrc/etc.`.

## Informational

`alias glog='git log --oneline --decorate --graph'`

`alias gss='git status -s' # short`
`alias gst='git status'`

`alias gba='git branch -a'`

`alias grv='git remote -v'`

`alias gd='git diff'`

## Local and Remote Branching and Committing

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

## Integrating

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
