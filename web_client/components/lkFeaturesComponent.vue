<template>
  <div class="lk-features">
    <button class="lk-features_item">Мои посты</button>
    <button class="lk-features_item">Новый участок</button>
    <button class="lk-features_item">Новый мод</button>
    <button class="lk-features_item">Новый доп. контент</button>
    <button class="lk-features_item">Настройки аккаунта</button>
  </div>
</template>

<script>
</script>

<style scoped lang="sass">
.lk-features
  display: flex
  flex-direction: column
  border: solid 2px rgb(0, 0, 0)
  border-radius: 10px
  &_item
    font-family: Montserrat, sans-serif 
    font-size: 20px
    font-weight: 700
    text-align: left
    padding: 10px 15px
    background: none
    border-radius: 10px
    transition: all 0.3s
    &:hover
      background: rgb(125, 146, 200)
      cursor: pointer
</style>