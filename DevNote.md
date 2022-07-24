# PapasBurgeria3D DevNote

## 开发过程

- 汉堡🍔建模
  
- 餐厅建模
  - [ ] 原料桌建模
  - [ ] 烧烤器
    - [ ] 烧烤粒子效果
  - [ ] 垃圾桶
  - [ ] 小费存钱罐

- 系统类
  - [ ] 经济系统
  - [ ] 烤肉系统

## 开发步骤

### 第一阶段

1. 建模汉堡
   - [x] 汉堡底座
   - [x] 肉片
   - [x] 芝士
   - [x] 黄瓜
   - [x] 洋葱
   - [x] 生菜
   - [ ] 汉堡顶部
   - [ ] 盘子
2. 厨房建模
   - [ ] 备菜桌
   - [ ] 烧烤桌 Griller
   - [ ] 柜台 Counter
   - [ ] 小费罐子 Tip Box
     - 硬币
       - [ ] 0.05
       - [ ] 0.10
       - [ ] 0.20
       - [ ] 0.50
     - 纸币
       - [ ] 1.00
       - [ ] 5.00
       - [ ] 10.00
       - [ ] 20.00
       - [ ] 50.00
3. 餐厅建模
   - [ ] 餐桌
   - [ ] 椅子

## 程序逻辑

### 点餐逻辑

```c#
List<BurgerLayers> Order() {
    List<BurgerLayers> layers = new();
    // Random to build special dishes or not
    // 40% chance for a special dishes
    if (random(0, 10) < 4) {
        // Special Dishes
        int specialDishId = random(0, specialDishList.count);
        specialDishList[specialDishId].order();
    } else {
        // Normal Dishes
        // Random the burger layers.
        int burgerLayersCount = random(1, GameManager.Instance.MaximumBurgerLayer);
        for (int i = 0; i < burgerLayersCount; i++) {
            // Randomize all burger layer
            // TODO: make every layers got different chance
            int burgerIngredientId = random(0, GameManager.Instance.BurgerIngredientList);
            layers.append(GameManager.Instance.BurgerIngredientList[burgerIngredientId]);
        }
    }
    return layers;
}
```

### 拾取逻辑

### 扔垃圾

```c#
OnCollisionEnter(Collision target) {
    Destroy(target.gameObject);
    // Reduce Money
}
```