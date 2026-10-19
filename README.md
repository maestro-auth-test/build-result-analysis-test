# Build Insights scenario fixture

A real Helix known-issue failure with a passing companion pipeline.

This permanent fixture branch is `fixtures/known-issue-only`.
Build Insights scenario tests create disposable branches from it and open PRs
targeting this branch. Each run changes only `fake_item.txt`.
Both Azure Pipelines YAML files include this target in their PR triggers.

Maintain the pipeline, test source, SDK and tool versions here. Shared changes
on `main` must be deliberately incorporated; do not merge this fixture into
`main`. Do not delete this branch during scenario cleanup.

The test driver and result assertions live in
`test/BuildInsights.ScenarioTests` in the Build Insights repository.